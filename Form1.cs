using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonBom
{
    public partial class Form1 : Form
    {
        public string honnan;
        public string v_cikk,user,jog,pecset, v_report, satlar;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(SplitContainer1_KeyDown);
            this.KeyPreview = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.CrystalNyilv' table. You can move, or remove it, as needed.
            this.crystalNyilvTableAdapter.Fill(this.dataSet11.CrystalNyilv);
            // TODO: This line of code loads data into the 'dataSet1.Jogok' table. You can move, or remove it, as needed.
            this.jogokTableAdapter.Fill(this.dataSet1.Jogok);
            // TODO: This line of code loads data into the 'dataSet1.VNB_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vNB_SC010300_StockfileTableAdapter.Fill(this.dataSet1.VNB_SC010300_Stockfile);
            System.Security.Principal.WindowsIdentity currentUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            user = Environment.UserName;
            Jogosult();
            this.dataGridView1.Columns[1].Frozen = true;
            treeView1.ExpandAll();
            Keresmezo();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            string wkeres = " ";

            string seekValue = this.textBox1.Text;
            if (seekValue != wkeres)
            {
                if (!string.IsNullOrEmpty(seekValue))
                {
                 vNBSC010300StockfileBindingSource.Filter = "Kereso like '%" + seekValue.Trim() + "%'";
                }
                else
                {
                    try
                    {
                      vNBSC010300StockfileBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                wkeres = seekValue;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            treeView1.SelectedNode = treeView1.Nodes["Készletek(L)"];
            Alapinformaciok();
        }
    
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            treeView1.SelectedNode = treeView1.Nodes["Készletek(L)"];
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Alapinformaciok();
            }
        }
   
        private void Alapinformaciok()
        {
            v_cikk = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = v_cikk;
            int SorFound =vNBSC010300StockfileBindingSource.Find("StockCode", v_cikk.Trim());
            textBox2.Text = dataGridView1.Rows[SorFound].Cells["description1DataGridViewTextBoxColumn"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[SorFound].Cells["description2DataGridViewTextBoxColumn"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[SorFound].Cells["internRem1DataGridViewTextBoxColumn"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[SorFound].Cells["Meegys"].Value.ToString();
            satlar= dataGridView1.Rows[SorFound].Cells["AverCostPrc2"].Value.ToString();
            textBox1.ReadOnly = true;
            this.KeyPreview = true;
            Form3 Form3 = new Form3();
            Form3.v_cikk = v_cikk;
            ShowForm(Form3);
        }
  
        public void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "NonBom Cikkek Lekérdezése(ESC)":
                    v_cikk = "";
                    this.KeyPreview = false;
                    this.splitContainer1.Panel2.Controls.Clear();
                    this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
                    Keresmezo();
                    break;
                case "Alap Információk(A)":
                    Form2 Form2 = new Form2();
                    Form2.v_cikk = v_cikk;
                    ShowForm(Form2);
                    break;
                case "Készletek(L)":
                    Form3 Form3 = new Form3();
                    Form3.v_cikk = v_cikk;
                    ShowForm(Form3);
                    break;
                case "Beérkezések(B)":
                    Form4 Form4 = new Form4();
                    Form4.v_cikk = v_cikk;
                    ShowForm(Form4);
                    break;
                case "Várható beérk./ kiszáll.(K)":
                    Form5 Form5 = new Form5();
                    Form5.v_cikk = v_cikk;
                    ShowForm(Form5);
                    break;
                case "KészletTranzakciók(T)":
                    Form6 Form6 = new Form6();
                    Form6.v_cikk = v_cikk;
                    Form6.v_megn1 = textBox2.Text.Trim();
                    Form6.v_megn2 = textBox3.Text.Trim();
                    Form6.v_megn3 = textBox5.Text.Trim();
                    Form6.v_mertegys = textBox4.Text.Trim();
                    ShowForm(Form6);
                    break;
                case "Felhasználás":
                    Form29 Form29 = new Form29();
                 //   Form29.v_cikk = v_cikk;
                    ShowForm2(Form29);
                    break;
                case "Szállítólevelek":
                    Form30 Form30 = new Form30();
                    //   Form29.v_cikk = v_cikk;
                    ShowForm2(Form30);
                    break;
                case "NonBom Igények(F2)":
                    Form8 Form8 = new Form8();
                    Form8.jog = jog.Trim();
                    ShowForm2(Form8);
                    break;
                case "Szolgáltatások":
                    Form17 Form17 = new Form17();
                    ShowForm2(Form17);
                    break;
                case "Új Igény Felvitele(F3)":
                    if (jog.Trim() == "A" || jog.Trim() == "I" || jog.Trim() == "E" || jog.Trim() == "R")
                    {
                         FormZaras();
                        this.KeyPreview = false;
                        Form9 Form9 = new Form9();
                        Form9.honnan = "1";
                        ShowForm2(Form9);
                      //  break;
                     }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Konszig Rendelés Létrehozása":
                    if (jog.Trim() == "A" || jog.Trim() == "I" || jog.Trim() == "E" || jog.Trim() == "R")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form25 Form25 = new Form25();
                      //  Form25.honnan = "1";
                        ShowForm2(Form25);
                      //  break;
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;

                case "Engedélyezés(F4)":
                    if (jog.Trim() == "A" || jog.Trim() == "E")
                    {
                        Form10 Form10 = new Form10();
                        ShowForm2(Form10);
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Bevételezés(F5)":
                    if (jog.Trim() == "A" || jog.Trim() == "R" || jog.Trim() == "E")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form12 Form12 = new Form12();
                        Form12.pecset = pecset;
                        ShowForm2(Form12);
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Címke Nyomtatás(F6)":
                    if (jog.Trim() == "A" || jog.Trim() == "R" || jog.Trim() == "E")
                    {
                       Form13 Form13 = new Form13();
                       Form13.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Polcra Helyezés(F7)":
                    if (jog.Trim() == "A" || jog.Trim() == "R" || jog.Trim() == "E")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form14 Form14 = new Form14();
                        //Form13.pecset = pecset;
                        ShowForm2(Form14);
                     }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Kiadás(F8)":
                    honnan ="1";
                    Kiadas();
                    break;
                case "Visszavételezés":
                    if (jog.Trim() == "A" || jog.Trim() == "R" || jog.Trim() == "E")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form33 Form33 = new Form33();
                        //Form13.pecset = pecset;
                        ShowForm2(Form33);
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Készlet Módosítás Kérés(U)":
                    if (v_cikk != "" && v_cikk != null)
                    {
                        Form7 Form7 = new Form7();
                        Form7.v_cikk = v_cikk;
                        Form7.v_megn1 = textBox2.Text.Trim();
                        Form7.v_megn2 = textBox3.Text.Trim();
                        Form7.v_megn3 = textBox5.Text.Trim();
                        Form7.v_mertegys = textBox4.Text.Trim();
                        Form7.v_satlar = satlar;
                        Form7.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("      NINCS KIVÁLASZTOTT CIKK !!       ");
                        treeView1.SelectedNode = null;
                        textBox1.Select();
                    }
                    break;
                case "Rendelés Nyomtatás PO (F9)":
                    if (jog.Trim() == "A" || jog.Trim() == "R" || jog.Trim() == "E")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form16 Form16 = new Form16();
                        //Form15.pecset = pecset;
                        ShowForm2(Form16);
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Szolgáltatási Igény Felvitele":
                    if (jog.Trim() == "A" || jog.Trim() == "I" || jog.Trim() == "E" || jog.Trim() == "R")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form18 Form18 = new Form18();
                        Form18.honnan = "1";
                        ShowForm2(Form18);
                      //  break;
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Engedélyezés":
                    if (jog.Trim() == "A" || jog.Trim() == "E")
                    {
                        Form19 Form19= new Form19();
                        ShowForm2(Form19);
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Megrendelő Nyomtatás":
                    if (jog.Trim() == "A" || jog.Trim() == "I" || jog.Trim() == "E" || jog.Trim() == "R")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form20 Form20 = new Form20();
                   //     Form20.honnan = "1";
                        ShowForm2(Form20);
                     //   break;
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                //case "Számla Igazolás":
                //    if (jog.Trim() == "A" || jog.Trim() == "I" || jog.Trim() == "E" || jog.Trim() == "R")
                //    {
                //        FormZaras();
                //        this.KeyPreview = false;
                //        Form21 Form21 = new Form21();
                //        //     Form20.honnan = "1";
                //        ShowForm2(Form21);
                //       // break;
                //    }
                //    else
                //    {
                //        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                //                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                //        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                //    }
                //    break;
                case "Teljesítés Igazolás":
                    if (jog.Trim() == "A" || jog.Trim() == "E")
                    {
                        Form22 Form22 = new Form22();
                        ShowForm2(Form22);
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Lezárt NonBom Igények":
                    Form23 Form23 = new Form23();
                    ShowForm2(Form23);
                    break;
                case "Lezárt Szolgáltatási Igények":
                    Form24 Form24 = new Form24();
                    ShowForm2(Form24);
                    break;
                case "Beszerzési Ajánlatok":
                    if (jog.Trim() == "A" || jog.Trim() == "I" || jog.Trim() == "E" || jog.Trim() == "R")
                    {
                        Form28 Form28 = new Form28();
                        Form28.honnan = "1";
                        ShowForm2(Form28);
                    }
                    break;
                case "Konszig Rendelések Bevételezése":
                    if (jog.Trim() == "A" || jog.Trim() == "I" || jog.Trim() == "E" || jog.Trim() == "R")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form26 Form26 = new Form26();
                        //     Form20.honnan = "1";
                        ShowForm2(Form26);
                      //  break;
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Leltár Adatok Felvitele":
                    if (jog.Trim() == "A" || jog.Trim() == "I" || jog.Trim() == "E" || jog.Trim() == "R")
                    {
                        FormZaras();
                        this.KeyPreview = false;
                        Form32 Form32 = new Form32();
                        //     Form20.honnan = "1";
                        ShowForm2(Form32);
                      //  break;
                    }
                    else
                    {
                        MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        treeView1.SelectedNode = treeView1.Nodes["Node20"];
                    }
                    break;
                case "Leltár":
                        FormZaras();
                        this.KeyPreview = false;
                        Form31 Form31 = new Form31();
                        //     Form20.honnan = "1";
                        ShowForm2(Form31);
                        break;

            }
        }

        public void SplitContainer1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    v_cikk = "";
                    this.KeyPreview = false;
                    this.splitContainer1.Panel2.Controls.Clear();
                    this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
                    Keresmezo();
                    break;
                case Keys.L:
                    FormZaras();
                    Form3 Form3 = new Form3();
                    Form3.v_cikk = v_cikk;
                    ShowForm(Form3);
                    break;
                 case Keys.K:
                    FormZaras();
                    Form5 Form5 = new Form5();
                    Form5.v_cikk = v_cikk;
                    ShowForm(Form5);
                    break;
                case Keys.A:
                    FormZaras();
                    Form2 Form2 = new Form2();
                    Form2.v_cikk = v_cikk;
                    ShowForm(Form2);
                    break;
                case Keys.B:
                    FormZaras();
                    Form4 Form4 = new Form4();
                    Form4.v_cikk = v_cikk;
                    ShowForm(Form4);
                    break;
                case Keys.T:
                    FormZaras();
                    Form6 Form6 = new Form6();
                    Form6.v_cikk = v_cikk;
                    Form6.v_megn1 = textBox2.Text.Trim();
                    Form6.v_megn2 = textBox3.Text.Trim();
                    Form6.v_megn3 = textBox5.Text.Trim();
                    Form6.v_mertegys = textBox4.Text.Trim();
                    ShowForm(Form6);
                    break;
                case Keys.U:
                    FormZaras();
                    if (v_cikk != "" && v_cikk != null)
                    {
                        Form7 Form7 = new Form7();
                        Form7.v_cikk = v_cikk;
                        Form7.v_megn1 = textBox2.Text.Trim();
                        Form7.v_megn2 = textBox3.Text.Trim();
                        Form7.v_megn3 = textBox5.Text.Trim();
                        Form7.v_mertegys = textBox4.Text.Trim();
                        Form7.v_satlar = satlar;
                        Form7.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("      NINCS KIVÁLASZTOTT CIKK !!       ");
                        treeView1.SelectedNode = null;
                        textBox1.Select();
                    }
                    break;
               
            }
        }

        public void ShowForm(Form sender)
        {
            if (v_cikk != null && v_cikk != "")
            {
                //sender.ControlBox = false;
                //sender.FormBorderStyle = FormBorderStyle.Fixed3D;
                //sender.ShowInTaskbar = true;
                sender.TopLevel = false;
            //    this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(sender);
                sender.Show();
            }
            else
            {
                MessageBox.Show("      NINCS KIVÁLASZTOTT CIKK !!       ");
                treeView1.SelectedNode = null;
                textBox1.Select();
            }
        }
   
         private void Keresmezo()
        {
            textBox1.ReadOnly = false;
            textBox1.Clear();
            textBox1.Select();
        }

        private void FormZaras()
        {
            if (Application.OpenForms["Form2"] != null)
                Application.OpenForms["Form2"].Close();
          //  if (Application.OpenForms["Form3"] != null)
          //      Application.OpenForms["Form3"].Close();
            if (Application.OpenForms["Form4"] != null)
                Application.OpenForms["Form4"].Close();
            if (Application.OpenForms["Form5"] != null)
                Application.OpenForms["Form5"].Close();
            if (Application.OpenForms["Form12"] != null)
                Application.OpenForms["Form12"].Close();
            if (Application.OpenForms["Form7"] != null)
                Application.OpenForms["Form7"].Close();
            if (Application.OpenForms["Form8"] != null)
                Application.OpenForms["Form8"].Close();
            if (Application.OpenForms["Form9"] != null)
                Application.OpenForms["Form9"].Close();
            if (Application.OpenForms["Form13"] != null)
                Application.OpenForms["Form13"].Close();
            if (Application.OpenForms["Form14"] != null)
                Application.OpenForms["Form14"].Close();
            if (Application.OpenForms["Form15"] != null)
                Application.OpenForms["Form15"].Close();
            if (Application.OpenForms["Form16"] != null)
                Application.OpenForms["Form16"].Close();
            if (Application.OpenForms["Form26"] != null)
                Application.OpenForms["Form26"].Close();
            if (Application.OpenForms["Form27"] != null)
                Application.OpenForms["Form27"].Close();
            if (Application.OpenForms["Form29"] != null)
                Application.OpenForms["Form29"].Close();
            if (Application.OpenForms["Form30"] != null)
                Application.OpenForms["Form30"].Close();
            if (Application.OpenForms["Form31"] != null)
                Application.OpenForms["Form31"].Close();
            if (Application.OpenForms["Form32"] != null)
                Application.OpenForms["Form32"].Close();
            if (Application.OpenForms["Form33"] != null)
                Application.OpenForms["Form33"].Close();
            if (Application.OpenForms["Form35"] != null)
                Application.OpenForms["Form35"].Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Jogosult()
        {
            int itemFound = JogokBindingSource.Find("Jogosult", user);
            if (itemFound < 0)
                 MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                 MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            else
            {
                DataTable joguDataTable =dataSet1.Tables["Jogok"];
                joguDataTable.PrimaryKey =
                     new DataColumn[]
                    {
                     joguDataTable.Columns["Jogosult"]
                    };
                DataRow jogi = joguDataTable.Rows.Find(user);
                foreach (DataColumn myDataColumn in joguDataTable.Columns)
                {
                    jog = jogi["NonBom_Jog"].ToString();
                    pecset = jogi["Pecset"].ToString().Trim();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    v_cikk = "";
                    this.KeyPreview = false;
                    this.splitContainer1.Panel2.Controls.Clear();
                    this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
                    Keresmezo();
                    break;
                case Keys.F2:
                    FormZaras();
                    this.KeyPreview = false;
                    Form8 Form8 = new Form8();
                    ShowForm2(Form8);
                    break;
                case Keys.F3:
                    FormZaras();
                    this.KeyPreview = false;
                    Form9 Form9 = new Form9();
                    Form9.honnan = "2";
                    ShowForm2(Form9);
                    break;
                case Keys.F4:
                    FormZaras();
                    this.KeyPreview = false;
                    Form10 Form10 = new Form10();
                    ShowForm2(Form10);
                    break;
                case Keys.F5:
                    FormZaras();
                    this.KeyPreview = false;
                    Form12 Form12 = new Form12();
                    Form12.pecset = pecset;
                    ShowForm2(Form12);
                    break;
                case Keys.F6:
                    FormZaras();
                    this.KeyPreview = false;
                    Form13 Form13 = new Form13();
                    Form13.ShowDialog();
                    break;
                case Keys.F7:
                    FormZaras();
                    this.KeyPreview = false;
                    Form14 Form14 = new Form14();
                    ShowForm2(Form14);
                    break;
                case Keys.F8:
                    honnan = "0";
                    Kiadas();
                    break;
                case Keys.F9:
                    FormZaras();
                    this.KeyPreview = false;
                    Form16 Form16 = new Form16();
                 //   Form16.pecset = pecset;
                    ShowForm2(Form16);
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.vNB_SC010300_StockfileTableAdapter.Fill(this.dataSet1.VNB_SC010300_Stockfile);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string wkeres = " ";

            string seekValue = this.textBox6.Text;
            if (seekValue != wkeres)
            {
                if (!string.IsNullOrEmpty(seekValue))
                {
                    crystalNyilvBindingSource.Filter = "Cim like '%" + seekValue + "%'";
                }
                else
                {
                    try
                    {
                        crystalNyilvBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                wkeres = seekValue;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            v_report = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox6.Clear();
            FormZaras();
            Form27 Form27 = new Form27();
            Form27.v_report = v_report;
            ShowForm2(Form27);
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                v_report = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                textBox6.Clear();
                FormZaras();
                Form27 Form27 = new Form27();
                Form27.v_report = v_report;
                ShowForm2(Form27);
            }
        }

        private void ShowForm3(Form sender)
        {
           sender.TopLevel = false;
           this.splitContainer1.Panel2.Controls.Clear(); //clear panel first
            this.splitContainer1.Panel2.Controls.Add(sender);
            sender.Show();
        }

        private void Kiadas()
        {
            if (jog.Trim() == "A" || jog.Trim() == "R" || jog.Trim() == "E")
            {
                FormZaras();
                this.KeyPreview = false;
                Form15 Form15 = new Form15();
                Form15.pecset = pecset;
                Form15.honnan = honnan;
                ShowForm2(Form15);
            }
            else
            {
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                treeView1.SelectedNode = treeView1.Nodes["Node20"];
            }
        }

        private void ShowForm2(Form sender)
        {
            //   sender.MdiParent = this;
            sender.TopLevel = false;
            sender.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear(); //clear panel first
            this.splitContainer1.Panel2.Controls.Add(sender);
            sender.Show();
        }




    }
}
