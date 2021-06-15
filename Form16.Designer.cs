namespace NonBom
{
    partial class Form16
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.purchaOrdNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppCodBuyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deviza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNBPC030300POLineFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet9 = new NonBom.DataSet9();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.vNB_PC030300_POLineFileTableAdapter = new NonBom.DataSet9TableAdapters.VNB_PC030300_POLineFileTableAdapter();
            this.JogokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet91 = new NonBom.DataSet9();
            this.jogokTableAdapter = new NonBom.DataSet9TableAdapters.JogokTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBPC030300POLineFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JogokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet91)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(1279, 676);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 0;
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
            this.purchaOrdNoDataGridViewTextBoxColumn,
            this.linesDataGridViewTextBoxColumn,
            this.suppCodBuyerDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.orderValueDataGridViewTextBoxColumn,
            this.Deviza,
            this.orderDateDataGridViewTextBoxColumn,
            this.rendelesSzamDataGridViewTextBoxColumn,
            this.kerteDataGridViewTextBoxColumn,
            this.Status});
            this.dataGridView1.DataSource = this.vNBPC030300POLineFileBindingSource;
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
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // purchaOrdNoDataGridViewTextBoxColumn
            // 
            this.purchaOrdNoDataGridViewTextBoxColumn.DataPropertyName = "PurchaOrdNo";
            this.purchaOrdNoDataGridViewTextBoxColumn.HeaderText = "Rendelésszám";
            this.purchaOrdNoDataGridViewTextBoxColumn.Name = "purchaOrdNoDataGridViewTextBoxColumn";
            this.purchaOrdNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linesDataGridViewTextBoxColumn
            // 
            this.linesDataGridViewTextBoxColumn.DataPropertyName = "Lines";
            this.linesDataGridViewTextBoxColumn.HeaderText = "Rend.S. Szám";
            this.linesDataGridViewTextBoxColumn.Name = "linesDataGridViewTextBoxColumn";
            this.linesDataGridViewTextBoxColumn.ReadOnly = true;
            this.linesDataGridViewTextBoxColumn.Width = 120;
            // 
            // suppCodBuyerDataGridViewTextBoxColumn
            // 
            this.suppCodBuyerDataGridViewTextBoxColumn.DataPropertyName = "SuppCodBuyer";
            this.suppCodBuyerDataGridViewTextBoxColumn.HeaderText = "Szállító Kód";
            this.suppCodBuyerDataGridViewTextBoxColumn.Name = "suppCodBuyerDataGridViewTextBoxColumn";
            this.suppCodBuyerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // orderValueDataGridViewTextBoxColumn
            // 
            this.orderValueDataGridViewTextBoxColumn.DataPropertyName = "OrderValue";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.orderValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderValueDataGridViewTextBoxColumn.HeaderText = "Rendelt Érték";
            this.orderValueDataGridViewTextBoxColumn.Name = "orderValueDataGridViewTextBoxColumn";
            this.orderValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // Deviza
            // 
            this.Deviza.DataPropertyName = "Deviza";
            this.Deviza.HeaderText = "Dev.";
            this.Deviza.Name = "Deviza";
            this.Deviza.ReadOnly = true;
            this.Deviza.Width = 60;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Rendelés Ideje";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // rendelesSzamDataGridViewTextBoxColumn
            // 
            this.rendelesSzamDataGridViewTextBoxColumn.DataPropertyName = "RendelesSzam";
            this.rendelesSzamDataGridViewTextBoxColumn.HeaderText = "Rendelés Szám";
            this.rendelesSzamDataGridViewTextBoxColumn.Name = "rendelesSzamDataGridViewTextBoxColumn";
            this.rendelesSzamDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendelesSzamDataGridViewTextBoxColumn.Width = 120;
            // 
            // kerteDataGridViewTextBoxColumn
            // 
            this.kerteDataGridViewTextBoxColumn.DataPropertyName = "Kerte";
            this.kerteDataGridViewTextBoxColumn.HeaderText = "Igénylő";
            this.kerteDataGridViewTextBoxColumn.Name = "kerteDataGridViewTextBoxColumn";
            this.kerteDataGridViewTextBoxColumn.ReadOnly = true;
            this.kerteDataGridViewTextBoxColumn.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // vNBPC030300POLineFileBindingSource
            // 
            this.vNBPC030300POLineFileBindingSource.DataMember = "VNB_PC030300_POLineFile";
            this.vNBPC030300POLineFileBindingSource.DataSource = this.dataSet9;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // vNB_PC030300_POLineFileTableAdapter
            // 
            this.vNB_PC030300_POLineFileTableAdapter.ClearBeforeFill = true;
            // 
            // JogokBindingSource
            // 
            this.JogokBindingSource.DataMember = "Jogok";
            this.JogokBindingSource.DataSource = this.dataSet91;
            // 
            // dataSet91
            // 
            this.dataSet91.DataSetName = "DataSet9";
            this.dataSet91.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogokTableAdapter
            // 
            this.jogokTableAdapter.ClearBeforeFill = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 676);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.Text = "Beszerzési Rendelés (PO) Nyomtatás";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form16_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBPC030300POLineFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JogokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet91)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet9 dataSet9;
        private System.Windows.Forms.BindingSource vNBPC030300POLineFileBindingSource;
        private DataSet9TableAdapters.VNB_PC030300_POLineFileTableAdapter vNB_PC030300_POLineFileTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.BindingSource JogokBindingSource;
        private DataSet9 dataSet91;
        private DataSet9TableAdapters.JogokTableAdapter jogokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaOrdNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppCodBuyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deviza;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelesSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}