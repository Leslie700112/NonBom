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
    public partial class Form29 : Form
    {
      //  public string v_cikk;
        public Form29()
        {
            InitializeComponent();
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet29.FelhasznalasDataTable' table. You can move, or remove it, as needed.
            this.felhasznalasDataTableTableAdapter.Fill(this.dataSet29.FelhasznalasDataTable);

            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;
            this.toolStripStatusLabel5.Text = "0";
            this.toolStripStatusLabel3.Text = "0";
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            int sorindex = 0, i;
            double osszeg = 0, szam;
            double orm = 0, rm;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                i = sorindex - 1;
                while (i > -1 && cell.RowIndex != sor[i]) i--;
                if (i == -1)
                {
                    if (double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells["mennyisegDataGridViewTextBoxColumn"].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells["mennyisegDataGridViewTextBoxColumn"].Value.ToString(), out rm);
                        osszeg += szam;
                        orm += rm;
                        //ogym += gym;

                        // okeszl += szam;
                        this.toolStripStatusLabel3.Text = dataGridView1.SelectedCells.Count.ToString();
                        this.toolStripStatusLabel5.Text = orm.ToString();

                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }
            }
        }
    }
}
