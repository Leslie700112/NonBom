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
    public partial class Form36 : Form
    {
        private string Kerelmezo;
        public Form36()
        {
            InitializeComponent();
        }

        private void Form36_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet361.NBCetLeeSor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet36.NBCetLeeFej' table. You can move, or remove it, as needed.
            this.nBCetLeeFejTableAdapter.Fill(this.dataSet36.NBCetLeeFej);

            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            Kerelmezo = de.Properties["fullName"].Value.ToString();
        }

        private void Frissit()
        {
            this.nBCetLeeFejTableAdapter.Fill(this.dataSet36.NBCetLeeFej);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frissit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    try
                    {
                        if (!Convert.ToBoolean(dataGridView1.Rows[cell.RowIndex].Cells["Column1"].Value))
                            dataGridView1.Rows[cell.RowIndex].Cells["Column1"].Value = true;
                        else
                            dataGridView1.Rows[cell.RowIndex].Cells["Column1"].Value = false;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                try
                {
                    if (!Convert.ToBoolean(dataGridView1.Rows[j].Cells["Column1"].Value))
                        dataGridView1.Rows[j].Cells["Column1"].Value = true;
                    else
                        dataGridView1.Rows[j].Cells["Column1"].Value = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            for (int q = 0; q < dataGridView1.RowCount; q++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[q].Cells["Column1"].Value))
                {
                    mySqlCommand.CommandText = "UPDATE NBCetLeeFej SET Statusz='0',Engedelyezo=@Enged,EngedIdeje=CURRENT_TIMESTAMP where CetLeeID=@Sor";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sor"].Value = Convert.ToInt32(dataGridView1.Rows[q].Cells["cetLeeIDDataGridViewTextBoxColumn"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Enged", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Enged"].Value = Kerelmezo.Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            Frissit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            for (int q = 0; q < dataGridView1.RowCount; q++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[q].Cells["Column1"].Value))
                {
                    mySqlCommand.CommandText = "UPDATE NBCetLeeFej SET Statusz='2',Engedelyezo=@Enged,EngedIdeje=CURRENT_TIMESTAMP where CetLeeID=@Sor";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sor"].Value = Convert.ToInt32(dataGridView1.Rows[q].Cells["cetLeeIDDataGridViewTextBoxColumn"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Enged", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Enged"].Value = Kerelmezo.Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            Frissit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] == this.Column2)
            {
              CetleeSorok();
            }
        }
  
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dataGridView1.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Cells[0];
                CetleeSorok();
            }
         }

        private void CetleeSorok()
        {
            int AktSor = dataGridView1.CurrentCell.RowIndex;
            Form38 Form38 = new Form38();
            Form38.Ugyintez = this.dataGridView1.CurrentRow.Cells["keszitetteDataGridViewTextBoxColumn"].Value.ToString();
            Form38.LetrehozIdo = this.dataGridView1.CurrentRow.Cells["letrehozasIdejeDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Tranzsz = this.dataGridView1.CurrentRow.Cells["tranzakcioSzamDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Szall = this.dataGridView1.CurrentRow.Cells["szallitoDataGridViewTextBoxColumn"].Value.ToString();
            Form38.SzallNev = this.dataGridView1.CurrentRow.Cells["supplierNameDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Szlaszam = this.dataGridView1.CurrentRow.Cells["InvoiceNo"].Value.ToString();
            Form38.Szlaido = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells["InvoiceDate1"].Value).ToString("yyyy.MM.dd");
            Form38.Osszeg = this.dataGridView1.CurrentRow.Cells["osszegDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Arfoly = this.dataGridView1.CurrentRow.Cells["arfolyamDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Netto = this.dataGridView1.CurrentRow.Cells["nettoDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Deviza = this.dataGridView1.CurrentRow.Cells["devizaDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Afakod = this.dataGridView1.CurrentRow.Cells["VATCode"].Value.ToString();
            Form38.Afa = this.dataGridView1.CurrentRow.Cells["afaDataGridViewTextBoxColumn"].Value.ToString();
            Form38.AfaNev = this.dataGridView1.CurrentRow.Cells["VATDesc"].Value.ToString();
            Form38.Fksz = this.dataGridView1.CurrentRow.Cells["bruttoFKSZDataGridViewTextBoxColumn"].Value.ToString();
            Form38.ElterO = this.dataGridView1.CurrentRow.Cells["elteresODataGridViewTextBoxColumn"].Value.ToString();
            Form38.ElterSz = this.dataGridView1.CurrentRow.Cells["elteresSzDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Enged = "Vár"; 
            Form38.ShowDialog();
            dataGridView1.CurrentCell = dataGridView1[0, AktSor];
        }

    }
}
