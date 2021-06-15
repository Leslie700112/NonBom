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

namespace NonBom
{
    public partial class Form2 : Form
    {
        public string v_cikk;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VNB_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vNB_SC010300_StockfileTableAdapter.FillBy(this.dataSet1.VNB_SC010300_Stockfile,v_cikk);
            label2.Text = v_cikk;
            label4.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["Description1"].ToString().Trim();
            label70.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["Description2"].ToString().Trim();
            label5.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["InternRem1"].ToString().Trim();
            label71.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["InternRem2"].ToString().Trim();
            label6.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["TCSMegn"].ToString().Trim();
            label7.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["ETCSMegn"].ToString().Trim();
            label11.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["StatCodeExte"].ToString().Trim();
            label13.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["NetWeight"].ToString().Trim();
            label15.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["GrossWeight"].ToString().Trim();
            label17.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["Meegys"].ToString().Trim();
            label18.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["PurchasePric"].ToString().Trim();
            label20.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["SupplierName"].ToString().Trim();
            label21.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["Purchaser"].ToString().Trim();
            label23.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["Planner"].ToString().Trim();
            label25.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["SupplStockCo"].ToString().Trim();
            label26.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["DelTimeWeek"].ToString().Trim();
            label28.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["ReOrdLevel"].ToString().Trim();
            label30.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["OptPurchQty"].ToString().Trim();
            label32.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["MinPurchQty"].ToString().Trim();
            label59.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["MaxPurchQty"].ToString().Trim();
            label33.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["SafetyStock"].ToString().Trim();
            label37.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["StdCostPric1"].ToString().Trim();
            label39.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["AccountCode"].ToString().Trim();
            label41.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["AccCodeStrg"].ToString().Trim();
            label43.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["ReplStocCode"].ToString().Trim();
            label45.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["DefaultBinNo"].ToString().Trim();
            label47.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["ArticlStatus"].ToString().Trim();
            label49.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["RecCreatDate"].ToString().Trim();
            label51.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["HoldStatus"].ToString().Trim();
            label35.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["HldStaSrtDat"].ToString().Trim();
            label53.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["StockBalance"].ToString().Trim();
            label61.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["Meegys"].ToString().Trim();
            label54.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["ReservedQty"].ToString().Trim();
            label63.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["Meegys"].ToString().Trim();
            label56.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["SCQtyOrder"].ToString().Trim();
            label65.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["Meegys"].ToString().Trim();
            label57.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["DelDateSuppl"].ToString().Trim();
            label58.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["DelDateCust"].ToString().Trim();
            label67.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["UserDefined8"].ToString().Trim();
            label68.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["QtyIn"].ToString().Trim();
            label72.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["QtyOut"].ToString().Trim();
            label74.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["QtyOutT"].ToString().Trim();
            label77.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["AverCostPri1"].ToString().Trim();
            label79.Text = dataSet1.Tables["VNB_SC010300_Stockfile"].Rows[0]["CurrencyShortName"].ToString().Trim();
            Adatlapok();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }

       private void Adatlapok()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"\\fs\munkakonyvtarak\OP\PRODUCTION\_Termelés\Biztonsági adatlapok\Adatlapok");
            FileInfo[] Files = dinfo.GetFiles(v_cikk + "*.pdf");
            foreach (FileInfo file in Files)
            {
                listBox1.Items.Add(file.Name);
            }

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = listBox1.IndexFromPoint(e.X, e.Y);
            if (listBox1.Items.Count != 0 && x>=0)
            {
               
                System.Diagnostics.Process.Start(@"\\fs\munkakonyvtarak\OP\PRODUCTION\_Termelés\Biztonsági adatlapok\Adatlapok\" + listBox1.Items[x].ToString().Trim());
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listBox1.Items.Count != 0)
                    System.Diagnostics.Process.Start(@"\\fs\munkakonyvtarak\OP\PRODUCTION\_Termelés\Biztonsági adatlapok\Adatlapok\" + listBox1.SelectedItem.ToString().Trim());
            }
        }
    }
}
