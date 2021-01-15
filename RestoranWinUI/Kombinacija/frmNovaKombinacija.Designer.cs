namespace RestoranWinUI.Kombinacija
{
    partial class frmNovaKombinacija
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.ArtikalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StavkeKombinacijeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaSaPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtCijenaSaPdv = new System.Windows.Forms.TextBox();
            this.txtPdv = new System.Windows.Forms.TextBox();
            this.btnDodajArtikal = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(225, 30);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(66, 139);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 4;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvArtikli);
            this.groupBox1.Location = new System.Drawing.Point(26, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 275);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artikli";
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtikalId,
            this.StavkeKombinacijeId,
            this.Slika,
            this.Naziv,
            this.Cijena,
            this.CijenaSaPdv,
            this.Pdv,
            this.Kolicina});
            this.dgvArtikli.Location = new System.Drawing.Point(18, 19);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            this.dgvArtikli.Size = new System.Drawing.Size(644, 251);
            this.dgvArtikli.TabIndex = 1;
            this.dgvArtikli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikli_CellClick);
            this.dgvArtikli.Validating += new System.ComponentModel.CancelEventHandler(this.dgvArtikli_Validating);
            // 
            // ArtikalId
            // 
            this.ArtikalId.DataPropertyName = "ArtikalId";
            this.ArtikalId.HeaderText = "ArtikalId";
            this.ArtikalId.Name = "ArtikalId";
            this.ArtikalId.ReadOnly = true;
            this.ArtikalId.Visible = false;
            // 
            // StavkeKombinacijeId
            // 
            this.StavkeKombinacijeId.DataPropertyName = "StavkeKombinacijeId";
            this.StavkeKombinacijeId.HeaderText = "StavkeKombinacijeId";
            this.StavkeKombinacijeId.Name = "StavkeKombinacijeId";
            this.StavkeKombinacijeId.ReadOnly = true;
            this.StavkeKombinacijeId.Visible = false;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.Pdv.DataPropertyName = "PDV";
            this.Pdv.HeaderText = "Pdv";
            this.Pdv.Name = "Pdv";
            this.Pdv.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ukupno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cijena sa pdvom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pdv";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(225, 83);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 11;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // txtCijenaSaPdv
            // 
            this.txtCijenaSaPdv.Enabled = false;
            this.txtCijenaSaPdv.Location = new System.Drawing.Point(342, 83);
            this.txtCijenaSaPdv.Name = "txtCijenaSaPdv";
            this.txtCijenaSaPdv.Size = new System.Drawing.Size(100, 20);
            this.txtCijenaSaPdv.TabIndex = 12;
            // 
            // txtPdv
            // 
            this.txtPdv.Location = new System.Drawing.Point(460, 83);
            this.txtPdv.Name = "txtPdv";
            this.txtPdv.Size = new System.Drawing.Size(100, 20);
            this.txtPdv.TabIndex = 13;
            this.txtPdv.Validating += new System.ComponentModel.CancelEventHandler(this.txtPdv_Validating);
            // 
            // btnDodajArtikal
            // 
            this.btnDodajArtikal.Location = new System.Drawing.Point(613, 124);
            this.btnDodajArtikal.Name = "btnDodajArtikal";
            this.btnDodajArtikal.Size = new System.Drawing.Size(75, 23);
            this.btnDodajArtikal.TabIndex = 14;
            this.btnDodajArtikal.Text = "Dodaj artikal";
            this.btnDodajArtikal.UseVisualStyleBackColor = true;
            this.btnDodajArtikal.Click += new System.EventHandler(this.btnDodajArtikal_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(613, 27);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 15;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(44, 12);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(121, 91);
            this.pbSlika.TabIndex = 5;
            this.pbSlika.TabStop = false;
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(613, 56);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 16;
            this.btnPonisti.Text = "Ponisti";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // txtSlika
            // 
            this.txtSlika.Enabled = false;
            this.txtSlika.Location = new System.Drawing.Point(59, 113);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(109, 20);
            this.txtSlika.TabIndex = 17;
            this.txtSlika.Validating += new System.ComponentModel.CancelEventHandler(this.txtSlika_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Slika";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmNovaKombinacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnDodajArtikal);
            this.Controls.Add(this.txtPdv);
            this.Controls.Add(this.txtCijenaSaPdv);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmNovaKombinacija";
            this.Text = "frmNovaKombinacija";
            this.Load += new System.EventHandler(this.frmNovaKombinacija_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtCijenaSaPdv;
        private System.Windows.Forms.TextBox txtPdv;
        private System.Windows.Forms.Button btnDodajArtikal;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StavkeKombinacijeId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaSaPdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}