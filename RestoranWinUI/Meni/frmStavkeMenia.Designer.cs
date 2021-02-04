
namespace RestoranWinUI.Meni
{
    partial class frmStavkeMenia
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
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPdv = new System.Windows.Forms.TextBox();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(276, 41);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(123, 121);
            this.pbSlika.TabIndex = 41;
            this.pbSlika.TabStop = false;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(171, 207);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 40;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Popust";
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(146, 142);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(100, 20);
            this.txtPopust.TabIndex = 34;
            this.txtPopust.Validating += new System.ComponentModel.CancelEventHandler(this.txtPopust_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kategorija";
            // 
            // txtKategorija
            // 
            this.txtKategorija.Enabled = false;
            this.txtKategorija.Location = new System.Drawing.Point(146, 64);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(100, 20);
            this.txtKategorija.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(146, 117);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 26;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Enabled = false;
            this.txtNaziv.Location = new System.Drawing.Point(146, 38);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 24;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Pdv";
            // 
            // txtPdv
            // 
            this.txtPdv.Location = new System.Drawing.Point(146, 91);
            this.txtPdv.Name = "txtPdv";
            this.txtPdv.Size = new System.Drawing.Size(100, 20);
            this.txtPdv.TabIndex = 46;
            this.txtPdv.Validating += new System.ComponentModel.CancelEventHandler(this.txtPdv_Validating);
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(146, 168);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(62, 17);
            this.cbAktivan.TabIndex = 48;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmStavkeMenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 267);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPdv);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmStavkeMenia";
            this.Text = "frmStavkeMenia";
            this.Load += new System.EventHandler(this.frmStavkeMenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPdv;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}