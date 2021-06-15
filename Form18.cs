using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Data.SqlClient;
using System.IO;

namespace NonBom
{
    public partial class Form18 : Form
    {
        public string honnan,rendi,doku;
        private int korx, kory, tipus;
        private double osszeg;
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet18.NBKodok' table. You can move, or remove it, as needed.
            this.nBKodokTableAdapter.Fill(this.dataSet18.NBKodok);
            // TODO: This line of code loads data into the 'dataSet182.MTGeplista' table. You can move, or remove it, as needed.
            this.mTGeplistaTableAdapter.Fill(this.dataSet18.MTGeplista);
            // TODO: This line of code loads data into the 'dataSet18.MTGeplista1' table. You can move, or remove it, as needed.
         //   this.mTGeplista1TableAdapter.Fill(this.dataSet18.MTGeplista);
            // TODO: This line of code loads data into the 'dataSet181.NBSzolgKodok_SzolgTipus' table. You can move, or remove it, as needed.
            this.nBSzolgKodok_SzolgTipusTableAdapter.Fill(this.dataSet18.NBSzolgKodok_SzolgTipus);
           
            // TODO: This line of code loads data into the 'dataSet18.MTGeplista' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet18.VF_SY240300_EXT_termcsop' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet18.VF_PL010300_SupplierFile' table. You can move, or remove it, as needed.
            this.vF_PL010300_SupplierFileTableAdapter.Fill(this.dataSet18.VF_PL010300_SupplierFile);
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            label7.Text = de.Properties["fullName"].Value.ToString();
          
            if (honnan == "1")
            {
                this.label2.Select();
                SendKeys.Send("{tab}");
                SendKeys.Send("{tab}");
                SendKeys.Send("{tab}");
            }
          //  comboBox1.SelectedIndex = 0;
          //  this.comboBox1.Select();
            Eltuntet();
        }

