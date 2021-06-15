namespace NonBom
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataSet5 = new NonBom.DataSet5();
            this.vNBSC110300StockPlanningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vNB_SC110300_StockPlanningTableAdapter = new NonBom.DataSet5TableAdapters.VNB_SC110300_StockPlanningTableAdapter();
            this.szHetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSuppNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSuppCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megnevezesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBSC110300StockPlanningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szHetDataGridViewTextBoxColumn,
            this.szdatumDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.custSuppNameDataGridViewTextBoxColumn,
            this.custSuppCodeDataGridViewTextBoxColumn,
            this.megnevezesDataGridViewTextBoxColumn,
            this.internRem1DataGridViewTextBoxColumn,
            this.plannedQtyDataGridViewTextBoxColumn,
            this.manufactQtyDataGridViewTextBoxColumn,
            this.customerNoDataGridViewTextBoxColumn,
            this.salesOrderNoDataGridViewTextBoxColumn,
            this.text1DataGridViewTextBoxColumn,
            this.inOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vNBSC110300StockPlanningBindingSource;
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
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1201, 663);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1201, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.EnforceConstraints = false;
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vNBSC110300StockPlanningBindingSource
            // 
            this.vNBSC110300StockPlanningBindingSource.DataMember = "VNB_SC110300_StockPlanning";
            this.vNBSC110300StockPlanningBindingSource.DataSource = this.dataSet5;
            // 
            // vNB_SC110300_StockPlanningTableAdapter
            // 
            this.vNB_SC110300_StockPlanningTableAdapter.ClearBeforeFill = true;
            // 
            // szHetDataGridViewTextBoxColumn
            // 
            this.szHetDataGridViewTextBoxColumn.DataPropertyName = "SzHet";
            this.szHetDataGridViewTextBoxColumn.HeaderText = "Száll.Hét";
            this.szHetDataGridViewTextBoxColumn.Name = "szHetDataGridViewTextBoxColumn";
            this.szHetDataGridViewTextBoxColumn.ReadOnly = true;
            this.szHetDataGridViewTextBoxColumn.Width = 60;
            // 
            // szdatumDataGridViewTextBoxColumn
            // 
            this.szdatumDataGridViewTextBoxColumn.DataPropertyName = "Szdatum";
            this.szdatumDataGridViewTextBoxColumn.HeaderText = "Száll.dátum";
            this.szdatumDataGridViewTextBoxColumn.Name = "szdatumDataGridViewTextBoxColumn";
            this.szdatumDataGridViewTextBoxColumn.ReadOnly = true;
            this.szdatumDataGridViewTextBoxColumn.Width = 80;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.qtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "Raktár";
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            this.warehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseDataGridViewTextBoxColumn.Width = 60;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Rendelés";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custSuppNameDataGridViewTextBoxColumn
            // 
            this.custSuppNameDataGridViewTextBoxColumn.DataPropertyName = "CustSuppName";
            this.custSuppNameDataGridViewTextBoxColumn.HeaderText = "Vevő/Száll. neve";
            this.custSuppNameDataGridViewTextBoxColumn.Name = "custSuppNameDataGridViewTextBoxColumn";
            this.custSuppNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.custSuppNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // custSuppCodeDataGridViewTextBoxColumn
            // 
            this.custSuppCodeDataGridViewTextBoxColumn.DataPropertyName = "CustSuppCode";
            this.custSuppCodeDataGridViewTextBoxColumn.HeaderText = "Vevő/Száll. kód";
            this.custSuppCodeDataGridViewTextBoxColumn.Name = "custSuppCodeDataGridViewTextBoxColumn";
            this.custSuppCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.custSuppCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // megnevezesDataGridViewTextBoxColumn
            // 
            this.megnevezesDataGridViewTextBoxColumn.DataPropertyName = "Megnevezes";
            this.megnevezesDataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.megnevezesDataGridViewTextBoxColumn.Name = "megnevezesDataGridViewTextBoxColumn";
            this.megnevezesDataGridViewTextBoxColumn.ReadOnly = true;
            this.megnevezesDataGridViewTextBoxColumn.Width = 200;
            // 
            // internRem1DataGridViewTextBoxColumn
            // 
            this.internRem1DataGridViewTextBoxColumn.DataPropertyName = "InternRem1";
            this.internRem1DataGridViewTextBoxColumn.HeaderText = "Rajzszám";
            this.internRem1DataGridViewTextBoxColumn.Name = "internRem1DataGridViewTextBoxColumn";
            this.internRem1DataGridViewTextBoxColumn.ReadOnly = true;
            this.internRem1DataGridViewTextBoxColumn.Width = 150;
            // 
            // plannedQtyDataGridViewTextBoxColumn
            // 
            this.plannedQtyDataGridViewTextBoxColumn.DataPropertyName = "PlannedQty";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.plannedQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.plannedQtyDataGridViewTextBoxColumn.HeaderText = "Rendelt menny.";
            this.plannedQtyDataGridViewTextBoxColumn.Name = "plannedQtyDataGridViewTextBoxColumn";
            this.plannedQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.plannedQtyDataGridViewTextBoxColumn.Width = 120;
            // 
            // manufactQtyDataGridViewTextBoxColumn
            // 
            this.manufactQtyDataGridViewTextBoxColumn.DataPropertyName = "ManufactQty";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.manufactQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.manufactQtyDataGridViewTextBoxColumn.HeaderText = "Gyártott menny.";
            this.manufactQtyDataGridViewTextBoxColumn.Name = "manufactQtyDataGridViewTextBoxColumn";
            this.manufactQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufactQtyDataGridViewTextBoxColumn.Width = 120;
            // 
            // customerNoDataGridViewTextBoxColumn
            // 
            this.customerNoDataGridViewTextBoxColumn.DataPropertyName = "CustomerNo";
            this.customerNoDataGridViewTextBoxColumn.HeaderText = "Vevő kód";
            this.customerNoDataGridViewTextBoxColumn.Name = "customerNoDataGridViewTextBoxColumn";
            this.customerNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // salesOrderNoDataGridViewTextBoxColumn
            // 
            this.salesOrderNoDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderNo";
            this.salesOrderNoDataGridViewTextBoxColumn.HeaderText = "Rend.szám";
            this.salesOrderNoDataGridViewTextBoxColumn.Name = "salesOrderNoDataGridViewTextBoxColumn";
            this.salesOrderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // text1DataGridViewTextBoxColumn
            // 
            this.text1DataGridViewTextBoxColumn.DataPropertyName = "text1";
            this.text1DataGridViewTextBoxColumn.HeaderText = "Vevői rend.szám";
            this.text1DataGridViewTextBoxColumn.Name = "text1DataGridViewTextBoxColumn";
            this.text1DataGridViewTextBoxColumn.ReadOnly = true;
            this.text1DataGridViewTextBoxColumn.Width = 110;
            // 
            // inOutDataGridViewTextBoxColumn
            // 
            this.inOutDataGridViewTextBoxColumn.DataPropertyName = "InOut";
            this.inOutDataGridViewTextBoxColumn.HeaderText = "InOut";
            this.inOutDataGridViewTextBoxColumn.Name = "inOutDataGridViewTextBoxColumn";
            this.inOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.inOutDataGridViewTextBoxColumn.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(172, 18);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 18);
            this.toolStripStatusLabel2.Text = "Összesen :";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(172, 18);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(175, 18);
            this.toolStripStatusLabel4.Text = "Várható Beérkezés/Felhasználás:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(114, 18);
            this.toolStripStatusLabel5.Text = "Rendelt Mennyiség :";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 686);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form5";
            this.ShowIcon = false;
            this.Text = "Várható beérk./ kiszáll.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBSC110300StockPlanningBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource vNBSC110300StockPlanningBindingSource;
        private DataSet5 dataSet5;
        private DataSet5TableAdapters.VNB_SC110300_StockPlanningTableAdapter vNB_SC110300_StockPlanningTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn szHetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSuppNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSuppCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megnevezesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn text1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}