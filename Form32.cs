using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Data.SqlClient;

namespace NonBom
{
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet31.VNB_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vNB_SC010300_StockfileTableAdapter.Fill(this.dataSet31.VNB_SC010300_Stockfile);
            // TODO: This line of code loads data into the 'dataSet31.NBLeltarAdatok' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dataSet31.VF_SC360300_StockBinNo' table. You can move, or remove it, as needed.
            this.vF_SC360300_StockBinNoTableAdapter.Fill(this.dataSet31.VF_SC360300_StockBinNo);
            // TODO: This line of code loads data into the 'dataSet31.NBCikkAdatok' table. You can move, or remove it, as needed.
            this.nBCikkAdatokTableAdapter.Fill(this.dataSet31.NBCikkAdatok);

            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;

            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;

            Torol();
            SendKeys.Send("{tab}");
            SendKeys.Send("{tab}");
            SendKeys.Send("{tab}");
            comboBox1.Select();
        }

        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "extProdGroupDataGridViewTextBoxColumn":
                case "textDescriptionDataGridViewTextBoxColumn":
                case "termcsopDataGridViewTextBoxColumn":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
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
                  nBCikkAdatokBindingSource.Filter = "Kereso like '%" + seekValue.Trim() + "%'";
                }
                else
                {
                    try
                    {
                      nBCikkAdatokBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                wkeres = seekValue;
            }
        }

private void Torol ()
        {
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox2.Clear();
            label4.Text = "";
            label5.Text = "";
            comboBox1.ResetText();
            textBox2.Visible = false;
            textBox3.Clear();
            textBox3.Visible = false;
            comboBox1.Select();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter && textBox2.Text != "")
            {
                int CikkFound = nBCikkAdatokBindingSource.Find("StockCode", textBox2.Text.Trim());
                if (CikkFound < 0)
                {
                    textBox2.Clear();
                    textBox2.Select();
                }
                else
                {
                    this.dataGridView1.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
                    this.dataGridView1.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
                    Alapinformaciok();
                }
            }
        }

        private void Alapinformaciok()
        {
           int SorFound =VNB_SC010300_StockfileBindingSource.Find("StockCode", textBox2.Text.Trim());
           label4.Text = dataSet31.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description1"].ToString().Trim() + " ¤ " +
                           dataSet31.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description2"].ToString().Trim() + " ¤ " +
                            dataSet31.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["InternRem1"].ToString().Trim() + " ¤ " +
                             dataSet31.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["InternRem2"].ToString().Trim();
            label5.Text = dataSet31.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description"].ToString().Trim();
            textBox3.Visible = true;
            textBox3.Select();
            textBox2.Enabled = false;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox1.Text.Trim() != "")
            {
                
                    int SorFound2 =vFSC360300StockBinNoBindingSource.Find("BinNumber", comboBox1.Text.Trim());
                    if (SorFound2 < 0)
                    {
                        comboBox1.ResetText();
                        comboBox1.Select();
                    }
                    else
                    {
                    this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
                    this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
                    this.nBLeltarAdatokTableAdapter.FillBy(this.dataSet31.NBLeltarAdatok,comboBox1.Text.Trim());
                    textBox2.Visible = true;
                      textBox2.Select();
                      comboBox1.Enabled = false;
                    }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter && textBox3.Text != "")
            {
                dataGridView2.Rows.Add(textBox2.Text.Trim().ToUpper(), label4.Text.Trim(), textBox3.Text.Trim(), label5.Text.Trim(),
                                      comboBox1.Text.Trim());
                button1.Visible = true;
                textBox2.Clear();
                textBox2.Enabled = true;
                textBox3.Clear();
                textBox3.Visible = false;
                label4.Text = "";
                label5.Text = "";
                this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
                this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
                textBox2.Select();

            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox2.Clear();
            label4.Text = "";
            label5.Text = "";
            textBox3.Clear();
            textBox3.Visible = false;
            textBox2.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            dataGridView3.EndEdit();
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                mySqlCommand.CommandText = "execute NBLeltarJegy @JegyID OUTPUT, @Cikk,@Igenylo,@Raktar,@Polc,@Menny,@Megj";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@JegyID", SqlDbType.Int);
                mySqlCommand.Parameters["@JegyID"].Direction = ParameterDirection.Output;
                mySqlCommand.Parameters.Add("@Cikk", SqlDbType.Char);
                mySqlCommand.Parameters["@Cikk"].Value = dataGridView2.Rows[i].Cells["Column2"].Value.ToString().Trim(); 
                mySqlCommand.Parameters.Add("@Igenylo", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Igenylo"].Value = "NOB";
                mySqlCommand.Parameters.Add("@Raktar", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Raktar"].Value = "50";
                mySqlCommand.Parameters.Add("@Polc", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Polc"].Value = dataGridView2.Rows[i].Cells["Column6"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@Menny", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Menny"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column4"].Value.ToString().Trim());
                mySqlCommand.Parameters.Add("@Megj", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Megj"].Value = "";
                int numberOfRows = mySqlCommand.ExecuteNonQuery();
            }
            for (int j = 0; j < dataGridView3.RowCount; j++)
            {
                mySqlCommand.CommandText = "UPDATE NBLeltarAdatok SET Mennyiseg=@Mennyi,LeltIdo=CURRENT_TIMESTAMP where Bizszam=@Sor";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                mySqlCommand.Parameters["@Sor"].Value =Convert.ToUInt32(dataGridView3.Rows[j].Cells["bizszamDataGridViewTextBoxColumn"].Value.ToString().Trim());
                mySqlCommand.Parameters.Add("@Mennyi", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Mennyi"].Value = Convert.ToDecimal(dataGridView3.Rows[j].Cells["mennyisegDataGridViewTextBoxColumn"].Value.ToString().Trim()); ;
                mySqlCommand.ExecuteNonQuery();
            }


                connection.Close();
            dataGridView2.Rows.Clear();
            this.nBLeltarAdatokTableAdapter.FillBy(this.dataSet31.NBLeltarAdatok, "");
            Torol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            this.nBLeltarAdatokTableAdapter.FillBy(this.dataSet31.NBLeltarAdatok, "");
            Torol();
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);

            if (dataGridView2.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells["Column5"].Value.ToString().Trim() == "db")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                // only allow one decimal point 
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Alapinformaciok();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Alapinformaciok();
        }

        private void dataGridView3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);

            if (dataGridView3.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }

        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView3.CurrentRow.Cells["megysDataGridViewTextBoxColumn"].Value.ToString().Trim() == "db")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                // only allow one decimal point 
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }



    }
}
