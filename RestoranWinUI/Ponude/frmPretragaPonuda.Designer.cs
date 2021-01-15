namespace RestoranWinUI.Ponude
{
    partial class frmPretragaPonuda
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
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPonude = new System.Windows.Forms.DataGridView();
            this.PonudaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZavrsetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konobar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.cbxKorisnik = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonude)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(385, 90);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 0;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPonude);
            this.groupBox1.Location = new System.Drawing.Point(49, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ponude";
            // 
            // dgvPonude
            // 
            this.dgvPonude.AllowUserToAddRows = false;
            this.dgvPonude.AllowUserToDeleteRows = false;
            this.dgvPonude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonude.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PonudaId,
            this.DatumPocetka,
            this.DatumZavrsetka,
            this.Konobar});
            this.dgvPonude.Location = new System.Drawing.Point(19, 19);
            this.dgvPonude.Name = "dgvPonude";
            this.dgvPonude.ReadOnly = true;
            this.dgvPonude.Size = new System.Drawing.Size(345, 252);
            this.dgvPonude.TabIndex = 0;
            this.dgvPonude.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPonude_CellClick);
            // 
            // PonudaId
            // 
            this.PonudaId.DataPropertyName = "PonudaId";
            this.PonudaId.HeaderText = "PonudaId";
            this.PonudaId.Name = "PonudaId";
            this.PonudaId.ReadOnly = true;
            this.PonudaId.Visible = false;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "DatumPocetka";
            this.DatumPocetka.Name = "DatumPocetka";
            this.DatumPocetka.ReadOnly = true;
            // 
            // DatumZavrsetka
            // 
            this.DatumZavrsetka.DataPropertyName = "DatumZavrsetka";
            this.DatumZavrsetka.HeaderText = "DatumZavrsetka";
            this.DatumZavrsetka.Name = "DatumZavrsetka";
            this.DatumZavrsetka.ReadOnly = true;
            // 
            // Konobar
            // 
            this.Konobar.DataPropertyName = "KorisnickoIme";
            this.Konobar.HeaderText = "Konobar";
            this.Konobar.Name = "Konobar";
            this.Konobar.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Datum pocetka";
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Location = new System.Drawing.Point(118, 28);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.ShowCheckBox = true;
            this.dtpDatumPocetka.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumPocetka.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Konobar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datum zavrsetka";
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(118, 62);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.ShowCheckBox = true;
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumZavrsetka.TabIndex = 14;
            // 
            // cbxKorisnik
            // 
            this.cbxKorisnik.FormattingEnabled = true;
            this.cbxKorisnik.Location = new System.Drawing.Point(118, 100);
            this.cbxKorisnik.Name = "cbxKorisnik";
            this.cbxKorisnik.Size = new System.Drawing.Size(200, 21);
            this.cbxKorisnik.TabIndex = 20;
            // 
            // frmPretragaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.cbxKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumPocetka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumZavrsetka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretrazi);
            this.Name = "frmPretragaPonuda";
            this.Text = "frmPretragaPonuda";
            this.Load += new System.EventHandler(this.frmPretragaPonuda_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPonude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
        private System.Windows.Forms.ComboBox cbxKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn PonudaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZavrsetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konobar;
    }
}