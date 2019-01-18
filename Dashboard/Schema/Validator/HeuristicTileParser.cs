using System;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;

namespace SquaredUp.Dashboard.Schema.Validator
{
    /// <summary>
    /// Parser which will attempt a number of heuristics/hacks to work around known bugs and issues in common dashboards
    /// and perspectives. These are compatibility shims, effectively - invalid/non-conforming dashboards that we SHOULD
    /// accept as valid
    /// </summary>
    public class HeuristicTileParser : ITileConfigParser
    {
        private readonly JsonParser _strictParser =
            new JsonParser(
                new JsonParser.Settings(JsonParser.Settings.Default.RecursionLimit));

        public dynamic Parse<T>(string originalType, Value v, ResultInfo result) where T : IMessage, new()
        {
            try
            {
                return _strictParser.Parse<T>(v.StructValue.ToString());
            }
            catch (Exception ex)
            {
                // This block has many unintentionally caught exceptions so that a failed attempt at parsing 
                // with a looser schema will continue on to the next heuristic/guess in line
                //
                // This is clumsy and strange mainly because protobuf does not really deal with differences in 
                // case etc. between JSON -> proto without just disabling checking altogether (which defeats the object
                // of it for our purposes)

                switch (originalType)
                {
                    // Heuristic for 'showtitles' being a string in alert tiles
                    case "tile/alert-list":

                        try
                        {
                            var p = _strictParser.Parse<Heuristic1_AlertListTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema allowing 'showTitles' to be a string. " +
                                "This currently works in the product but is not ideal.");

                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // unitkey case issue
                    case "tile/scomperf-as-bar":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic2_ScomPerfAsBarTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'unitKey' is incorrectly specified as 'unitkey'.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // unitkey case issue
                    case "tile/scomperf-as-heatmap":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic2_ScomPerfAsHeatmapTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'unitKey' is incorrectly specified as 'unitkey'.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // unitkey case issue
                    case "tile/scomperf-as-line-graph":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic2_ScomPerfAsLineGraphTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'unitKey' is incorrectly specified as 'unitkey'.");

                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // unitkey case issue
                    case "tile/scomperf-as-line-graph-report":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic2_ScomPerfAsLineGraphReportTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'unitKey' is incorrectly specified as 'unitkey'.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // unitkey case issue
                    case "tile/scomperf-as-spark-lines":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic2_ScomPerfAsSparklinesTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'unitKey' is incorrectly specified as 'unitkey'.");
                            return p;
                        }
                        catch
                        {
                        }
                        break;

                    // iconsize case issue
                    case "tile/visio":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic3_VisioTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'iconsize' is specified as a string. " +
                                $"This currently works in the product but is incorrect and should be removed.");
                            return p;
                        }
                        catch
                        {
                        }
                        break;

                }

