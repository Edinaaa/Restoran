namespace RestoranWinUI.Meni
{
    partial class frmNoviMeni
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBNaziv = new System.Windows.Forms.TextBox();
            this.dtpDatumObjave = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKonobar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.ArtikalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Artikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaSaPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajArtikal = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.cbxVazevi = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtBNaziv
            // 
            this.txtBNaziv.Location = new System.Drawing.Point(109, 11);
            this.txtBNaziv.Name = "txtBNaziv";
            this.txtBNaziv.Size = new System.Drawing.Size(200, 20);
            this.txtBNaziv.TabIndex = 1;
            this.txtBNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtBNaziv_Validating);
            // 
            // dtpDatumObjave
            // 
            this.dtpDatumObjave.Enabled = false;
            this.dtpDatumObjave.Location = new System.Drawing.Point(109, 38);
            this.dtpDatumObjave.Name = "dtpDatumObjave";
            this.dtpDatumObjave.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumObjave.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum objave";
            // 
            // txtKonobar
            // 
            this.txtKonobar.Location = new System.Drawing.Point(109, 73);
            this.txtKonobar.Name = "txtKonobar";
            this.txtKonobar.Size = new System.Drawing.Size(200, 20);
            this.txtKonobar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Konobar";
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AllowUserToDeleteRows = false;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtikalId,
            this.Slika,
            this.Artikal,
            this.Popust,
            this.Cijena,
            this.CijenaSaPdv,
            this.Kategorija});
            this.dgvStavke.Location = new System.Drawing.Point(6, 19);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.RowTemplate.Height = 60;
            this.dgvStavke.Size = new System.Drawing.Size(647, 268);
            this.dgvStavke.TabIndex = 6;
            this.dgvStavke.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStavke_CellClick);
            this.dgvStavke.Validating += new System.ComponentModel.CancelEventHandler(this.dgvStavke_Validating);
            // 
            // ArtikalId
            // 
            this.ArtikalId.DataPropertyName = "ArtikalId";
            this.ArtikalId.HeaderText = "ArtikalId";
            this.ArtikalId.Name = "ArtikalId";
            this.ArtikalId.ReadOnly = true;
            this.ArtikalId.Visible = false;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Artikal
            // 
            this.Artikal.DataPropertyName = "Naziv";
            this.Artikal.HeaderText = "Naziv artikla";
            this.Artikal.Name = "Artikal";
            this.Artikal.ReadOnly = true;
            // 
            // Popust
            // 
            this.Popust.DataPropertyName = "Popust";
            this.Popust.HeaderText = "Popust";
            this.Popust.Name = "Popust";
            this.Popust.ReadOnly = true;
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
            this.CijenaSaPdv.HeaderText = "CijenaSaPdv";
            this.CijenaSaPdv.Name = "CijenaSaPdv";
            this.CijenaSaPdv.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStavke);
            this.groupBox1.Location = new System.Drawing.Point(27, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 301);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke menia";
            // 
            // btnDodajArtikal
            // 
            this.btnDodajArtikal.Location = new System.Drawing.Point(578, 73);
            this.btnDodajArtikal.Name = "btnDodajArtikal";
            this.btnDodajArtikal.Size = new System.Drawing.Size(75, 23);
            this.btnDodajArtikal.TabIndex = 8;
            this.btnDodajArtikal.Text = "Dodaj artikal";
            this.btnDodajArtikal.UseVisualStyleBackColor = true;
            this.btnDodajArtikal.Click += new System.EventHandler(this.btnDodajArtikal_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(578, 14);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 9;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // cbxVazevi
            // 
            this.cbxVazevi.AutoSize = true;
            this.cbxVazevi.Location = new System.Drawing.Point(350, 14);
            this.cbxVazevi.Name = "cbxVazevi";
            this.cbxVazevi.Size = new System.Drawing.Size(58, 17);
            this.cbxVazevi.TabIndex = 10;
            this.cbxVazevi.Text = "Vazeci";
            this.cbxVazevi.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmNoviMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.cbxVazevi);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnDodajArtikal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKonobar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumObjave);
            this.Controls.Add(this.txtBNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviMeni";
            this.Text = "frmNoviMeni";
            this.Load += new System.EventHandler(this.frmNoviMeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBNaziv;
        private System.Windows.Forms.DateTimePicker dtpDatumObjave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKonobar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajArtikal;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.CheckBox cbxVazevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaSaPdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}