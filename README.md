# Dashboard/perspective schema

## Notice
This schema data and its assembly are designed for programmatic schema consumption and verification - not end user consumption.

Additionally, the protocol buffer defined here is relatively 'impure' - dashboards use a large amount of dynamic behaviour, which requires a significant amount of logic inside the verifier. It is not sufficient to just parse JSON as the provided protocol buffer types

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
* region/newscomcontext

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