        private void comboBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox5.Text.Trim() != "")
            {

                if (comboBox5.SelectedValue.ToString() == "0")
                    tipus = 0;
                else
                    tipus = 1;
                    comboBox1.ResetText();
                    comboBox1.Visible = true;
                    comboBox1.Select();
                    comboBox5.Enabled = false;
            }
            else
                comboBox5.Select();
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
                    label6.Text = dataSet18.Tables["VF_PL010300_SupplierFile"].Rows[SzallFound]["SupplierCode"].ToString().Trim();
                    this.vF_SY240300_EXT_termcsopTableAdapter.Fill(this.dataSet18.VF_SY240300_EXT_termcsop);
                    label11.Text = dataSet18.Tables["VF_PL010300_SupplierFile"].Rows[SzallFound]["CurrencyCode"].ToString().Trim();
                    if (tipus == 0)
                    {
                        comboBox4.ResetText();
                        comboBox4.Visible = true;
                        comboBox4.Select();
                        comboBox1.Enabled = false;
                    }
                    else
                    {
                        comboBox3.Text = "";
                        textBox2.Clear();
                        textBox2.Visible = true;
                        textBox2.Select();
                        comboBox1.Enabled = false;
                    }
                }
            }
            else
                comboBox1.Select();
        }

        private void Eltuntet()
        {
            osszeg = 0;
            dataGridView1.Rows.Clear();
            comboBox1.ResetText();
            label6.Text = "";
            label9.Text = "";
            label11.Text = "";
            comboBox1.ResetText();
            comboBox1.Visible = false;
            comboBox3.ResetText();
            comboBox3.Visible = false;
            comboBox2.ResetText();
            comboBox2.Visible = false;
            comboBox4.ResetText();
            comboBox4.Visible = false;
            groupBox1.Visible = false;
            button2.Visible = false;
            textBox1.Clear();
            textBox1.Visible = false;
            textBox2.Clear();
            textBox3.Visible = false;
            textBox3.Enabled = true;
            textBox2.Visible = false;
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
            comboBox2.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox5.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eltuntet();
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox3.Text != "")
                {
                    int CellFound = vFSY240300EXTtermcsopBindingSource.Find("TextDescription", comboBox3.Text.Trim());
                    if (CellFound < 0)
                    {
                        comboBox3.ResetText();
                        comboBox3.Select();
                    }
                    else
                    {
                        this.mTGeplistaTableAdapter.Fill(this.dataSet18.MTGeplista);
                        comboBox2.ResetText();
                        comboBox2.Visible = true;
                        comboBox2.Select();
                        comboBox3.Enabled = false;
                    }
                }
                else
                {
                    this.mTGeplistaTableAdapter.Fill(this.dataSet18.MTGeplista);
                    comboBox2.ResetText();
                    comboBox2.Visible = true;
                    comboBox2.Select();
                    comboBox3.Enabled = false;
                }
            }
            else
                comboBox3.Select();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox2.Text != "")
                {
                    int GepFound = mTGeplistaBindingSource.Find("Gepek", comboBox2.Text.Trim());
                    if (GepFound < 0)
                    {
                        comboBox2.ResetText();
                        comboBox2.Select();
                    }
                    else
                    {
                     label9.Text = dataSet18.Tables["MTGeplista"].Rows[GepFound]["FusetechKod"].ToString().Trim();
                  //   label14.Text = dataSet18.Tables["MTGeplista"].Rows[GepFound]["Gepek"].ToString().Trim();
                     textBox2.Visible = true;
                     textBox2.Select();
                     comboBox2.Enabled = false;
                    }
                }
                else
                {
                    textBox2.Visible = true;
                    textBox2.Select();
                    comboBox2.Enabled = false;
                }
            }
            else
                comboBox2.Select();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
             {
                 textBox3.Visible = true;
                 textBox3.Select();
                 textBox2.Enabled = false;
             }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && textBox1.Text.Trim() != "")
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, comboBox3.Text.Trim(), label9.Text.Trim(), comboBox2.Text.Trim(), textBox2.Text.Trim(),
                    textBox1.Text.Trim(), textBox3.Text.Trim(), label11.Text.Trim(), comboBox4.Text.Trim(),tipus.ToString().Trim());
                button2.Visible = true;
                osszeg = osszeg + Convert.ToDouble(textBox3.Text);
                if (tipus == 0)
                {
                    label9.Text = "";
                    comboBox3.ResetText();
                    comboBox3.Visible = false;
                    comboBox2.ResetText();
                    comboBox2.Visible = false;
                    comboBox4.ResetText();
                    comboBox4.Visible = true;
                    groupBox1.Visible = false;
                    textBox1.Clear();
                    textBox1.Visible = false;
                    textBox2.Clear();
                    textBox2.Visible = false;
                    textBox2.Enabled = true;
                    textBox3.Clear();
                    textBox3.Visible = false;
                    textBox3.Enabled = true;
                    comboBox3.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox4.Enabled = true;
                    comboBox4.Select();
                }
                else
                {
                    textBox1.Clear();
                    textBox1.Visible = false;
                    textBox2.Clear();
                    textBox2.Visible = true;
                    textBox2.Enabled = true;
                    textBox3.Clear();
                    textBox3.Visible = false;
                    textBox3.Enabled = true;
                    textBox2.Select();
                }

            }
            else
                textBox1.Select();
        }

         private void comboBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                groupBox1.Visible = true;
                textBox4.Select();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string wkeres = " ";

            string seekValue = this.textBox4.Text;
            if (seekValue != wkeres)
            {
                if (!string.IsNullOrEmpty(seekValue))
                {
                    mTGeplistaBindingSource.Filter = "Gepek like '%" + seekValue.Trim() + "%'";
                }
                else
                {
                    try
                    {
                        mTGeplistaBindingSource.Filter = "";
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
            if (osszeg >= 500)
            {
                Form182 Form182 = new Form182();
                Form182.Tipus = tipus;
                Form182.Location = new Point(100, 800);
                Form182.ShowDialog();
                doku = Form182.Doku;
            }

            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = "execute NBSzolgaltat @RendelesID OUTPUT,@Szall,@Igenylo,@Tipus,@Dok ";
            mySqlCommand.Parameters.Add("@RendelesID", SqlDbType.Int);
            mySqlCommand.Parameters["@RendelesID"].Direction = ParameterDirection.Output;
            mySqlCommand.Parameters.Add("@Szall", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Szall"].Value = label6.Text.Trim();
            mySqlCommand.Parameters.Add("@Igenylo", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Igenylo"].Value = label7.Text.Trim();
            mySqlCommand.Parameters.Add("@Tipus", SqlDbType.Int);
            mySqlCommand.Parameters["@Tipus"].Value = tipus;
            mySqlCommand.Parameters.Add("@Dok", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Dok"].Value = doku;
            int numberOfRows = mySqlCommand.ExecuteNonQuery();
            rendi = mySqlCommand.Parameters["@RendelesID"].Value.ToString();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                mySqlCommand.CommandText = "INSERT INTO NBSzolgaltatas (Szolgaltato,Munkahely,GepSzerszam,BeruszamRACF,Megjegyzes,Igenylo,RendIdo,Statusz,RendelesSzam,RendSorszam,Ar,Deviza,SzolgTipus)" +
                "VALUES (@szolgaltato,@munkahely,@gepSzerszam,@beruszamRACF,@megjegyzes,@igenylo,CURRENT_TIMESTAMP,'0',@RendelesSzam,@RendSorszam,@Ar,@Dev,@szolgtip)";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@szolgaltato", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@szolgaltato"].Value = label6.Text.Trim();
                mySqlCommand.Parameters.Add("@munkahely", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@munkahely"].Value = dataGridView1.Rows[i].Cells["Column2"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@gepSzerszam", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@gepSzerszam"].Value = dataGridView1.Rows[i].Cells["Column6"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@beruszamRACF", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@beruszamRACF"].Value = dataGridView1.Rows[i].Cells["Column4"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@megjegyzes", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@megjegyzes"].Value = dataGridView1.Rows[i].Cells["Column5"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@igenylo", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@igenylo"].Value = label7.Text.Trim();
                mySqlCommand.Parameters.Add("@RendelesSzam", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@RendelesSzam"].Value = rendi.Trim();
                mySqlCommand.Parameters.Add("@RendSorszam", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@RendSorszam"].Value = dataGridView1.Rows[i].Cells["Column1"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@Ar", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Ar"].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Column7"].Value.ToString().Trim());
                mySqlCommand.Parameters.Add("@Dev", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Dev"].Value = dataGridView1.Rows[i].Cells["Column8"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@szolgtip", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@szolgtip"].Value = dataGridView1.Rows[i].Cells["Column9"].Value.ToString().Trim();
                mySqlCommand.ExecuteNonQuery();
            }
            connection.Close();
            Eltuntet();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dataGridView1.HitTest(e.X, e.Y).RowIndex != -1)
            {
                ContextMenu m = new ContextMenu();
                MenuItem mTorol = new MenuItem("Törlés");
                mTorol.Click += new EventHandler(mTorol_Click);
                m.MenuItems.AddRange(new MenuItem[] { mTorol });
                //dataGridView1.ContextMenu= m;
                korx = e.X;
                kory = e.Y;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }
  
        private void mTorol_Click(object sender, EventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridView1.HitTest(korx, kory);
            dataGridView1.Rows.RemoveAt(hit.RowIndex);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Select();
            groupBox1.Visible = false;
        }

        

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                comboBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                comboBox2.Select();
                groupBox1.Visible = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point 
            if (e.KeyChar == '.' &&  (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter && textBox3.Text.Trim()!="")
            {
                textBox1.Clear();
                textBox1.Visible = true;
                textBox1.Select();
                textBox3.Enabled = false;
            }
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox4.Text != "")
            {
                   int TipFound = nBSzolgKodokSzolgTipusBindingSource.Find("Megnevezes", comboBox4.Text.Trim());
                    if (TipFound < 0)
                    {
                        comboBox4.ResetText();
                        comboBox4.Select();
                    }
                    else
                    {
                      
                        comboBox3.ResetText();
                        comboBox3.Visible = true;
                        comboBox3.Select();
                        comboBox4.Enabled = false;
                    }
                }
            else
                comboBox4.Select();
        }

        private void Form18_DragEnter(object sender, DragEventArgs e)
        {
            //if(e.Data.GetDataPresent(DataFormats.FileDrop,false)==true)
            //{
            //    e.Effect = DragDropEffects.All;
            //}
        }

        private void Form18_DragDrop(object sender, DragEventArgs e)
        {
            //string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            //foreach(string file in droppedFiles)
            //{
            // textBox5.Text =file;
           
            //}
        }

    }
}
