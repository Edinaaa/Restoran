namespace RestoranWinUI.Meni
{
    partial class frmPretragaMenia
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMeni = new System.Windows.Forms.DataGridView();
            this.MeniId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konobar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vazeci = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.rbtnVazeci = new System.Windows.Forms.RadioButton();
            this.rbtnNeVazeci = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeni)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(131, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(100, 20);
            this.txtPretraga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMeni);
            this.groupBox1.Location = new System.Drawing.Point(39, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 355);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meni";
            // 
            // dgvMeni
            // 
            this.dgvMeni.AllowUserToAddRows = false;
            this.dgvMeni.AllowUserToDeleteRows = false;
            this.dgvMeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MeniId,
            this.Naziv,
            this.Konobar,
            this.DatumObjave,
            this.Vazeci});
            this.dgvMeni.Location = new System.Drawing.Point(6, 19);
            this.dgvMeni.Name = "dgvMeni";
            this.dgvMeni.ReadOnly = true;
            this.dgvMeni.Size = new System.Drawing.Size(468, 330);
            this.dgvMeni.TabIndex = 0;
            this.dgvMeni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeni_CellClick);
            // 
            // MeniId
            // 
            this.MeniId.DataPropertyName = "MeniId";
            this.MeniId.HeaderText = "MeniId";
            this.MeniId.Name = "MeniId";
            this.MeniId.ReadOnly = true;
            this.MeniId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Konobar
            // 
            this.Konobar.DataPropertyName = "KorisnickoIme";
            this.Konobar.HeaderText = "Konobar";
            this.Konobar.Name = "Konobar";
            this.Konobar.ReadOnly = true;
            // 
            // DatumObjave
            // 
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Datum objave";
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            // 
            // Vazeci
            // 
            this.Vazeci.DataPropertyName = "Vazeci";
            this.Vazeci.HeaderText = "Vazeci";
            this.Vazeci.Name = "Vazeci";
            this.Vazeci.ReadOnly = true;
            this.Vazeci.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vazeci.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(438, 46);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // rbtnVazeci
            // 
            this.rbtnVazeci.AutoSize = true;
            this.rbtnVazeci.Location = new System.Drawing.Point(51, 46);
            this.rbtnVazeci.Name = "rbtnVazeci";
            this.rbtnVazeci.Size = new System.Drawing.Size(57, 17);
            this.rbtnVazeci.TabIndex = 4;
            this.rbtnVazeci.TabStop = true;
            this.rbtnVazeci.Text = "Vazeci";
            this.rbtnVazeci.UseVisualStyleBackColor = true;
            // 
            // rbtnNeVazeci
            // 
            this.rbtnNeVazeci.AutoSize = true;
            this.rbtnNeVazeci.Location = new System.Drawing.Point(131, 46);
            this.rbtnNeVazeci.Name = "rbtnNeVazeci";
            this.rbtnNeVazeci.Size = new System.Drawing.Size(73, 17);
            this.rbtnNeVazeci.TabIndex = 5;
            this.rbtnNeVazeci.TabStop = true;
            this.rbtnNeVazeci.Text = "Ne vazeci";
            this.rbtnNeVazeci.UseVisualStyleBackColor = true;
            // 
            // frmPretragaMenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.rbtnNeVazeci);
            this.Controls.Add(this.rbtnVazeci);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPretragaMenia";
            this.Text = "frmPretragaMenia";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeniId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konobar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vazeci;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.RadioButton rbtnVazeci;
        private System.Windows.Forms.RadioButton rbtnNeVazeci;
    }
}