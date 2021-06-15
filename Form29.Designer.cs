namespace NonBom
{
    partial class Form29
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.felhasznalasDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet29 = new NonBom.DataSet29();
            this.felhasznalasDataTableTableAdapter = new NonBom.DataSet29TableAdapters.FelhasznalasDataTableTableAdapter();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terület = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEgys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktsghKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktsghNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igenyloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gepKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gepMegnevezesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felhIdejeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.felhasznalasDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet29)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cikkszamDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.internRem1DataGridViewTextBoxColumn,
            this.Terület,
            this.raktarDataGridViewTextBoxColumn,
            this.polcDataGridViewTextBoxColumn,
            this.mennyisegDataGridViewTextBoxColumn,
            this.MEgys,
            this.ktsghKodDataGridViewTextBoxColumn,
            this.ktsghNevDataGridViewTextBoxColumn,
            this.igenyloDataGridViewTextBoxColumn,
            this.TSz,
            this.textDescriptionDataGridViewTextBoxColumn,
            this.kiadtaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.gepKodDataGridViewTextBoxColumn,
            this.gepMegnevezesDataGridViewTextBoxColumn,
            this.felhIdejeDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.felhasznalasDataTableBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 630);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // felhasznalasDataTableBindingSource
            // 
            this.felhasznalasDataTableBindingSource.DataMember = "FelhasznalasDataTable";
            this.felhasznalasDataTableBindingSource.DataSource = this.dataSet29;
            // 
            // dataSet29
            // 
            this.dataSet29.DataSetName = "DataSet29";
            this.dataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // felhasznalasDataTableTableAdapter
            // 
            this.felhasznalasDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            this.cikkszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // description1DataGridViewTextBoxColumn
            // 
            this.description1DataGridViewTextBoxColumn.DataPropertyName = "Description1";
            this.description1DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.description1DataGridViewTextBoxColumn.Name = "description1DataGridViewTextBoxColumn";
            this.description1DataGridViewTextBoxColumn.ReadOnly = true;
            this.description1DataGridViewTextBoxColumn.Width = 200;
            // 
            // description2DataGridViewTextBoxColumn
            // 
            this.description2DataGridViewTextBoxColumn.DataPropertyName = "Description2";
            this.description2DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.description2DataGridViewTextBoxColumn.Name = "description2DataGridViewTextBoxColumn";
            this.description2DataGridViewTextBoxColumn.ReadOnly = true;
            this.description2DataGridViewTextBoxColumn.Width = 150;
            // 
            // internRem1DataGridViewTextBoxColumn
            // 
            this.internRem1DataGridViewTextBoxColumn.DataPropertyName = "InternRem1";
            this.internRem1DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.internRem1DataGridViewTextBoxColumn.Name = "internRem1DataGridViewTextBoxColumn";
            this.internRem1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Terület
            // 
            this.Terület.DataPropertyName = "Terület";
            this.Terület.HeaderText = "Terület";
            this.Terület.Name = "Terület";
            this.Terület.ReadOnly = true;
            // 
            // raktarDataGridViewTextBoxColumn
            // 
            this.raktarDataGridViewTextBoxColumn.DataPropertyName = "Raktar";
            this.raktarDataGridViewTextBoxColumn.HeaderText = "Raktár";
            this.raktarDataGridViewTextBoxColumn.Name = "raktarDataGridViewTextBoxColumn";
            this.raktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.raktarDataGridViewTextBoxColumn.Width = 50;
            // 
            // polcDataGridViewTextBoxColumn
            // 
            this.polcDataGridViewTextBoxColumn.DataPropertyName = "Polc";
            this.polcDataGridViewTextBoxColumn.HeaderText = "Polc";
            this.polcDataGridViewTextBoxColumn.Name = "polcDataGridViewTextBoxColumn";
            this.polcDataGridViewTextBoxColumn.ReadOnly = true;
            this.polcDataGridViewTextBoxColumn.Width = 60;
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            this.mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.mennyisegDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            this.mennyisegDataGridViewTextBoxColumn.ReadOnly = true;
            this.mennyisegDataGridViewTextBoxColumn.Width = 80;
            // 
            // MEgys
            // 
            this.MEgys.DataPropertyName = "MEgys";
            this.MEgys.HeaderText = "M.Egys.";
            this.MEgys.Name = "MEgys";
            this.MEgys.ReadOnly = true;
            this.MEgys.Width = 40;
            // 
            // ktsghKodDataGridViewTextBoxColumn
            // 
            this.ktsghKodDataGridViewTextBoxColumn.DataPropertyName = "KtsghKod";
            this.ktsghKodDataGridViewTextBoxColumn.HeaderText = "KtsghKód";
            this.ktsghKodDataGridViewTextBoxColumn.Name = "ktsghKodDataGridViewTextBoxColumn";
            this.ktsghKodDataGridViewTextBoxColumn.ReadOnly = true;
            this.ktsghKodDataGridViewTextBoxColumn.Width = 80;
            // 
            // ktsghNevDataGridViewTextBoxColumn
            // 
            this.ktsghNevDataGridViewTextBoxColumn.DataPropertyName = "KtsghNev";
            this.ktsghNevDataGridViewTextBoxColumn.HeaderText = "KtsghNév";
            this.ktsghNevDataGridViewTextBoxColumn.Name = "ktsghNevDataGridViewTextBoxColumn";
            this.ktsghNevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // igenyloDataGridViewTextBoxColumn
            // 
            this.igenyloDataGridViewTextBoxColumn.DataPropertyName = "Igenylo";
            this.igenyloDataGridViewTextBoxColumn.HeaderText = "Igénylő";
            this.igenyloDataGridViewTextBoxColumn.Name = "igenyloDataGridViewTextBoxColumn";
            this.igenyloDataGridViewTextBoxColumn.ReadOnly = true;
            this.igenyloDataGridViewTextBoxColumn.Width = 60;
            // 
            // TSz
            // 
            this.TSz.DataPropertyName = "TSz";
            this.TSz.HeaderText = "TSz";
            this.TSz.Name = "TSz";
            this.TSz.ReadOnly = true;
            this.TSz.Width = 70;
            // 
            // textDescriptionDataGridViewTextBoxColumn
            // 
            this.textDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TextDescription";
            this.textDescriptionDataGridViewTextBoxColumn.HeaderText = "Igénylő Neve";
            this.textDescriptionDataGridViewTextBoxColumn.Name = "textDescriptionDataGridViewTextBoxColumn";
            this.textDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kiadtaDataGridViewTextBoxColumn
            // 
            this.kiadtaDataGridViewTextBoxColumn.DataPropertyName = "Kiadta";
            this.kiadtaDataGridViewTextBoxColumn.HeaderText = "Kiadta";
            this.kiadtaDataGridViewTextBoxColumn.Name = "kiadtaDataGridViewTextBoxColumn";
            this.kiadtaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kiadtaDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kiadta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gepKodDataGridViewTextBoxColumn
            // 
            this.gepKodDataGridViewTextBoxColumn.DataPropertyName = "GepKod";
            this.gepKodDataGridViewTextBoxColumn.HeaderText = "GépKód";
            this.gepKodDataGridViewTextBoxColumn.Name = "gepKodDataGridViewTextBoxColumn";
            this.gepKodDataGridViewTextBoxColumn.ReadOnly = true;
            this.gepKodDataGridViewTextBoxColumn.Width = 60;
            // 
            // gepMegnevezesDataGridViewTextBoxColumn
            // 
            this.gepMegnevezesDataGridViewTextBoxColumn.DataPropertyName = "GepMegnevezes";
            this.gepMegnevezesDataGridViewTextBoxColumn.HeaderText = "Gép Megnevezés";
            this.gepMegnevezesDataGridViewTextBoxColumn.Name = "gepMegnevezesDataGridViewTextBoxColumn";
            this.gepMegnevezesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // felhIdejeDataGridViewTextBoxColumn
            // 
            this.felhIdejeDataGridViewTextBoxColumn.DataPropertyName = "FelhIdeje";
            this.felhIdejeDataGridViewTextBoxColumn.HeaderText = "Felh. Ideje";
            this.felhIdejeDataGridViewTextBoxColumn.Name = "felhIdejeDataGridViewTextBoxColumn";
            this.felhIdejeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // megjegyzesDataGridViewTextBoxColumn
            // 
            this.megjegyzesDataGridViewTextBoxColumn.DataPropertyName = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.HeaderText = "Megjegyzés";
            this.megjegyzesDataGridViewTextBoxColumn.Name = "megjegyzesDataGridViewTextBoxColumn";
            this.megjegyzesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "Összesen :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel2.Text = "Tételek száma :";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(151, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel4.Text = "Mennyiség :";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(151, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // Form29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 652);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form29";
            this.ShowIcon = false;
            this.Text = "Felhasználások/Kiadások Részletes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form29_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.felhasznalasDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet29)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet29 dataSet29;
        private System.Windows.Forms.BindingSource felhasznalasDataTableBindingSource;
        private DataSet29TableAdapters.FelhasznalasDataTableTableAdapter felhasznalasDataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDescription1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terület;
        private System.Windows.Forms.DataGridViewTextBoxColumn raktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEgys;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktsghKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktsghNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igenyloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSz;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gepKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gepMegnevezesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felhIdejeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}