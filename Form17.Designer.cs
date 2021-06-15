namespace NonBom
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nBSzolgaltatasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet17 = new NonBom.DataSet17();
            this.nBSzolgaltatasTableAdapter1 = new NonBom.DataSet17TableAdapters.NBSzolgaltatasTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RendSorszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szolgaltatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkahelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gepSzerszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSZNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beruszamRACFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igenyloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RendIdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Engedelyezo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngIdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deviza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).BeginInit();
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
            this.iDDataGridViewTextBoxColumn,
            this.RendSorszam,
            this.szolgaltatoDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.munkahelyDataGridViewTextBoxColumn,
            this.gepSzerszamDataGridViewTextBoxColumn,
            this.gSZNevDataGridViewTextBoxColumn,
            this.beruszamRACFDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.igenyloDataGridViewTextBoxColumn,
            this.statuszDataGridViewTextBoxColumn,
            this.RendIdo,
            this.Engedelyezo,
            this.EngIdo,
            this.Ar,
            this.Deviza,
            this.IDS});
            this.dataGridView1.DataSource = this.nBSzolgaltatasBindingSource1;
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
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1334, 509);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // nBSzolgaltatasBindingSource1
            // 
            this.nBSzolgaltatasBindingSource1.DataMember = "NBSzolgaltatas";
            this.nBSzolgaltatasBindingSource1.DataSource = this.dataSet17;
            // 
            // dataSet17
            // 
            this.dataSet17.DataSetName = "DataSet17";
            this.dataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBSzolgaltatasTableAdapter1
            // 
            this.nBSzolgaltatasTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Rend.Szám";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // RendSorszam
            // 
            this.RendSorszam.DataPropertyName = "RendSorszam";
            this.RendSorszam.HeaderText = "S.szám";
            this.RendSorszam.Name = "RendSorszam";
            this.RendSorszam.ReadOnly = true;
            this.RendSorszam.Width = 60;
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
            this.gepSzerszamDataGridViewTextBoxColumn.HeaderText = "Gép/Szerszám";
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
            this.statuszDataGridViewTextBoxColumn.HeaderText = "Státusz";
            this.statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            this.statuszDataGridViewTextBoxColumn.ReadOnly = true;
            this.statuszDataGridViewTextBoxColumn.Width = 60;
            // 
            // RendIdo
            // 
            this.RendIdo.DataPropertyName = "RendIdo";
            this.RendIdo.HeaderText = "Rendelés Ideje";
            this.RendIdo.Name = "RendIdo";
            this.RendIdo.ReadOnly = true;
            // 
            // Engedelyezo
            // 
            this.Engedelyezo.DataPropertyName = "Engedelyezo";
            this.Engedelyezo.HeaderText = "Engedélyező";
            this.Engedelyezo.Name = "Engedelyezo";
            this.Engedelyezo.ReadOnly = true;
            // 
            // EngIdo
            // 
            this.EngIdo.DataPropertyName = "EngIdo";
            this.EngIdo.HeaderText = "Eng. Ideje";
            this.EngIdo.Name = "EngIdo";
            this.EngIdo.ReadOnly = true;
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
            this.Ar.ReadOnly = true;
            this.Ar.Width = 80;
            // 
            // Deviza
            // 
            this.Deviza.DataPropertyName = "Deviza";
            this.Deviza.HeaderText = "Dev.";
            this.Deviza.Name = "Deviza";
            this.Deviza.ReadOnly = true;
            this.Deviza.Width = 60;
            // 
            // IDS
            // 
            this.IDS.DataPropertyName = "IDS";
            this.IDS.HeaderText = "IDS";
            this.IDS.Name = "IDS";
            this.IDS.ReadOnly = true;
            this.IDS.Visible = false;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 509);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form17";
            this.Text = "Szolgáltatások";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet17 dataSet17;
        private System.Windows.Forms.BindingSource nBSzolgaltatasBindingSource1;
        private DataSet17TableAdapters.NBSzolgaltatasTableAdapter nBSzolgaltatasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RendSorszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn szolgaltatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkahelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gepSzerszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSZNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beruszamRACFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igenyloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RendIdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Engedelyezo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngIdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deviza;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDS;
    }
}