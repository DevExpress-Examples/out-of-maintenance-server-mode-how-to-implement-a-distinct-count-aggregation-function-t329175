namespace XPG_ServerMode_EF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.entityServerModeSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName,
            this.fieldQuantity,
            this.fieldExtendedPrice,
            this.pivotGridField1,
            this.fieldCountry,
            this.fieldCity,
            this.fieldOrderYear,
            this.fieldOrderMonth});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.AutoExpandGroups = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.Size = new System.Drawing.Size(898, 422);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.ElementType = typeof(XPG_ServerMode_EF.Invoice);
            this.entityServerModeSource1.KeyExpression = "[OrderID]";
            // 
            // fieldProductName
            // 
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 1;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.CellFormat.FormatString = "N0";
            this.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.FieldName = "ExtendedPrice";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField1.AreaIndex = 2;
            this.pivotGridField1.Caption = "Distinct Products";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.UnboundExpression = "DistinctCount([ProductID])";
            this.pivotGridField1.UnboundExpressionMode = DevExpress.XtraPivotGrid.UnboundExpressionMode.UseAggregateFunctions;
            this.pivotGridField1.UnboundFieldName = "Average";
            this.pivotGridField1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            this.fieldCountry.FieldName = "Country";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldCity
            // 
            this.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCity.AreaIndex = 1;
            this.fieldCity.Caption = "City";
            this.fieldCity.FieldName = "City";
            this.fieldCity.Name = "fieldCity";
            // 
            // fieldOrderYear
            // 
            this.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Year";
            this.fieldOrderYear.FieldName = "OrderDate";
            this.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.Name = "fieldOrderYear";
            // 
            // fieldOrderMonth
            // 
            this.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderMonth.AreaIndex = 1;
            this.fieldOrderMonth.Caption = "Month";
            this.fieldOrderMonth.FieldName = "OrderDate";
            this.fieldOrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderMonth.Name = "fieldOrderMonth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 422);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderMonth;
    }
}

