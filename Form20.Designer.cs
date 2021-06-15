namespace NonBom
{
    partial class Form20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form20));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nBSzolgaltatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet20 = new NonBom.DataSet20();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.nBSzolgaltatasTableAdapter = new NonBom.DataSet20TableAdapters.NBSzolgaltatasTableAdapter();
            this.JogokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogokTableAdapter1 = new NonBom.DataSet20TableAdapters.JogokTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szolgaltatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkahelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSZNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beruszamRACFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igenyloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RendIdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statusz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JogokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1174, 597);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.szolgaltatoDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.munkahelyDataGridViewTextBoxColumn,
            this.gSZNevDataGridViewTextBoxColumn,
            this.beruszamRACFDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.igenyloDataGridViewTextBoxColumn,
            this.RendIdo,
            this.Expr1,
            this.Statusz});
            this.dataGridView1.DataSource = this.nBSzolgaltatasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // nBSzolgaltatasBindingSource
            // 
            this.nBSzolgaltatasBindingSource.DataMember = "NBSzolgaltatas";
            this.nBSzolgaltatasBindingSource.DataSource = this.dataSet20;
            // 
            // dataSet20
            // 
            this.dataSet20.DataSetName = "DataSet20";
            this.dataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(774, 485);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // nBSzolgaltatasTableAdapter
            // 
            this.nBSzolgaltatasTableAdapter.ClearBeforeFill = true;
            // 
            // JogokBindingSource
            // 
            this.JogokBindingSource.DataMember = "Jogok";
            this.JogokBindingSource.DataSource = this.dataSet20;
            // 
            // jogokTableAdapter1
            // 
            this.jogokTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
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
            this.gSZNevDataGridViewTextBoxColumn.Width = 400;
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
            this.megjegyzesDataGridViewTextBoxColumn.Width = 400;
            // 
            // igenyloDataGridViewTextBoxColumn
            // 
            this.igenyloDataGridViewTextBoxColumn.DataPropertyName = "Igenylo";
            this.igenyloDataGridViewTextBoxColumn.HeaderText = "Igénylő";
            this.igenyloDataGridViewTextBoxColumn.Name = "igenyloDataGridViewTextBoxColumn";
            this.igenyloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RendIdo
            // 
            this.RendIdo.DataPropertyName = "RendIdo";
            this.RendIdo.HeaderText = "Rend.Idő";
            this.RendIdo.Name = "RendIdo";
            this.RendIdo.ReadOnly = true;
            // 
            // Expr1
            // 
            this.Expr1.DataPropertyName = "Expr1";
            this.Expr1.HeaderText = "Engedélyezte";
            this.Expr1.Name = "Expr1";
            this.Expr1.ReadOnly = true;
            // 
            // Statusz
            // 
            this.Statusz.DataPropertyName = "Statusz";
            this.Statusz.HeaderText = "Statusz";
            this.Statusz.Name = "Statusz";
            this.Statusz.ReadOnly = true;
            this.Statusz.Visible = false;
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 597);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form20";
            this.Text = "Megrendelő Nyomtatás";
            this.Load += new System.EventHandler(this.Form20_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JogokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet20 dataSet20;
        private System.Windows.Forms.BindingSource nBSzolgaltatasBindingSource;
        private DataSet20TableAdapters.NBSzolgaltatasTableAdapter nBSzolgaltatasTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gepSzerszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.BindingSource JogokBindingSource;
        private DataSet20TableAdapters.JogokTableAdapter jogokTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szolgaltatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkahelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSZNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beruszamRACFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igenyloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RendIdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statusz;
    }
}