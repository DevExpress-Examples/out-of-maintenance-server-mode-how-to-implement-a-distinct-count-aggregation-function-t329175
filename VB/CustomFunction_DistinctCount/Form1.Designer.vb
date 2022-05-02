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
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim ExpressionDataBinding1 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding7 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
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
            'pivotGridControl1
            '
            Me.pivotGridControl1.DataSource = Me.entityServerModeSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName, Me.fieldQuantity, Me.fieldExtendedPrice, Me.pivotGridField1, Me.fieldCountry, Me.fieldCity, Me.fieldOrderYear, Me.fieldOrderMonth})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.AutoExpandGroups = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotGridControl1.Size = New System.Drawing.Size(898, 422)
            Me.pivotGridControl1.TabIndex = 0
            '
            'entityServerModeSource1
            '
            Me.entityServerModeSource1.ElementType = GetType(NorthwindModel.Invoice)
            Me.entityServerModeSource1.KeyExpression = "[OrderID]"
            '
            'fieldProductName
            '
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product Name"
            DataSourceColumnBinding1.ColumnName = "ProductName"
            Me.fieldProductName.DataBinding = DataSourceColumnBinding1
            Me.fieldProductName.Name = "fieldProductName"
            '
            'fieldQuantity
            '
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            Me.fieldQuantity.Caption = "Quantity"
            Me.fieldQuantity.CellFormat.FormatString = "N0"
            Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            DataSourceColumnBinding2.ColumnName = "Quantity"
            Me.fieldQuantity.DataBinding = DataSourceColumnBinding2
            Me.fieldQuantity.Name = "fieldQuantity"
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            DataSourceColumnBinding3.ColumnName = "ExtendedPrice"
            Me.fieldExtendedPrice.DataBinding = DataSourceColumnBinding3
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            '
            'pivotGridField1
            '
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField1.AreaIndex = 2
            Me.pivotGridField1.Caption = "Distinct Products"
            ExpressionDataBinding1.Expression = "DistinctCount([ProductID])"
            Me.pivotGridField1.DataBinding = ExpressionDataBinding1
            Me.pivotGridField1.Name = "pivotGridField1"
            Me.pivotGridField1.UnboundFieldName = "pivotGridField1"
            '
            'fieldCountry
            '
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            DataSourceColumnBinding4.ColumnName = "Country"
            Me.fieldCountry.DataBinding = DataSourceColumnBinding4
            Me.fieldCountry.Name = "fieldCountry"
            '
            'fieldCity
            '
            Me.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCity.AreaIndex = 1
            Me.fieldCity.Caption = "City"
            DataSourceColumnBinding5.ColumnName = "City"
            Me.fieldCity.DataBinding = DataSourceColumnBinding5
            Me.fieldCity.Name = "fieldCity"
            '
            'fieldOrderYear
            '
            Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderYear.AreaIndex = 0
            Me.fieldOrderYear.Caption = "Year"
            DataSourceColumnBinding6.ColumnName = "OrderDate"
            DataSourceColumnBinding6.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderYear.DataBinding = DataSourceColumnBinding6
            Me.fieldOrderYear.Name = "fieldOrderYear"
            Me.fieldOrderYear.UnboundFieldName = "fieldOrderYear"
            '
            'fieldOrderMonth
            '
            Me.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderMonth.AreaIndex = 1
            Me.fieldOrderMonth.Caption = "Month"
            DataSourceColumnBinding7.ColumnName = "OrderDate"
            DataSourceColumnBinding7.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderMonth.DataBinding = DataSourceColumnBinding7
            Me.fieldOrderMonth.Name = "fieldOrderMonth"
            Me.fieldOrderMonth.UnboundFieldName = "fieldOrderMonth"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 422)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
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

