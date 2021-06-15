using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonBom
{
    public partial class Form4 : Form
    {
        public string v_cikk;
        public Form4()
        {
          InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.vNB_ST080300_PurchaseStatTableAdapter.Fill(this.dataSet4.VNB_ST080300_PurchaseStat, v_cikk);
        }
    }
}
