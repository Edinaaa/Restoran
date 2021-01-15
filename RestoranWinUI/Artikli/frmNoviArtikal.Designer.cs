namespace RestoranWinUI.Artikli
{
    partial class frmNoviArtikal
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSastav = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cbxJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijenaSaPdv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(166, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(166, 66);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 2;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PDV";
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(166, 137);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(100, 20);
            this.txtPDV.TabIndex = 6;
            this.txtPDV.Validating += new System.ComponentModel.CancelEventHandler(this.txtPDV_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sastav";
            // 
            // txtSastav
            // 
            this.txtSastav.Location = new System.Drawing.Point(166, 168);
            this.txtSastav.Name = "txtSastav";
            this.txtSastav.Size = new System.Drawing.Size(100, 20);
            this.txtSastav.TabIndex = 8;
            this.txtSastav.Validating += new System.ComponentModel.CancelEventHandler(this.txtSastav_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Popust";
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(166, 195);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(100, 20);
            this.txtPopust.TabIndex = 10;
            this.txtPopust.Validating += new System.ComponentModel.CancelEventHandler(this.txtPopust_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(166, 253);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 12;
            this.txtKolicina.Validating += new System.ComponentModel.CancelEventHandler(this.txtKolicina_Validating);
            // 
            // cbxJedinicaMjere
            // 
            this.cbxJedinicaMjere.FormattingEnabled = true;
            this.cbxJedinicaMjere.Location = new System.Drawing.Point(309, 250);
            this.cbxJedinicaMjere.Name = "cbxJedinicaMjere";
            this.cbxJedinicaMjere.Size = new System.Drawing.Size(67, 21);
            this.cbxJedinicaMjere.TabIndex = 14;
            this.cbxJedinicaMjere.Validating += new System.ComponentModel.CancelEventHandler(this.cbxJedinicaMjere_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "jm";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(205, 313);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 16;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(362, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(123, 121);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(399, 192);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 18;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kategorija";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(166, 226);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(100, 21);
            this.cbKategorija.TabIndex = 21;
            this.cbKategorija.Validating += new System.ComponentModel.CancelEventHandler(this.cbKategorija_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Slika";
            // 
            // txtSlika
            // 
            this.txtSlika.Enabled = false;
            this.txtSlika.Location = new System.Drawing.Point(345, 163);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(156, 20);
            this.txtSlika.TabIndex = 22;
            this.txtSlika.Validating += new System.ComponentModel.CancelEventHandler(this.txtSlika_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cijena sa pdvom";
            // 
            // txtCijenaSaPdv
            // 
            this.txtCijenaSaPdv.Enabled = false;
            this.txtCijenaSaPdv.Location = new System.Drawing.Point(168, 101);
            this.txtCijenaSaPdv.Name = "txtCijenaSaPdv";
            this.txtCijenaSaPdv.Size = new System.Drawing.Size(100, 20);
            this.txtCijenaSaPdv.TabIndex = 24;
            // 
            // frmNoviArtikal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijenaSaPdv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxJedinicaMjere);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSastav);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmNoviArtikal";
            this.Text = "frmNoviArtikal";
            this.Load += new System.EventHandler(this.frmNoviArtikal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSastav;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cbxJedinicaMjere;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijenaSaPdv;
    }
}