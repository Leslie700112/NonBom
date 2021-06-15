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
using System.Data.SqlClient;
using System.DirectoryServices;


namespace NonBom
{
    public partial class Form7 : Form
    {
        public string v_cikk, v_mertegys, v_megn1, v_megn2, v_megn3,v_satlar;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet7.VF_SC360300_StockBinNo' table. You can move, or remove it, as needed.
            this.vF_SC360300_StockBinNoTableAdapter.Fill(this.dataSet7.VF_SC360300_StockBinNo);
            // TODO: This line of code loads data into the 'dataSet7.VF_SC230300_WarehouseInfo' table. You can move, or remove it, as needed.
            this.vF_SC230300_WarehouseInfoTableAdapter.Fill(this.dataSet7.VF_SC230300_WarehouseInfo);
            textBox1.Text = v_cikk;
            label7.Text = v_megn1.Trim() + " ¤ " + v_megn2 + " ¤ " + v_megn3;
            label8.Text = v_mertegys.Trim();
            textBox3.Clear();
            textBox3.Select();
            Torol();
        }
        
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (label8.Text.Trim() == "db")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
                // only allow one decimal point 
                if ((e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            if (((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.Tab) && textBox3.Text != "")
            {
                textBox4.Visible = true;
                textBox4.Select();
                textBox3.Enabled = false;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Escape && textBox4.Text != "")
            {
                textBox8.Visible = true;
                textBox8.Select();
                textBox4.Enabled = false;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Escape && textBox8.Text != "")
            {
                DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
                textBox12.Text = de.Properties["fullName"].Value.ToString();
                textBox12.Visible = true;
                textBox12.Select();
                textBox8.Enabled = false;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //  SendKeys.Send("{TAB}");
                textBox6.Visible = true;
                textBox6.Select();
                comboBox1.Enabled = false;
                textBox6.Text = "STD" + comboBox1.Text.Substring(0, 2).Trim();
                this.vF_SC360300_StockBinNoTableAdapter.FillBy(this.dataSet7.VF_SC360300_StockBinNo, comboBox1.Text.Substring(0, 2).Trim());
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter && textBox6.Text != "")
            {
                int polcFound = VF_SC360300_StockBinNoBindingSource.Find("BinNumber", textBox6.Text.ToUpper().Trim());
                if (polcFound >= 0)
                {
                    textBox3.Visible = true;
                    textBox3.Select();
                    textBox6.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Nincs ilyen polc az adott raktárban !!", "Figyelmeztetés",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    textBox6.Text = "STD" + comboBox1.Text.Substring(0, 2).Trim();
                    textBox6.Select();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Torol();
            comboBox1.Select();
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter && textBox4.Text != "")
            {
                button1.Visible = true;
                button1.Select();
                textBox12.Enabled = false; //button1.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.textBox3.Text != "" && textBox4.Text.Trim() != "" && textBox8.Text.Trim() != "" && textBox12.Text.Trim() != "")
            //{
            //    //  this.printDocument1.Print();
            //    this.printPreviewDialog1.ShowDialog();
            //}
            //else
            //    MessageBox.Show("A cellák kitöltése kötelező  !!");

            SqlConnection mySqlConnection = new SqlConnection("Data Source=scala1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            mySqlConnection.Open();
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "INSERT INTO KeszletModKeresek " +
                "(Cikkszam,Raktar,Polc,Menyyiseg ,ModositasOka,JavitoIntezkedes ,Kerelmezo ,KerelmezesIdeje,Statusz) " +
                "VALUES (@Cikkszam,@Raktar,@Polc,@Menny,@Oka,@Intez,@Kerelmezo,CURRENT_TIMESTAMP,0)";
            mySqlCommand.Parameters.Clear();
            mySqlCommand.Parameters.Add("@Cikkszam", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Cikkszam"].Value = textBox1.Text.Trim();
            mySqlCommand.Parameters.Add("@Raktar", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Raktar"].Value = comboBox1.Text.Substring(0, 2);
            mySqlCommand.Parameters.Add("@Polc", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Polc"].Value = textBox6.Text.Trim();
            mySqlCommand.Parameters.Add("@Menny", SqlDbType.Decimal);
            mySqlCommand.Parameters["@Menny"].Value = Convert.ToDouble(textBox3.Text.Trim());
            mySqlCommand.Parameters.Add("@Oka", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Oka"].Value = textBox4.Text.Trim();
            mySqlCommand.Parameters.Add("@Intez", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Intez"].Value = textBox8.Text.Trim();
            mySqlCommand.Parameters.Add("@Kerelmezo", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Kerelmezo"].Value = textBox12.Text.Trim();
            mySqlCommand.ExecuteNonQuery();
            Torol();
        }

        private void Torol()
        {
            textBox6.Visible = false;
            textBox6.Enabled = true;
            textBox6.Clear();
            textBox3.Visible = false;
            textBox3.Enabled = true;
            textBox3.Clear();
            textBox4.Visible = false;
            textBox4.Enabled = true;
            textBox4.Clear();
            textBox8.Visible = false;
            textBox8.Enabled = true;
            textBox8.Clear();
            textBox12.Visible = false;
            textBox12.Enabled = true;
            textBox12.Clear();
            button1.Visible = false;
            comboBox1.Enabled = true;
            comboBox1.Select();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image newImage = Image.FromFile("Logo_FT.jpg");
            Point ulCorner = new Point(20, 70);
            string mystring = Convert.ToString(DateTime.Today);
            System.Drawing.Graphics g = e.Graphics;
            e.Graphics.DrawImage(newImage, ulCorner);

            g.DrawString("FUSETECH", new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(20, 10));
            g.DrawString("MF-13-036", new System.Drawing.Font("Times New Roman", 12F), new SolidBrush(Color.Black), new Point(350, 10));
            g.DrawString("Verzió : A", new System.Drawing.Font("Times New Roman", 12F), new SolidBrush(Color.Black), new Point(700, 10));
            Pen blackPen = new Pen(Color.Black, 1);
            Point point1 = new Point(15, 35);
            Point point2 = new Point(805, 35);
            e.Graphics.DrawLine(blackPen, point1, point2);

            g.DrawString("Készlet Módosítási Kérelem", new System.Drawing.Font("Verdana", 18F, FontStyle.Italic), new SolidBrush(Color.Black), new Point(230, 80));

            Rectangle rect = new Rectangle(30, 173, 750, 35);
            e.Graphics.DrawRectangle(blackPen, rect);
            g.DrawString("Kérelmező : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 180));
            g.DrawString(textBox12.Text.Trim(), new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(220, 180));

            Rectangle rect1 = new Rectangle(30, 215, 750, 200);
            e.Graphics.DrawRectangle(blackPen, rect1);
            Point point5 = new Point(30, 340);
            Point point6 = new Point(780, 340);
            e.Graphics.DrawLine(blackPen, point5, point6);
            g.DrawString("Cikkszám : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 220));
            g.DrawString(v_cikk, new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(220, 220));
            g.DrawString("Megnevezés : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 250));
            g.DrawString(v_megn1 + " ¤ " + v_megn2, new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(220, 250));
            g.DrawString(v_megn3 , new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(220, 275));
            g.DrawString("Raktár : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 305));
          //  g.DrawString(textBox5.Text.Trim(), new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(220, 305));
            g.DrawString("Mennyiség : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 350));
            g.DrawString(textBox3.Text.Replace(",", ".") + "   " + label8.Text, new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(220, 350));
            g.DrawString("Érték (S.Átl.Ár) : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 380));
            g.DrawString(Math.Round(Convert.ToDecimal(v_satlar) * Convert.ToDecimal(textBox3.Text.Replace(",", ".")), 2) + "   €", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(230, 380));

            Rectangle rect2 = new Rectangle(30, 440, 750, 120);
            e.Graphics.DrawRectangle(blackPen, rect2);
            g.DrawString("Módosítás oka : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 450));
            g.DrawString(textBox4.Text, new System.Drawing.Font("Verdana", 12F), new SolidBrush(Color.Black), new Point(220, 450));
          //  g.DrawString(textBox5.Text, new System.Drawing.Font("Verdana", 12F), new SolidBrush(Color.Black), new Point(220, 490));
        
            Rectangle rect3 = new Rectangle(30, 567, 750, 90);
            e.Graphics.DrawRectangle(blackPen, rect3);
            g.DrawString("Intézkedések : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 570));
            g.DrawString(textBox8.Text, new System.Drawing.Font("Verdana", 12F), new SolidBrush(Color.Black), new Point(220, 570));
                
            Rectangle rect5 = new Rectangle(30, 680, 750, 120);
            e.Graphics.DrawRectangle(blackPen, rect5);
            g.DrawString("Megjegyzés : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 685));

            Rectangle rect6 = new Rectangle(30, 810, 750, 55);
            e.Graphics.DrawRectangle(blackPen, rect6);
            g.DrawString("Kód *: ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 815));
            g.DrawString("9991 Téves bevételezés javítása", new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(130, 815));
            g.DrawString("9994 Kész.korr. mennyiségi eltérés", new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(130, 840));
            g.DrawString("9995 Kész.korr. egyéb felhasználás", new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(360, 815));
            g.DrawString("9998 Készletkorrekció", new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(360, 840));


            Rectangle rect4 = new Rectangle(30, 895, 750, 35);
            e.Graphics.DrawRectangle(blackPen, rect4);
            g.DrawString("Dátum : ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(60, 900));
            g.DrawString(mystring.Substring(0, 11), new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(220, 900));
            g.DrawString("Kérelmező ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(150, 1050));
            g.DrawString("Engedélyező ", new System.Drawing.Font("Verdana", 14F), new SolidBrush(Color.Black), new Point(500, 1050));
            g.DrawString("* Logisztikai vezető tölti ki !", new System.Drawing.Font("Times New Roman", 7F), new SolidBrush(Color.Black), new Point(40, 1095));
            Point point3 = new Point(15, 1110);
            Point point4 = new Point(805, 1110);
            e.Graphics.DrawLine(blackPen, point3, point4);
            g.DrawString("Készítette: Fazekas László", new System.Drawing.Font("Times New Roman", 10F), new SolidBrush(Color.Black), new Point(20, 1115));
            // g.DrawString("Vevői referencia : MF-xx-xxx", new System.Drawing.Font("Times New Roman", 10F), new SolidBrush(Color.Black), new Point(320, 1115));
            g.DrawString("Dátum: 2013.05.31", new System.Drawing.Font("Times New Roman", 10F), new SolidBrush(Color.Black), new Point(670, 1115));
        }
    }
}
