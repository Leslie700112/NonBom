using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NonBom
{
    public partial class Form182 : Form
    {
       public int Tipus;
        public string Doku;
        public Form182()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCSV = new OpenFileDialog();
            openFileDialogCSV.InitialDirectory = @"\\fs\munkakonyvtarak\OP\RACF\";
            openFileDialogCSV.Filter = "All Files(*.*)|*.*";
            openFileDialogCSV.FilterIndex = 1;
            openFileDialogCSV.RestoreDirectory = true;
            if (openFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                this.textBox5.Text = openFileDialogCSV.FileName.ToString();
                textBox5.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tipus == 0)
            {
                Doku = textBox5.Text.Trim();
                this.Close();
            }
            else
            {
                if (textBox5.Text != "")
                {
                    Doku = textBox5.Text.Trim();
                    this.Close();
                }
                else
                    textBox5.Select();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (Tipus == 0)
            //    {
            //        //textBox1.Clear();
            //        //textBox1.Visible = true;
            //        //textBox1.Select();
            //    }
            //    else
            //    {
            //        //if (Convert.ToDouble(textBox3.Text) >= 500 && textBox5.Text != "")
            //        {
            //            //textBox1.Clear();
            //            //textBox1.Visible = true;
            //            //textBox1.Select();
            //        }
            //        //if (Convert.ToDouble(textBox3.Text) < 500)
            //        {
            //            //textBox1.Clear();
            //            //textBox1.Visible = true;
            //            //textBox1.Select();
            //        }

            //    }
            //}
        }

        private void Form182_Load(object sender, EventArgs e)
        {
            //if (Tipus == 0)
            //    button1.Visible = true;
            label1.Text = "500 € felett Beruházás esetén ajánlat csatolása kötelező !\r\nSzolgáltatás esetén opcionális !";
            textBox5.Select();
        }
    }
}
