using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using DgvFilterPopup;

namespace NonBom
{
    public partial class Form15 : Form
    {
        private string vizsgal = "";
        public string honnan;
        private double BevMenny, Elozo; //,Keszlet;
        private string KtsghKod, KtsgNev,KonyvKod,Konszig,FelhasznID;
        public string pecset;
       

        public Form15()
        {
            InitializeComponent();
          
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet15.MTGeplista1' table. You can move, or remove it, as needed.
            this.mTGeplista1TableAdapter.Fill(this.dataSet15.MTGeplista1);
            // TODO: This line of code loads data into the 'dataSet15.VNB_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vNB_SC010300_StockfileTableAdapter.Fill(this.dataSet15.VNB_SC010300_Stockfile);
            // TODO: This line of code loads data into the 'dataSet15.MTGeplista' table. You can move, or remove it, as needed.
            this.mTGeplistaTableAdapter.Fill(this.dataSet15.MTGeplista);
            // TODO: This line of code loads data into the 'dataSet15.DolgKodok' table. You can move, or remove it, as needed.
            this.dolgKodokTableAdapter.Fill(this.dataSet15.DolgKodok);
            // TODO: This line of code loads data into the 'dataSet15.VF_GL0303XX_CodingSegments_ktsgh' table. You can move, or remove it, as needed.
            this.vF_GL0303XX_CodingSegments_ktsghTableAdapter.Fill(this.dataSet15.VF_GL0303XX_CodingSegments_ktsgh);
            // TODO: This line of code loads data into the 'dataSet15.VF_SY240300_EXT_termcsop' table. You can move, or remove it, as needed.
            this.vF_SY240300_EXT_termcsopTableAdapter.Fill(this.dataSet15.VF_SY240300_EXT_termcsop);
            // TODO: This line of code loads data into the 'dataSet151.VF_SC360300_StockBinNo' table. You can move, or remove it, as needed.
            this.vF_SC360300_StockBinNoTableAdapter.Fill(this.dataSet151.VF_SC360300_StockBinNo);
            // TODO: This line of code loads data into the 'dataSet15.VNB_SC330300_StockBatch' table. You can move, or remove it, as needed.
            this.vNB_SC330300_StockBatchTableAdapter.Fill(this.dataSet15.VNB_SC330300_StockBatch);
           
            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;

            if (honnan == "1")
            {
                SendKeys.Send("{tab}");
                SendKeys.Send("{tab}");
                SendKeys.Send("{tab}");
            }
            Torol();
        }
      
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "binNumberDataGridViewTextBoxColumn":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && comboBox4.Text.Trim() != "")
            {
                int IgFound = dolgKodokBindingSource.Find("Key1", comboBox4.Text.Trim());
                if (IgFound < 0)
                {
                    comboBox4.ResetText();
                    comboBox4.Select();
                }
                else
                {
                    label9.Text = dataSet15.Tables["DolgKodok"].Rows[IgFound]["TextDescription"].ToString().Trim();
                    comboBox3.Visible = true;
                    comboBox3.Select();
                    comboBox4.Enabled = false;
                }
            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox3.Text.Trim() != "")
            {
                int KolFound = vFGL0303XXCodingSegmentsktsghBindingSource.Find("Name2", comboBox3.Text.Trim());
                if (KolFound < 0)
                {
                    comboBox3.ResetText();
                    comboBox3.Select();
                }
                else
                {
                    KtsghKod = dataSet15.Tables["VF_GL0303XX_CodingSegments_ktsgh"].Rows[KolFound]["CostCentre"].ToString().Trim();
                    KtsgNev = dataSet15.Tables["VF_GL0303XX_CodingSegments_ktsgh"].Rows[KolFound]["Name2"].ToString().Trim();
                    this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
                    this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
                    textBox1.Visible = true;
                    textBox1.Select();
                    if (dataGridView3.RowCount>0)
                    this.dataGridView3.CurrentRow.Cells["Column5"].ReadOnly =true;
                    comboBox3.Enabled = false;
                    label11.Text = comboBox3.SelectedValue.ToString().Trim();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Konszig = "0";
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                int CikkFound = vNBSC330300StockBatchBindingSource.Find("StockItem", textBox1.Text.Trim());
                int KonszFound = VNB_SC010300_StockfileBbindingSource.Find("StockCode", textBox1.Text.Trim());

                if (KonszFound > 0 && dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[KonszFound]["UserDefined9"].ToString().Trim() == "50")
                {
                   DialogResult dr = MessageBox.Show("Kiadás konszig raktárból ?", "Figyelmeztetés", MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        if (dr == DialogResult.Yes)
                        {
                            label4.Text = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[KonszFound]["Description1"].ToString().Trim() + " ¤ " +
                                       dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[KonszFound]["Description2"].ToString().Trim() + " ¤ " +
                                        dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[KonszFound]["InternRem1"].ToString().Trim() + " ¤ " +
                                         dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[KonszFound]["InternRem2"].ToString().Trim();
                            label7.Text = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[KonszFound]["Description"].ToString().Trim();
                            KonyvKod = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[KonszFound]["AccountCode"].ToString().Trim();
                            Konszig = "1";
                            comboBox1.Visible = true;
                            comboBox1.Text = "NBKON";
                            textBox3.Visible = true;
                            textBox3.Select();
                            comboBox1.Enabled = false;
                            textBox1.Enabled = false;
                         }
                        else
                        {
                           if (CikkFound < 0)
                        {
                            textBox1.Clear();
                            textBox1.Select();
                        }
                        else
                        {
                            CikkKiadas();
                        }
                        }
                 }
                    else
                     {
                    if (CikkFound < 0)
                    {
                        textBox1.Clear();
                        textBox1.Select();
                    }
                    else
                    {
                        CikkKiadas();
                    }
                }
             }
            else
                textBox1.Select();
        }

      private void CikkKiadas()
        {
            int SorFound = VNB_SC010300_StockfileBbindingSource.Find("StockCode", textBox1.Text.Trim().ToUpper());
            label4.Text = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description1"].ToString().Trim() + " ¤ " +
                           dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description2"].ToString().Trim() + " ¤ " +
                            dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["InternRem1"].ToString().Trim() + " ¤ " +
                             dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["InternRem2"].ToString().Trim();
            label7.Text = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description"].ToString().Trim();
            KonyvKod = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["AccountCode"].ToString().Trim();
            this.vNB_SC330300_StockBatch1TableAdapter.Fill(this.dataSet152.VNB_SC330300_StockBatch1, textBox1.Text.Trim().ToUpper());
            Konszig = "0";
            comboBox1.Visible = true;
            comboBox1.Select();
            textBox1.Enabled = false;
            Kerescikk();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && comboBox1.Text.Trim() != "")
            {
                if (Konszig != "1")
                {
                    int SorFound2 = vNBSC330300StockBatch1BindingSource.Find("BinNumber", comboBox1.Text.Trim());
                    if (SorFound2 < 0)
                    {
                        comboBox1.ResetText();
                        comboBox1.Select();
                    }
                    else
                    {
                        BevMenny = Convert.ToDouble(dataSet152.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound2]["BalanceQty"].ToString().Trim());
                        int ismetlodo = 0;
                        foreach (DataGridViewRow row in dataGridView3.Rows)
                        {
                            if (textBox1.Text.Trim() == row.Cells[1].Value.ToString().Trim() && comboBox1.Text.Trim() == row.Cells[8].Value.ToString().Trim())
                            {
                                MessageBox.Show("EZ A CIKK ERRŐL A POLCRÓL MÁR KIADÁSRA FOG KERÜLNI !! HA MÉG SZERETNÉL KIADNI AKKOR MÓDOSÍTHATOD A MENNYISÉGET A TÁBLÁZATBAN !!",
                                    "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                ismetlodo = 1;
                            }
                        }
                            if (ismetlodo == 1)
                            {
                               KisTorol();
                            }
                            else
                            {
                                textBox3.Visible = true;
                                textBox3.Select();
                                comboBox1.Enabled = false;
                            }
                    }
                }
                else
                {
                    textBox3.Visible = true;
                    textBox3.Select();
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
                    if (Konszig != "1")
                    {
                        if (Convert.ToDouble(textBox3.Text) <= BevMenny && Convert.ToDouble(textBox3.Text) > 0)
                        {
                            comboBox5.Visible = true;
                            comboBox5.Select();
                            textBox3.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("A MENNYISÉG NEM LEHET NAGYOBB A BATCH-EN LÉVŐ MENNYISÉGTŐL, ÉS NEM LEHET 0 !!", "Figyelmeztetés", MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            textBox3.Clear();
                            textBox3.Select();
                        }
                    }
                    else
                    {
                        comboBox5.Visible = true;
                        comboBox5.Select();
                        textBox3.Enabled = false;
                    }
                }
            }

         private void button2_Click(object sender, EventArgs e)
        {
           Torol();
        }

        private void Torol()
        {
            textBox1.Clear();
            Konszig="0";
            label4.Text = "";
            label11.Text = "";
            comboBox1.ResetText();
            comboBox1.Visible = false;
            listBox1.Visible = false;
            groupBox1.Visible = false;
            textBox3.Clear();
            textBox3.Visible = false;
            textBox5.Clear();
            textBox5.Visible = true;
            label7.Text = "";
            label13.Text = "";
            textBox4.Clear();
            //comboBox2.ResetText();
            //comboBox2.Visible = false;
            comboBox3.ResetText();
            comboBox3.Visible = false;
            comboBox4.ResetText();
          //  comboBox4.Visible = false;
            comboBox5.ResetText();
            comboBox5.Visible = false;
            label9.Text = "";
            textBox2.Clear();
            textBox2.Visible = false;
          //  button1.Visible = false;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            //comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            textBox1.Visible = false;
            this.textBox5.Clear();
            this.textBox5.Enabled = true;
            textBox5.Select();
          //  comboBox4.Select();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dataGridView3.Rows.Add(dataGridView3.Rows.Count + 1, textBox1.Text.Trim().ToUpper(), label4.Text.Trim(), label7.Text.Trim(),
                                        textBox3.Text.Replace(",", ".").Trim(), textBox5.Text.Trim(), KtsghKod, KtsgNev, comboBox1.Text.Trim(),
                                    label13.Text.Trim(),textBox2.Text.Trim(), Konszig.Trim(),KonyvKod.Trim(),
                                     BevMenny.ToString().Trim(),Konszig.ToString().Trim());
                KisTorol();
                //button1.Visible = true;
                //button1.Select();
            }
        }
        private void KisTorol()
        {
            textBox1.Clear();
            textBox1.Visible = false;
            label4.Text = "";
            comboBox1.ResetText();
            comboBox1.Visible = false;
            listBox1.Visible = false;
            textBox3.Clear();
            textBox3.Visible = false;
            label7.Text = "";
            comboBox5.ResetText();
            comboBox5.Visible = false;
            label9.Text = "";
            textBox2.Clear();
            textBox2.Visible = false;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            comboBox5.Enabled = true;
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
            this.dataGridView3.CurrentRow.Cells["Column5"].ReadOnly = false;
            comboBox3.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            string datum = DateTime.Now.ToString("yyyy-MM-dd");
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if (Convert.ToDouble(dataGridView3.Rows[i].Cells["Column5"].Value.ToString().Trim()) > 0)
                {
                    mySqlCommand.CommandText = "execute NBFelhasznal @FelhasznID OUTPUT,@Cikkszam,@Raktar,@Polc,@Mennyiseg,@Terület,@KtsghKod,@KtsghNev,@Igenylo,@Kiadta,@Megjegyzes,@GepSzerszam,@Statusz";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@FelhasznID", SqlDbType.Int);
                    mySqlCommand.Parameters["@FelhasznID"].Direction = ParameterDirection.Output;
                    mySqlCommand.Parameters.Add("@Cikkszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Cikkszam"].Value = dataGridView3.Rows[i].Cells["Column2"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Raktar", SqlDbType.Char);
                    mySqlCommand.Parameters["@Raktar"].Value = "50";
                    mySqlCommand.Parameters.Add("@Polc", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Polc"].Value = dataGridView3.Rows[i].Cells["Column11"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Mennyiseg", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@Mennyiseg"].Value = Convert.ToDouble(dataGridView3.Rows[i].Cells["Column5"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Terület", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Terület"].Value = "NonBom";//comboBox2.Text.Trim();
                    mySqlCommand.Parameters.Add("@KtsghKod", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@KtsghKod"].Value = dataGridView3.Rows[i].Cells["Column7"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@KtsghNev", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@KtsghNev"].Value = dataGridView3.Rows[i].Cells["Column8"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Igenylo", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Igenylo"].Value = dataGridView3.Rows[i].Cells["Column6"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Kiadta", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Kiadta"].Value = pecset.Trim();
                    mySqlCommand.Parameters.Add("@Megjegyzes", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Megjegyzes"].Value = dataGridView3.Rows[i].Cells["Column10"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@GepSzerszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@GepSzerszam"].Value = dataGridView3.Rows[i].Cells["Column9"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Statusz", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Statusz"].Value = dataGridView3.Rows[i].Cells["Column12"].Value.ToString().Trim();
                    int numberOfRows = mySqlCommand.ExecuteNonQuery();
                    FelhasznID = mySqlCommand.Parameters["@FelhasznID"].Value.ToString();
                    //string cost = comboBox3.ValueMember.ToString().Trim();   
                    if (dataGridView3.Rows[i].Cells["Column12"].Value.ToString().Trim() == "0")
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml("<?xml version='1.0' ?>" +
                 "<msg:Msg xsi:schemaLocation='http://Epicor.com/Message/2.0 http://scshost/schemas/epicor/ScalaMessage.xsd' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:msg='http://Epicor.com/Message/2.0'>" +
                   "<msg:Hdr>" +
                   "<msg:Sender>" +
                       "<msg:Name>Hull</msg:Name>" +
                     // "<msg:Subname></msg:Subname>"+
                     "</msg:Sender>" +
                   "</msg:Hdr>" +
                  "<msg:Body>" +
                   "<msg:Req msg-type='Stock Transaction' action='Process' >" +
                     "<msg:Dta>" +
                      "<dta:StockTransaction xsi:schemaLocation='http://www.scala.net/StockTransaction/1.1 http://scshost/schemas/Scala/1.1/StockTransaction.xsd' xmlns:dta='http://www.scala.net/StockTransaction/1.1'>" +
                     "<dta:Issue>" +
                       "<dta:TransDate>" + datum + "</dta:TransDate>" +
                       "<dta:Qty>" + Convert.ToDouble(dataGridView3.Rows[i].Cells["Column5"].Value.ToString().Trim()) + "</dta:Qty>" +
                       "<dta:StockCode>" + dataGridView3.Rows[i].Cells["Column2"].Value.ToString().Trim() + "</dta:StockCode>" +
                       "<dta:WhCode>50</dta:WhCode>" +
                       "<dta:BinCode>" + dataGridView3.Rows[i].Cells["Column11"].Value.ToString().Trim() + "</dta:BinCode>" +
                       "<dta:Ref>" + FelhasznID.Trim() + "</dta:Ref>" +
                       "<dta:AccCode>" + dataGridView3.Rows[i].Cells["Column13"].Value.ToString().Trim() + "</dta:AccCode>" +
                        "<dta:AccDims>" +
                         "<dta:AccDim id='1' >" + dataGridView3.Rows[i].Cells["Column7"].Value.ToString().Trim() + "</dta:AccDim>" +
                       "</dta:AccDims>" +
                   "</dta:Issue>" +
                  "</dta:StockTransaction>" +
                 "</msg:Dta>" +
                 "</msg:Req>" +
                 "</msg:Body>" +
                 "</msg:Msg>");
                        // Save the document to a file.
                        string f_nev = "NBKi" + dataGridView3.Rows[i].Cells["Column1"].Value.ToString().Trim() + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
                       // doc.Save(f_nev);
                        doc.Save(@"\\10.0.0.11\inputxml\" + f_nev);
                    }
                }
                }
            connection.Close();
            Thread.Sleep(1000);
            dataGridView3.Rows.Clear();
            Torol();
        }

    private void comboBox5_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
        int GepFound = mTGeplistaBindingSource.Find("Gepek", comboBox5.Text.Trim());
        if (GepFound < 0 && comboBox5.Text.Trim() != "")
        {
            comboBox5.ResetText();
            comboBox5.Select();
        }
        else
        {
            if (comboBox5.Text.Trim() != "")
                label13.Text = dataSet15.Tables["MTGeplista"].Rows[GepFound]["FusetechKod"].ToString().Trim();
            else
                label13.Text = "";
            textBox2.Visible = true;
            textBox2.Select();
            comboBox5.Enabled = false;
        }
    }
}