                // Another pass of heuristics for performance tiles
                // showkey type issuse
                switch (originalType)
                {
                    case "tile/scomperf-as-bar":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic4_ScomPerfAsBarTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'showKey' is incorrectly specified as a string.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // showkey type issue
                    case "tile/scomperf-as-heatmap":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic4_ScomPerfAsHeatmapTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'showKey' is incorrectly specified as a string.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // showkey type issue
                    case "tile/scomperf-as-line-graph":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic4_ScomPerfAsLineGraphTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'showKey' is incorrectly specified as a string.");

                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // showkey type issue
                    case "tile/scomperf-as-line-graph-report":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic4_ScomPerfAsLineGraphReportTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'showKey' is incorrectly specified as a string.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    // showkey type issue
                    case "tile/scomperf-as-spark-lines":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic4_ScomPerfAsSparklinesTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'showKey' is incorrectly specified as a string.");
                            return p;
                        }
                        catch
                        {
                        }
                        break;
                }

                // And.... ANOTHER pass of heuristics for performance tiles
                // (rangemin/rangemax defects)
                switch (originalType)
                {
                    case "tile/scomperf-as-bar":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic5_ScomPerfAsBarTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'rangemin' or 'rangemax' is incorrectly specified as a string.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    case "tile/scomperf-as-heatmap":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic5_ScomPerfAsHeatmapTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'rangemin' or 'rangemax' is incorrectly specified as a string.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    case "tile/scomperf-as-line-graph":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic5_ScomPerfAsLineGraphTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'rangemin' or 'rangemax' is incorrectly specified as a string.");

                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    case "tile/scomperf-as-line-graph-report":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic5_ScomPerfAsLineGraphReportTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'rangemin' or 'rangemax' is incorrectly specified as a string.");
                            return p;
                        }
                        catch
                        {
                        }

                        break;

                    case "tile/scomperf-as-spark-lines":
                        try
                        {
                            var p = _strictParser.Parse<Heuristic5_ScomPerfAsSparklinesTileConfig>(v.StructValue.ToString());

                            result.Warnings.Add(
                                $"Parsing {originalType} with non-conformant schema because 'rangemin' or 'rangemax' is incorrectly specified as a string.");
                            return p;
                        }
                        catch
                        {
                        }
                        break;
                }


                // Attempt heuristics that are not applicable to any specific tile
                //
                JObject modifiable = JObject.Parse(v.StructValue.ToString());

                // Check for 'stepSummary' which shouldn't be there (SU-6429)
                //
                if (modifiable["source"] != null && modifiable["source"]["stepSummary"] != null)
                {
                    JObject source = modifiable["source"].ToObject<JObject>();
                    source.Remove("stepSummary");
                    modifiable["source"] = source;

                    try
                    {
                        var p = _strictParser.Parse<T>(modifiable.ToString());

                        result.Warnings.Add(
                            $"{originalType} - ignored source/stepSummary property (SU-6429) in order to parse. " +
                            "This currently works in the product but is incorrect and the property should be removed.");

                        return p;
                    }
                    catch
                    {
                    }
                }

                // Check for 'stepSummary' under context/ which shouldn't be there (SU-6429)
                //
                if (modifiable["context"] != null && modifiable["context"]["stepSummary"] != null)
                {
                    JObject source = modifiable["context"].ToObject<JObject>();
                    source.Remove("stepSummary");
                    modifiable["context"] = source;

                    try
                    {
                        var p = _strictParser.Parse<T>(modifiable.ToString());

                        result.Warnings.Add(
                            $"{originalType} - ignored context/stepSummary property (SU-6429) in order to parse. " +
                            "This currently works in the product but is incorrect and the property should be removed.");

                        return p;
                    }
                    catch
                    {
                    }
                }

                // Check for 'signed' which shouldn't be there
                //
                if (modifiable["source"] != null && modifiable["source"]["__signed"] != null)
                {
                    JObject source = modifiable["source"].ToObject<JObject>();
                    source.Remove("__signed");
                    modifiable["source"] = source;

                    try
                    {
                        var p = _strictParser.Parse<T>(modifiable.ToString());

                        result.Warnings.Add(
                            $"{originalType} - ignored '__signed' property in order to parse. " +
                            "This currently works in the product but is incorrect and should be removed.");

                        return p;
                    }
                    catch
                    {
                    }
                }

                // Check for array source/scope
                //
                if (modifiable["source"] != null &&
                    modifiable["source"]["scope"] != null &&
                    modifiable["source"]["scope"].Type == JTokenType.Array)
                {
                    JObject source = modifiable["source"].ToObject<JObject>();

                    foreach (JToken scope in (source["scope"] as JArray))
                    {
                        _strictParser.Parse<CommonScope>(scope.ToString());
                    }

                    source.Remove("scope");
                    modifiable["source"] = source;

                    try
                    {
                        var p = _strictParser.Parse<T>(modifiable.ToString());

                        result.Warnings.Add(
                            $"{originalType} - source/scope valid but is not supported by static schema (polymorphic object -> array). " +
                            $"This message is information only and your JSON does not need to be changed.");

                        return p;
                    }
                    catch
                    {
                    }
                }

                // Check for array context/scope
                //
                if (modifiable["context"] != null &&
                    modifiable["context"]["scope"] != null &&
                    modifiable["context"]["scope"].Type == JTokenType.Array)
                {
                    JObject source = modifiable["context"].ToObject<JObject>();

                    foreach (JToken scope in (source["scope"] as JArray))
                    {
                        _strictParser.Parse<CommonScope>(scope.ToString());
                    }

                    source.Remove("scope");
                    modifiable["context"] = source;

                    try
                    {
                        var p = _strictParser.Parse<T>(modifiable.ToString());

                        result.Warnings.Add(
                            $"{originalType} - context/scope valid but is not supported by static schema (polymorphic object -> array). " +
                            $"This message is information only and your JSON does not need to be changed.");

                        return p;
                    }
                    catch
                    {
                    }
                }

                // No heuristics/attempts worked, schema is not valid
                throw;
            }
        }
    }
}
