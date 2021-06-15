using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;

namespace NonBom
{
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet30.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet30.DataTable1);
            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;
        }

        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            //switch (e.Column.Name)
            //{
            //    case "binNumberDataGridViewTextBoxColumn":
            //        e.ColumnFilter = new DgvComboBoxColumnFilter();
            //        break;
            //}
        }
    }
}
