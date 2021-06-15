using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace NonBom
{
    public partial class Form12 : Form
    {
        public string pecset;
        private string Lejar, Lejardatum;
        private double BevMenny, BevMenny2;
        private int Iktsz;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet12.SzallitoLevelek' table. You can move, or remove it, as needed.
            this.szallitoLevelekTableAdapter.Fill(this.dataSet12.SzallitoLevelek);
            // TODO: This line of code loads data into the 'dataSet12.VNB_PC030300_POLineFile' table. You can move, or remove it, as needed.
            this.vNB_PC030300_POLineFileTableAdapter.Fill(this.dataSet12.VNB_PC030300_POLineFile);
            textBox1.Select();
            label1.Text = "";
            label4.Text = "";
            label13.Text = "";
            label7.Text = DateTime.Today.ToString("d");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rkeres = " ";
            string cikkValue = this.textBox1.Text;
            if (cikkValue != rkeres)
            {
                if (!string.IsNullOrEmpty(cikkValue))
                {
                  vNBPC030300POLineFileBindingSource.Filter = "Kereso2 like '%" + cikkValue + "%'";
                }
                else
                {

                    try
                    {
                      vNBPC030300POLineFileBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                rkeres = cikkValue;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string ckeres = " ";
            string cikkValue = this.textBox4.Text;
            if (cikkValue != ckeres)
            {
                if (!string.IsNullOrEmpty(cikkValue))
                {
                  vNBPC030300POLineFileBindingSource.Filter = "Kereso like '%" + cikkValue + "%'";
                }
                else
                {

                    try
                    {
                       vNBPC030300POLineFileBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                ckeres = cikkValue;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["userDefined8DataGridViewTextBoxColumn"].Value.ToString().Trim() == "1")
                this.dataGridView1.Rows[e.RowIndex].Cells["stockCodeDataGridViewTextBoxColumn"].Style.BackColor = Color.Crimson;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cikkinformaciok();
        }

        private void cikkinformaciok()
        {
            label1.Text = dataGridView1.CurrentRow.Cells["purchaOrdNoDataGridViewTextBoxColumn"].Value.ToString() + " ¤ " +
                              dataGridView1.CurrentRow.Cells["suppCodBuyerDataGridViewTextBoxColumn"].Value.ToString() + " ¤ " + dataGridView1.CurrentRow.Cells["supplierNameDataGridViewTextBoxColumn"].Value.ToString();
            label13.Text = dataGridView1.CurrentRow.Cells["lineNumberDataGridViewTextBoxColumn"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString().Trim() + " ¤ " +
                                  dataGridView1.CurrentRow.Cells["descriptLine1DataGridViewTextBoxColumn"].Value.ToString().Trim() + " ¤ " +
                                  dataGridView1.CurrentRow.Cells["descriptLine2DataGridViewTextBoxColumn"].Value.ToString().Trim()
            +" ¤ " +dataGridView1.CurrentRow.Cells["InternRem1"].Value.ToString().Trim();
            this.vF_PC190300_OrderLineDelTableAdapter.Fill(this.dataSet121.VF_PC190300_OrderLineDel, dataGridView1.CurrentRow.Cells["purchaOrdNoDataGridViewTextBoxColumn"].Value.ToString(), label13.Text);
            label4.Text = dataGridView1.CurrentRow.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString().Trim();
            BevMenny = Convert.ToDouble(dataGridView1.CurrentRow.Cells["pCQtyOrderedDataGridViewTextBoxColumn"].Value.ToString()) - Convert.ToDouble(dataGridView1.CurrentRow.Cells["PCQtyReceive"].Value.ToString());
            BevMenny2 = (Convert.ToDouble(dataGridView1.CurrentRow.Cells["pCQtyOrderedDataGridViewTextBoxColumn"].Value.ToString()) + Convert.ToDouble(dataGridView1.CurrentRow.Cells["pCQtyInvoiceDataGridViewTextBoxColumn"].Value.ToString()))
               - Convert.ToDouble(dataGridView1.CurrentRow.Cells["Menny"].Value.ToString());
            Lejar = dataGridView1.CurrentRow.Cells["userDefined8DataGridViewTextBoxColumn"].Value.ToString().Trim();
            ; textBox6.Text = BevMenny.ToString();
            button1.BackColor = Color.Gray;
            if (BevMenny <= 0)
            {
                MessageBox.Show("ERRE A BESZERZÉSI RENDELÉS SORRA NEM VÉTELEZHETŐ TÖBB MENNYISÉG !!");
                Torles2();
            }
            else
                textBox3.Select();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                cikkinformaciok();
            }
            if (e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{left}");
                SendKeys.Send("{down}");
            }
            if (e.KeyCode == Keys.Escape)
            {
                Torles2();
            }
        }
        private void Torles()
        {
            label1.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox6.Clear();
            label13.Text = "";
            dateTimePicker1.Visible = false;
            dataSet121.VF_PC190300_OrderLineDel.Clear();
            button1.BackColor = Color.Gray;
            textBox4.Select();
        }

        private void Torles2()
        {
            label1.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox6.Clear();
            label13.Text = "";
            dateTimePicker1.Visible = false;
            dataSet121.VF_PC190300_OrderLineDel.Clear();
            button1.BackColor = Color.Gray;
            textBox1.Select();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (label1.Text == "")
                {
                    MessageBox.Show("NINCS BESZERZÉSI RENDELÉS KIVÁLASZTVA !!");
                    textBox3.Clear();
                    textBox4.Select();
                }
                else
                {
                    if (textBox3.Text == "")
                        textBox3.Select();
                    else
                        textBox5.Select();
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (label1.Text == "")
                {
                    MessageBox.Show("NINCS BESZERZÉSI RENDELÉS KIVÁLASZTVA !!");
                    textBox3.Clear();
                    textBox1.Select();
                }
                else
                {
                    if (textBox5.Text != "")
                    {
                        this.szallitoLevelekTableAdapter.Fill(this.dataSet12.SzallitoLevelek);
                        int SzallFound = SzallitoLevelekbindingSource.Find("IktatoSzam", textBox5.Text.Trim());
                        if (SzallFound < 0)
                        {
                            MessageBox.Show("NINCS ILYEN BEÉRKEZÉSI SORSZÁM !!");
                            textBox5.Clear();
                            textBox5.Select();
                        }
                        else
                        {
                            if (Lejar == "1")
                            {
                                dateTimePicker1.Visible = true;
                                dateTimePicker1.Select();
                            }
                            else
                            {
                                Lejardatum = "9999-12-31";
                                textBox6.Select();
                            }
                         }
                    }
                        else
                        {
                         if (Lejar == "1")
                         {
                         dateTimePicker1.Visible = true;
                         dateTimePicker1.Select();
                        }
                       else
                        {
                         Lejardatum = "9999-12-31";
                         textBox6.Select();
                         }
                        }
                  }
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Lejardatum = dateTimePicker1.Text;
                textBox6.Select();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (Convert.ToDouble(textBox6.Text) <= BevMenny && Convert.ToDouble(textBox6.Text) <= BevMenny2)
                    {
                        button1.Visible = true;
                        button1.BackColor = Color.Orange;
                        button1.Select();
                    }
                    else
                    {
                        MessageBox.Show("A MENNYISÉG NEM LEHET NAGYOBB A RENDELT MENNYISÉGTŐL !!");
                        textBox6.Text = BevMenny.ToString();
                        textBox6.SelectAll();
                    }
                }
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            Torles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bevetelezes();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                Bevetelezes();
        }

        private void Bevetelezes()
        {
            if (label1.Text != "" && textBox3.Text != "" && textBox6.Text != "")
            {
                if (textBox5.Text != "")
                    Iktsz = Convert.ToInt32(textBox5.Text);
                else
                    Iktsz = 0;
                SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                connection.Open();
                SqlCommand mySqlCommand = connection.CreateCommand();
                mySqlCommand.CommandText = "INSERT INTO NBBeszerzesbolBevet (BeszRendSzam,Sorszam,Cikkszam,Menny,Bevetelezte,BevDatum,Iktatoszam,SzallitoLevel)" +
                "VALUES (@RendSzam,@Sor, @StockCode,@Menny,@bevetelezo,CURRENT_TIMESTAMP,@Iktatoszam,@Szalllevel)";
                mySqlCommand.Parameters.Add("@RendSzam", SqlDbType.Char);
                mySqlCommand.Parameters["@RendSzam"].Value = dataGridView1.CurrentRow.Cells["purchaOrdNoDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@Sor", SqlDbType.Char);
                mySqlCommand.Parameters["@Sor"].Value = dataGridView1.CurrentRow.Cells["lineNumberDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@StockCode", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@StockCode"].Value = dataGridView1.CurrentRow.Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@Menny", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Menny"].Value = Convert.ToDecimal(textBox6.Text.Trim());
                mySqlCommand.Parameters.Add("@bevetelezo", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@bevetelezo"].Value = pecset.Trim();
                mySqlCommand.Parameters.Add("@Iktatoszam", SqlDbType.Int);
                mySqlCommand.Parameters["@Iktatoszam"].Value = Iktsz;
                mySqlCommand.Parameters.Add("@Szalllevel", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Szalllevel"].Value = textBox3.Text.Trim();
                mySqlCommand.ExecuteNonQuery();
                connection.Close();
                BeirXML();
                button1.BackColor = Color.Gray;
                DialogResult dialogResult = MessageBox.Show("Cimke nyomtatás !!", "Cimke", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    Form13 Form13 = new Form13();
                    Form13.Cikkszam = dataGridView1.CurrentRow.Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString().Trim();
                    Form13.Szalllevel = textBox3.Text.Trim();
                    Form13.Szallito = dataGridView1.CurrentRow.Cells["supplierNameDataGridViewTextBoxColumn"].Value.ToString();
                    Form13.Lejart = Convert.ToDateTime(Lejardatum).ToString("yyyy-MM-dd");
                    Form13.ShowDialog();
                    button1.Visible = false;
                  //  textBox6.Select();
                    label13.Text = "";
                    textBox2.Clear();
                    textBox6.Clear();
                    dataGridView1.Select();
                }
                else if (dialogResult == DialogResult.No)
                {
                    button1.Visible = false;
                 //   textBox6.Select();
                    label13.Text = "";
                    textBox2.Clear();
                    textBox6.Clear();
                    dataGridView1.Select();
                }

            }
            else
            {
                MessageBox.Show("A KÖTELEZŐ MEZŐK NINCSENEK KITÖLTVE !!");
                button1.BackColor = Color.Gray;
            }
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            Torles();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Torles2();
        }

        private void BeirXML()
        {
            string datu = DateTime.Now.ToString("yyyy-MM-dd");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<?xml version='1.0' encoding='UTF-8'?>" +
"<msg:Msg xsi:schemaLocation='http://Epicor.com/Message/2.0 http://scshost/schemas/epicor/ScalaMessage.xsd' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:msg='http://Epicor.com/Message/2.0'>" +
   "<msg:Hdr>" +
        "<msg:Sender>" +
            "<msg:Name>TF</msg:Name>" +
                //   "<msg:Subname></msg:Subname>"+
        "</msg:Sender>" +
    "</msg:Hdr>" +
    "<msg:Body>" +
        "<msg:Req msg-type='Goods Receive Note' action='Process'>" +
         " <msg:Dta>" +
                "<dta:PurchaseOrderDelivery xsi:schemaLocation='http://www.scala.net/PurchaseOrderDelivery/1.1 http://scshost/schemas/Scala/1.1/PurchaseOrderDelivery.xsd' xmlns:msg='http://Epicor.com/InternalMessage/1.1' xmlns:dta='http://www.scala.net/PurchaseOrderDelivery/1.1'>" +
                   "<dta:OrderHeader>" +
                        "<dta:OrdNum>" + dataGridView1.CurrentRow.Cells["purchaOrdNoDataGridViewTextBoxColumn"].Value.ToString().Trim() + "</dta:OrdNum>" +
                        "<dta:DelivNoteNum>" + textBox3.Text.Trim() + "</dta:DelivNoteNum>" +
                //           "<dta:Note>TF</dta:Note>" +
                    "</dta:OrderHeader>" +
                    "<dta:OrderLineList>" +
                        "<dta:OrderLine>" +
    "<dta:LineNum>" + dataGridView1.CurrentRow.Cells["lineNumberDataGridViewTextBoxColumn"].Value.ToString().Trim() + "</dta:LineNum>" +
    "<dta:StockCode>" + dataGridView1.CurrentRow.Cells["stockCodeDataGridViewTextBoxColumn"].Value.ToString().Trim() + "</dta:StockCode>" +
    "<dta:DelivDateAct>" + datu + "</dta:DelivDateAct>" +
    "<dta:DelivLineList>" +
        "<dta:DelivLine>" +
            "<dta:BinCode>STD03</dta:BinCode>" +
            "<dta:QtyDeliv>" + Convert.ToDecimal(textBox6.Text.Trim().Replace(",",".")) + "</dta:QtyDeliv>" +
           "<dta:ExpiryDate>" + Convert.ToDateTime(Lejardatum).ToString("yyyy-MM-dd") + "</dta:ExpiryDate>" +
        "</dta:DelivLine>" +
    "</dta:DelivLineList>" +
"</dta:OrderLine>	" +
                   "</dta:OrderLineList>" +
                "</dta:PurchaseOrderDelivery>" +
            "</msg:Dta>" +
        "</msg:Req>" +
    "</msg:Body>" +
"</msg:Msg>");
            // Save the document to a file.
            string f_nev = "Bevet" + pecset + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
          //   doc.Save(f_nev);
            doc.Save(@"\\10.0.0.11\inputxml\" + f_nev);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            textBox6.Select();
        }


    }
}
