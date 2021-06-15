namespace NonBom
{
    partial class Form23
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nBAnyagigenyloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet23 = new NonBom.DataSet23();
            this.nBAnyagigenyloTableAdapter = new NonBom.DataSet23TableAdapters.NBAnyagigenyloTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallitoKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerelmezoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesFejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendSorszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendeltMennyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kertSzallIdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engedelyezoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumBeerkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzes2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beruhazasszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBAnyagigenyloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet23)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.szallitoKodDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.kerelmezoDataGridViewTextBoxColumn,
            this.rendelesDatumDataGridViewTextBoxColumn,
            this.megjegyzesFejDataGridViewTextBoxColumn,
            this.rendSorszamDataGridViewTextBoxColumn,
            this.cikkszamDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.internRem1DataGridViewTextBoxColumn,
            this.internRem2DataGridViewTextBoxColumn,
            this.rendeltMennyDataGridViewTextBoxColumn,
            this.meeDataGridViewTextBoxColumn,
            this.egysegarDataGridViewTextBoxColumn,
            this.devizaDataGridViewTextBoxColumn,
            this.kertSzallIdoDataGridViewTextBoxColumn,
            this.engedelyezoDataGridViewTextBoxColumn,
            this.engDatumDataGridViewTextBoxColumn,
            this.datumBeerkDataGridViewTextBoxColumn,
            this.megjegyzes2DataGridViewTextBoxColumn,
            this.beruhazasszamDataGridViewTextBoxColumn,
            this.purchaseOrdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nBAnyagigenyloBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 544);
            this.dataGridView1.TabIndex = 0;
            // 
            // nBAnyagigenyloBindingSource
            // 
            this.nBAnyagigenyloBindingSource.DataMember = "NBAnyagigenylo";
            this.nBAnyagigenyloBindingSource.DataSource = this.dataSet23;
            // 
            // dataSet23
            // 
            this.dataSet23.DataSetName = "DataSet23";
            this.dataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBAnyagigenyloTableAdapter
            // 
            this.nBAnyagigenyloTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Rend.szám";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // szallitoKodDataGridViewTextBoxColumn
            // 
            this.szallitoKodDataGridViewTextBoxColumn.DataPropertyName = "SzallitoKod";
            this.szallitoKodDataGridViewTextBoxColumn.HeaderText = "Szállító Kód";
            this.szallitoKodDataGridViewTextBoxColumn.Name = "szallitoKodDataGridViewTextBoxColumn";
            this.szallitoKodDataGridViewTextBoxColumn.ReadOnly = true;
            this.szallitoKodDataGridViewTextBoxColumn.Width = 80;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kerelmezoDataGridViewTextBoxColumn
            // 
            this.kerelmezoDataGridViewTextBoxColumn.DataPropertyName = "Kerelmezo";
            this.kerelmezoDataGridViewTextBoxColumn.HeaderText = "Igénylő";
            this.kerelmezoDataGridViewTextBoxColumn.Name = "kerelmezoDataGridViewTextBoxColumn";
            this.kerelmezoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendelesDatumDataGridViewTextBoxColumn
            // 
            this.rendelesDatumDataGridViewTextBoxColumn.DataPropertyName = "RendelesDatum";
            this.rendelesDatumDataGridViewTextBoxColumn.HeaderText = "Rendelés Ideje";
            this.rendelesDatumDataGridViewTextBoxColumn.Name = "rendelesDatumDataGridViewTextBoxColumn";
            this.rendelesDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // megjegyzesFejDataGridViewTextBoxColumn
            // 
            this.megjegyzesFejDataGridViewTextBoxColumn.DataPropertyName = "MegjegyzesFej";
            this.megjegyzesFejDataGridViewTextBoxColumn.HeaderText = "Megjegyzés";
            this.megjegyzesFejDataGridViewTextBoxColumn.Name = "megjegyzesFejDataGridViewTextBoxColumn";
            this.megjegyzesFejDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendSorszamDataGridViewTextBoxColumn
            // 
            this.rendSorszamDataGridViewTextBoxColumn.DataPropertyName = "RendSorszam";
            this.rendSorszamDataGridViewTextBoxColumn.HeaderText = "Sorszám";
            this.rendSorszamDataGridViewTextBoxColumn.Name = "rendSorszamDataGridViewTextBoxColumn";
            this.rendSorszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendSorszamDataGridViewTextBoxColumn.Width = 60;
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            this.cikkszamDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.internRem1DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.internRem1DataGridViewTextBoxColumn.Name = "internRem1DataGridViewTextBoxColumn";
            this.internRem1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internRem2DataGridViewTextBoxColumn
            // 
            this.internRem2DataGridViewTextBoxColumn.DataPropertyName = "InternRem2";
            this.internRem2DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.internRem2DataGridViewTextBoxColumn.Name = "internRem2DataGridViewTextBoxColumn";
            this.internRem2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendeltMennyDataGridViewTextBoxColumn
            // 
            this.rendeltMennyDataGridViewTextBoxColumn.DataPropertyName = "RendeltMenny";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.rendeltMennyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.rendeltMennyDataGridViewTextBoxColumn.HeaderText = "Rendelt Menny.";
            this.rendeltMennyDataGridViewTextBoxColumn.Name = "rendeltMennyDataGridViewTextBoxColumn";
            this.rendeltMennyDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendeltMennyDataGridViewTextBoxColumn.Width = 80;
            // 
            // meeDataGridViewTextBoxColumn
            // 
            this.meeDataGridViewTextBoxColumn.DataPropertyName = "Mee";
            this.meeDataGridViewTextBoxColumn.HeaderText = "M.egys.";
            this.meeDataGridViewTextBoxColumn.Name = "meeDataGridViewTextBoxColumn";
            this.meeDataGridViewTextBoxColumn.ReadOnly = true;
            this.meeDataGridViewTextBoxColumn.Width = 60;
            // 
            // egysegarDataGridViewTextBoxColumn
            // 
            this.egysegarDataGridViewTextBoxColumn.DataPropertyName = "Egysegar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.egysegarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.egysegarDataGridViewTextBoxColumn.HeaderText = "Egységár";
            this.egysegarDataGridViewTextBoxColumn.Name = "egysegarDataGridViewTextBoxColumn";
            this.egysegarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devizaDataGridViewTextBoxColumn
            // 
            this.devizaDataGridViewTextBoxColumn.DataPropertyName = "Deviza";
            this.devizaDataGridViewTextBoxColumn.HeaderText = "Dev.";
            this.devizaDataGridViewTextBoxColumn.Name = "devizaDataGridViewTextBoxColumn";
            this.devizaDataGridViewTextBoxColumn.ReadOnly = true;
            this.devizaDataGridViewTextBoxColumn.Width = 60;
            // 
            // kertSzallIdoDataGridViewTextBoxColumn
            // 
            this.kertSzallIdoDataGridViewTextBoxColumn.DataPropertyName = "KertSzallIdo";
            this.kertSzallIdoDataGridViewTextBoxColumn.HeaderText = "Száll.Idő";
            this.kertSzallIdoDataGridViewTextBoxColumn.Name = "kertSzallIdoDataGridViewTextBoxColumn";
            this.kertSzallIdoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engedelyezoDataGridViewTextBoxColumn
            // 
            this.engedelyezoDataGridViewTextBoxColumn.DataPropertyName = "Engedelyezo";
            this.engedelyezoDataGridViewTextBoxColumn.HeaderText = "Engedélyező";
            this.engedelyezoDataGridViewTextBoxColumn.Name = "engedelyezoDataGridViewTextBoxColumn";
            this.engedelyezoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engDatumDataGridViewTextBoxColumn
            // 
            this.engDatumDataGridViewTextBoxColumn.DataPropertyName = "EngDatum";
            this.engDatumDataGridViewTextBoxColumn.HeaderText = "Eng.Ideje";
            this.engDatumDataGridViewTextBoxColumn.Name = "engDatumDataGridViewTextBoxColumn";
            this.engDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumBeerkDataGridViewTextBoxColumn
            // 
            this.datumBeerkDataGridViewTextBoxColumn.DataPropertyName = "DatumBeerk";
            this.datumBeerkDataGridViewTextBoxColumn.HeaderText = "Beérk.Ideje";
            this.datumBeerkDataGridViewTextBoxColumn.Name = "datumBeerkDataGridViewTextBoxColumn";
            this.datumBeerkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // megjegyzes2DataGridViewTextBoxColumn
            // 
            this.megjegyzes2DataGridViewTextBoxColumn.DataPropertyName = "Megjegyzes2";
            this.megjegyzes2DataGridViewTextBoxColumn.HeaderText = "Megjegyzés";
            this.megjegyzes2DataGridViewTextBoxColumn.Name = "megjegyzes2DataGridViewTextBoxColumn";
            this.megjegyzes2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beruhazasszamDataGridViewTextBoxColumn
            // 
            this.beruhazasszamDataGridViewTextBoxColumn.DataPropertyName = "Beruhazasszam";
            this.beruhazasszamDataGridViewTextBoxColumn.HeaderText = "Beruházás száma";
            this.beruhazasszamDataGridViewTextBoxColumn.Name = "beruhazasszamDataGridViewTextBoxColumn";
            this.beruhazasszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseOrdDataGridViewTextBoxColumn
            // 
            this.purchaseOrdDataGridViewTextBoxColumn.DataPropertyName = "PurchaseOrd";
            this.purchaseOrdDataGridViewTextBoxColumn.HeaderText = "iScala PO";
            this.purchaseOrdDataGridViewTextBoxColumn.Name = "purchaseOrdDataGridViewTextBoxColumn";
            this.purchaseOrdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Státusz";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 60;
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 544);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form23";
            this.Text = "Lezárt NonBom Igények";
            this.Load += new System.EventHandler(this.Form23_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBAnyagigenyloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet23 dataSet23;
        private System.Windows.Forms.BindingSource nBAnyagigenyloBindingSource;
        private DataSet23TableAdapters.NBAnyagigenyloTableAdapter nBAnyagigenyloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szallitoKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerelmezoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelesDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesFejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendSorszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendeltMennyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egysegarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kertSzallIdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engedelyezoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumBeerkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzes2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beruhazasszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}