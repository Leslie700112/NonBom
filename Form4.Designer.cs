namespace NonBom
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivNoteNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLCUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtySCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRefNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNBST080300PurchaseStatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new NonBom.DataSet4();
            this.vNB_ST080300_PurchaseStatTableAdapter = new NonBom.DataSet4TableAdapters.VNB_ST080300_PurchaseStatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBST080300PurchaseStatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryDateDataGridViewTextBoxColumn,
            this.supplierCodeDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.orderNoDataGridViewTextBoxColumn,
            this.delivNoteNoDataGridViewTextBoxColumn,
            this.textDescriptionDataGridViewTextBoxColumn,
            this.priceLCUDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.currencyCodeDataGridViewTextBoxColumn,
            this.qtySCDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.InvoiceDate1,
            this.internRefNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vNBST080300PurchaseStatBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 639);
            this.dataGridView1.TabIndex = 0;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Száll.idő";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryDateDataGridViewTextBoxColumn.Width = 75;
            // 
            // supplierCodeDataGridViewTextBoxColumn
            // 
            this.supplierCodeDataGridViewTextBoxColumn.DataPropertyName = "SupplierCode";
            this.supplierCodeDataGridViewTextBoxColumn.HeaderText = "Szállító kód";
            this.supplierCodeDataGridViewTextBoxColumn.Name = "supplierCodeDataGridViewTextBoxColumn";
            this.supplierCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "Rendelésszám";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delivNoteNoDataGridViewTextBoxColumn
            // 
            this.delivNoteNoDataGridViewTextBoxColumn.DataPropertyName = "DelivNoteNo";
            this.delivNoteNoDataGridViewTextBoxColumn.HeaderText = "Szállítólevél";
            this.delivNoteNoDataGridViewTextBoxColumn.Name = "delivNoteNoDataGridViewTextBoxColumn";
            this.delivNoteNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDescriptionDataGridViewTextBoxColumn
            // 
            this.textDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TextDescription";
            this.textDescriptionDataGridViewTextBoxColumn.HeaderText = "Termékcsoport";
            this.textDescriptionDataGridViewTextBoxColumn.Name = "textDescriptionDataGridViewTextBoxColumn";
            this.textDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.textDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceLCUDataGridViewTextBoxColumn
            // 
            this.priceLCUDataGridViewTextBoxColumn.DataPropertyName = "PriceLCU";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.priceLCUDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceLCUDataGridViewTextBoxColumn.HeaderText = "Besz.ár EUR";
            this.priceLCUDataGridViewTextBoxColumn.Name = "priceLCUDataGridViewTextBoxColumn";
            this.priceLCUDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceLCUDataGridViewTextBoxColumn.Width = 105;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Beszerzési ár";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 110;
            // 
            // currencyCodeDataGridViewTextBoxColumn
            // 
            this.currencyCodeDataGridViewTextBoxColumn.DataPropertyName = "CurrencyCode";
            this.currencyCodeDataGridViewTextBoxColumn.HeaderText = "Dev. kód";
            this.currencyCodeDataGridViewTextBoxColumn.Name = "currencyCodeDataGridViewTextBoxColumn";
            this.currencyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtySCDataGridViewTextBoxColumn
            // 
            this.qtySCDataGridViewTextBoxColumn.DataPropertyName = "QtySC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.qtySCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.qtySCDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.qtySCDataGridViewTextBoxColumn.Name = "qtySCDataGridViewTextBoxColumn";
            this.qtySCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "Számlaszám";
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InvoiceDate1
            // 
            this.InvoiceDate1.DataPropertyName = "InvoiceDate1";
            this.InvoiceDate1.HeaderText = "Számla dátum";
            this.InvoiceDate1.Name = "InvoiceDate1";
            this.InvoiceDate1.ReadOnly = true;
            this.InvoiceDate1.Width = 110;
            // 
            // internRefNoDataGridViewTextBoxColumn
            // 
            this.internRefNoDataGridViewTextBoxColumn.DataPropertyName = "InternRefNo";
            this.internRefNoDataGridViewTextBoxColumn.HeaderText = "Tranz.szám";
            this.internRefNoDataGridViewTextBoxColumn.Name = "internRefNoDataGridViewTextBoxColumn";
            this.internRefNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vNBST080300PurchaseStatBindingSource
            // 
            this.vNBST080300PurchaseStatBindingSource.DataMember = "VNB_ST080300_PurchaseStat";
            this.vNBST080300PurchaseStatBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.EnforceConstraints = false;
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vNB_ST080300_PurchaseStatTableAdapter
            // 
            this.vNB_ST080300_PurchaseStatTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 639);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Beérkezések";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBST080300PurchaseStatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vNBST080300PurchaseStatBindingSource;
        private DataSet4 dataSet4;
        private DataSet4TableAdapters.VNB_ST080300_PurchaseStatTableAdapter vNB_ST080300_PurchaseStatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivNoteNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLCUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtySCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRefNoDataGridViewTextBoxColumn;
    }
}