using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Diagnostics;
using DgvFilterPopup;


namespace NonBom
{
    public partial class Form10 : Form
    {
        private string Engedo;
        public Thread th;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet10.NBAnyagigenylo' table. You can move, or remove it, as needed.
            this.nBAnyagigenyloTableAdapter.Fill(this.dataSet10.NBAnyagigenylo);
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            Engedo = de.Properties["fullName"].Value.ToString();
            toolStripStatusLabel2.Text = "0";
            toolStripStatusLabel4.Text = "0";

            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(Fm_ColumnFilterAdding);

            fm.DataGridView = dataGridView1; // this raises ColumnFilterAdding events
            //fm["ORQtyOrdered"] = new DgvNumRangeColumnFilter();
          }
  
        void Fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "kerelmezoDataGridViewTextBoxColumn":
                case "supplierNameDataGridViewTextBoxColumn":
                case "Beruhazasszam":
                case "szallitoKodDataGridViewTextBoxColumn":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }
        
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                   if (!Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value))
                        dataGridView1.Rows[i].Cells["Column1"].Value = true;
                   else
                       dataGridView1.Rows[i].Cells["Column1"].Value = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
             SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value))
                {
                    mySqlCommand.CommandText = "UPDATE NBAnyagigenylo SET Engedelyezo=@Enged,EngDatum=CURRENT_TIMESTAMP,Status='1' where IDS=@Sor";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sor"].Value = dataGridView1.Rows[i].Cells["IDS"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Enged", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Enged"].Value =  Engedo.Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
               
              }
            connection.Close();
            th = new Thread(Futtat);
            th.Start();
            this.nBAnyagigenyloTableAdapter.Fill(this.dataSet10.NBAnyagigenylo);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (dataGridView1.Columns[e.ColumnIndex] == this.Column2)
             {
                     dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.BlanchedAlmond;
                     Form11 f11 = new Form11();
                     f11.Szall = dataGridView1.Rows[e.RowIndex].Cells["supplierNameDataGridViewTextBoxColumn"].Value.ToString();
                     f11.Szallido = dataGridView1.Rows[e.RowIndex].Cells["kertSzallIdoDataGridViewTextBoxColumn"].Value.ToString();
                     f11.Kerte = dataGridView1.Rows[e.RowIndex].Cells["kerelmezoDataGridViewTextBoxColumn"].Value.ToString();
                     f11.Megj1 = dataGridView1.Rows[e.RowIndex].Cells["megjegyzesFejDataGridViewTextBoxColumn"].Value.ToString().Trim();
                     f11.Beruhaz = dataGridView1.Rows[e.RowIndex].Cells["Beruhazasszam"].Value.ToString();
                     f11.Cikk = dataGridView1.Rows[e.RowIndex].Cells["cikkszamDataGridViewTextBoxColumn"].Value.ToString();
                     f11.Megnv = dataGridView1.Rows[e.RowIndex].Cells["Description1"].Value.ToString() + " ¤ " +
                         dataGridView1.Rows[e.RowIndex].Cells["Description2"].Value.ToString() + " ¤ " +
                         dataGridView1.Rows[e.RowIndex].Cells["InternRem1"].Value.ToString() + " ¤ " +
                         dataGridView1.Rows[e.RowIndex].Cells["InternRem2"].Value.ToString();
                     f11.Ar = dataGridView1.Rows[e.RowIndex].Cells["egysegarDataGridViewTextBoxColumn"].Value.ToString();
                     f11.Menny = dataGridView1.Rows[e.RowIndex].Cells["rendeltMennyDataGridViewTextBoxColumn"].Value.ToString();
                     f11.Mee = dataGridView1.Rows[e.RowIndex].Cells["Mee"].Value.ToString();
                     f11.Azonosito = dataGridView1.Rows[e.RowIndex].Cells["IDS"].Value.ToString();
                     f11.Megj1 = dataGridView1.Rows[e.RowIndex].Cells["megjegyzes2DataGridViewTextBoxColumn"].Value.ToString();
                     f11.ShowDialog();
                     this.nBAnyagigenyloTableAdapter.Fill(this.dataSet10.NBAnyagigenylo);
                 
             }
             else if (dataGridView1.Columns[e.ColumnIndex] == this.Column3 )
             {
                 SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                 connection.Open();
                 SqlCommand mySqlCommand = connection.CreateCommand();
                 mySqlCommand.CommandText = "UPDATE NBAnyagigenylo SET Engedelyezo=@Enged,EngDatum=CURRENT_TIMESTAMP,Status='9' where IDS=@Sor";
                 mySqlCommand.Parameters.Clear();
                 mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                 mySqlCommand.Parameters["@Sor"].Value = dataGridView1.Rows[e.RowIndex].Cells["IDS"].Value.ToString().Trim();
                 mySqlCommand.Parameters.Add("@Enged", SqlDbType.NVarChar);
                 mySqlCommand.Parameters["@Enged"].Value = Engedo.Trim();
                 mySqlCommand.ExecuteNonQuery();
                 connection.Close();
                 this.nBAnyagigenyloTableAdapter.Fill(this.dataSet10.NBAnyagigenylo);
             }
        }
        private void Futtat()
         {
            Process proc = new Process();
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.FileName = @"\\fs\anyagigenyles\Program\NonBomRendGen.exe";
            proc.Start();
            proc.WaitForExit();
            th.Abort();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            int sorindex = 0, q;
            double szam = 0;
            double osszeg = 0, osszeg1 = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                q = sorindex - 1;
                while (q > -1 && cell.RowIndex != sor[q]) q--;
                if (q == -1)
                {
                    if (double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[12].Value.ToString(), out szam))
                    {
                        if (dataGridView1.Rows[cell.RowIndex].Cells["Deviza"].Value.ToString() == "EUR")
                        {
                            osszeg += szam;
                            this.toolStripStatusLabel2.Text = osszeg.ToString("N2");
                        }
                        else
                        {
                            osszeg1 += szam;
                            this.toolStripStatusLabel4.Text = osszeg1.ToString("N2");
                        }
                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }
            }
        }
    
   

    }
}
