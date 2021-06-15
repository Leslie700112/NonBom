namespace NonBom
{
    partial class Form30
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form30));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet30 = new NonBom.DataSet30();
            this.dataTable1TableAdapter = new NonBom.DataSet30TableAdapters.DataTable1TableAdapter();
            this.purchaOrdNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCQtyOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCQtyReceiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCQtyInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pC19012DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delDateCommiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delDateActuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delDateRequeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchCreatDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet30)).BeginInit();
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
            this.purchaOrdNoDataGridViewTextBoxColumn,
            this.lineNumberDataGridViewTextBoxColumn,
            this.stockCodeDataGridViewTextBoxColumn,
            this.descriptLine1DataGridViewTextBoxColumn,
            this.descriptLine2DataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.currencyShortNameDataGridViewTextBoxColumn,
            this.pCQtyOrderedDataGridViewTextBoxColumn,
            this.pCQtyReceiveDataGridViewTextBoxColumn,
            this.pCQtyInvoiceDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.pC19012DataGridViewTextBoxColumn,
            this.delDateCommiDataGridViewTextBoxColumn,
            this.delDateActuaDataGridViewTextBoxColumn,
            this.delDateRequeDataGridViewTextBoxColumn,
            this.batchCreatDtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 635);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet30;
            // 
            // dataSet30
            // 
            this.dataSet30.DataSetName = "DataSet30";
            this.dataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // purchaOrdNoDataGridViewTextBoxColumn
            // 
            this.purchaOrdNoDataGridViewTextBoxColumn.DataPropertyName = "PurchaOrdNo";
            this.purchaOrdNoDataGridViewTextBoxColumn.HeaderText = "Rendelés Szám";
            this.purchaOrdNoDataGridViewTextBoxColumn.Name = "purchaOrdNoDataGridViewTextBoxColumn";
            this.purchaOrdNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineNumberDataGridViewTextBoxColumn
            // 
            this.lineNumberDataGridViewTextBoxColumn.DataPropertyName = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn.HeaderText = "Sorszám";
            this.lineNumberDataGridViewTextBoxColumn.Name = "lineNumberDataGridViewTextBoxColumn";
            this.lineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineNumberDataGridViewTextBoxColumn.Width = 70;
            // 
            // stockCodeDataGridViewTextBoxColumn
            // 
            this.stockCodeDataGridViewTextBoxColumn.DataPropertyName = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.stockCodeDataGridViewTextBoxColumn.Name = "stockCodeDataGridViewTextBoxColumn";
            this.stockCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptLine1DataGridViewTextBoxColumn
            // 
            this.descriptLine1DataGridViewTextBoxColumn.DataPropertyName = "DescriptLine1";
            this.descriptLine1DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.descriptLine1DataGridViewTextBoxColumn.Name = "descriptLine1DataGridViewTextBoxColumn";
            this.descriptLine1DataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptLine1DataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptLine2DataGridViewTextBoxColumn
            // 
            this.descriptLine2DataGridViewTextBoxColumn.DataPropertyName = "DescriptLine2";
            this.descriptLine2DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.descriptLine2DataGridViewTextBoxColumn.Name = "descriptLine2DataGridViewTextBoxColumn";
            this.descriptLine2DataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptLine2DataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "M.egys.";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 60;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.unitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Besz.Ár";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // currencyShortNameDataGridViewTextBoxColumn
            // 
            this.currencyShortNameDataGridViewTextBoxColumn.DataPropertyName = "CurrencyShortName";
            this.currencyShortNameDataGridViewTextBoxColumn.HeaderText = "Dev.";
            this.currencyShortNameDataGridViewTextBoxColumn.Name = "currencyShortNameDataGridViewTextBoxColumn";
            this.currencyShortNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyShortNameDataGridViewTextBoxColumn.Width = 50;
            // 
            // pCQtyOrderedDataGridViewTextBoxColumn
            // 
            this.pCQtyOrderedDataGridViewTextBoxColumn.DataPropertyName = "PCQtyOrdered";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.pCQtyOrderedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pCQtyOrderedDataGridViewTextBoxColumn.HeaderText = "Rendelt Mennyiség";
            this.pCQtyOrderedDataGridViewTextBoxColumn.Name = "pCQtyOrderedDataGridViewTextBoxColumn";
            this.pCQtyOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCQtyOrderedDataGridViewTextBoxColumn.Width = 80;
            // 
            // pCQtyReceiveDataGridViewTextBoxColumn
            // 
            this.pCQtyReceiveDataGridViewTextBoxColumn.DataPropertyName = "PCQtyReceive";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.pCQtyReceiveDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.pCQtyReceiveDataGridViewTextBoxColumn.HeaderText = "Bevételezett Mennyiség";
            this.pCQtyReceiveDataGridViewTextBoxColumn.Name = "pCQtyReceiveDataGridViewTextBoxColumn";
            this.pCQtyReceiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCQtyReceiveDataGridViewTextBoxColumn.Width = 80;
            // 
            // pCQtyInvoiceDataGridViewTextBoxColumn
            // 
            this.pCQtyInvoiceDataGridViewTextBoxColumn.DataPropertyName = "PCQtyInvoice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.pCQtyInvoiceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.pCQtyInvoiceDataGridViewTextBoxColumn.HeaderText = "Számlázott Mennyiség";
            this.pCQtyInvoiceDataGridViewTextBoxColumn.Name = "pCQtyInvoiceDataGridViewTextBoxColumn";
            this.pCQtyInvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCQtyInvoiceDataGridViewTextBoxColumn.Width = 80;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pC19012DataGridViewTextBoxColumn
            // 
            this.pC19012DataGridViewTextBoxColumn.DataPropertyName = "PC19012";
            this.pC19012DataGridViewTextBoxColumn.HeaderText = "Szállítólevél";
            this.pC19012DataGridViewTextBoxColumn.Name = "pC19012DataGridViewTextBoxColumn";
            this.pC19012DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delDateCommiDataGridViewTextBoxColumn
            // 
            this.delDateCommiDataGridViewTextBoxColumn.DataPropertyName = "DelDateCommi";
            this.delDateCommiDataGridViewTextBoxColumn.HeaderText = "Visszaigazolt dátum";
            this.delDateCommiDataGridViewTextBoxColumn.Name = "delDateCommiDataGridViewTextBoxColumn";
            this.delDateCommiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delDateActuaDataGridViewTextBoxColumn
            // 
            this.delDateActuaDataGridViewTextBoxColumn.DataPropertyName = "DelDateActua";
            this.delDateActuaDataGridViewTextBoxColumn.HeaderText = "Utolsó beérk. dátum";
            this.delDateActuaDataGridViewTextBoxColumn.Name = "delDateActuaDataGridViewTextBoxColumn";
            this.delDateActuaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delDateRequeDataGridViewTextBoxColumn
            // 
            this.delDateRequeDataGridViewTextBoxColumn.DataPropertyName = "DelDateReque";
            this.delDateRequeDataGridViewTextBoxColumn.HeaderText = "Eredeti kért dátum";
            this.delDateRequeDataGridViewTextBoxColumn.Name = "delDateRequeDataGridViewTextBoxColumn";
            this.delDateRequeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchCreatDtDataGridViewTextBoxColumn
            // 
            this.batchCreatDtDataGridViewTextBoxColumn.DataPropertyName = "BatchCreatDt";
            this.batchCreatDtDataGridViewTextBoxColumn.HeaderText = "BatchCreatDt";
            this.batchCreatDtDataGridViewTextBoxColumn.Name = "batchCreatDtDataGridViewTextBoxColumn";
            this.batchCreatDtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form30
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 635);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form30";
            this.Text = "Szállítólevelek";
            this.Load += new System.EventHandler(this.Form30_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet30)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet30 dataSet30;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet30TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaOrdNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCQtyOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCQtyReceiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCQtyInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pC19012DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delDateCommiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delDateActuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delDateRequeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchCreatDtDataGridViewTextBoxColumn;
    }
}