using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace NonBom
{
    public partial class Form27 : Form
    {
        public string v_report;
        public Form27()
        {
            InitializeComponent();
        }

        private void Form27_Load(object sender, EventArgs e)
        {
           CrystalDecisions.CrystalReports.Engine.ReportDocument doc =
           new CrystalDecisions.CrystalReports.Engine.ReportDocument();
           doc.Load(v_report);
           crystalReportViewer1.ReportSource = doc;
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Escape)
        //    {
        //        this.Close();
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}
