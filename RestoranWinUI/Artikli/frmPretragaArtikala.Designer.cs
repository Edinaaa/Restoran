namespace RestoranWinUI.Artikli
{
    partial class frmPretragaArtikala
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cbxKategorije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.Artikli = new System.Windows.Forms.GroupBox();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.ArtikalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaSaPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNajProdavaniji = new System.Windows.Forms.CheckBox();
            this.Artikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(112, 33);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // cbxKategorije
            // 
            this.cbxKategorije.FormattingEnabled = true;
            this.cbxKategorije.Location = new System.Drawing.Point(112, 60);
            this.cbxKategorije.Name = "cbxKategorije";
            this.cbxKategorije.Size = new System.Drawing.Size(121, 21);
            this.cbxKategorije.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategorija";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(301, 36);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // Artikli
            // 
            this.Artikli.Controls.Add(this.dgvArtikli);
            this.Artikli.Location = new System.Drawing.Point(46, 127);
            this.Artikli.Name = "Artikli";
            this.Artikli.Size = new System.Drawing.Size(667, 296);
            this.Artikli.TabIndex = 5;
            this.Artikli.TabStop = false;
            this.Artikli.Text = "Artikli";
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtikalId,
            this.Slika,
            this.Naziv,
            this.Cijena,
            this.CijenaSaPdv,
            this.Pdv,
            this.Popust});
            this.dgvArtikli.Location = new System.Drawing.Point(6, 26);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            this.dgvArtikli.RowTemplate.Height = 40;
            this.dgvArtikli.Size = new System.Drawing.Size(645, 264);
            this.dgvArtikli.TabIndex = 0;
            this.dgvArtikli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikli_CellClick);
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
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Slika.Width = 102;
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
            this.CijenaSaPdv.HeaderText = "CijenaSaPdv";
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
            // Popust
            // 
            this.Popust.DataPropertyName = "Popust";
            this.Popust.HeaderText = "Popust";
            this.Popust.Name = "Popust";
            this.Popust.ReadOnly = true;
            // 
            // cbNajProdavaniji
            // 
            this.cbNajProdavaniji.AutoSize = true;
            this.cbNajProdavaniji.Location = new System.Drawing.Point(112, 87);
            this.cbNajProdavaniji.Name = "cbNajProdavaniji";
            this.cbNajProdavaniji.Size = new System.Drawing.Size(108, 17);
            this.cbNajProdavaniji.TabIndex = 7;
            this.cbNajProdavaniji.Text = "5 Najprodavanijih";
            this.cbNajProdavaniji.UseVisualStyleBackColor = true;
            // 
            // frmPretragaArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.cbNajProdavaniji);
            this.Controls.Add(this.Artikli);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxKategorije);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaArtikala";
            this.Text = "frmPretragaArtikala";
            this.Load += new System.EventHandler(this.frmPretragaArtikala_Load);
            this.Artikli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cbxKategorije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.GroupBox Artikli;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaSaPdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.CheckBox cbNajProdavaniji;
    }
}