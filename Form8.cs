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
using DgvFilterPopup;

namespace NonBom
{
    public partial class Form8 : Form
    {
        public string jog;
        private int korx, kory;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet8.NBAnyagigenylo' table. You can move, or remove it, as needed.
            this.nBAnyagigenyloTableAdapter.Fill(this.dataSet8.NBAnyagigenylo);

            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);

            fm.DataGridView = dataGridView1; // this raises ColumnFilterAdding events
            //fm["ORQtyOrdered"] = new DgvNumRangeColumnFilter();
            
        }
  
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "szallitoKodDataGridViewTextBoxColumn":
                case "SupplierName":
                case "kerelmezoDataGridViewTextBoxColumn":
                case "engedelyezoDataGridViewTextBoxColumn":
                case "statusDataGridViewTextBoxColumn":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }
        
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dataGridView1.HitTest(e.X, e.Y).RowIndex != -1)
              {
                ContextMenu m = new ContextMenu();
                MenuItem mModi = new MenuItem("Módosítás");
                MenuItem mTorol = new MenuItem("Törlés");
                mModi.Click += new EventHandler(mModi_Click);
                mTorol.Click += new EventHandler(mTorol_Click);
                if (jog=="A")
                {
                    MenuItem mLezar = new MenuItem("Lezárás");
                    mLezar.Click += new EventHandler(mLezar_Click);
                    m.MenuItems.AddRange(new MenuItem[] { mModi, mTorol,mLezar });
                }
                else
                m.MenuItems.AddRange(new MenuItem[] { mModi, mTorol });
                //dataGridView1.ContextMenu= m;
                korx = e.X;
                kory = e.Y;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void mModi_Click(object sender, EventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridView1.HitTest(korx, kory);
            if (dataGridView1.Rows[hit.RowIndex].Cells["statusDataGridViewTextBoxColumn"].Value.ToString() == "0")
            {
                Form11 f11 = new Form11();
                f11.Szall = dataGridView1.Rows[hit.RowIndex].Cells["SupplierName"].Value.ToString();
                f11.Szallido = dataGridView1.Rows[hit.RowIndex].Cells["kertSzallIdoDataGridViewTextBoxColumn"].Value.ToString();
                f11.Kerte = dataGridView1.Rows[hit.RowIndex].Cells["kerelmezoDataGridViewTextBoxColumn"].Value.ToString();
                f11.Megj1 = dataGridView1.Rows[hit.RowIndex].Cells["megjegyzesFejDataGridViewTextBoxColumn"].Value.ToString();
                f11.Beruhaz = dataGridView1.Rows[hit.RowIndex].Cells["Beruhazasszam"].Value.ToString();
                f11.Cikk = dataGridView1.Rows[hit.RowIndex].Cells["cikkszamDataGridViewTextBoxColumn"].Value.ToString();
                f11.Ar = dataGridView1.Rows[hit.RowIndex].Cells["egysegarDataGridViewTextBoxColumn"].Value.ToString();
                f11.Megnv = dataGridView1.Rows[hit.RowIndex].Cells["Description1"].Value.ToString();
                f11.Menny = dataGridView1.Rows[hit.RowIndex].Cells["rendeltMennyDataGridViewTextBoxColumn"].Value.ToString();
                f11.Mee = dataGridView1.Rows[hit.RowIndex].Cells["Mee"].Value.ToString();
                f11.Azonosito = dataGridView1.Rows[hit.RowIndex].Cells["IDS"].Value.ToString();
                f11.Megj1 = dataGridView1.Rows[hit.RowIndex].Cells["megjegyzes2DataGridViewTextBoxColumn"].Value.ToString();
                f11.Deviza = dataGridView1.Rows[hit.RowIndex].Cells["Deviza"].Value.ToString();
                f11.ShowDialog();
                //   fusetechDataSet.Clear();
                this.nBAnyagigenyloTableAdapter.Fill(this.dataSet8.NBAnyagigenylo);
            }
            else
                MessageBox.Show(" A rendelés már nem módosítható !!", "Figyelmeztetés", MessageBoxButtons.OK,
                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
        }

        private void mTorol_Click(object sender, EventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridView1.HitTest(korx, kory);
            if (dataGridView1.Rows[hit.RowIndex].Cells["statusDataGridViewTextBoxColumn"].Value.ToString() == "0")
            {
                SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                connection.Open();
                SqlCommand mySqlCommand = connection.CreateCommand();
                mySqlCommand.CommandText = "UPDATE NBAnyagigenylo SET Status='9' where IDS=@Sor";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                mySqlCommand.Parameters["@Sor"].Value = dataGridView1.Rows[hit.RowIndex].Cells["IDS"].Value.ToString().Trim();
                mySqlCommand.ExecuteNonQuery();
                connection.Close();
                this.nBAnyagigenyloTableAdapter.Fill(this.dataSet8.NBAnyagigenylo);
            }
            else
                MessageBox.Show(" A rendelés már nem törölhető !!", "Figyelmeztetés", MessageBoxButtons.OK,
                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
        }
        private void mLezar_Click(object sender, EventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridView1.HitTest(korx, kory);
          
                SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                connection.Open();
                SqlCommand mySqlCommand = connection.CreateCommand();
                mySqlCommand.CommandText = "UPDATE NBAnyagigenylo SET Status='9' where IDS=@Sor";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                mySqlCommand.Parameters["@Sor"].Value = dataGridView1.Rows[hit.RowIndex].Cells["IDS"].Value.ToString().Trim();
                mySqlCommand.ExecuteNonQuery();
                connection.Close();
                this.nBAnyagigenyloTableAdapter.Fill(this.dataSet8.NBAnyagigenylo);
       
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].Cells["PurchaseOrd"].Value.ToString().Trim()=="Problema")
            {
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }



    }
}
