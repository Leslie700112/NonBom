using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NonBom
{
    public partial class Form13 : Form
    {
        public string Cikkszam, Szalllevel, Szallito, mennyiseg, Lejart;
      
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VNB_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vNB_SC010300_StockfileTableAdapter.Fill(this.dataSet1.VNB_SC010300_Stockfile);
            textBox2.Text = "1";
            if (String.IsNullOrEmpty(Cikkszam))
            {
                textBox1.Select();
                Szalllevel = "";
                Szallito = "";
                Lejart = "";
            }
            else
            {
                textBox1.Text = Cikkszam;
                label1.Text = dataGridView1.CurrentRow.Cells["description1DataGridViewTextBoxColumn"].Value.ToString() + " ¤ " +
                dataGridView1.CurrentRow.Cells["description2DataGridViewTextBoxColumn"].Value.ToString();
                label7.Text = dataGridView1.CurrentRow.Cells["internRem1DataGridViewTextBoxColumn"].Value.ToString() + " ¤ " +
                dataGridView1.CurrentRow.Cells["internRem2DataGridViewTextBoxColumn"].Value.ToString();
                Cikkszam = textBox1.Text.Trim();
                textBox2.Select();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string wkeres = " ";
            string seekValue = this.textBox1.Text;
            if (seekValue != wkeres)
            {
                if (!string.IsNullOrEmpty(seekValue))
                {
                    vNBSC010300StockfileBindingSource.Filter = "Kereso like '%" + seekValue.Trim() + "%'";
                }
                else
                {
                    try
                    {
                        vNBSC010300StockfileBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                wkeres = seekValue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString();
            label1.Text = dataGridView1.CurrentRow.Cells["description1DataGridViewTextBoxColumn"].Value.ToString()+" ¤ "+
            dataGridView1.CurrentRow.Cells["description2DataGridViewTextBoxColumn"].Value.ToString();
            label7.Text = dataGridView1.CurrentRow.Cells["internRem1DataGridViewTextBoxColumn"].Value.ToString() + " ¤ " +
            dataGridView1.CurrentRow.Cells["internRem2DataGridViewTextBoxColumn"].Value.ToString();
            Cikkszam = textBox1.Text.Trim();
            textBox2.Select();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
             if ((int)e.KeyChar == (int)Keys.Enter)
             {
                 button1.Select();
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nyomtatas();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Nyomtatas();
        }
   
        private void Nyomtatas()
        {
            this.printDocument1.DefaultPageSettings.Landscape = false;
            this.printDocument1.DefaultPageSettings.PrinterSettings.PrinterName = @"\\DELL-PC124\ZDesigner GC420T (EPL)";
            this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 268, 200);
             for (int i = 1; i <= Convert.ToInt32(textBox2.Text.Trim()); i++)
            {

              //  if (this.printDialog1.ShowDialog() == DialogResult.OK)
             //  {
                    this.printDocument1.Print();
                   //   this.printPreviewDialog1.ShowDialog();
                    //   Application.OpenForms["Form2"].Close();
                }
             textBox1.Clear();
             textBox2.Text = "1";
             textBox1.Select();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                System.Drawing.Graphics g = e.Graphics;
                g.DrawString("Fusetech Kft.", new System.Drawing.Font("Arial", 6F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(215, 5));
                g.DrawString('*' + Cikkszam + '*', new System.Drawing.Font("Code 39", 18F, FontStyle.Regular), new SolidBrush(Color.Black), new Point(10, 20));

                g.DrawString(Cikkszam, new System.Drawing.Font("Arial", 7F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 55));
                g.DrawString(label1.Text.Trim(), new System.Drawing.Font("Arial", 7F), new SolidBrush(Color.Black), new Point(10, 70));
                g.DrawString(label7.Text.Trim(), new System.Drawing.Font("Arial", 7F), new SolidBrush(Color.Black), new Point(10, 85));

                g.DrawString("Beérk.dátum: " + DateTime.Today.ToString("d"), new System.Drawing.Font("Arial", 7F), new SolidBrush(Color.Black), new Point(10, 105));
                if (Lejart != "9999-12-31")
                {
                    g.DrawString("Lejárati dátum: " + Lejart, new System.Drawing.Font("Arial", 7F), new SolidBrush(Color.Black), new Point(140, 105));
                }
                g.DrawString("Száll.lev.sz.: ", new System.Drawing.Font("Arial", 7F), new SolidBrush(Color.Black), new Point(10, 118));
                g.DrawString(Szalllevel.Trim(), new System.Drawing.Font("Arial", 7F), new SolidBrush(Color.Black), new Point(70, 118));
                g.DrawString("Szállító: ", new System.Drawing.Font("Arial", 7F), new SolidBrush(Color.Black), new Point(10, 130));
                g.DrawString(Szallito.Trim(), new System.Drawing.Font("Arial", 7F), new SolidBrush(Color.Black), new Point(70, 130));
        }


    }
}
