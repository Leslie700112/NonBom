using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Xml;
using System.Threading;

namespace NonBom
{
    public partial class Form33 : Form
    {
        private int SorFound;
        private string KonyvKod,KtsghKod;
        public Form33()
        {
            InitializeComponent();
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet33.VF_GL0303XX_CodingSegments_ktsgh' table. You can move, or remove it, as needed.
            this.vF_GL0303XX_CodingSegments_ktsghTableAdapter.Fill(this.dataSet33.VF_GL0303XX_CodingSegments_ktsgh);
            // TODO: This line of code loads data into the 'dataSet33.VNB_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vNB_SC010300_StockfileTableAdapter.Fill(this.dataSet33.VNB_SC010300_Stockfile);
            // TODO: This line of code loads data into the 'dataSet331.VF_SC360300_StockBinNo' table. You can move, or remove it, as needed.
            this.vF_SC360300_StockBinNoTableAdapter.Fill(this.dataSet331.VF_SC360300_StockBinNo);
            // TODO: This line of code loads data into the 'dataSet331.DolgKodok' table. You can move, or remove it, as needed.
            this.dolgKodokTableAdapter.Fill(this.dataSet331.DolgKodok);
            // TODO: This line of code loads data into the 'dataSet33.NBCikkAdatok' table. You can move, or remove it, as needed.
            this.nBCikkAdatokTableAdapter.Fill(this.dataSet33.NBCikkAdatok);

            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;

            SendKeys.Send("{tab}");
            SendKeys.Send("{tab}");
            SendKeys.Send("{tab}");
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

        private void Torol()
        {
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            textBox1.Clear();
            label4.Text = "";
            label11.Text = "";
            comboBox1.ResetText();
            comboBox1.Visible = false;
            textBox3.Clear();
            textBox3.Visible = false;
            label7.Text = "";
            comboBox4.ResetText();
            comboBox4.Visible = false;
            label9.Text = "";
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            textBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox3.ResetText();
            comboBox3.Visible = false;
            comboBox3.Enabled = true;
            button1.Visible = false;
            textBox1.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                int KonszFound = nBCikkAdatokBindingSource.Find("StockCode", textBox1.Text.Trim());  

                if (KonszFound > 0)
                {
                    SorFound = VNB_SC010300_StockfilebindingSource.Find("StockCode", textBox1.Text.Trim().ToUpper());
                    CikkKiadas();
                }
                else
                    textBox1.Select();
            }
        }

        private void CikkKiadas()
        {
           
            label4.Text = dataSet33.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description1"].ToString().Trim() + " ¤ " +
                           dataSet33.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description2"].ToString().Trim() + " ¤ " +
                            dataSet33.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["InternRem1"].ToString().Trim() + " ¤ " +
                             dataSet33.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["InternRem2"].ToString().Trim();
            label7.Text = dataSet33.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["Description"].ToString().Trim();
            KonyvKod = dataSet33.Tables["VNB_SC010300_Stockfile"].Rows[SorFound]["AccountCode"].ToString().Trim();
            this.dataGridView1.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            comboBox1.Visible = true;
            comboBox1.Select();
            textBox1.Enabled = false;
            //Kerescikk();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SorFound = VNB_SC010300_StockfilebindingSource.Find("StockCode", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            CikkKiadas();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                SorFound = VNB_SC010300_StockfilebindingSource.Find("StockCode", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                CikkKiadas();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Torol();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox1.Text.Trim() != "")
            {

                int SorFound2 = vFSC360300StockBinNoBindingSource.Find("BinNumber", comboBox1.Text.Trim());
                if (SorFound2 < 0)
                {
                    comboBox1.ResetText();
                    comboBox1.Select();
                }
                else
                {
                    comboBox4.Visible = true;
                    comboBox4.Select();
                    comboBox1.Enabled = false;
                }
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
                    label9.Text = dataSet331.Tables["DolgKodok"].Rows[IgFound]["TextDescription"].ToString().Trim();
                    comboBox3.Visible = true;
                    comboBox3.Select();
                    comboBox4.Enabled = false;
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
                button1.Visible = true;
                button1.Select();
                textBox3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datum = DateTime.Now.ToString("yyyy-MM-dd");
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
           "<dta:Qty>" + Convert.ToDouble(textBox3.Text.Trim())*-1 + "</dta:Qty>" +
           "<dta:StockCode>" + textBox1.Text.Trim().ToUpper() + "</dta:StockCode>" +
           "<dta:WhCode>50</dta:WhCode>" +
           "<dta:BinCode>" + comboBox1.Text.Trim().ToUpper() + "</dta:BinCode>" +
           "<dta:Ref>" + comboBox4.Text.Trim() + "</dta:Ref>" +
           "<dta:AccCode>" +  KonyvKod.Trim() + "</dta:AccCode>" +
            "<dta:AccDims>" +
             "<dta:AccDim id='1' >" +KtsghKod.Trim() + "</dta:AccDim>" +
           "</dta:AccDims>" +
       "</dta:Issue>" +
      "</dta:StockTransaction>" +
     "</msg:Dta>" +
     "</msg:Req>" +
     "</msg:Body>" +
     "</msg:Msg>");
            // Save the document to a file.
            string f_nev = "NBVi" + textBox1.Text.Trim().ToUpper() + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
            // doc.Save(f_nev);
            doc.Save(@"\\10.0.0.11\inputxml\" + f_nev);
            Thread.Sleep(1000);
            Form39 form39 = new Form39();
            form39.ShowDialog();
            Torol();
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
                    KtsghKod = dataSet33.Tables["VF_GL0303XX_CodingSegments_ktsgh"].Rows[KolFound]["CostCentre"].ToString().Trim();
                    textBox3.Visible = true;
                    textBox3.Select();
                    comboBox3.Enabled = false;
                    label11.Text = comboBox3.SelectedValue.ToString().Trim();
                }
            }
        }
    }
}
