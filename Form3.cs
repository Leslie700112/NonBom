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
    public partial class Form3 : Form
    {
        public string v_cikk;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VNB_SC330300_StockBatch' table. You can move, or remove it, as needed.
            this.vNB_SC330300_StockBatchTableAdapter.Fill(this.dataSet3.VNB_SC330300_StockBatch,v_cikk,"%%");
            // TODO: This line of code loads data into the 'dataSet1.VNB_SC030300_StockWarehouse' table. You can move, or remove it, as needed.
            this.vNB_SC030300_StockWarehouseTableAdapter.Fill(this.dataSet3.VNB_SC030300_StockWarehouse,v_cikk);

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case (int)Keys.Space:
                    string v_raktar = dataGridView1.CurrentRow.Cells[0].Value.ToString() + "%";
                    this.vNB_SC330300_StockBatchTableAdapter.Fill(this.dataSet3.VNB_SC330300_StockBatch, v_cikk, v_raktar);
                    break;
                case (int)Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string v_raktar = dataGridView1.CurrentRow.Cells[0].Value.ToString() + "%";
            this.vNB_SC330300_StockBatchTableAdapter.Fill(this.dataSet3.VNB_SC330300_StockBatch, v_cikk, v_raktar);
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView2.SelectedCells.Count];
            this.toolStripStatusLabel3.Text = dataGridView2.SelectedCells.Count.ToString();
            int sorindex = 0, a;
            int szam;
            double orm = 0, rm;

            foreach (DataGridViewCell cell in dataGridView2.SelectedCells)
            {
                a = sorindex - 1;
                while (a > -1 && cell.RowIndex != sor[a]) a--;
                if (a == -1)
                {
                    if (Int32.TryParse(dataGridView2.Rows[cell.RowIndex].Cells[1].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView2.Rows[cell.RowIndex].Cells["balanceQtyDataGridViewTextBoxColumn"].Value.ToString(), out rm);

                        orm += rm;

                        this.toolStripStatusLabel4.Text = orm.ToString("N4");
                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }
         }
        }
  


    
    }
}
