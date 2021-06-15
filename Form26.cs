using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.IO;
using System.Xml;

namespace NonBom
{
    public partial class Form26 : Form
    {
        private int karx, kary,Rendszam;
        private Point MouseDownLocation;

        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet261.VNB_PC030300_POLineFile' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet26.VNB_POKonszig' table. You can move, or remove it, as needed.
            this.vNB_POKonszigTableAdapter.Fill(this.dataSet26.VNB_POKonszig);
            Torol();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                karx = e.X;
                kary = e.Y;
                DataGridView.HitTestInfo kat = dataGridView1.HitTest(karx, kary);
                int AktSor = kat.RowIndex;
                if (AktSor >= 0)
                {
                    this.vNB_PC030300_POLineFileTableAdapter.Fill(this.dataSet261.VNB_PC030300_POLineFile, dataGridView1.Rows[kat.RowIndex].Cells["purchaOrdNoDataGridViewTextBoxColumn"].Value.ToString().Trim());
                    this.nBFelhasznalasTableAdapter.Fill(this.dataSet262.NBFelhasznalas, Convert.ToInt32(dataGridView1.Rows[kat.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value));
                    dataGridView2.Visible = true;
                    dataGridView3.Visible = true;
                }
            }
            else
            {
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
            }
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void dataGridView2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                dataGridView2.Left = e.X + dataGridView2.Left - MouseDownLocation.X;
                dataGridView2.Top = e.Y + dataGridView2.Top - MouseDownLocation.Y;
            }
        }

        private void dataGridView3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                dataGridView3.Left = e.X + dataGridView3.Left - MouseDownLocation.X;
                dataGridView3.Top = e.Y + dataGridView3.Top - MouseDownLocation.Y;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           Torol();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                int RendFound = vNBPOKonszigBindingSource.Find("PurchaOrdNo", textBox1.Text.Trim());
                if (RendFound < 0)
                {
                    textBox1.Clear();
                    textBox1.Select();
                }
                else
                {
                    Rendszam=Convert.ToInt32(dataSet26.Tables["VNB_POKonszig"].Rows[RendFound]["RendelesSzam"].ToString().Trim());
                    this.vNB_PC030300_POLineFileTableAdapter.Fill(this.dataSet261.VNB_PC030300_POLineFile, textBox1.Text.Trim());
                    this.nBFelhasznalasTableAdapter.Fill(this.dataSet262.NBFelhasznalas,Rendszam);
                    dataGridView2.Visible = true;
                    dataGridView3.Visible = true;
                    textBox1.Enabled = false;
                    textBox2.Visible = true;
                    textBox2.Select();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter && textBox2.Text != "")
            {
                textBox2.Enabled = false;
                dateTimePicker1.Visible = true;
                dateTimePicker1.Select();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Enabled = false;
                button2.Visible = true;
                button2.Select();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Rendszam=Convert.ToInt32(dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString().Trim());
            this.vNB_PC030300_POLineFileTableAdapter.Fill(this.dataSet261.VNB_PC030300_POLineFile, textBox1.Text.Trim());
            this.nBFelhasznalasTableAdapter.Fill(this.dataSet262.NBFelhasznalas, Rendszam);
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;
            textBox1.Enabled = false;
            textBox2.Visible = true;
            textBox2.Select();
        }

        private void Torol()
        {
            dateTimePicker1.Visible = false;
            dateTimePicker1.Value = DateTime.Today;
            textBox2.Visible = false;
            button2.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeirXML();
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                mySqlCommand.CommandText = "INSERT INTO NBBeszerzesbolBevet (BeszRendSzam,Sorszam,Cikkszam,Menny,Bevetelezte,BevDatum,Iktatoszam,SzallitoLevel)" +
              "VALUES (@RendSzam,@Sor, @StockCode,@Menny,@bevetelezo,CURRENT_TIMESTAMP,@Iktatoszam,@Szalllevel)";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@RendSzam", SqlDbType.Char);
                mySqlCommand.Parameters["@RendSzam"].Value = dataGridView2.Rows[i].Cells["purchaOrdNoDataGridViewTextBoxColumn1"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@Sor", SqlDbType.Char);
                mySqlCommand.Parameters["@Sor"].Value = dataGridView2.Rows[i].Cells["lineNumberDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@StockCode", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@StockCode"].Value = dataGridView2.Rows[i].Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@Menny", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Menny"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["pCQtyOrderedDataGridViewTextBoxColumn"].Value.ToString().Trim());
                mySqlCommand.Parameters.Add("@bevetelezo", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@bevetelezo"].Value = "KON";
                mySqlCommand.Parameters.Add("@Iktatoszam", SqlDbType.Int);
                mySqlCommand.Parameters["@Iktatoszam"].Value = 0;
                mySqlCommand.Parameters.Add("@Szalllevel", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Szalllevel"].Value = textBox2.Text.Trim();
                mySqlCommand.Parameters.Add("@BevIdo", SqlDbType.DateTime);
                mySqlCommand.Parameters["@BevIdo"].Value =Convert.ToDateTime(dateTimePicker1.Value);
                mySqlCommand.ExecuteNonQuery();
            }
            connection.Close();
            Kivet();
            Torol();
        }
        private void BeirXML()
        {
            string f_nev = "NBKON" + textBox1.Text.Trim()+ DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
              StreamWriter doc = new StreamWriter(@"\\10.0.0.11\inputxml\" + f_nev);
          //  StreamWriter doc = new StreamWriter(f_nev);
            string datu =dateTimePicker1.Value.ToString("yyyy-MM-dd");
            // XmlDocument doc = new XmlDocument();
            doc.Write("<?xml version='1.0' encoding='UTF-8'?>\n" +
"<msg:Msg xsi:schemaLocation='http://Epicor.com/Message/2.0 http://scshost/schemas/epicor/ScalaMessage.xsd' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:msg='http://Epicor.com/Message/2.0'>\n" +
   "<msg:Hdr>\n" +
        "<msg:Sender>\n" +
            "<msg:Name>TF</msg:Name>\n" +
        //   "<msg:Subname></msg:Subname>"+
        "</msg:Sender>\n" +
    "</msg:Hdr>\n" +
    "<msg:Body>\n" +
        "<msg:Req msg-type='Goods Receive Note' action='Process'>\n" +
         " <msg:Dta>\n" +
                "<dta:PurchaseOrderDelivery xsi:schemaLocation='http://www.scala.net/PurchaseOrderDelivery/1.1 http://scshost/schemas/Scala/1.1/PurchaseOrderDelivery.xsd' xmlns:msg='http://Epicor.com/InternalMessage/1.1' xmlns:dta='http://www.scala.net/PurchaseOrderDelivery/1.1'>\n" +
                   "<dta:OrderHeader>\n" +
                        "<dta:OrdNum>" + textBox1.Text + "</dta:OrdNum>\n" +
                        "<dta:DelivNoteNum>" + textBox2.Text.Trim() + "</dta:DelivNoteNum>\n" +
                    //           "<dta:Note>TF</dta:Note>" +
                    "</dta:OrderHeader>\n" +
                    "<dta:OrderLineList>\n");
            for (int y = 0; y < dataGridView2.RowCount; y++)
            {
                doc.Write("<dta:OrderLine>\n" +
    "<dta:LineNum>" + dataGridView2.Rows[y].Cells["lineNumberDataGridViewTextBoxColumn"].Value.ToString().Trim() + "</dta:LineNum>\n" +
    "<dta:StockCode>" + dataGridView2.Rows[y].Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString().Trim() + "</dta:StockCode>\n" +
    "<dta:DelivDateAct>" + datu + "</dta:DelivDateAct>\n" +
    "<dta:DelivLineList>\n" +
        "<dta:DelivLine>\n" +
            "<dta:BinCode>NBKON</dta:BinCode>\n" +
            "<dta:QtyDeliv>" + Convert.ToDecimal(dataGridView2.Rows[y].Cells["pCQtyOrderedDataGridViewTextBoxColumn"].Value) + "</dta:QtyDeliv>\n" +
           "<dta:ExpiryDate>" + Convert.ToDateTime("9999-12-31").ToString("yyyy-MM-dd") + "</dta:ExpiryDate>\n" +
        "</dta:DelivLine>\n" +
    "</dta:DelivLineList>\n" +
"</dta:OrderLine>\n");
            }
                doc.Write("</dta:OrderLineList>\n" +
                "</dta:PurchaseOrderDelivery>\n" +
            "</msg:Dta>\n" +
        "</msg:Req>\n" +
    "</msg:Body>\n" +
"</msg:Msg>\n");
                doc.Close();
        }

        private void Kivet()
        {
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();

            mySqlCommand.CommandText = "UPDATE NBFelhasznalas SET Statusz='3' where AnyagigenyloID=@Sor";
            mySqlCommand.Parameters.Clear();
            mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
            mySqlCommand.Parameters["@Sor"].Value = Rendszam;
            mySqlCommand.ExecuteNonQuery();
            connection.Close();
            string datum = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            for (int j = 0; j < dataGridView3.RowCount; j++)
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
                     "<dta:Qty>" + Convert.ToDecimal(dataGridView3.Rows[j].Cells["mennyisegDataGridViewTextBoxColumn"].Value.ToString().Trim()) + "</dta:Qty>" +
                     "<dta:StockCode>" + dataGridView3.Rows[j].Cells["cikkszamDataGridViewTextBoxColumn"].Value.ToString().Trim() + "</dta:StockCode>" +
                     "<dta:WhCode>50</dta:WhCode>" +
                     "<dta:BinCode>" + dataGridView3.Rows[j].Cells["polcDataGridViewTextBoxColumn"].Value.ToString().Trim() + "</dta:BinCode>" +
                     "<dta:Ref>KON</dta:Ref>" +
                     "<dta:AccCode>" + dataGridView3.Rows[j].Cells["AccountCode"].Value.ToString().Trim() + "</dta:AccCode>" +
                     "<dta:AccDims>" +
                     "<dta:AccDim id='1' >" + dataGridView3.Rows[j].Cells["ktsghKodDataGridViewTextBoxColumn"].Value.ToString().Trim() + "</dta:AccDim>" +
                     "</dta:AccDims>" +
                     "</dta:Issue>" +
                     "</dta:StockTransaction>" +
                     "</msg:Dta>" +
                     "</msg:Req>" +
                     "</msg:Body>" +
                     "</msg:Msg>");
                     // Save the document to a file.
                      string f_nev = "NBKoKi" + dataGridView3.Rows[j].Cells["bizonylatSzamDataGridViewTextBoxColumn"].Value.ToString().Trim() + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
                 //    doc.Save(f_nev);
                   doc.Save(@"\\10.0.0.11\inputxml\" + f_nev);
                
            }
        }

       
    }
}
