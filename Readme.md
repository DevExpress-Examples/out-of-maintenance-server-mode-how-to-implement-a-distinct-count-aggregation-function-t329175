# Server Mode - How to implement a Distinct Count Aggregation Function


<p>This example demonstrates how to define and register the Distinct Count function that allows calculating the count of unique field values if the <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument17856.aspx">Server Mode</a> is enabled. This concept is described in the <a href="https://documentation.devexpress.com/windowsforms/CustomDocument9947.aspx">Implementing Custom Functions</a> help topic. A custom function class should implement the following interfaces:<br><a href="https://documentation.devexpress.com/CoreLibraries/clsDevExpressDataFilteringICustomFunctionOperatortopic.aspx">ICustomFunctionOperator</a> <br><a href="https://documentation.devexpress.com/CoreLibraries/clsDevExpressDataFilteringICustomFunctionOperatorFormattabletopic.aspx">ICustomFunctionOperatorFormattable</a> <br><strong>IQueryableConvertible</strong><br><br>To register a custom function in your application, use the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpressDataFilteringCriteriaOperator_RegisterCustomFunctiontopic.aspx">CriteriaOperator.RegisterCustomFunction</a> method.</p>

<br/>


