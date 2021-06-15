using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Diagnostics;

namespace NonBom
{
    public partial class Form25 : Form
    {
        public string Igenylo,Rendsz,Devi;
        public Thread th;
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet25.VF_PL010300_SupplierFile' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet25.NBFelhasznalasKonszig' table. You can move, or remove it, as needed.
            this.nBFelhasznalasKonszigTableAdapter.Fill(this.dataSet25.NBFelhasznalasKonszig);
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            Igenylo = de.Properties["fullName"].Value.ToString();
            dataGridView3.Visible = false;
            label3.Visible = false;
            comboBox1.Visible = false;
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
           
            if (dataGridView2.CurrentCell.ColumnIndex == 14) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }
        
        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();

            int kijelolt = 0;
            for (int g = 0; g < dataGridView2.RowCount; g++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[g].Cells["Column1"].Value))
                {
                    Devi = dataGridView2.Rows[g].Cells["CurrencyShortName"].Value.ToString().Trim();
                    break;
                }
            }
            for (int r = 0; r < dataGridView2.RowCount; r++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[r].Cells["Column1"].Value))
                {
                    if (dataGridView2.Rows[r].Cells["CurrencyShortName"].Value.ToString().Trim() != Devi)
                    {
                        MessageBox.Show("Több fajta DEVIZA !!", "Figyelmeztetés", MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        kijelolt = 1;
                        break;
                    }
                }
            }
            if (kijelolt == 0)
            {

            //    SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=ScaCompDB;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            //    connection.Open();
            //    string sqlquery = ("SELECT count(DISTINCT V.CurrencyShortName) as Dev FROM Fusetech.dbo.NBFelhasznalas AS F LEFT OUTER JOIN" +
            //                 " VNB_SC010300_Stockfile AS SC ON F.Cikkszam = SC.StockCode LEFT OUTER JOIN" +
            //                 " VF_SYCD0300_DevizaNevek AS V ON SC.CurrCodePurc = V.CurrencyCode WHERE F.Statusz = 1");
            //    SqlCommand command = new SqlCommand(sqlquery, connection);

            //    string devfele = command.ExecuteScalar().ToString();// sdr["Dev"].ToString();
            //    connection.Close();
            //    if (devfele != "1")
            //    {
            //        MessageBox.Show("Több fajta DEVIZA !!", "Figyelmeztetés", MessageBoxButtons.OK,
            //                          MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    }
           //    string devi = dataGridView2.Rows[0].Cells["CurrencyShortName"].Value.ToString().Trim();
                this.vF_PL010300_SupplierFileTableAdapter.Fill(this.dataSet25.VF_PL010300_SupplierFile, Devi);
                label3.Visible = true;
                comboBox1.Visible = true;
                comboBox1.Select();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                try
                {
                    if (!Convert.ToBoolean(dataGridView2.Rows[i].Cells["Column1"].Value))
                        dataGridView2.Rows[i].Cells["Column1"].Value = true;
                    else
                        dataGridView2.Rows[i].Cells["Column1"].Value = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox1.Text.Trim() != "")
            {
                int SzallFound = vFPL010300SupplierFileBindingSource.Find("SupplierName", comboBox1.Text.Trim());
                if (SzallFound < 0)
                {
                    comboBox1.ResetText();
                    comboBox1.Select();
                }
                else
                {
                  string Szallkod = dataSet25.Tables["VF_PL010300_SupplierFile"].Rows[SzallFound]["SupplierCode"].ToString().Trim();
                   
                    dataGridView2.EndEdit();
                    SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                    connection.Open();
                    SqlCommand mySqlCommand = connection.CreateCommand();
                    mySqlCommand.CommandText = "execute NBRendeles @RendelesID OUTPUT,@Szall,@KertIdo,@Megj,@Igenylo,'1','0' ";
                    mySqlCommand.Parameters.Add("@RendelesID", SqlDbType.Int);
                    mySqlCommand.Parameters["@RendelesID"].Direction = ParameterDirection.Output;
                    mySqlCommand.Parameters.Add("@Szall", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Szall"].Value = Szallkod.Trim();
                    mySqlCommand.Parameters.Add("@KertIdo", SqlDbType.Date);
                    mySqlCommand.Parameters["@KertIdo"].Value = DateTime.Now;
                    mySqlCommand.Parameters.Add("@Megj", SqlDbType.Char);
                    mySqlCommand.Parameters["@Megj"].Value = "Konszignációs készlet feltöltés";
                    mySqlCommand.Parameters.Add("@Igenylo", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Igenylo"].Value =Igenylo;
                    int numberOfRows = mySqlCommand.ExecuteNonQuery();
                    Rendsz = mySqlCommand.Parameters["@RendelesID"].Value.ToString();

                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        if (Convert.ToBoolean(dataGridView2.Rows[i].Cells["Column1"].Value))
                        {
                            mySqlCommand.CommandText = "UPDATE NBFelhasznalas SET Statusz='9',AnyagigenyloID=@AnyagIg where BizonylatSzam=@Sor";
                            mySqlCommand.Parameters.Clear();
                            mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                            mySqlCommand.Parameters["@Sor"].Value = dataGridView2.Rows[i].Cells["bizonylatSzamDataGridViewTextBoxColumn"].Value.ToString().Trim();
                            mySqlCommand.Parameters.Add("@AnyagIg", SqlDbType.Int);
                            mySqlCommand.Parameters["@AnyagIg"].Value = Rendsz;
                            mySqlCommand.ExecuteNonQuery();
                        }
                    }
                    dataGridView3.Visible = true;
                    this.nBFelhasznalasKonszigTableAdapter.Fill(this.dataSet25.NBFelhasznalasKonszig);
                    this.nBFelhasznalasKonszig2TableAdapter.Fill(this.dataSet251.NBFelhasznalasKonszig2);

                    for (int k = 0; k < dataGridView3.RowCount; k++)
                    {
                        mySqlCommand.CommandText = "INSERT INTO NBAnyagigenylo" +
                     "(RendelesSzam,RendSorszam,Cikkszam,RendeltMenny,Egysegar,KertSzallIdo,Tipus,Status,Beruhazasszam,Megjegyzes2,Deviza,Engedelyezo,EngDatum)" +
                     "VALUES (@RendelesSzam,@RendSorszam,@Cikkszam,@RendeltMenny,@Egysegar,@KertSzallIdo,'1','1',@Beruszam,@megj2,@deviza,'NonBom Konszig',CURRENT_TIMESTAMP)";
                        mySqlCommand.Parameters.Clear();
                        mySqlCommand.Parameters.Add("@RendelesSzam", SqlDbType.NVarChar);
                        mySqlCommand.Parameters["@RendelesSzam"].Value = Rendsz.Trim();
                        mySqlCommand.Parameters.Add("@RendSorszam", SqlDbType.NVarChar);
                        mySqlCommand.Parameters["@RendSorszam"].Value = k + 1;
                        mySqlCommand.Parameters.Add("@Cikkszam", SqlDbType.NVarChar);
                        mySqlCommand.Parameters["@Cikkszam"].Value = dataGridView3.Rows[k].Cells["cikkszamDataGridViewTextBoxColumn1"].Value.ToString().Trim();
                        mySqlCommand.Parameters.Add("@RendeltMenny", SqlDbType.Decimal);
                        mySqlCommand.Parameters["@RendeltMenny"].Value = Convert.ToDouble(dataGridView3.Rows[k].Cells["menyyisegDataGridViewTextBoxColumn"].Value);
                        mySqlCommand.Parameters.Add("@Egysegar", SqlDbType.Decimal);
                        mySqlCommand.Parameters["@Egysegar"].Value = Convert.ToDouble(dataGridView3.Rows[k].Cells["priceDataGridViewTextBoxColumn"].Value);
                        mySqlCommand.Parameters.Add("@KertSzallIdo", SqlDbType.Date);
                        mySqlCommand.Parameters["@KertSzallIdo"].Value = DateTime.Now;
                        mySqlCommand.Parameters.Add("@Beruszam", SqlDbType.NVarChar);
                        mySqlCommand.Parameters["@Beruszam"].Value = "";
                        mySqlCommand.Parameters.Add("@megj2", SqlDbType.NVarChar);
                        mySqlCommand.Parameters["@megj2"].Value = "";
                        mySqlCommand.Parameters.Add("@deviza", SqlDbType.NVarChar);
                        mySqlCommand.Parameters["@deviza"].Value = dataGridView3.Rows[k].Cells["devDataGridViewTextBoxColumn"].Value.ToString().Trim();
                        mySqlCommand.ExecuteNonQuery();
                    }
                    mySqlCommand.CommandText = "UPDATE NBFelhasznalas SET Statusz='2' where Statusz='9'";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.ExecuteNonQuery();
                    connection.Close();
                    th = new Thread(Futtat);
                    th.Start();
                }
            }
            else
                comboBox1.Select();
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



    }
}
