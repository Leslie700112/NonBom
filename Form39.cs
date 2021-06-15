using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NonBom
{
    public partial class Form39 : Form
    {
        public Form39()
        {
            InitializeComponent();
        }

        private void Form39_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Dolgozok várj egy kicsit!!  ";
        }

        private void Form39_Shown(object sender, EventArgs e)
        {
            do
            {
                this.Close();
            }
            while (Directory.GetFiles(@"\\scala1\inputxml\", "NB*.xml", SearchOption.TopDirectoryOnly).Count() > 0);
        }
    }
}
