namespace NonBom
{
    partial class Form14
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplRetuCustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderReceiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locktatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNBSC330300StockBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet14 = new NonBom.DataSet14();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vFSC360300StockBinNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vnB_ST080300_PurchaseStatTableAdapter1 = new NonBom.DataSet4TableAdapters.VNB_ST080300_PurchaseStatTableAdapter();
            this.vNB_SC330300_StockBatchTableAdapter = new NonBom.DataSet14TableAdapters.VNB_SC330300_StockBatchTableAdapter();
            this.vF_SC360300_StockBinNoTableAdapter = new NonBom.DataSet14TableAdapters.VF_SC360300_StockBinNoTableAdapter();
            this.VNB_SC330300_StockBatch1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vNB_SC330300_StockBatch1TableAdapter = new NonBom.DataSet14TableAdapters.VNB_SC330300_StockBatch1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBSC330300StockBatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFSC360300StockBinNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VNB_SC330300_StockBatch1BindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 630);
            this.splitContainer1.SplitterDistance = 442;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockItemDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.internRem1DataGridViewTextBoxColumn,
            this.internRem2DataGridViewTextBoxColumn,
            this.warehouseIDDataGridViewTextBoxColumn,
            this.binNumberDataGridViewTextBoxColumn,
            this.balanceQtyDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.supplRetuCustDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.orderReceiveDataGridViewTextBoxColumn,
            this.locktatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vNBSC330300StockBatchBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // stockItemDataGridViewTextBoxColumn
            // 
            this.stockItemDataGridViewTextBoxColumn.DataPropertyName = "StockItem";
            this.stockItemDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.stockItemDataGridViewTextBoxColumn.Name = "stockItemDataGridViewTextBoxColumn";
            this.stockItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockItemDataGridViewTextBoxColumn.Width = 150;
            // 
            // description1DataGridViewTextBoxColumn
            // 
            this.description1DataGridViewTextBoxColumn.DataPropertyName = "Description1";
            this.description1DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.description1DataGridViewTextBoxColumn.Name = "description1DataGridViewTextBoxColumn";
            this.description1DataGridViewTextBoxColumn.ReadOnly = true;
            this.description1DataGridViewTextBoxColumn.Width = 250;
            // 
            // description2DataGridViewTextBoxColumn
            // 
            this.description2DataGridViewTextBoxColumn.DataPropertyName = "Description2";
            this.description2DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.description2DataGridViewTextBoxColumn.Name = "description2DataGridViewTextBoxColumn";
            this.description2DataGridViewTextBoxColumn.ReadOnly = true;
            this.description2DataGridViewTextBoxColumn.Width = 200;
            // 
            // internRem1DataGridViewTextBoxColumn
            // 
            this.internRem1DataGridViewTextBoxColumn.DataPropertyName = "InternRem1";
            this.internRem1DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.internRem1DataGridViewTextBoxColumn.Name = "internRem1DataGridViewTextBoxColumn";
            this.internRem1DataGridViewTextBoxColumn.ReadOnly = true;
            this.internRem1DataGridViewTextBoxColumn.Width = 150;
            // 
            // internRem2DataGridViewTextBoxColumn
            // 
            this.internRem2DataGridViewTextBoxColumn.DataPropertyName = "InternRem2";
            this.internRem2DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.internRem2DataGridViewTextBoxColumn.Name = "internRem2DataGridViewTextBoxColumn";
            this.internRem2DataGridViewTextBoxColumn.ReadOnly = true;
            this.internRem2DataGridViewTextBoxColumn.Width = 150;
            // 
            // warehouseIDDataGridViewTextBoxColumn
            // 
            this.warehouseIDDataGridViewTextBoxColumn.DataPropertyName = "WarehouseID";
            this.warehouseIDDataGridViewTextBoxColumn.HeaderText = "Raktár";
            this.warehouseIDDataGridViewTextBoxColumn.Name = "warehouseIDDataGridViewTextBoxColumn";
            this.warehouseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // binNumberDataGridViewTextBoxColumn
            // 
            this.binNumberDataGridViewTextBoxColumn.DataPropertyName = "BinNumber";
            this.binNumberDataGridViewTextBoxColumn.HeaderText = "Polc";
            this.binNumberDataGridViewTextBoxColumn.Name = "binNumberDataGridViewTextBoxColumn";
            this.binNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.binNumberDataGridViewTextBoxColumn.Width = 70;
            // 
            // balanceQtyDataGridViewTextBoxColumn
            // 
            this.balanceQtyDataGridViewTextBoxColumn.DataPropertyName = "BalanceQty";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.balanceQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.balanceQtyDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.balanceQtyDataGridViewTextBoxColumn.Name = "balanceQtyDataGridViewTextBoxColumn";
            this.balanceQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceQtyDataGridViewTextBoxColumn.Width = 80;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "M.egys.";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 60;
            // 
            // supplRetuCustDataGridViewTextBoxColumn
            // 
            this.supplRetuCustDataGridViewTextBoxColumn.DataPropertyName = "SupplRetuCust";
            this.supplRetuCustDataGridViewTextBoxColumn.HeaderText = "Száll.Kód";
            this.supplRetuCustDataGridViewTextBoxColumn.Name = "supplRetuCustDataGridViewTextBoxColumn";
            this.supplRetuCustDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderReceiveDataGridViewTextBoxColumn
            // 
            this.orderReceiveDataGridViewTextBoxColumn.DataPropertyName = "OrderReceive";
            this.orderReceiveDataGridViewTextBoxColumn.HeaderText = "Besz.Rend.Sz.";
            this.orderReceiveDataGridViewTextBoxColumn.Name = "orderReceiveDataGridViewTextBoxColumn";
            this.orderReceiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locktatusDataGridViewTextBoxColumn
            // 
            this.locktatusDataGridViewTextBoxColumn.DataPropertyName = "Locktatus";
            this.locktatusDataGridViewTextBoxColumn.HeaderText = "Locktatus";
            this.locktatusDataGridViewTextBoxColumn.Name = "locktatusDataGridViewTextBoxColumn";
            this.locktatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vNBSC330300StockBatchBindingSource
            // 
            this.vNBSC330300StockBatchBindingSource.DataMember = "VNB_SC330300_StockBatch";
            this.vNBSC330300StockBatchBindingSource.DataSource = this.dataSet14;
            // 
            // dataSet14
            // 
            this.dataSet14.DataSetName = "DataSet14";
            this.dataSet14.EnforceConstraints = false;
            this.dataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(1126, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1053, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(903, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "O K";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.vFSC360300StockBinNoBindingSource;
            this.comboBox1.DisplayMember = "BinNumber";
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(670, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.TabStop = false;
            this.comboBox1.ValueMember = "BinNumber";
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // vFSC360300StockBinNoBindingSource
            // 
            this.vFSC360300StockBinNoBindingSource.DataMember = "VF_SC360300_StockBinNo";
            this.vFSC360300StockBinNoBindingSource.DataSource = this.dataSet14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(492, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(413, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Polcról :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(163, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(895, 49);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 23);
            this.textBox3.TabIndex = 5;
            this.textBox3.TabStop = false;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(806, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mennyiség:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(605, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Polcra :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(148, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cikkszám:";
            // 
            // vnB_ST080300_PurchaseStatTableAdapter1
            // 
            this.vnB_ST080300_PurchaseStatTableAdapter1.ClearBeforeFill = true;
            // 
            // vNB_SC330300_StockBatchTableAdapter
            // 
            this.vNB_SC330300_StockBatchTableAdapter.ClearBeforeFill = true;
            // 
            // vF_SC360300_StockBinNoTableAdapter
            // 
            this.vF_SC360300_StockBinNoTableAdapter.ClearBeforeFill = true;
            // 
            // VNB_SC330300_StockBatch1BindingSource
            // 
            this.VNB_SC330300_StockBatch1BindingSource.DataMember = "VNB_SC330300_StockBatch1";
            this.VNB_SC330300_StockBatch1BindingSource.DataSource = this.dataSet14;
            // 
            // vNB_SC330300_StockBatch1TableAdapter
            // 
            this.vNB_SC330300_StockBatch1TableAdapter.ClearBeforeFill = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 630);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form14";
            this.Text = "Polcra Helyezés";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form14_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBSC330300StockBatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFSC360300StockBinNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VNB_SC330300_StockBatch1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet14 dataSet14;
        private System.Windows.Forms.BindingSource vNBSC330300StockBatchBindingSource;
        private DataSet14TableAdapters.VNB_SC330300_StockBatchTableAdapter vNB_SC330300_StockBatchTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource vFSC360300StockBinNoBindingSource;
        private DataSet14TableAdapters.VF_SC360300_StockBinNoTableAdapter vF_SC360300_StockBinNoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn binNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplRetuCustDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderReceiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locktatusDataGridViewTextBoxColumn;
        private DataSet4TableAdapters.VNB_ST080300_PurchaseStatTableAdapter vnB_ST080300_PurchaseStatTableAdapter1;
        private System.Windows.Forms.BindingSource VNB_SC330300_StockBatch1BindingSource;
        private DataSet14TableAdapters.VNB_SC330300_StockBatch1TableAdapter vNB_SC330300_StockBatch1TableAdapter;
        private System.Windows.Forms.Button button2;
    }
}