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


namespace NonBom
{
    public partial class Form22 : Form
    {
        private string Engedo;
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet22.NBSzolgaltatas' table. You can move, or remove it, as needed.
            this.nBSzolgaltatasTableAdapter.Fill(this.dataSet22.NBSzolgaltatas);
          

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
                    mySqlCommand.CommandText = "UPDATE NBSzolgaltatas SET TeljIgazol=@Enged,TeljIgIdo=CURRENT_TIMESTAMP,Statusz='4' where IDS=@Sor";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sor"].Value = dataGridView1.Rows[i].Cells["iDSDataGridViewTextBoxColumn"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Enged", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Enged"].Value = Engedo.Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            this.nBSzolgaltatasTableAdapter.Fill(this.dataSet22.NBSzolgaltatas);
        }

       
    }
}
