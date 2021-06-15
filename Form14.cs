using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using DgvFilterPopup;

namespace NonBom
{
    public partial class Form14 : Form
    {
        private double BevMenny;
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet14.VNB_SC330300_StockBatch1' table. You can move, or remove it, as needed.
            this.vNB_SC330300_StockBatch1TableAdapter.Fill(this.dataSet14.VNB_SC330300_StockBatch1);
           // TODO: This line of code loads data into the 'dataSet14.VF_SC360300_StockBinNo' table. You can move, or remove it, as needed.
            this.vF_SC360300_StockBinNoTableAdapter.Fill(this.dataSet14.VF_SC360300_StockBinNo);
            // TODO: This line of code loads data into the 'dataSet14.VNB_SC330300_StockBatch' table. You can move, or remove it, as needed.
            this.vNB_SC330300_StockBatchTableAdapter.Fill(this.dataSet14.VNB_SC330300_StockBatch);
          
            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);

            fm.DataGridView = dataGridView1;
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
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                  int CikkFound =vNBSC330300StockBatchBindingSource.Find("StockItem",textBox1.Text.Trim());
                  if (CikkFound < 0)
                  {
                      textBox1.Clear();
                      textBox1.Select();
                  }
                  else
                  {
                      int SorFound =VNB_SC330300_StockBatch1BindingSource.Find("StockItem", textBox1.Text.Trim());
                      label4.Text = dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["Description1"].ToString().Trim() + " ¤ " +
                          dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["Description2"].ToString().Trim() + " ¤ " +
                           dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["InternRem1"].ToString().Trim() + " ¤ " +
                            dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["InternRem2"].ToString().Trim();
                      label6.Text = dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["BinNumber"].ToString().Trim();
                      label7.Text = dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["Description"].ToString().Trim();
                      textBox3.Text = dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["BalanceQty"].ToString().Trim();
                      BevMenny = Convert.ToDouble(dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["BalanceQty"].ToString().Trim());
                      comboBox1.Select();
                  }
            }
            else
                textBox1.Select();
        }
     
        private void Torol()
        {
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            label4.Text = "";
            label6.Text = "";
            label7.Text = "";
            textBox1.Clear();
            textBox3.Clear();
            button1.Visible = false;
            textBox1.Enabled = true;
            textBox1.Select();
        }
    
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox1.Text.Trim() != "")
            {
                int SorFound = vFSC360300StockBinNoBindingSource.Find("BinNumber", comboBox1.Text.Trim());
                if (SorFound < 0)
                {
                    comboBox1.ResetText();
                    comboBox1.Select();
                }
                else
                {
                    textBox3.Select();
                }
            }
            else
                comboBox1.Select();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Escape)
            {
                dataGridView1.Select();
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (Convert.ToDouble(textBox3.Text) <= BevMenny && Convert.ToDouble(textBox3.Text)>0 )
                    {
                        button1.Visible = true;
                    //    button1.BackColor = Color.Orange;
                        button1.Select();
                    }
                    else
                    {
                        MessageBox.Show("A MENNYISÉG NEM LEHET NAGYOBB A BATCH-EN LÉVŐ MENNYISÉGTŐL, ÉS NEM LEHET 0 !!", "Figyelmeztetés", MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        textBox3.Text = BevMenny.ToString();
                        textBox3.SelectAll();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XMLKeszit();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                XMLKeszit();
            }
        }

        private void XMLKeszit()
        {
            string datum = DateTime.Now.ToString("yyyy-MM-dd");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<msg:Msg xsi:schemaLocation='http://Epicor.com/Message/2.0 http://scshost/schemas/epicor/ScalaMessage.xsd' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:msg='http://Epicor.com/Message/2.0'>" +
     "<msg:Hdr>" +
     "<msg:Sender>" +
     "<msg:Name>03</msg:Name>" +
     "<msg:Subname>{0}</msg:Subname>" +
     "</msg:Sender>" +
     "</msg:Hdr>" +
     "<msg:Body>" +
     "<msg:Req msg-type='Stock Transaction' action='Process'>" +
     "<msg:Dta>" +
     "<dta:StockTransaction xsi:schemaLocation='http://www.scala.net/StockTransaction/1.1 http://scshost/schemas/Scala/1.1/StockTransaction.xsd' xmlns:msg='http://Epicor.com/InternalMessage/1.1' xmlns:dta='http://www.scala.net/StockTransaction/1.1'>" +
     "<dta:Movement>" +
     "<dta:TransDate>" + datum + "</dta:TransDate>" +
     "<dta:Qty>" +Convert.ToDouble(textBox3.Text.Trim()) + "</dta:Qty>" +
     "<dta:StockCode>" + textBox1.Text.Trim().ToUpper() + "</dta:StockCode>" +
     "<dta:WhCodeFrom>03</dta:WhCodeFrom>" +
     "<dta:BinCodeFrom>"+label6.Text.Trim()+"</dta:BinCodeFrom>" +
     "<dta:WhCodeTo>50</dta:WhCodeTo>" +
     "<dta:BinCodeTo>" + comboBox1.Text.Trim().ToUpper() + "</dta:BinCodeTo>" +
      "<dta:Ref>NONBOM</dta:Ref>" +
                //"<dta:OrdNum>" + MRend.Trim() + "</dta:OrdNum>" +
     "<dta:Note>TM</dta:Note>" +
        "</dta:Movement>" +
        "</dta:StockTransaction>" +
        "</msg:Dta>" +
        "</msg:Req>" +
     "</msg:Body>" +
     "</msg:Msg>");
            // Save the document to a file.
            string f_nev = "NBM" + textBox1.Text.Trim() + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
          //   doc.Save(f_nev);
            doc.Save(@"\\10.0.0.11\inputxml\" + f_nev);
            this.vNB_SC330300_StockBatch1TableAdapter.Fill(this.dataSet14.VNB_SC330300_StockBatch1);
            this.vNB_SC330300_StockBatchTableAdapter.Fill(this.dataSet14.VNB_SC330300_StockBatch);
            Torol();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Alapinformaciok();
        }
   
        private void Alapinformaciok()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            int SorFound = VNB_SC330300_StockBatch1BindingSource.Find("StockItem", textBox1.Text.Trim());
            label4.Text = dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["Description1"].ToString().Trim() + " ¤ " +
                dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["Description2"].ToString().Trim() + " ¤ " +
                 dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["InternRem1"].ToString().Trim() + " ¤ " +
                  dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["InternRem2"].ToString().Trim();
            label6.Text = dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["BinNumber"].ToString().Trim();
            label7.Text = dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["Description"].ToString().Trim();
            textBox3.Text = dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["BalanceQty"].ToString().Trim();
            BevMenny = Convert.ToDouble(dataSet14.Tables["VNB_SC330300_StockBatch1"].Rows[SorFound]["BalanceQty"].ToString().Trim());
            comboBox1.Select();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Torol();
        }




    }
}
