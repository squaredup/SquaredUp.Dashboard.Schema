# Dashboard/perspective schema

## TODO
* Timeframe is duplicated and only supports 'type'
* Traversal mode and 'type' on scope is shared across many tiles
* 'zoom' is supported for display of most tiles
* Cell tiles support 'timeframe' which is undocumented

## Tiles

## General purpose
* alert-list
* alertlist-donut
* allscomperf
* azureappinsights-as-scalar
* azureappinsights-as-table
* azureloganalytics-as-scalar
* azureloganalytics-as-table
* dynamic-table
* web-content
* image
* knowledge-editor
* matrix
	* celltile/scomperf-as-sparkline
	* celltile/status-block
	* celltile/sla
	* celltile/signalstrength
	* celltile/status
	* celltile/text
* monitorconfig
* monitordetails
* monitors
* monitorstatechangehistory
* ruleconfig
* ruledetails
* rules
* scomperf-as-bar
* scomperf-as-heatmap
* scomperf-as-line-graph
* scomperf-as-line-graph-report
* scomperf-as-spark-lines
* scomtask-as-text
* scomtask-as-table
* sla
* sql-as-scalar
* sql-as-table
* status
* status-block
* status-donut
* text
* visio
* webapi-as-scalar
* webapi-as-table

### Special purpose
The following tiles are ignored by this schema because they are used for special/isolated cases and are not typically saved to dashboard JSON (or they have no actual configuration)

* alertcontext
* alerthistory
* button
* community
* Custom
* eas
* error
* explore
* hostingstack
* new 
* vada
* welcome 