     private void comboBox4_MouseDown(object sender, MouseEventArgs e)
     {
    if (e.Button == MouseButtons.Right)
    {
        listBox1.Visible = true;
        listBox1.Select();
    }
      }

     private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
     {
    if ((int)e.KeyChar == (int)Keys.Enter)
    {
        comboBox4.Select();
        listBox1.Visible = false;
    }
      }

    private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
     {
        comboBox4.Select();
        listBox1.Visible = false;
     }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
        string wkeres = " ";

        string seekValue = this.textBox4.Text;
        if (seekValue != wkeres)
        {
            if (!string.IsNullOrEmpty(seekValue))
            {
                mTGeplista1BindingSource.Filter = "Gepek like '%" + seekValue.Trim() + "%'";
            }
            else
            {
                try
                {
                  mTGeplista1BindingSource.Filter = "";
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            wkeres = seekValue;
        }
    }

    private void comboBox5_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
                groupBox1.BringToFront();
                groupBox1.Visible = true;
                textBox4.Select();
        }
    }

      private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                comboBox5.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
                comboBox5.Select();
                groupBox1.Visible = false;
            }
        }

      
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox5.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            comboBox5.Select();
            groupBox1.Visible = false;
        }

   private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        Alapinformaciok();
            Konszig = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            Torol();
        }

        private void Alapinformaciok()
    {
       textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
       int SorFound = VNB_SC010300_StockfileBbindingSource.Find("StockCode", dataGridView1.CurrentRow.Cells[0].Value.ToString());
       label4.Text = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description1"].ToString().Trim() + " ¤ " +
                      dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description2"].ToString().Trim() + " ¤ " +
                       dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["InternRem1"].ToString().Trim() + " ¤ " +
                        dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["InternRem2"].ToString().Trim();
       label7.Text = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description"].ToString().Trim();
       KonyvKod = dataSet15.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["AccountCode"].ToString().Trim();
       this.vNB_SC330300_StockBatch1TableAdapter.Fill(this.dataSet152.VNB_SC330300_StockBatch1, textBox1.Text.Trim());
       this.dataGridView1.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
       this.dataGridView1.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
       comboBox1.Visible = true;
       comboBox1.Select();
       textBox1.Enabled = false;
    }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.Handled = true;
            Alapinformaciok();
        }
    }

     

        private void Kerescikk()
        {
            string searchValue = textBox1.Text.Trim();
         dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                          row.Selected = true;
                     
                        dataGridView1.CurrentCell = dataGridView1[0, row.Index];
                        dataGridView1.FirstDisplayedScrollingRowIndex =row.Index;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
               MessageBox.Show(exc.Message);
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            this.Vizsgal(e);
        }

        private void Vizsgal(KeyEventArgs e)
        {
            try
            {
                this.vizsgal += e.KeyCode.ToString();
                if (this.vizsgal.Substring(0, 4) == "Menu")
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        if (this.textBox5.TextLength > 1 && this.textBox5.TextLength < 11)
                        {
                            int index = this.dolgKodokBindingSource.Find("Key1", (object)this.textBox5.Text.Trim());
                            if (index < 0)
                            {
                                this.textBox5.Clear();
                                this.textBox5.Select();
                            }
                            else
                            {
                                this.label9.Text = this.dataSet15.Tables["DolgKodok"].Rows[index]["TextDescription"].ToString().Trim();
                                this.comboBox3.Visible = true;
                                this.comboBox3.Select();
                                this.textBox5.Enabled = false;
                            }
                        }
                        else
                            this.textBox5.Clear();
                    }
                }
                else
                    this.textBox5.Clear();
            }
            catch
            {
                this.textBox5.Clear();
            }
            if (!(this.textBox5.Text == ""))
                return;
            this.vizsgal = "";
            this.textBox5.Clear();
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView3.CurrentRow.Cells["Column15"].Value.ToString().Trim() == "1")
                this.dataGridView3.CurrentRow.Cells["Column5"].ReadOnly = true;
        }
        private void dataGridView3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);

            //if (dataGridView3.CurrentCell.ColumnIndex == 4) //Desired Column
            //{
            //    TextBox tb = e.Control as TextBox;
            //    if (tb != null)
            //    {
            //        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //    }
            //}
            if (this.dataGridView3.CurrentCell.ColumnIndex != 4)
                return;
            TextBox control = e.Control as TextBox;
            if (control != null)
                control.KeyPress += new KeyPressEventHandler(this.Column1_KeyPress);
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView3.CurrentRow.Cells["Column4"].Value.ToString().Trim() == "db")
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
            this.Elozo = Convert.ToDouble(this.dataGridView3.CurrentRow.Cells["Column5"].Value.ToString().Trim());
        }
        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView3.CurrentRow.Cells["Column15"].Value.ToString().Trim() != "1" &&
               Convert.ToDouble(this.dataGridView3.CurrentRow.Cells["Column5"].Value.ToString().Trim()) > Convert.ToDouble(this.dataGridView3.CurrentRow.Cells["Column14"].Value.ToString().Trim()))
            {
                int num = (int)MessageBox.Show("Kiadott mennyiség nagyobb a készleten lévő mennyiségnél !!");
                this.dataGridView3.CurrentRow.Cells["Column5"].Value = (object)this.Elozo.ToString().Trim();
                this.dataGridView3.CurrentRow.Cells["Column5"].Selected = true;
            }
        }

    }
}
