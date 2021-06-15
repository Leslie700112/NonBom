using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Data.SqlClient;
using DgvFilterPopup;

namespace NonBom
{
    public partial class Form9 : Form
    {
        public string honnan;
        private DateTime most;
        private string Deviza;
     //   private int korx, kory, jelolt;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet7.VNB_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vNB_SC010300_StockfileTableAdapter.Fill(this.dataSet7.VNB_SC010300_Stockfile);
            // TODO: This line of code loads data into the 'dataSet7.VF_PL010300_SupplierFile' table. You can move, or remove it, as needed.
            this.vF_PL010300_SupplierFileTableAdapter.Fill(this.dataSet7.VF_PL010300_SupplierFile);
           
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            label10.Text = de.Properties["fullName"].Value.ToString();
            Eltuntet();
            label9.Text = DateTime.Now.ToString();
            dateTimePicker1.Value = DateTime.Today;

            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);

            fm.DataGridView = dataGridView2;
        
            if (honnan == "1")
            {
                this.label2.Select();
                SendKeys.Send("{tab}");
                SendKeys.Send("{tab}");
                SendKeys.Send("{tab}");
                //    splitContainer1.ActiveControl = comboBox1;
            }
            comboBox1.SelectedIndex = 0;
            this.comboBox1.Select();
         }
     
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "CurrencyShortName":
              //  case "supplierNameDataGridViewTextBoxColumn":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox1.Text.Trim() != "")
            {
                int SzallFound = vFPL010300SupplierFileBindingSource.Find("SupplierName", comboBox1.Text.Trim());
                if (SzallFound < 0)
                {
                    comboBox1.ResetText();
                    comboBox1.Select();
                }
                else
                {
                    label8.Text = dataSet7.Tables["VF_PL010300_SupplierFile"].Rows[SzallFound]["SupplierCode"].ToString().Trim();
                    label20.Text = dataSet7.Tables["VF_PL010300_SupplierFile"].Rows[SzallFound]["CurrencyCode"].ToString().Trim();
                    most = DateTime.Now;
                    dateTimePicker1.Visible = true;
                    dateTimePicker1.Select();
                }
            }
            else
                comboBox1.Select();
        }
  
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eltuntet();
            comboBox1.Select();
        }
        
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter )
          {
           if(dateTimePicker1.Value>=DateTime.Today)
             {
                textBox1.Visible = true;
                textBox1.Select();
            }
            else
            {
              dateTimePicker1.Value = DateTime.Today;
              dateTimePicker1.Select();
            }
          }
        }     
    
        private void Eltuntet()
        {
            label2.Text = "";
            label8.Text = "";
            label20.Text = "";
            label23.Text = "";
            textBox2.Clear();
            dateTimePicker1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            dataGridView2.Visible = false;
            label13.Text = "";
            button1.Visible = false;
            button2.Visible = false;
            EltuntetSor();
            this.toolStripStatusLabel2.Text = "";
        }
 
        private void EltuntetSor()
       {
           dateTimePicker2.Visible = false;
           label23.Text = "";
           textBox3.Visible = false;
           textBox4.Visible = false;
           textBox5.Visible = false;
           textBox6.Visible = false;
           textBox6.Clear();
           label14.Text = "";
           label17.Text = "";
           Deviza = "";
       }

        private void alapInfo()
       {
           label14.Text = dataGridView2.CurrentRow.Cells["description1DataGridViewTextBoxColumn"].Value.ToString() + " ¤ " +
                                   dataGridView2.CurrentRow.Cells["description2DataGridViewTextBoxColumn"].Value.ToString() + " ¤ " +
                                   dataGridView2.CurrentRow.Cells["internRem1DataGridViewTextBoxColumn"].Value.ToString();
           label17.Text = dataGridView2.CurrentRow.Cells["meegysDataGridViewTextBoxColumn"].Value.ToString();
           textBox4.Text = dataGridView2.CurrentRow.Cells["purchasePricDataGridViewTextBoxColumn"].Value.ToString();
           Deviza = dataGridView2.CurrentRow.Cells["CurrencyShortName"].Value.ToString();
           if (label20.Text == dataGridView2.CurrentRow.Cells["CurrencyShortName"].Value.ToString())
           {
               dateTimePicker2.Value = dateTimePicker1.Value;
               dateTimePicker2.Visible = true;
               label23.Text = Deviza;
               dateTimePicker2.Select();
           }
           else
           {
               MessageBox.Show("Nem egyezik a VEVŐ és a CIKK DEVIZA !!", "Figyelmeztetés", MessageBoxButtons.OK,
                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
               textBox2.Clear();
               EltuntetSor();
           }
       }

       private void textBox1_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter )
           {
               button1.Visible = true;
               button2.Visible = true;
               textBox2.Visible = true;
               textBox2.Select();
               dataGridView2.Visible = true;
               dataGridView2.ClearSelection();
           }
       }

       private void textBox2_TextChanged(object sender, EventArgs e)
       {
           EltuntetSor();
           string wkeres = " ";
           string seekValue = this.textBox2.Text;
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
   
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
       {
           if ((int)e.KeyChar == (int)Keys.Enter && textBox2.Text != "")
           {
               int CikkFound = vNBSC010300StockfileBindingSource.Find("StockCode", textBox2.Text.Trim());
               if (CikkFound < 0)
               {
                   if (dataGridView2.RowCount == 1)
                   {
                       
                       textBox2.Text = dataGridView2.CurrentRow.Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString();
                       alapInfo();
                     }
                   else
                   {
                       textBox2.Clear();
                       textBox2.Select();
                   }
               }
               else
               {
                   alapInfo();
               }
           }
       }
  
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (label17.Text == "db")
           {
               if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
               {
                   e.Handled = true;
               }
           }
           else
           {
               if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
               {
                   e.Handled = true;
               }
               // only allow one decimal point 
               if ((e.KeyChar == ',' || e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).Text.IndexOf('.') > -1))
               {
                   e.Handled = true;
               }
           }
           
           if ((int)e.KeyChar == (int)Keys.Enter)
           {
             if (!String.IsNullOrEmpty(textBox3.Text))
             {
                 if (Convert.ToDouble(textBox3.Text) > 0)
                 {
                     dataGridView1.Rows.Add(dataGridView1.Rows.Count+1, textBox2.Text.Trim().ToUpper(), label14.Text.Trim(), label17.Text.Trim(),
                         textBox3.Text.Replace(",", ".").Trim(), textBox4.Text.Replace(",", ".").Trim(),
                      Convert.ToDouble(textBox3.Text.Replace(",", ".")) * Convert.ToDouble(textBox4.Text.Replace(",", ".")),
                      dateTimePicker2.Value.ToString().Trim(), textBox6.Text.Trim(), textBox5.Text.Trim(),label23.Text.Trim());
                     textBox2.Clear();
                     textBox3.Clear();
                     textBox4.Clear();
                     dateTimePicker2.Value = dateTimePicker1.Value;
                     label14.Text = "";
                     label17.Text = "";
                     textBox2.Select();
                     Szamol();
                 }
                 else
                     textBox3.Clear();
             }
           }
       }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString();
            alapInfo();
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((int)e.KeyChar == (int)Keys.Enter)
             {
                 if (dataGridView2.RowCount > 0)
                 {
                     int r = dataGridView2.CurrentCell.RowIndex;
                     if (r == 0)
                     {
                         textBox2.Text = dataGridView2.Rows[r].Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString();
                     }
                     else
                     {
                         textBox2.Text = dataGridView2.Rows[r - 1].Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString();
                     }
                     alapInfo();
                 }
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eltuntet();
            dataGridView1.Rows.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox1.Select();
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter && dateTimePicker2.Value >= DateTime.Today)
            {
                textBox5.Visible = true;
                textBox5.Select();
            }
            else
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
                dateTimePicker2.Select();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                // only allow one decimal point 
                if ((e.KeyChar == ',' || e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    textBox3.Clear();
                    textBox3.Visible = true;
                    textBox3.Select();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 1)
            {
                SqlConnection mySqlConnection = new SqlConnection("Data Source=scala1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                mySqlConnection.Open();
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "execute NBRendeles @RendelesID OUTPUT,@Szall,@KertIdo,@Megj,@Igenylo,'0','0' ";
                mySqlCommand.Parameters.Add("@RendelesID", SqlDbType.Int);
                mySqlCommand.Parameters["@RendelesID"].Direction = ParameterDirection.Output;
                mySqlCommand.Parameters.Add("@Szall", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Szall"].Value = this.label8.Text.Trim();
                mySqlCommand.Parameters.Add("@KertIdo", SqlDbType.Date);
                mySqlCommand.Parameters["@KertIdo"].Value = this.dateTimePicker1.Value;
                mySqlCommand.Parameters.Add("@Megj", SqlDbType.Char);
                mySqlCommand.Parameters["@Megj"].Value = this.textBox1.Text;
                mySqlCommand.Parameters.Add("@Igenylo", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Igenylo"].Value = label10.Text.Trim();
                int numberOfRows = mySqlCommand.ExecuteNonQuery();
                label2.Text = mySqlCommand.Parameters["@RendelesID"].Value.ToString();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    mySqlCommand.CommandText = "INSERT INTO NBAnyagigenylo" +
                 "(RendelesSzam,RendSorszam,Cikkszam,RendeltMenny,Egysegar,KertSzallIdo,Tipus,Status,Beruhazasszam,Megjegyzes2,Deviza)" +
                 "VALUES (@RendelesSzam,@RendSorszam,@Cikkszam,@RendeltMenny,@Egysegar,@KertSzallIdo,'0','0',@Beruszam,@megj2,@deviza)";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@RendelesSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@RendelesSzam"].Value = label2.Text.Trim();
                    mySqlCommand.Parameters.Add("@RendSorszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@RendSorszam"].Value = dataGridView1.Rows[i].Cells["Column1"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Cikkszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Cikkszam"].Value = dataGridView1.Rows[i].Cells["Column2"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@RendeltMenny", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@RendeltMenny"].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells["Column5"].Value);
                    mySqlCommand.Parameters.Add("@Egysegar", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@Egysegar"].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells["Column6"].Value);
                    mySqlCommand.Parameters.Add("@KertSzallIdo", SqlDbType.Date);
                    mySqlCommand.Parameters["@KertSzallIdo"].Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["Column8"].Value);
                    mySqlCommand.Parameters.Add("@Beruszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Beruszam"].Value = dataGridView1.Rows[i].Cells["Column9"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@megj2", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@megj2"].Value = dataGridView1.Rows[i].Cells["Column10"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@deviza", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@deviza"].Value = dataGridView1.Rows[i].Cells["Column11"].Value.ToString().Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
                mySqlConnection.Close();
                EltuntetSor();
                Eltuntet();
                label9.Text = DateTime.Now.ToString();
                dateTimePicker1.Value = DateTime.Now;
                dataGridView1.Rows.Clear();
                comboBox1.SelectedIndex = 0;
                this.comboBox1.Select();
             
            }
            else
            {
                MessageBox.Show("Nincs tétel !!", "Figyelmeztetés", MessageBoxButtons.OK,
                                 MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                EltuntetSor();
                textBox2.Clear();
                textBox2.Select();
            }
           
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                textBox6.Visible = true;
                textBox6.Select();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                textBox4.Visible = true;
                textBox4.Select();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 5) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }
  
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Column4"].Value.ToString().Trim() == "db")
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
    
        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["Column7"].Value = Convert.ToDouble(dataGridView1.CurrentRow.Cells["Column6"].Value) *
                                                              Convert.ToDouble(dataGridView1.CurrentRow.Cells["Column5"].Value);
            if (Convert.ToDouble(dataGridView1.CurrentRow.Cells["Column5"].Value) == 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                Ujraszamoz();
                textBox2.Select();
            }
            Szamol();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor4 = new int[dataGridView1.SelectedCells.Count];
            int sorindex4 = 0, q;
            double szam4 = 0;
            double osszeg4 = 0;
            foreach (DataGridViewCell cell4 in dataGridView1.SelectedCells)
            {
                q = sorindex4 - 1;
                while (q > -1 && cell4.RowIndex != sor4[q]) q--;
                if (q == -1)
                {
                    if (double.TryParse(dataGridView1.Rows[cell4.RowIndex].Cells[6].Value.ToString(), out szam4))
                    {
                        osszeg4 += szam4;
                        this.toolStripStatusLabel2.Text = osszeg4.ToString("N2");
                    }
                    sor4[sorindex4] = cell4.RowIndex;
                    sorindex4++;
                }
            }
        }

       private void Szamol()
        {
            double sum5 = 0;
            for (int x = 0; x < dataGridView1.Rows.Count; ++x)
            {
                sum5 += Convert.ToDouble(dataGridView1.Rows[x].Cells[6].Value);
             }
            this.toolStripStatusLabel2.Text = sum5.ToString("N2");
        }
     private void Ujraszamoz()
     {
         int z = 1;
         for (int t = 0; t < dataGridView1.Rows.Count; ++t)
            {
                dataGridView1.Rows[t].Cells[0].Value = z.ToString().Trim();
                ++z;
             }
     }


    }
}
