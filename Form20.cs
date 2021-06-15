using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.DirectoryServices.AccountManagement;

namespace NonBom
{
    public partial class Form20 : Form
    {
        public string user, pecset;
        private string level;
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet20.Jogok' table. You can move, or remove it, as needed.
            this.jogokTableAdapter1.Fill(this.dataSet20.Jogok);
            // TODO: This line of code loads data into the 'dataSet20.NBSzolgaltatas' table. You can move, or remove it, as needed.
            this.nBSzolgaltatasTableAdapter.Fill(this.dataSet20.NBSzolgaltatas);
            System.Security.Principal.WindowsIdentity currentUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            user = Environment.UserName;
            level= UserPrincipal.Current.EmailAddress;
            Jogosult();
        }
    
        private void Jogosult()
        {
            int itemFound = JogokBindingSource.Find("Jogosult", user);
            if (itemFound < 0)
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            else
            {
                DataTable joguDataTable = dataSet20.Tables["Jogok"];
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
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            paramDiscreteValue.Value = dataGridView1.CurrentRow.Cells["iDDataGridViewTextBoxColumn"].Value.ToString();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            paramField = new ParameterField(); // <-- This line is added
            paramDiscreteValue = new ParameterDiscreteValue();  // <-- This line is added
            paramField.Name = "Ugyintezo";
            //  paramDiscreteValue.Value = dataGridView1.CurrentRow.Cells["igenyloDataGridViewTextBoxColumn"].Value.ToString();
            paramDiscreteValue.Value = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName.ToString();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            paramField = new ParameterField(); // <-- This line is added
            paramDiscreteValue = new ParameterDiscreteValue();  // <-- This line is added
            paramField.Name = "Email";
           // paramDiscreteValue.Value = pecset.ToString();
            paramDiscreteValue.Value = level.ToString();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);
       
            paramField = new ParameterField(); // <-- This line is added
            paramDiscreteValue = new ParameterDiscreteValue();  // <-- This line is added
            paramField.Name = "Jovahagyta";
            paramDiscreteValue.Value = dataGridView1.CurrentRow.Cells["Expr1"].Value.ToString().Trim();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            crystalReportViewer1.ParameterFieldInfo = paramFields;
            reportDocument.Load("SzolgMegrendel.rpt");
            crystalReportViewer1.ReportSource = reportDocument;

            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = "UPDATE NBSzolgaltatas SET Statusz='2' where RendelesSzam=@Sor";
            mySqlCommand.Parameters.Clear();
            mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
            mySqlCommand.Parameters["@Sor"].Value = dataGridView1.CurrentRow.Cells["iDDataGridViewTextBoxColumn"].Value.ToString();
            mySqlCommand.ExecuteNonQuery();
            connection.Close();
            this.nBSzolgaltatasTableAdapter.Fill(this.dataSet20.NBSzolgaltatas);
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].Cells["Statusz"].Value.ToString().Trim() == "2")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
        }
    }
}
