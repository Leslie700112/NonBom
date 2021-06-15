using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Diagnostics;

namespace NonBom
{
    public partial class Form19 : Form
    {
        private string Engedo;
        private int korx, kory;
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet19.NBSzolgaltatas' table. You can move, or remove it, as needed.
            this.nBSzolgaltatasTableAdapter.Fill(this.dataSet19.NBSzolgaltatas);
           
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            Engedo = de.Properties["fullName"].Value.ToString();
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
                    mySqlCommand.CommandText = "UPDATE NBSzolgaltatas SET Engedelyezo=@Enged,EngIdo=CURRENT_TIMESTAMP,Statusz='1' where IDS=@Sor";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sor"].Value = dataGridView1.Rows[i].Cells["IDS"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Enged", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Enged"].Value = Engedo.Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            this.nBSzolgaltatasTableAdapter.Fill(this.dataSet19.NBSzolgaltatas);
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dataGridView1.HitTest(e.X, e.Y).RowIndex != -1)
            {
                ContextMenu m = new ContextMenu();
                MenuItem mTorol = new MenuItem("Törlés");
                mTorol.Click += new EventHandler(MTorol_Click);
                m.MenuItems.AddRange(new MenuItem[] { mTorol });
                //dataGridView1.ContextMenu= m;
                korx = e.X;
                kory = e.Y;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataGridView1.Columns["Csatolmany"].Index)
            {
                string sUrl = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                ProcessStartInfo sInfo = new ProcessStartInfo(sUrl);

                Process.Start(sInfo);
            }
        }

        private void MTorol_Click(object sender, EventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridView1.HitTest(korx, kory);
              SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                connection.Open();
                SqlCommand mySqlCommand = connection.CreateCommand();
                mySqlCommand.CommandText = "delete NBSzolgaltatas where IDS=@Sor";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                mySqlCommand.Parameters["@Sor"].Value = dataGridView1.Rows[hit.RowIndex].Cells["IDS"].Value.ToString().Trim();
                mySqlCommand.ExecuteNonQuery();
                connection.Close();
                this.nBSzolgaltatasTableAdapter.Fill(this.dataSet19.NBSzolgaltatas);
        }
    
    
    
    }
}
