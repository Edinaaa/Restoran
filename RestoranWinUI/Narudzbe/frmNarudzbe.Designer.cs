namespace RestoranWinUI.Narudzbe
{
    partial class frmNarudzbe
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
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojStola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Narudzba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odobrena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Naplati = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Naplaceno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNarudzbe);
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narudzbe";
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaId,
            this.Rb,
            this.BrojStola,
            this.Narudzba,
            this.Cijena,
            this.Odobrena,
            this.Naplati,
            this.Naplaceno});
            this.dgvNarudzbe.Location = new System.Drawing.Point(23, 20);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.Size = new System.Drawing.Size(697, 299);
            this.dgvNarudzbe.TabIndex = 0;
            this.dgvNarudzbe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellClick);
            // 
            // NarudzbaId
            // 
            this.NarudzbaId.DataPropertyName = "NarudzbaId";
            this.NarudzbaId.FillWeight = 1F;
            this.NarudzbaId.HeaderText = "NarudzbaId";
            this.NarudzbaId.Name = "NarudzbaId";
            this.NarudzbaId.ReadOnly = true;
            this.NarudzbaId.Visible = false;
            this.NarudzbaId.Width = 5;
            // 
            // Rb
            // 
            this.Rb.HeaderText = "Rb";
            this.Rb.Name = "Rb";
            this.Rb.ReadOnly = true;
            this.Rb.Width = 50;
            // 
            // BrojStola
            // 
            this.BrojStola.DataPropertyName = "BrojStola";
            this.BrojStola.HeaderText = "BrojStola";
            this.BrojStola.Name = "BrojStola";
            this.BrojStola.ReadOnly = true;
            this.BrojStola.Width = 60;
            // 
            // Narudzba
            // 
            this.Narudzba.DataPropertyName = "Narudzba";
            this.Narudzba.HeaderText = "Narudzba";
            this.Narudzba.Name = "Narudzba";
            this.Narudzba.ReadOnly = true;
            this.Narudzba.Width = 280;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "CijenaSaPdv";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 80;
            // 
            // Odobrena
            // 
            this.Odobrena.DataPropertyName = "Odobrena";
            this.Odobrena.HeaderText = "Odobrena";
            this.Odobrena.Name = "Odobrena";
            this.Odobrena.ReadOnly = true;
            this.Odobrena.Width = 60;
            // 
            // Naplati
            // 
            this.Naplati.DataPropertyName = "Naplati";
            this.Naplati.HeaderText = "Naplati";
            this.Naplati.Name = "Naplati";
            this.Naplati.ReadOnly = true;
            this.Naplati.Width = 60;
            // 
            // Naplaceno
            // 
            this.Naplaceno.DataPropertyName = "Naplaceno";
            this.Naplaceno.HeaderText = "Naplaceno";
            this.Naplaceno.Name = "Naplaceno";
            this.Naplaceno.ReadOnly = true;
            this.Naplaceno.Width = 65;
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNarudzbe";
            this.Text = "frmNarudzbeLista";
            this.Load += new System.EventHandler(this.frmNarudzbeLista_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojStola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Narudzba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odobrena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Naplati;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Naplaceno;
    }
}