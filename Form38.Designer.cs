namespace NonBom
{
    partial class Form38
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cetLeeISorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranzakcioSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beszRendSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beszRendSorSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tetelSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rACFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beszArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltseghelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leirasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osszegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBCetLeeSorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet38BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet38 = new NonBom.DataSet38();
            this.nBCetLeeSorTableAdapter = new NonBom.DataSet38TableAdapters.NBCetLeeSorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBCetLeeSorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet38BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet38)).BeginInit();
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
            this.cetLeeISorIDDataGridViewTextBoxColumn,
            this.tranzakcioSzamDataGridViewTextBoxColumn,
            this.sorszamDataGridViewTextBoxColumn,
            this.beszRendSzamDataGridViewTextBoxColumn,
            this.beszRendSorSzamDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.tetelSzamDataGridViewTextBoxColumn,
            this.rACFDataGridViewTextBoxColumn,
            this.beszArDataGridViewTextBoxColumn,
            this.egysArDataGridViewTextBoxColumn,
            this.mennyisegDataGridViewTextBoxColumn,
            this.koltseghelyDataGridViewTextBoxColumn,
            this.fKSZDataGridViewTextBoxColumn,
            this.leirasDataGridViewTextBoxColumn,
            this.osszegDataGridViewTextBoxColumn,
            this.devizaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nBCetLeeSorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1305, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // cetLeeISorIDDataGridViewTextBoxColumn
            // 
            this.cetLeeISorIDDataGridViewTextBoxColumn.DataPropertyName = "CetLeeISorID";
            this.cetLeeISorIDDataGridViewTextBoxColumn.HeaderText = "CetLeeISorID";
            this.cetLeeISorIDDataGridViewTextBoxColumn.Name = "cetLeeISorIDDataGridViewTextBoxColumn";
            this.cetLeeISorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tranzakcioSzamDataGridViewTextBoxColumn
            // 
            this.tranzakcioSzamDataGridViewTextBoxColumn.DataPropertyName = "TranzakcioSzam";
            this.tranzakcioSzamDataGridViewTextBoxColumn.HeaderText = "TranzakcioSzam";
            this.tranzakcioSzamDataGridViewTextBoxColumn.Name = "tranzakcioSzamDataGridViewTextBoxColumn";
            this.tranzakcioSzamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sorszamDataGridViewTextBoxColumn
            // 
            this.sorszamDataGridViewTextBoxColumn.DataPropertyName = "Sorszam";
            this.sorszamDataGridViewTextBoxColumn.HeaderText = "Sorszam";
            this.sorszamDataGridViewTextBoxColumn.Name = "sorszamDataGridViewTextBoxColumn";
            this.sorszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beszRendSzamDataGridViewTextBoxColumn
            // 
            this.beszRendSzamDataGridViewTextBoxColumn.DataPropertyName = "BeszRendSzam";
            this.beszRendSzamDataGridViewTextBoxColumn.HeaderText = "BeszRendSzam";
            this.beszRendSzamDataGridViewTextBoxColumn.Name = "beszRendSzamDataGridViewTextBoxColumn";
            this.beszRendSzamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beszRendSorSzamDataGridViewTextBoxColumn
            // 
            this.beszRendSorSzamDataGridViewTextBoxColumn.DataPropertyName = "BeszRendSorSzam";
            this.beszRendSorSzamDataGridViewTextBoxColumn.HeaderText = "BeszRendSorSzam";
            this.beszRendSorSzamDataGridViewTextBoxColumn.Name = "beszRendSorSzamDataGridViewTextBoxColumn";
            this.beszRendSorSzamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // megjegyzesDataGridViewTextBoxColumn
            // 
            this.megjegyzesDataGridViewTextBoxColumn.DataPropertyName = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.HeaderText = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.Name = "megjegyzesDataGridViewTextBoxColumn";
            this.megjegyzesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tetelSzamDataGridViewTextBoxColumn
            // 
            this.tetelSzamDataGridViewTextBoxColumn.DataPropertyName = "TetelSzam";
            this.tetelSzamDataGridViewTextBoxColumn.HeaderText = "TetelSzam";
            this.tetelSzamDataGridViewTextBoxColumn.Name = "tetelSzamDataGridViewTextBoxColumn";
            this.tetelSzamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rACFDataGridViewTextBoxColumn
            // 
            this.rACFDataGridViewTextBoxColumn.DataPropertyName = "RACF";
            this.rACFDataGridViewTextBoxColumn.HeaderText = "RACF";
            this.rACFDataGridViewTextBoxColumn.Name = "rACFDataGridViewTextBoxColumn";
            this.rACFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beszArDataGridViewTextBoxColumn
            // 
            this.beszArDataGridViewTextBoxColumn.DataPropertyName = "BeszAr";
            this.beszArDataGridViewTextBoxColumn.HeaderText = "Rend.Ár";
            this.beszArDataGridViewTextBoxColumn.Name = "beszArDataGridViewTextBoxColumn";
            this.beszArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // egysArDataGridViewTextBoxColumn
            // 
            this.egysArDataGridViewTextBoxColumn.DataPropertyName = "EgysAr";
            this.egysArDataGridViewTextBoxColumn.HeaderText = "Szla.Ár";
            this.egysArDataGridViewTextBoxColumn.Name = "egysArDataGridViewTextBoxColumn";
            this.egysArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            this.mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            this.mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiseg";
            this.mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            this.mennyisegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // koltseghelyDataGridViewTextBoxColumn
            // 
            this.koltseghelyDataGridViewTextBoxColumn.DataPropertyName = "Koltseghely";
            this.koltseghelyDataGridViewTextBoxColumn.HeaderText = "Koltseghely";
            this.koltseghelyDataGridViewTextBoxColumn.Name = "koltseghelyDataGridViewTextBoxColumn";
            this.koltseghelyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKSZDataGridViewTextBoxColumn
            // 
            this.fKSZDataGridViewTextBoxColumn.DataPropertyName = "FKSZ";
            this.fKSZDataGridViewTextBoxColumn.HeaderText = "FKSZ";
            this.fKSZDataGridViewTextBoxColumn.Name = "fKSZDataGridViewTextBoxColumn";
            this.fKSZDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leirasDataGridViewTextBoxColumn
            // 
            this.leirasDataGridViewTextBoxColumn.DataPropertyName = "Leiras";
            this.leirasDataGridViewTextBoxColumn.HeaderText = "Leiras";
            this.leirasDataGridViewTextBoxColumn.Name = "leirasDataGridViewTextBoxColumn";
            this.leirasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // osszegDataGridViewTextBoxColumn
            // 
            this.osszegDataGridViewTextBoxColumn.DataPropertyName = "Osszeg";
            this.osszegDataGridViewTextBoxColumn.HeaderText = "Osszeg";
            this.osszegDataGridViewTextBoxColumn.Name = "osszegDataGridViewTextBoxColumn";
            this.osszegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devizaDataGridViewTextBoxColumn
            // 
            this.devizaDataGridViewTextBoxColumn.DataPropertyName = "Deviza";
            this.devizaDataGridViewTextBoxColumn.HeaderText = "Deviza";
            this.devizaDataGridViewTextBoxColumn.Name = "devizaDataGridViewTextBoxColumn";
            this.devizaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nBCetLeeSorBindingSource
            // 
            this.nBCetLeeSorBindingSource.DataMember = "NBCetLeeSor";
            this.nBCetLeeSorBindingSource.DataSource = this.dataSet38BindingSource;
            // 
            // dataSet38BindingSource
            // 
            this.dataSet38BindingSource.DataSource = this.dataSet38;
            this.dataSet38BindingSource.Position = 0;
            // 
            // dataSet38
            // 
            this.dataSet38.DataSetName = "DataSet38";
            this.dataSet38.EnforceConstraints = false;
            this.dataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBCetLeeSorTableAdapter
            // 
            this.nBCetLeeSorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(83, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(84, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(976, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(976, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(84, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(83, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(83, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(83, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(293, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(293, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(293, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 23);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(540, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 23);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(540, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 23);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(540, 228);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(189, 23);
            this.textBox6.TabIndex = 14;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(84, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(630, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1061, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Nyomtatás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form38
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form38";
            this.Text = "Cetlee";
            this.Load += new System.EventHandler(this.Form38_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBCetLeeSorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet38BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet38)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nBCetLeeSorBindingSource;
        private System.Windows.Forms.BindingSource dataSet38BindingSource;
        private DataSet38 dataSet38;
        private DataSet38TableAdapters.NBCetLeeSorTableAdapter nBCetLeeSorTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cetLeeISorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranzakcioSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beszRendSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beszRendSorSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tetelSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rACFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beszArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egysArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltseghelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKSZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leirasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osszegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devizaDataGridViewTextBoxColumn;
    }
}