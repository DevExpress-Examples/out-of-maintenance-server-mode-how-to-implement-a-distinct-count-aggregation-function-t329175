<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582772/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T329175)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DistinctCountFunction.cs](./CS/CustomFunction_DistinctCount/DistinctCountFunction.cs) (VB: [DistinctCountFunction.vb](./VB/CustomFunction_DistinctCount/DistinctCountFunction.vb))
* [Form1.cs](./CS/CustomFunction_DistinctCount/Form1.cs) (VB: [Form1.vb](./VB/CustomFunction_DistinctCount/Form1.vb))
* [Program.cs](./CS/CustomFunction_DistinctCount/Program.cs) (VB: [Program.vb](./VB/CustomFunction_DistinctCount/Program.vb))
<!-- default file list end -->
# Server Mode - How to implement a Distinct Count Aggregation Function


<p>This example demonstrates how to define and register the Distinct Count function that allows calculating the count of unique field values if the <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument17856.aspx">Server Mode</a> is enabled. This concept is described in the <a href="https://documentation.devexpress.com/windowsforms/CustomDocument9947.aspx">Implementing Custom Functions</a> help topic. A custom function class should implement the following interfaces:<br><a href="https://documentation.devexpress.com/CoreLibraries/clsDevExpressDataFilteringICustomFunctionOperatortopic.aspx">ICustomFunctionOperator</a> <br><a href="https://documentation.devexpress.com/CoreLibraries/clsDevExpressDataFilteringICustomFunctionOperatorFormattabletopic.aspx">ICustomFunctionOperatorFormattable</a> <br><strong>IQueryableConvertible</strong><br><br>To register a custom function in your application, use the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpressDataFilteringCriteriaOperator_RegisterCustomFunctiontopic.aspx">CriteriaOperator.RegisterCustomFunction</a> method.</p>

<br/>


