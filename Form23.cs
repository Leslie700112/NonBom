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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet23.NBAnyagigenylo' table. You can move, or remove it, as needed.
            this.nBAnyagigenyloTableAdapter.Fill(this.dataSet23.NBAnyagigenylo);

            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);

            fm.DataGridView = dataGridView1; 
        }
    
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "szallitoKodDataGridViewTextBoxColumn":
                case "supplierNameDataGridViewTextBoxColumn":
                case "kerelmezoDataGridViewTextBoxColumn":
                case "engedelyezoDataGridViewTextBoxColumn":
                case "statusDataGridViewTextBoxColumn":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }
    }
}
