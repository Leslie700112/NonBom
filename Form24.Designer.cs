namespace NonBom
{
    partial class Form24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form24));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nBSzolgaltatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet24 = new NonBom.DataSet24();
            this.nBSzolgaltatasTableAdapter = new NonBom.DataSet24TableAdapters.NBSzolgaltatasTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendSorszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szolgaltatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzolgTipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkahelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gepSzerszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSZNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beruszamRACFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igenyloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendIdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engedelyezoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engIdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzamlazottAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IktatoSzam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koltseghely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KltsgHNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szamligazol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzamlIgIdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeljIgazol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeljIgIdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet24)).BeginInit();
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
            this.rendSorszamDataGridViewTextBoxColumn,
            this.szolgaltatoDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.SzolgTipus,
            this.munkahelyDataGridViewTextBoxColumn,
            this.gepSzerszamDataGridViewTextBoxColumn,
            this.gSZNevDataGridViewTextBoxColumn,
            this.beruszamRACFDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.igenyloDataGridViewTextBoxColumn,
            this.rendIdoDataGridViewTextBoxColumn,
            this.engedelyezoDataGridViewTextBoxColumn,
            this.engIdoDataGridViewTextBoxColumn,
            this.statuszDataGridViewTextBoxColumn,
            this.arDataGridViewTextBoxColumn,
            this.devizaDataGridViewTextBoxColumn,
            this.SzamlazottAr,
            this.IktatoSzam,
            this.Koltseghely,
            this.KltsgHNev,
            this.Szamligazol,
            this.SzamlIgIdo,
            this.TeljIgazol,
            this.TeljIgIdo});
            this.dataGridView1.DataSource = this.nBSzolgaltatasBindingSource;
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
            this.dataGridView1.Size = new System.Drawing.Size(1276, 563);
            this.dataGridView1.TabIndex = 0;
            // 
            // nBSzolgaltatasBindingSource
            // 
            this.nBSzolgaltatasBindingSource.DataMember = "NBSzolgaltatas";
            this.nBSzolgaltatasBindingSource.DataSource = this.dataSet24;
            // 
            // dataSet24
            // 
            this.dataSet24.DataSetName = "DataSet24";
            this.dataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBSzolgaltatasTableAdapter
            // 
            this.nBSzolgaltatasTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Rend.Szám";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // rendSorszamDataGridViewTextBoxColumn
            // 
            this.rendSorszamDataGridViewTextBoxColumn.DataPropertyName = "RendSorszam";
            this.rendSorszamDataGridViewTextBoxColumn.HeaderText = "S.Szám";
            this.rendSorszamDataGridViewTextBoxColumn.Name = "rendSorszamDataGridViewTextBoxColumn";
            this.rendSorszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendSorszamDataGridViewTextBoxColumn.Width = 60;
            // 
            // szolgaltatoDataGridViewTextBoxColumn
            // 
            this.szolgaltatoDataGridViewTextBoxColumn.DataPropertyName = "Szolgaltato";
            this.szolgaltatoDataGridViewTextBoxColumn.HeaderText = "Szolg.Kód";
            this.szolgaltatoDataGridViewTextBoxColumn.Name = "szolgaltatoDataGridViewTextBoxColumn";
            this.szolgaltatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.szolgaltatoDataGridViewTextBoxColumn.Width = 60;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szolgáltató Neve";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // SzolgTipus
            // 
            this.SzolgTipus.DataPropertyName = "SzolgTipus";
            this.SzolgTipus.HeaderText = "Szolg.Típus";
            this.SzolgTipus.Name = "SzolgTipus";
            this.SzolgTipus.ReadOnly = true;
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
            this.gSZNevDataGridViewTextBoxColumn.Width = 300;
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
            this.megjegyzesDataGridViewTextBoxColumn.Width = 300;
            // 
            // igenyloDataGridViewTextBoxColumn
            // 
            this.igenyloDataGridViewTextBoxColumn.DataPropertyName = "Igenylo";
            this.igenyloDataGridViewTextBoxColumn.HeaderText = "Igénylő";
            this.igenyloDataGridViewTextBoxColumn.Name = "igenyloDataGridViewTextBoxColumn";
            this.igenyloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendIdoDataGridViewTextBoxColumn
            // 
            this.rendIdoDataGridViewTextBoxColumn.DataPropertyName = "RendIdo";
            this.rendIdoDataGridViewTextBoxColumn.HeaderText = "Rendelés Ideje";
            this.rendIdoDataGridViewTextBoxColumn.Name = "rendIdoDataGridViewTextBoxColumn";
            this.rendIdoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engedelyezoDataGridViewTextBoxColumn
            // 
            this.engedelyezoDataGridViewTextBoxColumn.DataPropertyName = "Engedelyezo";
            this.engedelyezoDataGridViewTextBoxColumn.HeaderText = "Engedélyező";
            this.engedelyezoDataGridViewTextBoxColumn.Name = "engedelyezoDataGridViewTextBoxColumn";
            this.engedelyezoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engIdoDataGridViewTextBoxColumn
            // 
            this.engIdoDataGridViewTextBoxColumn.DataPropertyName = "EngIdo";
            this.engIdoDataGridViewTextBoxColumn.HeaderText = "Eng. Ideje";
            this.engIdoDataGridViewTextBoxColumn.Name = "engIdoDataGridViewTextBoxColumn";
            this.engIdoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statuszDataGridViewTextBoxColumn
            // 
            this.statuszDataGridViewTextBoxColumn.DataPropertyName = "Statusz";
            this.statuszDataGridViewTextBoxColumn.HeaderText = "Státusz";
            this.statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            this.statuszDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arDataGridViewTextBoxColumn
            // 
            this.arDataGridViewTextBoxColumn.DataPropertyName = "Ar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.arDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.arDataGridViewTextBoxColumn.HeaderText = "Ajánlott Ár";
            this.arDataGridViewTextBoxColumn.Name = "arDataGridViewTextBoxColumn";
            this.arDataGridViewTextBoxColumn.ReadOnly = true;
            this.arDataGridViewTextBoxColumn.Width = 80;
            // 
            // devizaDataGridViewTextBoxColumn
            // 
            this.devizaDataGridViewTextBoxColumn.DataPropertyName = "Deviza";
            this.devizaDataGridViewTextBoxColumn.HeaderText = "Dev.";
            this.devizaDataGridViewTextBoxColumn.Name = "devizaDataGridViewTextBoxColumn";
            this.devizaDataGridViewTextBoxColumn.ReadOnly = true;
            this.devizaDataGridViewTextBoxColumn.Width = 60;
            // 
            // SzamlazottAr
            // 
            this.SzamlazottAr.DataPropertyName = "SzamlazottAr";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.SzamlazottAr.DefaultCellStyle = dataGridViewCellStyle3;
            this.SzamlazottAr.HeaderText = "Számlázott Ár";
            this.SzamlazottAr.Name = "SzamlazottAr";
            this.SzamlazottAr.ReadOnly = true;
            this.SzamlazottAr.Width = 80;
            // 
            // IktatoSzam
            // 
            this.IktatoSzam.DataPropertyName = "IktatoSzam";
            this.IktatoSzam.HeaderText = "Iktató Szám";
            this.IktatoSzam.Name = "IktatoSzam";
            this.IktatoSzam.ReadOnly = true;
            // 
            // Koltseghely
            // 
            this.Koltseghely.DataPropertyName = "Koltseghely";
            this.Koltseghely.HeaderText = "Költséghely";
            this.Koltseghely.Name = "Koltseghely";
            this.Koltseghely.ReadOnly = true;
            // 
            // KltsgHNev
            // 
            this.KltsgHNev.DataPropertyName = "KltsgHNev";
            this.KltsgHNev.HeaderText = "Kltsg.hely Név";
            this.KltsgHNev.Name = "KltsgHNev";
            this.KltsgHNev.ReadOnly = true;
            this.KltsgHNev.Width = 150;
            // 
            // Szamligazol
            // 
            this.Szamligazol.DataPropertyName = "Szamligazol";
            this.Szamligazol.HeaderText = "Száml. Ig.";
            this.Szamligazol.Name = "Szamligazol";
            this.Szamligazol.ReadOnly = true;
            // 
            // SzamlIgIdo
            // 
            this.SzamlIgIdo.DataPropertyName = "SzamlIgIdo";
            this.SzamlIgIdo.HeaderText = "Száml.Ig.Idő";
            this.SzamlIgIdo.Name = "SzamlIgIdo";
            this.SzamlIgIdo.ReadOnly = true;
            // 
            // TeljIgazol
            // 
            this.TeljIgazol.DataPropertyName = "TeljIgazol";
            this.TeljIgazol.HeaderText = "Telj. Ig.";
            this.TeljIgazol.Name = "TeljIgazol";
            this.TeljIgazol.ReadOnly = true;
            // 
            // TeljIgIdo
            // 
            this.TeljIgIdo.DataPropertyName = "TeljIgIdo";
            this.TeljIgIdo.HeaderText = "Telj.Ig.Idő";
            this.TeljIgIdo.Name = "TeljIgIdo";
            this.TeljIgIdo.ReadOnly = true;
            // 
            // Form24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 563);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form24";
            this.Text = "Lezárt Szolgáltatási Igények";
            this.Load += new System.EventHandler(this.Form24_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBSzolgaltatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet24)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet24 dataSet24;
        private System.Windows.Forms.BindingSource nBSzolgaltatasBindingSource;
        private DataSet24TableAdapters.NBSzolgaltatasTableAdapter nBSzolgaltatasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendSorszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szolgaltatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzolgTipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkahelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gepSzerszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSZNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beruszamRACFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igenyloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendIdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engedelyezoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engIdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzamlazottAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IktatoSzam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koltseghely;
        private System.Windows.Forms.DataGridViewTextBoxColumn KltsgHNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szamligazol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzamlIgIdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeljIgazol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeljIgIdo;
    }
}