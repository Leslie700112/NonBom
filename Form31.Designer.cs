namespace NonBom
{
    partial class Form31
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet31 = new NonBom.DataSet31();
            this.nBLeltarAdatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nBLeltarAdatokTableAdapter = new NonBom.DataSet31TableAdapters.NBLeltarAdatokTableAdapter();
            this.bizszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leltIdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBLeltarAdatokBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.bizszamDataGridViewTextBoxColumn,
            this.cikkszamDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.internRem1DataGridViewTextBoxColumn,
            this.internRem2DataGridViewTextBoxColumn,
            this.mennyisegDataGridViewTextBoxColumn,
            this.megysDataGridViewTextBoxColumn,
            this.raktarDataGridViewTextBoxColumn,
            this.polcDataGridViewTextBoxColumn,
            this.leltIdoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nBLeltarAdatokBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 663);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet31
            // 
            this.dataSet31.DataSetName = "DataSet31";
            this.dataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBLeltarAdatokBindingSource
            // 
            this.nBLeltarAdatokBindingSource.DataMember = "NBLeltarAdatok";
            this.nBLeltarAdatokBindingSource.DataSource = this.dataSet31;
            // 
            // nBLeltarAdatokTableAdapter
            // 
            this.nBLeltarAdatokTableAdapter.ClearBeforeFill = true;
            // 
            // bizszamDataGridViewTextBoxColumn
            // 
            this.bizszamDataGridViewTextBoxColumn.DataPropertyName = "Bizszam";
            this.bizszamDataGridViewTextBoxColumn.HeaderText = "Biz.szám";
            this.bizszamDataGridViewTextBoxColumn.Name = "bizszamDataGridViewTextBoxColumn";
            this.bizszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            this.cikkszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikkszamDataGridViewTextBoxColumn.Width = 150;
            // 
            // description1DataGridViewTextBoxColumn
            // 
            this.description1DataGridViewTextBoxColumn.DataPropertyName = "Description1";
            this.description1DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.description1DataGridViewTextBoxColumn.Name = "description1DataGridViewTextBoxColumn";
            this.description1DataGridViewTextBoxColumn.ReadOnly = true;
            this.description1DataGridViewTextBoxColumn.Width = 300;
            // 
            // description2DataGridViewTextBoxColumn
            // 
            this.description2DataGridViewTextBoxColumn.DataPropertyName = "Description2";
            this.description2DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.description2DataGridViewTextBoxColumn.Name = "description2DataGridViewTextBoxColumn";
            this.description2DataGridViewTextBoxColumn.ReadOnly = true;
            this.description2DataGridViewTextBoxColumn.Width = 250;
            // 
            // internRem1DataGridViewTextBoxColumn
            // 
            this.internRem1DataGridViewTextBoxColumn.DataPropertyName = "InternRem1";
            this.internRem1DataGridViewTextBoxColumn.HeaderText = "Rajzszám";
            this.internRem1DataGridViewTextBoxColumn.Name = "internRem1DataGridViewTextBoxColumn";
            this.internRem1DataGridViewTextBoxColumn.ReadOnly = true;
            this.internRem1DataGridViewTextBoxColumn.Width = 150;
            // 
            // internRem2DataGridViewTextBoxColumn
            // 
            this.internRem2DataGridViewTextBoxColumn.DataPropertyName = "InternRem2";
            this.internRem2DataGridViewTextBoxColumn.HeaderText = "Rajzszám";
            this.internRem2DataGridViewTextBoxColumn.Name = "internRem2DataGridViewTextBoxColumn";
            this.internRem2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            this.mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.mennyisegDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            this.mennyisegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // megysDataGridViewTextBoxColumn
            // 
            this.megysDataGridViewTextBoxColumn.DataPropertyName = "Megys";
            this.megysDataGridViewTextBoxColumn.HeaderText = "M.egys.";
            this.megysDataGridViewTextBoxColumn.Name = "megysDataGridViewTextBoxColumn";
            this.megysDataGridViewTextBoxColumn.ReadOnly = true;
            this.megysDataGridViewTextBoxColumn.Width = 60;
            // 
            // raktarDataGridViewTextBoxColumn
            // 
            this.raktarDataGridViewTextBoxColumn.DataPropertyName = "Raktar";
            this.raktarDataGridViewTextBoxColumn.HeaderText = "Raktár";
            this.raktarDataGridViewTextBoxColumn.Name = "raktarDataGridViewTextBoxColumn";
            this.raktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.raktarDataGridViewTextBoxColumn.Width = 80;
            // 
            // polcDataGridViewTextBoxColumn
            // 
            this.polcDataGridViewTextBoxColumn.DataPropertyName = "Polc";
            this.polcDataGridViewTextBoxColumn.HeaderText = "Polc";
            this.polcDataGridViewTextBoxColumn.Name = "polcDataGridViewTextBoxColumn";
            this.polcDataGridViewTextBoxColumn.ReadOnly = true;
            this.polcDataGridViewTextBoxColumn.Width = 80;
            // 
            // leltIdoDataGridViewTextBoxColumn
            // 
            this.leltIdoDataGridViewTextBoxColumn.DataPropertyName = "LeltIdo";
            this.leltIdoDataGridViewTextBoxColumn.HeaderText = "Lelt.Idő";
            this.leltIdoDataGridViewTextBoxColumn.Name = "leltIdoDataGridViewTextBoxColumn";
            this.leltIdoDataGridViewTextBoxColumn.ReadOnly = true;
            this.leltIdoDataGridViewTextBoxColumn.Width = 130;
            // 
            // Form31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 663);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form31";
            this.Text = "Leltár Adatok";
            this.Load += new System.EventHandler(this.Form31_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBLeltarAdatokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet31 dataSet31;
        private System.Windows.Forms.BindingSource nBLeltarAdatokBindingSource;
        private DataSet31TableAdapters.NBLeltarAdatokTableAdapter nBLeltarAdatokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bizszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leltIdoDataGridViewTextBoxColumn;
    }
}