using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;

namespace NonBom
{
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet31.NBLeltarAdatok' table. You can move, or remove it, as needed.
            this.nBLeltarAdatokTableAdapter.Fill(this.dataSet31.NBLeltarAdatok);

            DgvFilterManager fm = new DgvFilterManager();
            fm.DataGridView = dataGridView1;
        }

    }
}
