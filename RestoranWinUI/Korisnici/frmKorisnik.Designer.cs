namespace RestoranWinUI.Korisnici
{
    partial class frmKorisnik
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnZensko = new System.Windows.Forms.RadioButton();
            this.rbtnMusko = new System.Windows.Forms.RadioButton();
            this.dtpDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDatumZaposljavanja = new System.Windows.Forms.DateTimePicker();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(124, 26);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(201, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(125, 53);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // txtPasswordPotvrda
            // 
            this.txtPasswordPotvrda.Location = new System.Drawing.Point(125, 327);
            this.txtPasswordPotvrda.Name = "txtPasswordPotvrda";
            this.txtPasswordPotvrda.PasswordChar = '*';
            this.txtPasswordPotvrda.Size = new System.Drawing.Size(200, 20);
            this.txtPasswordPotvrda.TabIndex = 7;
            this.txtPasswordPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordPotvrda_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password potvrda";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 301);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(124, 370);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 8;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Spol";
            // 
            // rbtnZensko
            // 
            this.rbtnZensko.AutoSize = true;
            this.rbtnZensko.Location = new System.Drawing.Point(138, 79);
            this.rbtnZensko.Name = "rbtnZensko";
            this.rbtnZensko.Size = new System.Drawing.Size(61, 17);
            this.rbtnZensko.TabIndex = 10;
            this.rbtnZensko.TabStop = true;
            this.rbtnZensko.Text = "Zensko";
            this.rbtnZensko.UseVisualStyleBackColor = true;
            this.rbtnZensko.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnZensko_Validating);
            // 
            // rbtnMusko
            // 
            this.rbtnMusko.AutoSize = true;
            this.rbtnMusko.Location = new System.Drawing.Point(249, 79);
            this.rbtnMusko.Name = "rbtnMusko";
            this.rbtnMusko.Size = new System.Drawing.Size(57, 17);
            this.rbtnMusko.TabIndex = 11;
            this.rbtnMusko.TabStop = true;
            this.rbtnMusko.Text = "Musko";
            this.rbtnMusko.UseVisualStyleBackColor = true;
            this.rbtnMusko.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnMusko_Validating);
            // 
            // dtpDatumRodenja
            // 
            this.dtpDatumRodenja.Location = new System.Drawing.Point(125, 106);
            this.dtpDatumRodenja.MaxDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtpDatumRodenja.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDatumRodenja.Name = "dtpDatumRodenja";
            this.dtpDatumRodenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumRodenja.TabIndex = 12;
            this.dtpDatumRodenja.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtpDatumRodenja.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumRodenja_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum rodenja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Datum zaposljavanja";
            // 
            // dtpDatumZaposljavanja
            // 
            this.dtpDatumZaposljavanja.Location = new System.Drawing.Point(125, 132);
            this.dtpDatumZaposljavanja.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpDatumZaposljavanja.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpDatumZaposljavanja.Name = "dtpDatumZaposljavanja";
            this.dtpDatumZaposljavanja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumZaposljavanja.TabIndex = 14;
            this.dtpDatumZaposljavanja.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtpDatumZaposljavanja.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumZaposljavanja_Validating);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(125, 158);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(200, 20);
            this.txtKorisnickoIme.TabIndex = 17;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Korisnicko ime";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Uloga";
            // 
            // clbUloge
            // 
            this.clbUloge.FormattingEnabled = true;
            this.clbUloge.Location = new System.Drawing.Point(125, 187);
            this.clbUloge.Name = "clbUloge";
            this.clbUloge.Size = new System.Drawing.Size(200, 94);
            this.clbUloge.TabIndex = 20;
            this.clbUloge.Validating += new System.ComponentModel.CancelEventHandler(this.clbUloge_Validating);
            // 
            // pbxSlika
            // 
            this.pbxSlika.Location = new System.Drawing.Point(399, 29);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(109, 106);
            this.pbxSlika.TabIndex = 21;
            this.pbxSlika.TabStop = false;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(416, 182);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 22;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtSlika
            // 
            this.txtSlika.Enabled = false;
            this.txtSlika.Location = new System.Drawing.Point(388, 153);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(140, 20);
            this.txtSlika.TabIndex = 23;
            this.txtSlika.Validating += new System.ComponentModel.CancelEventHandler(this.txtSlika_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Slika";
            // 
            // frmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 402);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pbxSlika);
            this.Controls.Add(this.clbUloge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDatumZaposljavanja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDatumRodenja);
            this.Controls.Add(this.rbtnMusko);
            this.Controls.Add(this.rbtnZensko);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtPasswordPotvrda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "frmKorisnik";
            this.Text = "frmKorisnik";
            this.Load += new System.EventHandler(this.frmKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordPotvrda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnZensko;
        private System.Windows.Forms.RadioButton rbtnMusko;
        private System.Windows.Forms.DateTimePicker dtpDatumRodenja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposljavanja;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox clbUloge;
        private System.Windows.Forms.PictureBox pbxSlika;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSlika;
    }
}