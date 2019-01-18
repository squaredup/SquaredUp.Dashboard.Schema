using System;
using System.Collections.Generic;
using System.IO;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SquaredUp.Dashboard.Schema.Validator
{
    /// <summary>
    /// Warnings and errors from having performed validation
    /// </summary>
    public class ResultInfo
    {
        public List<string> Warnings { get; set; }
        public List<string> Errors { get; set; }
    }

    public class Validator
    {
        private readonly JsonParser _strictParser =
            new JsonParser(
                new JsonParser.Settings(JsonParser.Settings.Default.RecursionLimit));

        private readonly JsonParser _permissiveParser =
            new JsonParser(
                new JsonParser.Settings(JsonParser.Settings.Default.RecursionLimit).WithIgnoreUnknownFields(true));

        private readonly ITileConfigParser _tileParser;

        /// <summary>
        /// Build a dashboard validator
        /// </summary>
        /// <param name="strictConformanceMode">whether to use strict parsing - no compatibility checks etc.</param>
        public Validator(bool strictConformanceMode = false)
        {
            if (strictConformanceMode)
            {
                _tileParser = new ConformanceTileParser();
            }
            else
            {
                _tileParser = new HeuristicTileParser();
            }
        }

        public ResultInfo Validate(string filename)
        {
            return ValidateString(File.ReadAllText(filename));
        }

        public ResultInfo ValidateString(string text)
        {
            ResultInfo result = new ResultInfo
            {
                Warnings = new List<string>(),
                Errors =  new List<string>()
            };

            string json = JObject.Parse(text).ToString(Formatting.Indented);
            
            DashboardObsoleteType obsolete = _permissiveParser.Parse<DashboardObsoleteType>(json);

            // Check for and remove obsolete _type at top level (proto3 cannot distinguish between _type and type in this
            // circumstance)
            if (!String.IsNullOrEmpty(obsolete.Type))
            {
                JObject editable = JObject.Parse(json);
                editable.Remove("_type");

                json = editable.ToString(Formatting.Indented);
            }

            SquaredUp.Dashboard.Schema.Dashboard d = _strictParser.Parse<SquaredUp.Dashboard.Schema.Dashboard>(json);

            // If there are 'columns' at top level, this is a 'row' format perspective
            if (d.Columns != null)
            {
                // Validate each cell tile
                foreach(Value v in d.Columns)
                {
                    ValidateTile(v, result);
                }
            }

            if (d.Content != null)
            {
                ValidateContent(d.Content, result);
            }

            return result;
        }

        private void ValidateContent(Value layout, ResultInfo result)
        {
            // Read the layout as just the _type property
            AbstractDashboardContent type = _permissiveParser.Parse<AbstractDashboardContent>(layout.StructValue.ToString());

            switch (type.Type)
            {
                case "layout/list":
                    ValidateListLayout(layout, result);
                    break;

                case "layout/column":
                    ValidateColumnLayout(layout, result);
                    break;

                case "region/newscomcontext":
                    ValidateNewScomContext(layout, result);
                    break;


                default:
                    ValidateTile(layout, result);
                    break;
            }
        }

        private void ValidateTile(Value tile, ResultInfo result)
        {
            AbstractTile basic = _permissiveParser.Parse<AbstractTile>(tile.StructValue.ToString());
            
            ValidateTileConfig(basic.Config, basic.Type, result);
        }

        private void ValidateListLayout(Value layout, ResultInfo result)
        {
            LayoutList list = _strictParser.Parse<LayoutList>(layout.StructValue.ToString());

            foreach (Value v in list.Contents)
            {
                ValidateContent(v, result);
            }
        }

        private void ValidateNewScomContext(Value context, ResultInfo result)
        {
            NewScomContextRegion region =
                _strictParser.Parse<NewScomContextRegion>(context.StructValue.ToString());

            if (region.Content != null)
            {
                // Should be a root tile or layout which itself can be verified
                ValidateContent(region.Content, result);
            }
        }

        private void ValidateColumnLayout(Value layout, ResultInfo result)
        {
            LayoutColumn column = _strictParser.Parse<LayoutColumn>(layout.StructValue.ToString());

            // Each nested item should be a column
            foreach (LayoutColumn_Column col in column.Columns)
            {
                foreach (Value v in col.Contents)
                {
                    ValidateContent(v, result);
                }
            }
        }
        
        private void ValidateTileConfig(Value config, string type, ResultInfo result)
        {
            if (config == null)
            {
                return;
            }

            try
            {
                switch (type)
                {
                    case "tile/alert-list":
                        _tileParser.Parse<AlertListTileConfig>(type, config, result);
                        break;

                    case "tile/alertlist-donut":
                        _tileParser.Parse<AlertDonutTileConfig>(type, config, result);
                        break;

                    case "tile/allscomperf":
                        _tileParser.Parse<AllScomPerfTileConfig>(type, config, result);
                        break;

                    case "tile/azureappinsights-as-scalar":
                        _tileParser.Parse<AzureInsightsAsScalarTileConfig>(type, config, result);
                        break;

                    case "tile/azureappinsights-as-table":
                        _tileParser.Parse<AzureInsightsAsTableTileConfig>(type, config, result);
                        break;

                    case "tile/azureloganalytics-as-scalar":
                        _tileParser.Parse<AzureLogAnalyticsAsScalarTileConfig>(type, config, result);
                        break;

                    case "tile/azureloganalytics-as-table":
                        _tileParser.Parse<AzureLogAnalyticsAsTableTileConfig>(type, config, result);
                        break;

                    case "tile/dynamic-table":
                        _tileParser.Parse<DynamicTableTileConfig>(type, config, result);
                        break;

                    case "tile/web-content":
                        _tileParser.Parse<WebContentTileConfig>(type, config, result);
                        break;

                    case "tile/image":
                        _tileParser.Parse<ImageTileConfig>(type, config, result);
                        break;

                    case "tile/knowledge-editor":
                        _tileParser.Parse<KnowledgeEditorTileConfig>(type, config, result);
                        break;

                    case "tile/matrix":
                        var matrix = _tileParser.Parse<MatrixTileConfig>(type, config, result);

                        if (matrix.Display == null)
                        {
                            result.Warnings.Add($"{type} without display settings");
                            return;
                        }

                        if (matrix.Display.Columns == null)
                        {
                            result.Warnings.Add($"{type} without columns");
                            return;
                        }

                        foreach (MatrixTile_Column column in matrix.Display.Columns)
                        {
                            // Process each nested column as if its own tile
                            ValidateTileConfig(column.Config, column.Type, result);
                        }

                        break;

                    case "celltile/scomperf-as-sparkline":
                        _tileParser.Parse<CellTile_ScomPerfAsSparkline_Config>(type, config, result);
                        break;

                    case "celltile/bar":
                        _tileParser.Parse<CellTile_Bar_Config>(type, config, result);
                        break;

                    case "celltile/sla":
                        _tileParser.Parse<CellTile_Sla_Config>(type, config, result);
                        break;

                    case "celltile/text":
                        _tileParser.Parse<CellTile_Text_Config>(type, config, result);
                        break;

                    case "celltile/signalstrength":
                        _tileParser.Parse<CellTile_SignalStrength_Config>(type, config, result);
                        break;

                    case "celltile/monitor":
                        _tileParser.Parse<CellTile_Monitor_Config>(type, config, result);
                        break;

                    case "celltile/monitor-status":
                        _tileParser.Parse<CellTile_MonitorStatus_Config>(type, config, result);
                        break;

                    case "celltile/status":
                        _tileParser.Parse<CellTile_Status_Config>(type, config, result);
                        break;

                    case "celltile/status-block":
                        _tileParser.Parse<CellTile_StatusBlock_Config>(type, config, result);
                        break;

                    case "celltile/timeseriesblocks":
                        _tileParser.Parse<CellTile_TimeseriesBlocks_Config>(type, config, result);
                        break;

                    case "tile/monitorconfig":
                        _tileParser.Parse<MonitorConfigTileConfig>(type, config, result);
                        break;

                    case "tile/monitordetails":
                        _tileParser.Parse<MonitorDetailsTileConfig>(type, config, result);
                        break;

                    case "tile/monitors":
                        _tileParser.Parse<MonitorsTileConfig>(type, config, result);
                        break;

                    case "tile/monitorstatechangehistory":
                        _tileParser.Parse<MonitorStateChangeHistoryTileConfig>(type, config, result);
                        break;

                    case "tile/ruleconfig":
                        _tileParser.Parse<RuleConfigTileConfig>(type, config, result);
                        break;

                    case "tile/ruledetails":
                        _tileParser.Parse<RuleDetailsTileConfig>(type, config, result);
                        break;

                    case "tile/rules":
                        _tileParser.Parse<RulesTileConfig>(type, config, result);
                        break;

                    case "tile/scomperf-as-bar":
                        _tileParser.Parse<ScomPerfAsBarTileConfig>(type, config, result);
                        break;

                    case "tile/scomperf-as-heatmap":
                        _tileParser.Parse<ScomPerfAsHeatmapTileConfig>(type, config, result);
                        break;

                    case "tile/scomperf-as-line-graph":
                        _tileParser.Parse<ScomPerfAsLineGraphTileConfig>(type, config, result);
                        break;

                    case "tile/scomperf-as-line-graph-report":
                        _tileParser.Parse<ScomPerfAsLineGraphReportTileConfig>(type, config, result);
                        break;

                    case "tile/scomperf-as-spark-lines":
                        _tileParser.Parse<ScomPerfAsSparklinesTileConfig>(type, config, result);
                        break;

                    case "tile/scomtask-as-text":
                        _tileParser.Parse<ScomTaskAsTextTileConfig>(type, config, result);
                        break;

                    case "tile/scomtask-as-table":
                        _tileParser.Parse<ScomTaskAsTableTileConfig>(type, config, result);
                        break;

                    case "tile/sla":
                        _tileParser.Parse<SlaTileConfig>(type, config, result);
                        break;

                    case "tile/sql-as-scalar":
                        _tileParser.Parse<SqlAsScalarTileConfig>(type, config, result);
                        break;

                    case "tile/sql-as-table":
                        _tileParser.Parse<SqlAsTableTileConfig>(type, config, result);
                        break;

                    case "tile/status":
                        _tileParser.Parse<StatusTileConfg>(type, config, result);
                        break;

                    case "tile/status-block":
                        _tileParser.Parse<StatusBlockTileConfig>(type, config, result);
                        break;

                    case "tile/status-donut":
                        _tileParser.Parse<StatusDonutTileConfig>(type, config, result);
                        break;

                    case "tile/text":
                        _tileParser.Parse<TextTileConfig>(type, config, result);
                        break;

                    case "tile/visio":
                        _tileParser.Parse<VisioTileConfig>(type, config, result);
                        break;

                    case "tile/webapi-as-scalar":
                        _tileParser.Parse<WebApiAsScalarTileConfig>(type, config, result);
                        break;

                    case "tile/webapi-as-table":
                        _tileParser.Parse<WebApiAsTableTileConfig>(type, config, result);
                        break;

                    case "tile/vada":
                        _tileParser.Parse<VadaTileConfig>(type, config, result);
                        break;

                    case "tile/button":
                        _tileParser.Parse<ButtonTileConfig>(type, config, result);
                        break;

                    case "tile/oms-as-table":
                        result.Warnings.Add("Performing shallow validation only of obsolete OMS tile");
                        _tileParser.Parse<Value>(type, config, result);
                        break;

                    case "tile/alertcontext":
                        _tileParser.Parse<AlertContextTileConfig>(type, config, result);
                        break;

                    case "tile/new":
                        result.Warnings.Add("Performing shallow validation only of tile/new which is not typically expected");
                        _tileParser.Parse<Value>(type, config, result);
                        break;

                    default:
                        result.Errors.Add($"Unknown tile \"{type}\"");
                        break;
                }
            }
            catch (Exception ex)
            {
                result.Errors.Add($"{type} -> {ex.Message}");
            }
        }
    }
}