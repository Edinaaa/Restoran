namespace RestoranWinUI.Ponude
{
    partial class frmNovaPonuda
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
            this.txtKonobar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKombinacije = new System.Windows.Forms.DataGridView();
            this.KombinacijeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaSaPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajKombinaciju = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKombinacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKonobar
            // 
            this.txtKonobar.Location = new System.Drawing.Point(135, 81);
            this.txtKonobar.Name = "txtKonobar";
            this.txtKonobar.Size = new System.Drawing.Size(200, 20);
            this.txtKonobar.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Konobar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum zavrsetka";
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(135, 46);
            this.dtpDatumZavrsetka.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumZavrsetka.TabIndex = 8;
            this.dtpDatumZavrsetka.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumZavrsetka_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Datum pocetka";
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Location = new System.Drawing.Point(135, 12);
            this.dtpDatumPocetka.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumPocetka.TabIndex = 12;
            this.dtpDatumPocetka.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumPocetka_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKombinacije);
            this.groupBox1.Location = new System.Drawing.Point(21, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 301);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kombinacije";
            // 
            // dgvKombinacije
            // 
            this.dgvKombinacije.AllowUserToAddRows = false;
            this.dgvKombinacije.AllowUserToDeleteRows = false;
            this.dgvKombinacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKombinacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KombinacijeId,
            this.Slika,
            this.Naziv,
            this.Cijena,
            this.CijenaSaPdv,
            this.Pdv});
            this.dgvKombinacije.Location = new System.Drawing.Point(6, 19);
            this.dgvKombinacije.Name = "dgvKombinacije";
            this.dgvKombinacije.ReadOnly = true;
            this.dgvKombinacije.Size = new System.Drawing.Size(549, 268);
            this.dgvKombinacije.TabIndex = 6;
            this.dgvKombinacije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKombinacije_CellClick);
            // 
            // KombinacijeId
            // 
            this.KombinacijeId.DataPropertyName = "KombinacijaId";
            this.KombinacijeId.HeaderText = "KombinacijeId";
            this.KombinacijeId.Name = "KombinacijeId";
            this.KombinacijeId.ReadOnly = true;
            this.KombinacijeId.Visible = false;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // CijenaSaPdv
            // 
            this.CijenaSaPdv.DataPropertyName = "CijenaSaPdv";
            this.CijenaSaPdv.HeaderText = "Cijena sa PDV";
            this.CijenaSaPdv.Name = "CijenaSaPdv";
            this.CijenaSaPdv.ReadOnly = true;
            // 
            // Pdv
            // 
            this.Pdv.DataPropertyName = "Pdv";
            this.Pdv.HeaderText = "Pdv";
            this.Pdv.Name = "Pdv";
            this.Pdv.ReadOnly = true;
            // 
            // btnDodajKombinaciju
            // 
            this.btnDodajKombinaciju.Location = new System.Drawing.Point(472, 84);
            this.btnDodajKombinaciju.Name = "btnDodajKombinaciju";
            this.btnDodajKombinaciju.Size = new System.Drawing.Size(123, 23);
            this.btnDodajKombinaciju.TabIndex = 15;
            this.btnDodajKombinaciju.Text = "Dodaj kombinaciju";
            this.btnDodajKombinaciju.UseVisualStyleBackColor = true;
            this.btnDodajKombinaciju.Click += new System.EventHandler(this.btnDodajKombinaciju_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(512, 13);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(83, 23);
            this.btnSnimi.TabIndex = 16;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmNovaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnDodajKombinaciju);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumPocetka);
            this.Controls.Add(this.txtKonobar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumZavrsetka);
            this.Name = "frmNovaPonuda";
            this.Text = "frmNovaPonuda";
            this.Load += new System.EventHandler(this.frmNovaPonuda_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKombinacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKonobar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKombinacije;
        private System.Windows.Forms.Button btnDodajKombinaciju;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KombinacijeId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaSaPdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdv;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}