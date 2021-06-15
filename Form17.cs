using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DgvFilterPopup;

namespace NonBom
{
    public partial class Form17 : Form
    {
        private int korx, kory;
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet17.NBSzolgaltatas' table. You can move, or remove it, as needed.
            this.nBSzolgaltatasTableAdapter1.Fill(this.dataSet17.NBSzolgaltatas);
            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);

            fm.DataGridView = dataGridView1;
         }
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "szolgaltatoDataGridViewTextBoxColumn":
                case "munkahelyDataGridViewTextBoxColumn":
                case "igenyloDataGridViewTextBoxColumn":
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
                MenuItem mTorol = new MenuItem("Törlés");
                mTorol.Click += new EventHandler(mTorol_Click);
                m.MenuItems.AddRange(new MenuItem[] { mTorol });
                korx = e.X;
                kory = e.Y;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

      private void mTorol_Click(object sender, EventArgs e)
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
                this.nBSzolgaltatasTableAdapter1.Fill(this.dataSet17.NBSzolgaltatas);
        }

    
       
    }
}
