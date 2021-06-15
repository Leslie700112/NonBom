using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Reflection;
using System.Data.SqlClient;
using System.DirectoryServices;

namespace NonBom
{
    public partial class Form21 : Form
    {
      private int szolgFound;
      private string KtsghKod, KtsgNev, SzolgID,Engedo,Szolgi;
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet21.NBSzolgaltatas1' table. You can move, or remove it, as needed.
            this.nBSzolgaltatas1TableAdapter.Fill(this.dataSet21.NBSzolgaltatas1);
            // TODO: This line of code loads data into the 'dataSet21.VF_GL0303XX_CodingSegments_ktsgh' table. You can move, or remove it, as needed.
            this.vF_GL0303XX_CodingSegments_ktsghTableAdapter.Fill(this.dataSet21.VF_GL0303XX_CodingSegments_ktsgh);
            // TODO: This line of code loads data into the 'dataSet21.NBSzolgaltatas' table. You can move, or remove it, as needed.
            this.nBSzolgaltatasTableAdapter.Fill(this.dataSet21.NBSzolgaltatas);
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            Engedo = de.Properties["fullName"].Value.ToString();


            MethodInfo mi = typeof(Control).GetMethod("SetStyle",BindingFlags.NonPublic | BindingFlags.Instance);
            object[] args = new object[] { ControlStyles.AllPaintingInWmPaint |
                             ControlStyles.UserPaint |ControlStyles.OptimizedDoubleBuffer, true };
         //   mi.Invoke(splitContainer1.Panel1, args);
            mi.Invoke(splitContainer1.Panel2, args);
       
            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);

            fm.DataGridView = dataGridView1;
            Torol();
            dataGridView1.Select();

        }
   
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "szolgaltatoDataGridViewTextBoxColumn":
                case "supplierNameDataGridViewTextBoxColumn":
                case "munkahelyDataGridViewTextBoxColumn":
                case "igenyloDataGridViewTextBoxColumn":
                   e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Alapinformaciok();
        }

        private void Torol()
        {
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            label1.Text = "";
            label6.Text = "";
            label7.Text = "";
            label9.Text = "";
            label11.Text = "";
            label13.Text = "";
            label17.Text = "";
            textBox1.Clear();
       //   textBox1.Visible = false;
            textBox2.Clear();
            textBox2.Visible = false;
            textBox2.Enabled = true;
            textBox3.Clear();
            textBox3.Visible = false;
            textBox3.Enabled = true;
            button2.Visible = false;
            comboBox3.ResetText();
            comboBox3.Visible = false;
            comboBox3.Enabled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point 
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter && textBox2.Text.Trim() != "")
            {
                textBox3.Visible = true;
                textBox3.Select();
                textBox2.Enabled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter && textBox3.Text.Trim() != "")
            {
                string tra = "'%" + textBox3.Text.Trim()+"'";
                this.vF_PL030300_PurchaseLedgerTableAdapter.Fill(this.dataSet211.VF_PL030300_PurchaseLedger, textBox3.Text.Trim());
                int TraFound = VF_PL030300_PurchaseLedgerBbindingSource.Count;
                if (TraFound <= 0)
                {
                    textBox3.Clear();
                    textBox3.Select();
                }
                else
                {
                   
                    if (dataSet211.Tables["VF_PL030300_PurchaseLedger"].Rows[0]["SupplierCode"].ToString().Trim() == Szolgi)
                   {
                       comboBox3.Visible = true;
                       comboBox3.Select();
                       textBox3.Enabled = false;
                   }
                   else
                       MessageBox.Show("Szállító nem jó !!");
               }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Torol();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Alapinformaciok();
            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox3.Text.Trim() != "")
            {
                int KolFound = vFGL0303XXCodingSegmentsktsghBindingSource.Find("Name2", comboBox3.Text.Trim());
                if (KolFound < 0)
                {
                    comboBox3.ResetText();
                    comboBox3.Select();
                }
                else
                {
                    KtsghKod = dataSet21.Tables["VF_GL0303XX_CodingSegments_ktsgh"].Rows[KolFound]["CostCentre"].ToString().Trim();
                    KtsgNev = dataSet21.Tables["VF_GL0303XX_CodingSegments_ktsgh"].Rows[KolFound]["Name2"].ToString().Trim();
                    button2.Visible = true;
                    button2.Select();
                    comboBox3.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = "UPDATE NBSzolgaltatas SET Statusz='3',SzamlazottAr=@SzAr,IktatoSzam=@Iktszam,Koltseghely=@KtsghKod,KltsgHNev=@KtsghNev,"+
                " Szamligazol=@igazolo,SzamlIgIdo=CURRENT_TIMESTAMP where IDS=@Sor";
            mySqlCommand.Parameters.Clear();
            mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
            mySqlCommand.Parameters["@Sor"].Value = SzolgID;
            mySqlCommand.Parameters.Add("@SzAr", SqlDbType.Decimal);
            mySqlCommand.Parameters["@SzAr"].Value =Convert.ToDecimal(textBox2.Text.Trim());
            mySqlCommand.Parameters.Add("@Iktszam", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@Iktszam"].Value = textBox3.Text.Trim();
            mySqlCommand.Parameters.Add("@KtsghKod", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@KtsghKod"].Value = KtsghKod.Trim();
            mySqlCommand.Parameters.Add("@KtsghNev", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@KtsghNev"].Value = KtsgNev.Trim();
            mySqlCommand.Parameters.Add("@igazolo", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@igazolo"].Value = Engedo.Trim();
            mySqlCommand.ExecuteNonQuery();
            connection.Close();
            this.nBSzolgaltatasTableAdapter.Fill(this.dataSet21.NBSzolgaltatas);
            Torol();
        }

        private void Alapinformaciok()
        {
          szolgFound =NBSzolgaltatas1BindingSource.Find("IDS", dataGridView1.CurrentRow.Cells["iDSDataGridViewTextBoxColumn"].Value.ToString());
            label1.Text = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["Szolgaltato"].ToString().Trim() + " ¤ " +
                dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["SupplierName"].ToString().Trim();
            Szolgi = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["Szolgaltato"].ToString().Trim();
            label6.Text = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["Munkahely"].ToString().Trim();
            label7.Text = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["GepSzerszam"].ToString().Trim() + " ¤ " +
                dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["GSZNev"].ToString().Trim();
            label9.Text = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["BeruszamRACF"].ToString().Trim();
            textBox1.Text = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["Megjegyzes"].ToString().Trim();
            label11.Text = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["Ar"].ToString().Trim() + " ¤ " +
                dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["Deviza"].ToString().Trim();
            label13.Text = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["Deviza"].ToString().Trim();
            label17.Text = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["SzolgTipus"].ToString().Trim();
            SzolgID = dataSet21.Tables["NBSzolgaltatas1"].Rows[szolgFound]["IDS"].ToString().Trim();
            this.dataGridView1.CellContentClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            textBox2.Visible = true;
            textBox2.Select();
        }



    }
}
