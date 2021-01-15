namespace RestoranWinUI.Narudzbe
{
    partial class frmNarudzba
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStavkeNarudzbe = new System.Windows.Forms.DataGridView();
            this.StavkaNarudzbeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaSaPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDatumNarudzbe = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojStola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCijenaSaPdv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.btnNaplati = new System.Windows.Forms.Button();
            this.cbNaplataKreditima = new System.Windows.Forms.CheckBox();
            this.cbNaplaceno = new System.Windows.Forms.CheckBox();
            this.cbOdobri = new System.Windows.Forms.CheckBox();
            this.cbOdbij = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStavkeNarudzbe);
            this.groupBox1.Location = new System.Drawing.Point(29, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke narudzbe";
            // 
            // dgvStavkeNarudzbe
            // 
            this.dgvStavkeNarudzbe.AllowUserToAddRows = false;
            this.dgvStavkeNarudzbe.AllowUserToDeleteRows = false;
            this.dgvStavkeNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StavkaNarudzbeId,
            this.Slika,
            this.Naziv,
            this.Cijena,
            this.PDV,
            this.CijenaSaPdv,
            this.Kolicina});
            this.dgvStavkeNarudzbe.Location = new System.Drawing.Point(7, 20);
            this.dgvStavkeNarudzbe.Name = "dgvStavkeNarudzbe";
            this.dgvStavkeNarudzbe.ReadOnly = true;
            this.dgvStavkeNarudzbe.Size = new System.Drawing.Size(589, 281);
            this.dgvStavkeNarudzbe.TabIndex = 0;
            // 
            // StavkaNarudzbeId
            // 
            this.StavkaNarudzbeId.DataPropertyName = "StavkaNarudzbeId";
            this.StavkaNarudzbeId.HeaderText = "StavkaNarudzbeId";
            this.StavkaNarudzbeId.Name = "StavkaNarudzbeId";
            this.StavkaNarudzbeId.ReadOnly = true;
            this.StavkaNarudzbeId.Visible = false;
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
            // PDV
            // 
            this.PDV.DataPropertyName = "PDV";
            this.PDV.HeaderText = "PDV";
            this.PDV.Name = "PDV";
            this.PDV.ReadOnly = true;
            // 
            // CijenaSaPdv
            // 
            this.CijenaSaPdv.DataPropertyName = "CijenaSaPdv";
            this.CijenaSaPdv.HeaderText = "Cijena sa pdv";
            this.CijenaSaPdv.Name = "CijenaSaPdv";
            this.CijenaSaPdv.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // dtpDatumNarudzbe
            // 
            this.dtpDatumNarudzbe.Enabled = false;
            this.dtpDatumNarudzbe.Location = new System.Drawing.Point(37, 26);
            this.dtpDatumNarudzbe.Name = "dtpDatumNarudzbe";
            this.dtpDatumNarudzbe.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumNarudzbe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum narudzbe";
            // 
            // txtBrojStola
            // 
            this.txtBrojStola.Enabled = false;
            this.txtBrojStola.Location = new System.Drawing.Point(262, 26);
            this.txtBrojStola.Name = "txtBrojStola";
            this.txtBrojStola.Size = new System.Drawing.Size(51, 20);
            this.txtBrojStola.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj stola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kupac";
            // 
            // txtKupac
            // 
            this.txtKupac.Enabled = false;
            this.txtKupac.Location = new System.Drawing.Point(334, 26);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(123, 20);
            this.txtKupac.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Enabled = false;
            this.txtCijena.Location = new System.Drawing.Point(104, 94);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cijena sa PDVom";
            // 
            // txtCijenaSaPdv
            // 
            this.txtCijenaSaPdv.Enabled = false;
            this.txtCijenaSaPdv.Location = new System.Drawing.Point(210, 94);
            this.txtCijenaSaPdv.Name = "txtCijenaSaPdv";
            this.txtCijenaSaPdv.Size = new System.Drawing.Size(100, 20);
            this.txtCijenaSaPdv.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "PDV";
            // 
            // txtPDV
            // 
            this.txtPDV.Enabled = false;
            this.txtPDV.Location = new System.Drawing.Point(34, 94);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(64, 20);
            this.txtPDV.TabIndex = 11;
            // 
            // btnNaplati
            // 
            this.btnNaplati.Location = new System.Drawing.Point(550, 26);
            this.btnNaplati.Name = "btnNaplati";
            this.btnNaplati.Size = new System.Drawing.Size(75, 23);
            this.btnNaplati.TabIndex = 13;
            this.btnNaplati.Text = "Naplati";
            this.btnNaplati.UseVisualStyleBackColor = true;
            this.btnNaplati.Click += new System.EventHandler(this.btnNaplati_Click);
            // 
            // cbNaplataKreditima
            // 
            this.cbNaplataKreditima.AutoCheck = false;
            this.cbNaplataKreditima.AutoSize = true;
            this.cbNaplataKreditima.Location = new System.Drawing.Point(349, 64);
            this.cbNaplataKreditima.Name = "cbNaplataKreditima";
            this.cbNaplataKreditima.Size = new System.Drawing.Size(108, 17);
            this.cbNaplataKreditima.TabIndex = 14;
            this.cbNaplataKreditima.Text = "Naplata kreditima";
            this.cbNaplataKreditima.UseVisualStyleBackColor = true;
            // 
            // cbNaplaceno
            // 
            this.cbNaplaceno.AutoCheck = false;
            this.cbNaplaceno.AutoSize = true;
            this.cbNaplaceno.Location = new System.Drawing.Point(349, 96);
            this.cbNaplaceno.Name = "cbNaplaceno";
            this.cbNaplaceno.Size = new System.Drawing.Size(78, 17);
            this.cbNaplaceno.TabIndex = 15;
            this.cbNaplaceno.Text = "Naplaceno";
            this.cbNaplaceno.UseVisualStyleBackColor = true;
            // 
            // cbOdobri
            // 
            this.cbOdobri.AutoSize = true;
            this.cbOdobri.Location = new System.Drawing.Point(547, 64);
            this.cbOdobri.Name = "cbOdobri";
            this.cbOdobri.Size = new System.Drawing.Size(57, 17);
            this.cbOdobri.TabIndex = 16;
            this.cbOdobri.Text = "Odobri";
            this.cbOdobri.UseVisualStyleBackColor = true;
            this.cbOdobri.Click += new System.EventHandler(this.cbOdobri_Click);
            // 
            // cbOdbij
            // 
            this.cbOdbij.AutoSize = true;
            this.cbOdbij.Location = new System.Drawing.Point(547, 94);
            this.cbOdbij.Name = "cbOdbij";
            this.cbOdbij.Size = new System.Drawing.Size(50, 17);
            this.cbOdbij.TabIndex = 17;
            this.cbOdbij.Text = "Odbij";
            this.cbOdbij.UseVisualStyleBackColor = true;
            this.cbOdbij.Click += new System.EventHandler(this.cbOdbij_Click);
            // 
            // frmNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.cbOdbij);
            this.Controls.Add(this.cbOdobri);
            this.Controls.Add(this.cbNaplaceno);
            this.Controls.Add(this.cbNaplataKreditima);
            this.Controls.Add(this.btnNaplati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCijenaSaPdv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojStola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumNarudzbe);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNarudzba";
            this.Text = "frmNarudzba";
            this.Load += new System.EventHandler(this.frmNarudzba_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStavkeNarudzbe;
        private System.Windows.Forms.DateTimePicker dtpDatumNarudzbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojStola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCijenaSaPdv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Button btnNaplati;
        private System.Windows.Forms.CheckBox cbNaplataKreditima;
        private System.Windows.Forms.CheckBox cbNaplaceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn StavkaNarudzbeId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaSaPdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.CheckBox cbOdobri;
        private System.Windows.Forms.CheckBox cbOdbij;
    }
}