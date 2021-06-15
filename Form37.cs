using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using DgvFilterPopup;

namespace NonBom
{
    public partial class Form37 : Form
    {
      
        public Form37()
        {
            InitializeComponent();
          
        }

        private void Form37_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet37.NBCetLeeFej' table. You can move, or remove it, as needed.
            this.nBCetLeeFejTableAdapter.Fill(this.dataSet37.NBCetLeeFej);

            DgvFilterManager fm = new DgvFilterManager();
            fm.DataGridView = dataGridView1;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dataGridView1.HitTest(e.X, e.Y).RowIndex >= 0)
            {
              dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Cells[0];
              CetleeSorok();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.nBCetLeeFejTableAdapter.Fill(this.dataSet37.NBCetLeeFej);
        }
  
        private void CetleeSorok()
        {
            int AktSor = dataGridView1.CurrentCell.RowIndex;
            Form38 Form38 = new Form38();
            Form38.Ugyintez= this.dataGridView1.CurrentRow.Cells["keszitetteDataGridViewTextBoxColumn"].Value.ToString();
            Form38.LetrehozIdo = this.dataGridView1.CurrentRow.Cells["letrehozasIdejeDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Tranzsz= this.dataGridView1.CurrentRow.Cells["tranzakcioSzamDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Szall= this.dataGridView1.CurrentRow.Cells["szallitoDataGridViewTextBoxColumn"].Value.ToString();
            Form38.SzallNev= this.dataGridView1.CurrentRow.Cells["supplierNameDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Szlaszam= this.dataGridView1.CurrentRow.Cells["invoiceNoDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Szlaido=Convert.ToDateTime( this.dataGridView1.CurrentRow.Cells["invoiceDate1DataGridViewTextBoxColumn"].Value).ToString("yyyy.MM.dd");
            Form38.Osszeg = this.dataGridView1.CurrentRow.Cells["osszegDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Arfoly = this.dataGridView1.CurrentRow.Cells["arfolyamDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Netto= this.dataGridView1.CurrentRow.Cells["nettoDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Deviza= this.dataGridView1.CurrentRow.Cells["devizaDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Afakod= this.dataGridView1.CurrentRow.Cells["vATCodeDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Afa= this.dataGridView1.CurrentRow.Cells["afaDataGridViewTextBoxColumn"].Value.ToString();
            Form38.AfaNev = this.dataGridView1.CurrentRow.Cells["vATDescDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Fksz= this.dataGridView1.CurrentRow.Cells["bruttoFKSZDataGridViewTextBoxColumn"].Value.ToString();
            Form38.ElterO= this.dataGridView1.CurrentRow.Cells["elteresODataGridViewTextBoxColumn"].Value.ToString();
            Form38.ElterSz= this.dataGridView1.CurrentRow.Cells["elteresSzDataGridViewTextBoxColumn"].Value.ToString();
            Form38.Enged= this.dataGridView1.CurrentRow.Cells["Engedelyezo"].Value.ToString();
            Form38.EngedIdo= this.dataGridView1.CurrentRow.Cells["EngedIdeje"].Value.ToString();
            Form38.ShowDialog();
            dataGridView1.CurrentCell = dataGridView1[0, AktSor];
        }



    }
}
