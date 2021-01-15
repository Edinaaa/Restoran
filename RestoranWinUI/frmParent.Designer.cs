namespace RestoranWinUI
{
    partial class frmParent
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciDetaljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreditiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudzbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviArtikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviMeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaMeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Obavijesti = new System.Windows.Forms.Label();
            this.clbNotifikacije = new System.Windows.Forms.CheckedListBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOpcije = new System.Windows.Forms.Button();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSmjena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem,
            this.narudzbaToolStripMenuItem,
            this.artikalToolStripMenuItem,
            this.meniToolStripMenuItem,
            this.ponudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(787, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(126, 411);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciDetaljiToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem,
            this.kreditiToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // korisniciDetaljiToolStripMenuItem
            // 
            this.korisniciDetaljiToolStripMenuItem.Name = "korisniciDetaljiToolStripMenuItem";
            this.korisniciDetaljiToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.korisniciDetaljiToolStripMenuItem.Text = "Pretraga korisnika";
            this.korisniciDetaljiToolStripMenuItem.Click += new System.EventHandler(this.korisniciDetaljiToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // kreditiToolStripMenuItem
            // 
            this.kreditiToolStripMenuItem.Name = "kreditiToolStripMenuItem";
            this.kreditiToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kreditiToolStripMenuItem.Text = "Krediti";
            this.kreditiToolStripMenuItem.Click += new System.EventHandler(this.kreditiToolStripMenuItem_Click);
            // 
            // narudzbaToolStripMenuItem
            // 
            this.narudzbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudzbeToolStripMenuItem});
            this.narudzbaToolStripMenuItem.Name = "narudzbaToolStripMenuItem";
            this.narudzbaToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.narudzbaToolStripMenuItem.Text = "Narudzba";
            // 
            // narudzbeToolStripMenuItem
            // 
            this.narudzbeToolStripMenuItem.Name = "narudzbeToolStripMenuItem";
            this.narudzbeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.narudzbeToolStripMenuItem.Text = "Narudzbe";
            this.narudzbeToolStripMenuItem.Click += new System.EventHandler(this.narudzbeToolStripMenuItem_Click);
            // 
            // artikalToolStripMenuItem
            // 
            this.artikalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviArtikalToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.artikalToolStripMenuItem.Name = "artikalToolStripMenuItem";
            this.artikalToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.artikalToolStripMenuItem.Text = "Artikal";
            // 
            // noviArtikalToolStripMenuItem
            // 
            this.noviArtikalToolStripMenuItem.Name = "noviArtikalToolStripMenuItem";
            this.noviArtikalToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.noviArtikalToolStripMenuItem.Text = "Novi artikal";
            this.noviArtikalToolStripMenuItem.Click += new System.EventHandler(this.noviArtikalToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga ";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviMeniToolStripMenuItem,
            this.pretragaMeniaToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // noviMeniToolStripMenuItem
            // 
            this.noviMeniToolStripMenuItem.Name = "noviMeniToolStripMenuItem";
            this.noviMeniToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.noviMeniToolStripMenuItem.Text = "Novi meni";
            this.noviMeniToolStripMenuItem.Click += new System.EventHandler(this.noviMeniToolStripMenuItem_Click);
            // 
            // pretragaMeniaToolStripMenuItem
            // 
            this.pretragaMeniaToolStripMenuItem.Name = "pretragaMeniaToolStripMenuItem";
            this.pretragaMeniaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pretragaMeniaToolStripMenuItem.Text = "Pretraga menia";
            this.pretragaMeniaToolStripMenuItem.Click += new System.EventHandler(this.pretragaMeniaToolStripMenuItem_Click);
            // 
            // ponudaToolStripMenuItem
            // 
            this.ponudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPonudaToolStripMenuItem,
            this.pretragaPonudaToolStripMenuItem});
            this.ponudaToolStripMenuItem.Name = "ponudaToolStripMenuItem";
            this.ponudaToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.ponudaToolStripMenuItem.Text = "Ponuda";
            // 
            // novaPonudaToolStripMenuItem
            // 
            this.novaPonudaToolStripMenuItem.Name = "novaPonudaToolStripMenuItem";
            this.novaPonudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaPonudaToolStripMenuItem.Text = "Nova ponuda";
            this.novaPonudaToolStripMenuItem.Click += new System.EventHandler(this.novaPonudaToolStripMenuItem_Click);
            // 
            // pretragaPonudaToolStripMenuItem
            // 
            this.pretragaPonudaToolStripMenuItem.Name = "pretragaPonudaToolStripMenuItem";
            this.pretragaPonudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaPonudaToolStripMenuItem.Text = "Pretraga ponuda";
            this.pretragaPonudaToolStripMenuItem.Click += new System.EventHandler(this.pretragaPonudaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(787, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Obavijesti);
            this.panel1.Controls.Add(this.clbNotifikacije);
            this.panel1.Controls.Add(this.txtImePrezime);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnOpcije);
            this.panel1.Controls.Add(this.pbxSlika);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 386);
            this.panel1.TabIndex = 4;
            // 
            // Obavijesti
            // 
            this.Obavijesti.AutoSize = true;
            this.Obavijesti.Location = new System.Drawing.Point(27, 154);
            this.Obavijesti.Name = "Obavijesti";
            this.Obavijesti.Size = new System.Drawing.Size(53, 13);
            this.Obavijesti.TabIndex = 10;
            this.Obavijesti.Text = "Obavijesti";
            // 
            // clbNotifikacije
            // 
            this.clbNotifikacije.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clbNotifikacije.FormattingEnabled = true;
            this.clbNotifikacije.Location = new System.Drawing.Point(13, 173);
            this.clbNotifikacije.Name = "clbNotifikacije";
            this.clbNotifikacije.Size = new System.Drawing.Size(149, 184);
            this.clbNotifikacije.TabIndex = 9;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtImePrezime.Location = new System.Drawing.Point(12, 113);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(150, 20);
            this.txtImePrezime.TabIndex = 8;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::RestoranWinUI.Properties.Resources.Logout24;
            this.btnLogOut.Location = new System.Drawing.Point(127, 64);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(39, 36);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOpcije
            // 
            this.btnOpcije.Image = global::RestoranWinUI.Properties.Resources.options24;
            this.btnOpcije.Location = new System.Drawing.Point(127, 25);
            this.btnOpcije.Name = "btnOpcije";
            this.btnOpcije.Size = new System.Drawing.Size(39, 33);
            this.btnOpcije.TabIndex = 6;
            this.btnOpcije.UseVisualStyleBackColor = true;
            this.btnOpcije.Click += new System.EventHandler(this.btnOpcije_Click);
            // 
            // pbxSlika
            // 
            this.pbxSlika.Location = new System.Drawing.Point(12, 12);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(100, 95);
            this.pbxSlika.TabIndex = 5;
            this.pbxSlika.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.txtSmjena);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDatum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 100);
            this.panel2.TabIndex = 5;
            // 
            // txtSmjena
            // 
            this.txtSmjena.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtSmjena.Location = new System.Drawing.Point(534, 12);
            this.txtSmjena.Name = "txtSmjena";
            this.txtSmjena.Size = new System.Drawing.Size(100, 20);
            this.txtSmjena.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Smjena";
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtDatum.Location = new System.Drawing.Point(60, 10);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmParent";
            this.Text = "frmParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciDetaljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudzbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudzbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviArtikalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviMeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaMeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPonudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnOpcije;
        private System.Windows.Forms.PictureBox pbxSlika;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Obavijesti;
        private System.Windows.Forms.CheckedListBox clbNotifikacije;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSmjena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem kreditiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaPonudaToolStripMenuItem;
    }
}



