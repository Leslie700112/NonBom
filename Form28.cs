using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Diagnostics;
using System.DirectoryServices;

namespace NonBom
{
    public partial class Form28 : Form
    {

        private double beszar;
        private string felaszn,beszerzo;
        public int karx, kary, barx, bary;
        public string honnan;
        public Thread th;
        public Form28()
        {
            InitializeComponent();
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet28.Purchaser' table. You can move, or remove it, as needed.
            this.purchaserTableAdapter.Fill(this.dataSet28.Purchaser);
            // TODO: This line of code loads data into the 'dataSet28.VF_PL010300_SupplierFile' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet28.BeszAjanlatok' table. You can move, or remove it, as needed.
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            felaszn = de.Properties["fullName"].Value.ToString();
          
            toolStripComboBox1.ComboBox.DataSource =dataSet28.Tables["Purchaser"];
            toolStripComboBox1.ComboBox.DisplayMember = "Purchaser";
            if (honnan == "1")
            {
                SendKeys.Send("{tab}");
                SendKeys.Send("{tab}");
                SendKeys.Send("{tab}");
            }
           
            toolStripComboBox1.SelectedIndex = 1;
            toolStripComboBox1.Select();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value))
                {
                    mySqlCommand.CommandText = "UPDATE NBBeszAjanlatok SET PurchasePric=@Beszar,AlternSuppl=@SzKod,Statusz=1,Felhasznalo=@User where ID=@Sor";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sor"].Value = dataGridView1.Rows[i].Cells["ID"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@SzKod", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@SzKod"].Value = dataGridView1.Rows[i].Cells["alternSupplDataGridViewTextBoxColumn"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Beszar", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@Beszar"].Value =Convert.ToDecimal(dataGridView1.Rows[i].Cells["purchasePricDataGridViewTextBoxColumn"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@User", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@User"].Value = felaszn.Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
              th = new Thread(Futtat);
              th.Start();
            this.beszAjanlatokTableAdapter.Fill(this.dataSet28.BeszAjanlatok, beszerzo);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
         
            if (dataGridView1.CurrentCell.ColumnIndex == 7) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToDouble(dataGridView1.CurrentRow.Cells["purchasePricDataGridViewTextBoxColumn"].Value) > (beszar * 1.1))
                dataGridView1.CurrentRow.Cells["purchasePricDataGridViewTextBoxColumn"].Value = beszar.ToString();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
          beszar =Convert.ToDouble(dataGridView1.CurrentRow.Cells["purchasePricDataGridViewTextBoxColumn"].Value);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                karx = e.X;
                kary = e.Y;
                DataGridView.HitTestInfo kat = dataGridView1.HitTest(karx, kary);
                int AktSor = kat.RowIndex;
                if (AktSor >= 0)
                {
                    this.vF_PL010300_SupplierFileTableAdapter.Fill(this.dataSet28.VF_PL010300_SupplierFile);
                    this.groupBox1.Location = new System.Drawing.Point(karx, kary+30 );
                    groupBox1.Visible = true;

                }
            }
            else
                groupBox1.Visible = false;
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            barx = e.X;
            bary = e.Y;
            DataGridView.HitTestInfo bat = dataGridView2.HitTest(barx, bary);
            int AktSor = bat.RowIndex;
            if (AktSor >= 0)
            {
                dataGridView1.CurrentRow.Cells["alternSupplDataGridViewTextBoxColumn"].Value= dataGridView2.CurrentRow.Cells[0].Value.ToString();
                dataGridView1.CurrentRow.Cells["supplierNameDataGridViewTextBoxColumn"].Value = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void Futtat()
        {
            Process proc = new Process();
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.FileName = @"\\fs\anyagigenyles\Program\NonBomAjanlatGen.exe";
            proc.Start();
            proc.WaitForExit();
            th.Abort();
        }


        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            beszerzo = "";
            if (e.KeyCode == Keys.Enter)
            {
                if (toolStripComboBox1.Text.Trim() == "Mind")
                    beszerzo = "%";
                else
                    beszerzo = toolStripComboBox1.Text.Trim();

                this.beszAjanlatokTableAdapter.Fill(this.dataSet28.BeszAjanlatok, beszerzo);
            }
        }

    }
}
