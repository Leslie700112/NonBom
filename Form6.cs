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
    public partial class Form6 : Form
    {
        public string v_cikk, v_mertegys,v_megn1, v_megn2, v_megn3;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.label4.Text = v_mertegys;
            this.dateTimePicker1.Value = DateTime.Today;
            this.dateTimePicker2.Value = DateTime.Today;
            //if (v_megn1 != null)
            //{
            //    textBox2.Text = v_cikk;
            //    textBox3.Text = v_megn1;
            //    textBox4.Text = v_megn2;
            //    textBox5.Text = v_megn3;
            //    textBox6.Text = v_mertegys;
            //}
            //else
            //{
            //    textBox2.Visible = false;
            //    textBox3.Visible = false;
            //    textBox4.Visible = false;
            //    textBox5.Visible = false;
            //    textBox6.Visible = false;
            //    toolStrip1.Visible = false;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bev, kiv, lel, rm1, ko1, ko2, rm2, ko3, ko4, ko5;
            if (checkBox2.Checked == true)
                bev = "00";
            else
                bev = "";
            if (checkBox3.Checked == true)
                kiv = "01";
            else
                kiv = "";
            if (checkBox4.Checked == true)
                lel = "02";
            else
                lel = "";
            if (checkBox5.Checked == true)
                rm1 = "04";
            else
                rm1 = "";
            if (checkBox6.Checked == true)
                ko1 = "05";
            else
                ko1 = "";
            if (checkBox7.Checked == true)
                ko2 = "08";
            else
                ko2 = "";
            if (checkBox8.Checked == true)
                rm2 = "09";
            else
                rm2 = "";
            if (checkBox9.Checked == true)
                ko3 = "03";
            else
                ko3 = "";
            if (checkBox10.Checked == true)
                ko4 = "10";
            else
                ko4 = "";
            if (checkBox11.Checked == true)
                ko5 = "07";
            else
                ko5 = "";
            if (checkBox1.Checked == false)
            {
                DateTime v_tol = new DateTime(2000, 1, 1, 0, 0, 0);
                DateTime v_ig = DateTime.Today;
                dataSet6.Clear();
                this.vNB_SC070300_StockTransactTableAdapter.Fill(this.dataSet6.VNB_SC070300_StockTransact, v_cikk, v_tol, v_ig, bev, kiv, lel, rm1, ko1, ko2, rm2, ko3, ko4, ko5);
                this.dataGridView1.Columns[7].Frozen = true;
            }
            else
            {
                DateTime v_tol = dateTimePicker1.Value;
                DateTime v_ig = dateTimePicker2.Value;
                dataSet6.Clear();
                this.vNB_SC070300_StockTransactTableAdapter.Fill(this.dataSet6.VNB_SC070300_StockTransact, v_cikk, v_tol, v_ig, bev, kiv, lel, rm1, ko1, ko2, rm2, ko3, ko4, ko5);
                this.dataGridView1.Columns[7].Frozen = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            int sorindex = 0, i;
            double osszeg = 0, szam;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                i = sorindex - 1;
                while (i > -1 && cell.RowIndex != sor[i]) i--;
                if (i == -1)
                {
                    if (double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[4].Value.ToString(), out szam))
                    {
                        osszeg += szam;
                        this.textBox1.Text = osszeg.ToString("0,0.00");
                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }

            }
        }
    }
}
