namespace NonBom
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Alap Információk(A)");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Készletek(L)");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Beérkezések(B)");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Várható beérk./ kiszáll.(K)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("KészletTranzakciók(T)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Készlet Módosítás Kérés(U)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Felhasználás");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Szállítólevelek");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("NonBom Cikkek Lekérdezése(ESC)", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Konszig Rendelés Létrehozása");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Beszerzési Ajánlatok");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Új Igény Felvitele(F3)", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Engedélyezés(F4)");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Rendelés Nyomtatás PO (F9)");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Konszig Rendelések Bevételezése");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Címke Nyomtatás(F6)");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Polcra Helyezés(F7)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Bevételezés(F5)", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Kiadás(F8)");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Visszavételezés");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Lezárt NonBom Igények");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("NonBom Igények(F2)", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Szolgáltatási Igény Felvitele");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Engedélyezés");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Megrendelő Nyomtatás");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Teljesítés Igazolás");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Lezárt Szolgáltatási Igények");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Szolgáltatások", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Leltár Adatok Felvitele");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Leltár", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EleresiUt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crystalNyilvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new NonBom.DataSet1();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCSMegn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETCSMegn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averCostPri1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCQtyOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrdLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optPurchQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePricDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternSupplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delTimeWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statCodeExteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recCreatDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meegys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverCostPrc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNBSC010300StockfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NonBom.DataSet1();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.JogokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vNB_SC010300_StockfileTableAdapter = new NonBom.DataSet1TableAdapters.VNB_SC010300_StockfileTableAdapter();
            this.jogokTableAdapter = new NonBom.DataSet1TableAdapters.JogokTableAdapter();
            this.crystalNyilvTableAdapter = new NonBom.DataSet1TableAdapters.CrystalNyilvTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalNyilvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBSC010300StockfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JogokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1267, 571);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplitContainer1_KeyDown);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(179, 571);
            this.splitContainer2.SplitterDistance = 311;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode1.Text = "Alap Információk(A)";
            treeNode2.Name = "Node4";
            treeNode2.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode2.Text = "Készletek(L)";
            treeNode3.Name = "Node6";
            treeNode3.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode3.Text = "Beérkezések(B)";
            treeNode4.Name = "Node8";
            treeNode4.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode4.Text = "Várható beérk./ kiszáll.(K)";
            treeNode5.Name = "Node10";
            treeNode5.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode5.Text = "KészletTranzakciók(T)";
            treeNode6.Name = "Node19";
            treeNode6.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode6.Text = "Készlet Módosítás Kérés(U)";
            treeNode7.Name = "Node191";
            treeNode7.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode7.Text = "Felhasználás";
            treeNode8.Name = "Node192";
            treeNode8.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode8.Text = "Szállítólevelek";
            treeNode9.BackColor = System.Drawing.Color.DarkSlateGray;
            treeNode9.ForeColor = System.Drawing.Color.White;
            treeNode9.Name = "Node0";
            treeNode9.NodeFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode9.Text = "NonBom Cikkek Lekérdezése(ESC)";
            treeNode10.Name = "Node211";
            treeNode10.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode10.Text = "Konszig Rendelés Létrehozása";
            treeNode11.Name = "Node214";
            treeNode11.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode11.Text = "Beszerzési Ajánlatok";
            treeNode12.Name = "Node21";
            treeNode12.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode12.Text = "Új Igény Felvitele(F3)";
            treeNode13.Name = "Node22";
            treeNode13.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode13.Text = "Engedélyezés(F4)";
            treeNode14.Name = "Node33";
            treeNode14.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode14.Text = "Rendelés Nyomtatás PO (F9)";
            treeNode15.Name = "Node30";
            treeNode15.NodeFont = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic);
            treeNode15.Text = "Konszig Rendelések Bevételezése";
            treeNode16.Name = "Node27";
            treeNode16.NodeFont = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic);
            treeNode16.Text = "Címke Nyomtatás(F6)";
            treeNode17.Name = "Node29";
            treeNode17.NodeFont = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic);
            treeNode17.Text = "Polcra Helyezés(F7)";
            treeNode18.Name = "Node25";
            treeNode18.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode18.Text = "Bevételezés(F5)";
            treeNode19.Name = "Node31";
            treeNode19.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode19.Text = "Kiadás(F8)";
            treeNode20.Name = "Node36";
            treeNode20.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode20.Text = "Visszavételezés";
            treeNode21.Name = "Node35";
            treeNode21.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode21.Text = "Lezárt NonBom Igények";
            treeNode22.BackColor = System.Drawing.Color.DarkSlateGray;
            treeNode22.ForeColor = System.Drawing.Color.White;
            treeNode22.Name = "Node20";
            treeNode22.NodeFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode22.Text = "NonBom Igények(F2)";
            treeNode23.Name = "Node41";
            treeNode23.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode23.Text = "Szolgáltatási Igény Felvitele";
            treeNode24.Name = "Node43";
            treeNode24.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode24.Text = "Engedélyezés";
            treeNode25.Name = "Node45";
            treeNode25.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode25.Text = "Megrendelő Nyomtatás";
            treeNode26.Name = "Node49";
            treeNode26.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode26.Text = "Teljesítés Igazolás";
            treeNode27.Name = "Node48";
            treeNode27.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode27.Text = "Lezárt Szolgáltatási Igények";
            treeNode28.BackColor = System.Drawing.Color.DarkSlateGray;
            treeNode28.ForeColor = System.Drawing.Color.White;
            treeNode28.Name = "Node40";
            treeNode28.NodeFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode28.Text = "Szolgáltatások";
            treeNode29.Name = "Node52";
            treeNode29.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode29.Text = "Leltár Adatok Felvitele";
            treeNode30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode30.Name = "Node50";
            treeNode30.NodeFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode30.Text = "Leltár";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode22,
            treeNode28,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(179, 311);
            this.treeView1.TabIndex = 0;
            this.treeView1.TabStop = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBox6);
            this.splitContainer3.Size = new System.Drawing.Size(179, 257);
            this.splitContainer3.SplitterDistance = 228;
            this.splitContainer3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cimDataGridViewTextBoxColumn,
            this.EleresiUt});
            this.dataGridView2.DataSource = this.crystalNyilvBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(179, 228);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // cimDataGridViewTextBoxColumn
            // 
            this.cimDataGridViewTextBoxColumn.DataPropertyName = "Cim";
            this.cimDataGridViewTextBoxColumn.HeaderText = "Cím";
            this.cimDataGridViewTextBoxColumn.Name = "cimDataGridViewTextBoxColumn";
            this.cimDataGridViewTextBoxColumn.ReadOnly = true;
            this.cimDataGridViewTextBoxColumn.Width = 300;
            // 
            // EleresiUt
            // 
            this.EleresiUt.DataPropertyName = "EleresiUt";
            this.EleresiUt.HeaderText = "EleresiUt";
            this.EleresiUt.Name = "EleresiUt";
            this.EleresiUt.ReadOnly = true;
            this.EleresiUt.Visible = false;
            // 
            // crystalNyilvBindingSource
            // 
            this.crystalNyilvBindingSource.DataMember = "CrystalNyilv";
            this.crystalNyilvBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 2);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(173, 19);
            this.textBox6.TabIndex = 2;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockCodeDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.internRem1DataGridViewTextBoxColumn,
            this.internRem2DataGridViewTextBoxColumn,
            this.TCSMegn,
            this.ETCSMegn,
            this.averCostPri1DataGridViewTextBoxColumn,
            this.stockBalanceDataGridViewTextBoxColumn,
            this.sCQtyOrderDataGridViewTextBoxColumn,
            this.reservedQtyDataGridViewTextBoxColumn,
            this.reOrdLevelDataGridViewTextBoxColumn,
            this.optPurchQtyDataGridViewTextBoxColumn,
            this.netWeightDataGridViewTextBoxColumn,
            this.grossWeightDataGridViewTextBoxColumn,
            this.purchaserDataGridViewTextBoxColumn,
            this.purchasePricDataGridViewTextBoxColumn,
            this.alternSupplDataGridViewTextBoxColumn,
            this.SupplierName,
            this.delTimeWeekDataGridViewTextBoxColumn,
            this.statCodeExteDataGridViewTextBoxColumn,
            this.recCreatDateDataGridViewTextBoxColumn,
            this.Meegys,
            this.AverCostPrc2});
            this.dataGridView1.DataSource = this.vNBSC010300StockfileBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 571);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // stockCodeDataGridViewTextBoxColumn
            // 
            this.stockCodeDataGridViewTextBoxColumn.DataPropertyName = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.stockCodeDataGridViewTextBoxColumn.Name = "stockCodeDataGridViewTextBoxColumn";
            this.stockCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockCodeDataGridViewTextBoxColumn.Width = 120;
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
            this.description2DataGridViewTextBoxColumn.Width = 200;
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
            this.internRem2DataGridViewTextBoxColumn.Width = 150;
            // 
            // TCSMegn
            // 
            this.TCSMegn.DataPropertyName = "TCSMegn";
            this.TCSMegn.HeaderText = "Termékcsoport";
            this.TCSMegn.Name = "TCSMegn";
            this.TCSMegn.ReadOnly = true;
            this.TCSMegn.Width = 200;
            // 
            // ETCSMegn
            // 
            this.ETCSMegn.DataPropertyName = "ETCSMegn";
            this.ETCSMegn.HeaderText = "Ext. Termékcsoport";
            this.ETCSMegn.Name = "ETCSMegn";
            this.ETCSMegn.ReadOnly = true;
            this.ETCSMegn.Width = 200;
            // 
            // averCostPri1DataGridViewTextBoxColumn
            // 
            this.averCostPri1DataGridViewTextBoxColumn.DataPropertyName = "AverCostPri1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N4";
            dataGridViewCellStyle1.NullValue = null;
            this.averCostPri1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.averCostPri1DataGridViewTextBoxColumn.HeaderText = "S.Átlagár";
            this.averCostPri1DataGridViewTextBoxColumn.Name = "averCostPri1DataGridViewTextBoxColumn";
            this.averCostPri1DataGridViewTextBoxColumn.ReadOnly = true;
            this.averCostPri1DataGridViewTextBoxColumn.Width = 70;
            // 
            // stockBalanceDataGridViewTextBoxColumn
            // 
            this.stockBalanceDataGridViewTextBoxColumn.DataPropertyName = "StockBalance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.stockBalanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockBalanceDataGridViewTextBoxColumn.HeaderText = "Készlet";
            this.stockBalanceDataGridViewTextBoxColumn.Name = "stockBalanceDataGridViewTextBoxColumn";
            this.stockBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockBalanceDataGridViewTextBoxColumn.Width = 80;
            // 
            // sCQtyOrderDataGridViewTextBoxColumn
            // 
            this.sCQtyOrderDataGridViewTextBoxColumn.DataPropertyName = "SCQtyOrder";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.sCQtyOrderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sCQtyOrderDataGridViewTextBoxColumn.HeaderText = "Rendelt";
            this.sCQtyOrderDataGridViewTextBoxColumn.Name = "sCQtyOrderDataGridViewTextBoxColumn";
            this.sCQtyOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCQtyOrderDataGridViewTextBoxColumn.Width = 80;
            // 
            // reservedQtyDataGridViewTextBoxColumn
            // 
            this.reservedQtyDataGridViewTextBoxColumn.DataPropertyName = "ReservedQty";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.reservedQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.reservedQtyDataGridViewTextBoxColumn.HeaderText = "Foglalt";
            this.reservedQtyDataGridViewTextBoxColumn.Name = "reservedQtyDataGridViewTextBoxColumn";
            this.reservedQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservedQtyDataGridViewTextBoxColumn.Width = 80;
            // 
            // reOrdLevelDataGridViewTextBoxColumn
            // 
            this.reOrdLevelDataGridViewTextBoxColumn.DataPropertyName = "ReOrdLevel";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.reOrdLevelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.reOrdLevelDataGridViewTextBoxColumn.HeaderText = "Újrarend.szint";
            this.reOrdLevelDataGridViewTextBoxColumn.Name = "reOrdLevelDataGridViewTextBoxColumn";
            this.reOrdLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.reOrdLevelDataGridViewTextBoxColumn.Width = 80;
            // 
            // optPurchQtyDataGridViewTextBoxColumn
            // 
            this.optPurchQtyDataGridViewTextBoxColumn.DataPropertyName = "OptPurchQty";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.optPurchQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.optPurchQtyDataGridViewTextBoxColumn.HeaderText = "Opt.Besz.Menny";
            this.optPurchQtyDataGridViewTextBoxColumn.Name = "optPurchQtyDataGridViewTextBoxColumn";
            this.optPurchQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netWeightDataGridViewTextBoxColumn
            // 
            this.netWeightDataGridViewTextBoxColumn.DataPropertyName = "NetWeight";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N5";
            dataGridViewCellStyle7.NullValue = null;
            this.netWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.netWeightDataGridViewTextBoxColumn.HeaderText = "Nettó Súly";
            this.netWeightDataGridViewTextBoxColumn.Name = "netWeightDataGridViewTextBoxColumn";
            this.netWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.netWeightDataGridViewTextBoxColumn.Width = 90;
            // 
            // grossWeightDataGridViewTextBoxColumn
            // 
            this.grossWeightDataGridViewTextBoxColumn.DataPropertyName = "GrossWeight";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N5";
            dataGridViewCellStyle8.NullValue = null;
            this.grossWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.grossWeightDataGridViewTextBoxColumn.HeaderText = "Bruttó Súly";
            this.grossWeightDataGridViewTextBoxColumn.Name = "grossWeightDataGridViewTextBoxColumn";
            this.grossWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossWeightDataGridViewTextBoxColumn.Width = 90;
            // 
            // purchaserDataGridViewTextBoxColumn
            // 
            this.purchaserDataGridViewTextBoxColumn.DataPropertyName = "Purchaser";
            this.purchaserDataGridViewTextBoxColumn.HeaderText = "Beszerző";
            this.purchaserDataGridViewTextBoxColumn.Name = "purchaserDataGridViewTextBoxColumn";
            this.purchaserDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaserDataGridViewTextBoxColumn.Width = 70;
            // 
            // purchasePricDataGridViewTextBoxColumn
            // 
            this.purchasePricDataGridViewTextBoxColumn.DataPropertyName = "PurchasePric";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N4";
            dataGridViewCellStyle9.NullValue = null;
            this.purchasePricDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.purchasePricDataGridViewTextBoxColumn.HeaderText = "Besz.ár";
            this.purchasePricDataGridViewTextBoxColumn.Name = "purchasePricDataGridViewTextBoxColumn";
            this.purchasePricDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchasePricDataGridViewTextBoxColumn.Width = 80;
            // 
            // alternSupplDataGridViewTextBoxColumn
            // 
            this.alternSupplDataGridViewTextBoxColumn.DataPropertyName = "AlternSuppl";
            this.alternSupplDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.alternSupplDataGridViewTextBoxColumn.Name = "alternSupplDataGridViewTextBoxColumn";
            this.alternSupplDataGridViewTextBoxColumn.ReadOnly = true;
            this.alternSupplDataGridViewTextBoxColumn.Width = 70;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Szállító";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // delTimeWeekDataGridViewTextBoxColumn
            // 
            this.delTimeWeekDataGridViewTextBoxColumn.DataPropertyName = "DelTimeWeek";
            this.delTimeWeekDataGridViewTextBoxColumn.HeaderText = "Szállítási hét";
            this.delTimeWeekDataGridViewTextBoxColumn.Name = "delTimeWeekDataGridViewTextBoxColumn";
            this.delTimeWeekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statCodeExteDataGridViewTextBoxColumn
            // 
            this.statCodeExteDataGridViewTextBoxColumn.DataPropertyName = "StatCodeExte";
            this.statCodeExteDataGridViewTextBoxColumn.HeaderText = "Tarifaszám";
            this.statCodeExteDataGridViewTextBoxColumn.Name = "statCodeExteDataGridViewTextBoxColumn";
            this.statCodeExteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recCreatDateDataGridViewTextBoxColumn
            // 
            this.recCreatDateDataGridViewTextBoxColumn.DataPropertyName = "RecCreatDate";
            this.recCreatDateDataGridViewTextBoxColumn.HeaderText = "Létrehozás";
            this.recCreatDateDataGridViewTextBoxColumn.Name = "recCreatDateDataGridViewTextBoxColumn";
            this.recCreatDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Meegys
            // 
            this.Meegys.DataPropertyName = "Meegys";
            this.Meegys.HeaderText = "M.egys.";
            this.Meegys.Name = "Meegys";
            this.Meegys.ReadOnly = true;
            this.Meegys.Width = 70;
            // 
            // AverCostPrc2
            // 
            this.AverCostPrc2.DataPropertyName = "AverCostPrc2";
            this.AverCostPrc2.HeaderText = "AverCostPrc2";
            this.AverCostPrc2.Name = "AverCostPrc2";
            this.AverCostPrc2.ReadOnly = true;
            this.AverCostPrc2.Visible = false;
            // 
            // vNBSC010300StockfileBindingSource
            // 
            this.vNBSC010300StockfileBindingSource.DataMember = "VNB_SC010300_Stockfile";
            this.vNBSC010300StockfileBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.EnforceConstraints = false;
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1267, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 36);
            this.toolStripButton1.Text = "Kilépés";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(95, 36);
            this.toolStripButton2.Text = "Frissítés";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 36);
            this.toolStripLabel1.Text = "Keresés :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(508, 10);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 19);
            this.textBox2.TabIndex = 0;
            this.textBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(712, 10);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(200, 19);
            this.textBox3.TabIndex = 0;
            this.textBox3.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1120, 10);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(21, 19);
            this.textBox4.TabIndex = 0;
            this.textBox4.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(916, 10);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(200, 19);
            this.textBox5.TabIndex = 0;
            this.textBox5.TabStop = false;
            // 
            // JogokBindingSource
            // 
            this.JogokBindingSource.DataMember = "Jogok";
            this.JogokBindingSource.DataSource = this.dataSet1;
            // 
            // vNB_SC010300_StockfileTableAdapter
            // 
            this.vNB_SC010300_StockfileTableAdapter.ClearBeforeFill = true;
            // 
            // jogokTableAdapter
            // 
            this.jogokTableAdapter.ClearBeforeFill = true;
            // 
            // crystalNyilvTableAdapter
            // 
            this.crystalNyilvTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1267, 610);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 7F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "NonBom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalNyilvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNBSC010300StockfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JogokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vNBSC010300StockfileBindingSource;
        private DataSet1TableAdapters.VNB_SC010300_StockfileTableAdapter vNB_SC010300_StockfileTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource JogokBindingSource;
        private DataSet1TableAdapters.JogokTableAdapter jogokTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource crystalNyilvBindingSource;
        private DataSet1TableAdapters.CrystalNyilvTableAdapter crystalNyilvTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EleresiUt;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCSMegn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETCSMegn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averCostPri1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCQtyOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reOrdLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optPurchQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePricDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternSupplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn delTimeWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statCodeExteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recCreatDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meegys;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverCostPrc2;
    }
}

