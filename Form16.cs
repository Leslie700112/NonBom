using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace NonBom
{
    public partial class Form16 : Form
    {
        public string v_cikk, user, jog, pecset;
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet91.Jogok' table. You can move, or remove it, as needed.
            this.jogokTableAdapter.Fill(this.dataSet91.Jogok);
            // TODO: This line of code loads data into the 'dataSet9.VNB_PC030300_POLineFile' table. You can move, or remove it, as needed.
            this.vNB_PC030300_POLineFileTableAdapter.Fill(this.dataSet9.VNB_PC030300_POLineFile);
            System.Security.Principal.WindowsIdentity currentUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            user = Environment.UserName;
            jogosult();
        }
   
        private void jogosult()
        {
            int itemFound = JogokBindingSource.Find("Jogosult", user);
            if (itemFound < 0)
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            else
            {
                DataTable joguDataTable = dataSet91.Tables["Jogok"];
                joguDataTable.PrimaryKey =
                     new DataColumn[]
                    {
                     joguDataTable.Columns["Jogosult"]
                    };
                DataRow jogi = joguDataTable.Rows.Find(user);
                foreach (DataColumn myDataColumn in joguDataTable.Columns)
                {
                  //  jog = jogi["NonBom_Jog"].ToString();
                    pecset = jogi["Email"].ToString().Trim();
                }
            }
        }
   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Add(this.crystalReportViewer1);
            crystalReportViewer1.Visible = true;
             crystalReportViewer1.BringToFront();
         
              this.crystalReportViewer1.ActiveViewIndex = 0;
              this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
              this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
              this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
              this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
              this.crystalReportViewer1.Name = "crystalReportViewer1";
             this.crystalReportViewer1.Size = new System.Drawing.Size(715, 642);
              this.crystalReportViewer1.TabIndex = 0;

              ReportDocument reportDocument = new ReportDocument();

              ParameterFields paramFields = new ParameterFields();
              // ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

              ParameterField paramField = new ParameterField();
              ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
              paramField.Name = "Rendelésszám";
              paramDiscreteValue.Value = dataGridView1.CurrentRow.Cells["purchaOrdNoDataGridViewTextBoxColumn"].Value.ToString();
              paramField.CurrentValues.Add(paramDiscreteValue);
              paramFields.Add(paramField);

              paramField = new ParameterField(); // <-- This line is added
              paramDiscreteValue = new ParameterDiscreteValue();  // <-- This line is added
              paramField.Name = "Ugyintezo";
              paramDiscreteValue.Value = dataGridView1.CurrentRow.Cells["kerteDataGridViewTextBoxColumn"].Value.ToString();
              paramField.CurrentValues.Add(paramDiscreteValue);
              paramFields.Add(paramField);
           
            paramField = new ParameterField(); // <-- This line is added
              paramDiscreteValue = new ParameterDiscreteValue();  // <-- This line is added
              paramField.Name = "Email";
              paramDiscreteValue.Value = pecset.ToString();
              paramField.CurrentValues.Add(paramDiscreteValue);
              paramFields.Add(paramField);

              crystalReportViewer1.ParameterFieldInfo = paramFields;
              reportDocument.Load("NonBomPO.rpt");
              crystalReportViewer1.ReportSource = reportDocument;

              SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
              connection.Open();
              SqlCommand mySqlCommand = connection.CreateCommand();
              mySqlCommand.CommandText = "UPDATE NBAnyagigenyloFej SET Status='1' where ID=@Sor";
              mySqlCommand.Parameters.Clear();
              mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
              mySqlCommand.Parameters["@Sor"].Value = dataGridView1.CurrentRow.Cells["rendelesSzamDataGridViewTextBoxColumn"].Value.ToString();
              mySqlCommand.ExecuteNonQuery();
              connection.Close();
              this.vNB_PC030300_POLineFileTableAdapter.Fill(this.dataSet9.VNB_PC030300_POLineFile);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString().Trim() == "1" )
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
        }
    }
}
