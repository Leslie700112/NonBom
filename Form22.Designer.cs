namespace NonBom
{
    partial class Form22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nBSzolgaltatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet22 = new NonBom.DataSet22();
            this.nBSzolgaltatasTableAdapter = new NonBom.DataSet22TableAdapters.NBSzolgaltatasTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.szolgaltatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkahelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSZNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beruszamRACFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igenyloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendSorszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzamlazottAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KltsgHNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IktatoSzam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koltseghely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1235, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(148, 36);
            this.toolStripButton1.Text = "Összeskijelölése";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(160, 36);
            this.toolStripButton2.Text = "Teljesítés Igazolás";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.szolgaltatoDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.munkahelyDataGridViewTextBoxColumn,
            this.gSZNevDataGridViewTextBoxColumn,
            this.beruszamRACFDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.igenyloDataGridViewTextBoxColumn,
            this.statuszDataGridViewTextBoxColumn,
            this.iDSDataGridViewTextBoxColumn,
            this.rendelesSzamDataGridViewTextBoxColumn,
            this.rendSorszamDataGridViewTextBoxColumn,
            this.arDataGridViewTextBoxColumn,
            this.SzamlazottAr,
            this.devizaDataGridViewTextBoxColumn,
            this.KltsgHNev,
            this.IktatoSzam,
            this.Koltseghely});
            this.dataGridView1.DataSource = this.nBSzolgaltatasBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 549);
            this.dataGridView1.TabIndex = 3;
            // 
            // nBSzolgaltatasBindingSource
            // 
            this.nBSzolgaltatasBindingSource.DataMember = "NBSzolgaltatas";
            this.nBSzolgaltatasBindingSource.DataSource = this.dataSet22;
            // 
            // dataSet22
            // 
            this.dataSet22.DataSetName = "DataSet22";
            this.dataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBSzolgaltatasTableAdapter
            // 
            this.nBSzolgaltatasTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.TrueValue = "true";
            this.Column1.Width = 35;
            // 
            // szolgaltatoDataGridViewTextBoxColumn
            // 
            this.szolgaltatoDataGridViewTextBoxColumn.DataPropertyName = "Szolgaltato";
            this.szolgaltatoDataGridViewTextBoxColumn.HeaderText = "Szolg.Kód";
            this.szolgaltatoDataGridViewTextBoxColumn.Name = "szolgaltatoDataGridViewTextBoxColumn";
            this.szolgaltatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.szolgaltatoDataGridViewTextBoxColumn.Width = 80;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szolgáltató Neve";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // munkahelyDataGridViewTextBoxColumn
            // 
            this.munkahelyDataGridViewTextBoxColumn.DataPropertyName = "Munkahely";
            this.munkahelyDataGridViewTextBoxColumn.HeaderText = "Munkahely";
            this.munkahelyDataGridViewTextBoxColumn.Name = "munkahelyDataGridViewTextBoxColumn";
            this.munkahelyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gSZNevDataGridViewTextBoxColumn
            // 
            this.gSZNevDataGridViewTextBoxColumn.DataPropertyName = "GSZNev";
            this.gSZNevDataGridViewTextBoxColumn.HeaderText = "Gép / Szerszám Név";
            this.gSZNevDataGridViewTextBoxColumn.Name = "gSZNevDataGridViewTextBoxColumn";
            this.gSZNevDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSZNevDataGridViewTextBoxColumn.Width = 300;
            // 
            // beruszamRACFDataGridViewTextBoxColumn
            // 
            this.beruszamRACFDataGridViewTextBoxColumn.DataPropertyName = "BeruszamRACF";
            this.beruszamRACFDataGridViewTextBoxColumn.HeaderText = "Beruházás/RACF Szám";
            this.beruszamRACFDataGridViewTextBoxColumn.Name = "beruszamRACFDataGridViewTextBoxColumn";
            this.beruszamRACFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // megjegyzesDataGridViewTextBoxColumn
            // 
            this.megjegyzesDataGridViewTextBoxColumn.DataPropertyName = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.HeaderText = "Szolgáltatási Igény Leírása";
            this.megjegyzesDataGridViewTextBoxColumn.Name = "megjegyzesDataGridViewTextBoxColumn";
            this.megjegyzesDataGridViewTextBoxColumn.ReadOnly = true;
            this.megjegyzesDataGridViewTextBoxColumn.Width = 300;
            // 
            // igenyloDataGridViewTextBoxColumn
            // 
            this.igenyloDataGridViewTextBoxColumn.DataPropertyName = "Igenylo";
            this.igenyloDataGridViewTextBoxColumn.HeaderText = "Igénylő";
            this.igenyloDataGridViewTextBoxColumn.Name = "igenyloDataGridViewTextBoxColumn";
            this.igenyloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statuszDataGridViewTextBoxColumn
            // 
            this.statuszDataGridViewTextBoxColumn.DataPropertyName = "Statusz";
            this.statuszDataGridViewTextBoxColumn.HeaderText = "Statusz";
            this.statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            this.statuszDataGridViewTextBoxColumn.ReadOnly = true;
            this.statuszDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSDataGridViewTextBoxColumn
            // 
            this.iDSDataGridViewTextBoxColumn.DataPropertyName = "IDS";
            this.iDSDataGridViewTextBoxColumn.HeaderText = "IDS";
            this.iDSDataGridViewTextBoxColumn.Name = "iDSDataGridViewTextBoxColumn";
            this.iDSDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSDataGridViewTextBoxColumn.Visible = false;
            // 
            // rendelesSzamDataGridViewTextBoxColumn
            // 
            this.rendelesSzamDataGridViewTextBoxColumn.DataPropertyName = "RendelesSzam";
            this.rendelesSzamDataGridViewTextBoxColumn.HeaderText = "RendelesSzam";
            this.rendelesSzamDataGridViewTextBoxColumn.Name = "rendelesSzamDataGridViewTextBoxColumn";
            this.rendelesSzamDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendelesSzamDataGridViewTextBoxColumn.Visible = false;
            // 
            // rendSorszamDataGridViewTextBoxColumn
            // 
            this.rendSorszamDataGridViewTextBoxColumn.DataPropertyName = "RendSorszam";
            this.rendSorszamDataGridViewTextBoxColumn.HeaderText = "RendSorszam";
            this.rendSorszamDataGridViewTextBoxColumn.Name = "rendSorszamDataGridViewTextBoxColumn";
            this.rendSorszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendSorszamDataGridViewTextBoxColumn.Visible = false;
            // 
            // arDataGridViewTextBoxColumn
            // 
            this.arDataGridViewTextBoxColumn.DataPropertyName = "Ar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.arDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.arDataGridViewTextBoxColumn.HeaderText = "Ajánlott Ár";
            this.arDataGridViewTextBoxColumn.Name = "arDataGridViewTextBoxColumn";
            this.arDataGridViewTextBoxColumn.ReadOnly = true;
            this.arDataGridViewTextBoxColumn.Width = 80;
            // 
            // SzamlazottAr
            // 
            this.SzamlazottAr.DataPropertyName = "SzamlazottAr";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.SzamlazottAr.DefaultCellStyle = dataGridViewCellStyle3;
            this.SzamlazottAr.HeaderText = "Számlázott Ár";
            this.SzamlazottAr.Name = "SzamlazottAr";
            this.SzamlazottAr.ReadOnly = true;
            this.SzamlazottAr.Width = 80;
            // 
            // devizaDataGridViewTextBoxColumn
            // 
            this.devizaDataGridViewTextBoxColumn.DataPropertyName = "Deviza";
            this.devizaDataGridViewTextBoxColumn.HeaderText = "Dev.";
            this.devizaDataGridViewTextBoxColumn.Name = "devizaDataGridViewTextBoxColumn";
            this.devizaDataGridViewTextBoxColumn.ReadOnly = true;
            this.devizaDataGridViewTextBoxColumn.Width = 60;
            // 
            // KltsgHNev
            // 
            this.KltsgHNev.DataPropertyName = "KltsgHNev";
            this.KltsgHNev.HeaderText = "Kltsg.H.Név";
            this.KltsgHNev.Name = "KltsgHNev";
            this.KltsgHNev.ReadOnly = true;
            // 
            // IktatoSzam
            // 
            this.IktatoSzam.DataPropertyName = "IktatoSzam";
            this.IktatoSzam.HeaderText = "Iktató Szám";
            this.IktatoSzam.Name = "IktatoSzam";
            this.IktatoSzam.ReadOnly = true;
            // 
            // Koltseghely
            // 
            this.Koltseghely.DataPropertyName = "Koltseghely";
            this.Koltseghely.HeaderText = "Költséghely";
            this.Koltseghely.Name = "Koltseghely";
            this.Koltseghely.ReadOnly = true;
            this.Koltseghely.Visible = false;
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form22";
            this.Text = "Teljesítés Igazolás";
            this.Load += new System.EventHandler(this.Form22_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet22 dataSet22;
        private System.Windows.Forms.BindingSource nBSzolgaltatasBindingSource;
        private DataSet22TableAdapters.NBSzolgaltatasTableAdapter nBSzolgaltatasTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn szolgaltatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkahelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSZNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beruszamRACFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igenyloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelesSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendSorszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzamlazottAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn devizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KltsgHNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn IktatoSzam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koltseghely;
    }
}