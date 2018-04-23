using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XPG_ServerMode_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(new DistinctCountFunction());
            InitializeComponent();
            entityServerModeSource1.QueryableSource = new NorthwindEntities().Invoices;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pivotGridControl1.BestFit();
        }
    }

    
}
