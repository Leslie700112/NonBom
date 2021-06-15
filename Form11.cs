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

namespace NonBom
{
    public partial class Form11 : Form
    {
        public string Szall, Szallido, Kerte, Megj1, Beruhaz,Cikk,Ar,Megnv,Menny,Mee,Azonosito,Statusz,Deviza;
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            label11.Text = Szall;
            label12.Text = Szallido;
            label13.Text = Kerte;
            label14.Text = Megj1;
            label15.Text = Beruhaz;
            label16.Text = Cikk;
            label17.Text = Megnv;
            label18.Text = Deviza;
            textBox3.Text = Ar;
            label19.Text = Mee;
            textBox1.Text = Menny;
            textBox2.Text = Megj1;
            textBox3.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (label19.Text == "db")
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
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    if (Convert.ToDouble(textBox1.Text) > 0)
                    {
                       textBox2.Select();
                    }
                    else
                        textBox1.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = "UPDATE NBAnyagigenylo SET RendeltMenny=@Menny,Egysegar=@Ar,Megjegyzes2=@Megj where IDS=@Sor";
                 mySqlCommand.Parameters.Clear();
                 mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                 mySqlCommand.Parameters["@Sor"].Value = Azonosito;
                 mySqlCommand.Parameters.Add("@Menny", SqlDbType.Decimal);
                 mySqlCommand.Parameters["@Menny"].Value =Convert.ToDouble(textBox1.Text.Trim());
                 mySqlCommand.Parameters.Add("@Ar", SqlDbType.Decimal);
                 mySqlCommand.Parameters["@Ar"].Value = Convert.ToDouble(textBox3.Text.Trim());
                 mySqlCommand.Parameters.Add("@Megj", SqlDbType.NVarChar);
                 mySqlCommand.Parameters["@Megj"].Value = textBox2.Text.Trim();
                 mySqlCommand.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                textBox1.Select();
            }
                  

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               button1.Select();
            }
        }


    }
}
