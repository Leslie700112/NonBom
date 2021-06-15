namespace NonBom
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.szolgaltatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkahelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gepSzerszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSZNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beruszamRACFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deviza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igenyloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megnevezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csatolmany = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nBSzolgaltatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet19 = new NonBom.DataSet19();
            this.nBSzolgaltatasTableAdapter = new NonBom.DataSet19TableAdapters.NBSzolgaltatasTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet19)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1184, 39);
            this.toolStrip1.TabIndex = 1;
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
            this.toolStripButton2.Size = new System.Drawing.Size(131, 36);
            this.toolStripButton2.Text = "Engedélyezés";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.gepSzerszamDataGridViewTextBoxColumn,
            this.gSZNevDataGridViewTextBoxColumn,
            this.beruszamRACFDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.Ar,
            this.Deviza,
            this.igenyloDataGridViewTextBoxColumn,
            this.statuszDataGridViewTextBoxColumn,
            this.IDS,
            this.Megnevezes,
            this.Csatolmany});
            this.dataGridView1.DataSource = this.nBSzolgaltatasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 521);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
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
            // gepSzerszamDataGridViewTextBoxColumn
            // 
            this.gepSzerszamDataGridViewTextBoxColumn.DataPropertyName = "GepSzerszam";
            this.gepSzerszamDataGridViewTextBoxColumn.HeaderText = "Gép / Szerszám";
            this.gepSzerszamDataGridViewTextBoxColumn.Name = "gepSzerszamDataGridViewTextBoxColumn";
            this.gepSzerszamDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Ar
            // 
            this.Ar.DataPropertyName = "Ar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Ar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ar.HeaderText = "Ajánlott Ár";
            this.Ar.Name = "Ar";
            this.Ar.Width = 80;
            // 
            // Deviza
            // 
            this.Deviza.DataPropertyName = "Deviza";
            this.Deviza.HeaderText = "Dev.";
            this.Deviza.Name = "Deviza";
            this.Deviza.Width = 60;
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
            // IDS
            // 
            this.IDS.DataPropertyName = "IDS";
            this.IDS.HeaderText = "IDS";
            this.IDS.Name = "IDS";
            this.IDS.ReadOnly = true;
            this.IDS.Visible = false;
            // 
            // Megnevezes
            // 
            this.Megnevezes.DataPropertyName = "Megnevezes";
            this.Megnevezes.HeaderText = "Megnevezes";
            this.Megnevezes.Name = "Megnevezes";
            // 
            // Csatolmany
            // 
            this.Csatolmany.DataPropertyName = "Csatolmany";
            this.Csatolmany.HeaderText = "Csatolmany";
            this.Csatolmany.Name = "Csatolmany";
            this.Csatolmany.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Csatolmany.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nBSzolgaltatasBindingSource
            // 
            this.nBSzolgaltatasBindingSource.DataMember = "NBSzolgaltatas";
            this.nBSzolgaltatasBindingSource.DataSource = this.dataSet19;
            // 
            // dataSet19
            // 
            this.dataSet19.DataSetName = "DataSet19";
            this.dataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBSzolgaltatasTableAdapter
            // 
            this.nBSzolgaltatasTableAdapter.ClearBeforeFill = true;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form19";
            this.Text = "Szolgáltatások Engedélyezése";
            this.Load += new System.EventHandler(this.Form19_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet19 dataSet19;
        private System.Windows.Forms.BindingSource nBSzolgaltatasBindingSource;
        private DataSet19TableAdapters.NBSzolgaltatasTableAdapter nBSzolgaltatasTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn szolgaltatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkahelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gepSzerszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSZNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beruszamRACFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deviza;
        private System.Windows.Forms.DataGridViewTextBoxColumn igenyloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megnevezes;
        private System.Windows.Forms.DataGridViewLinkColumn Csatolmany;
    }
}