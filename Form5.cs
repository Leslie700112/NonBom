using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonBom
{
    public partial class Form5 : Form
    {
        public string v_cikk;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.vNB_SC110300_StockPlanningTableAdapter.Fill(this.dataSet5.VNB_SC110300_StockPlanning, v_cikk);
            this.dataGridView1.Columns[5].Frozen = true;
            this.toolStripStatusLabel1.Text = "0";
            this.toolStripStatusLabel3.Text = "0";
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            int sorindex = 0, i;
         //   okeszl = Convert.ToDouble(dataSet6.Tables["VF_SC030300_StockW_Group_StockCode"].Rows[0]["StockBalance"]);
            double osszeg = 0, szam;
            double orm = 0, rm;
            double ogym = 0, gym;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                i = sorindex - 1;
                while (i > -1 && cell.RowIndex != sor[i]) i--;
                if (i == -1)
                {
                    if (double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[2].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[9].Value.ToString(), out rm);
                        double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[10].Value.ToString(), out gym);
                        osszeg += szam;
                        orm += rm;
                        ogym += gym;

                       // okeszl += szam;
                        this.toolStripStatusLabel1.Text = osszeg.ToString();
                        this.toolStripStatusLabel3.Text = orm.ToString();
                     //   this.toolStripStatusLabel7.Text = ogym.ToString();
                     //  this.toolStripStatusLabel11.Text = okeszl.ToString();
                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].Cells["inOutDataGridViewTextBoxColumn"].Value.ToString() == "0")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Coral;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }
    }
}
