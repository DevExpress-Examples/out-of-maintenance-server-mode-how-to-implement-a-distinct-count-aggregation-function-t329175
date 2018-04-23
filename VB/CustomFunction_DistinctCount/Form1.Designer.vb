Imports Microsoft.VisualBasic
Imports System
Namespace XPG_ServerMode_EF
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.entityServerModeSource1 = New DevExpress.Data.Linq.EntityServerModeSource()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderMonth = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.entityServerModeSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.entityServerModeSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName, Me.fieldQuantity, Me.fieldExtendedPrice, Me.pivotGridField1, Me.fieldCountry, Me.fieldCity, Me.fieldOrderYear, Me.fieldOrderMonth})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsData.AutoExpandGroups = DevExpress.Utils.DefaultBoolean.False
			Me.pivotGridControl1.Size = New System.Drawing.Size(898, 422)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' entityServerModeSource1
			' 
			Me.entityServerModeSource1.ElementType = GetType(XPG_ServerMode_EF.Invoice)
			Me.entityServerModeSource1.KeyExpression = "[OrderID]"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 1
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.CellFormat.FormatString = "N0"
			Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.FieldName = "ExtendedPrice"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField1.AreaIndex = 2
			Me.pivotGridField1.Caption = "Distinct Products"
			Me.pivotGridField1.Name = "pivotGridField1"
			Me.pivotGridField1.UnboundExpression = "DistinctCount([ProductID])"
			Me.pivotGridField1.UnboundExpressionMode = DevExpress.XtraPivotGrid.UnboundExpressionMode.UseAggregateFunctions
			Me.pivotGridField1.UnboundFieldName = "Average"
			Me.pivotGridField1.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			' 
			' fieldCountry
			' 
			Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.Caption = "Country"
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldCity
			' 
			Me.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCity.AreaIndex = 1
			Me.fieldCity.Caption = "City"
			Me.fieldCity.FieldName = "City"
			Me.fieldCity.Name = "fieldCity"
			' 
			' fieldOrderYear
			' 
			Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderYear.AreaIndex = 0
			Me.fieldOrderYear.Caption = "Year"
			Me.fieldOrderYear.FieldName = "OrderDate"
			Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderYear.Name = "fieldOrderYear"
			' 
			' fieldOrderMonth
			' 
			Me.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderMonth.AreaIndex = 1
			Me.fieldOrderMonth.Caption = "Month"
			Me.fieldOrderMonth.FieldName = "OrderDate"
			Me.fieldOrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldOrderMonth.Name = "fieldOrderMonth"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(898, 422)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.entityServerModeSource1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private entityServerModeSource1 As DevExpress.Data.Linq.EntityServerModeSource
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderMonth As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

