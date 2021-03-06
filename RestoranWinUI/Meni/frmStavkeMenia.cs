﻿using RestoranWinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI.Meni
{
    public partial class frmStavkeMenia : Form
    {
      public StavkeMenijaVM Stavka { get; set; }
        public frmStavkeMenia(StavkeMenijaVM stavka)
        {
            InitializeComponent();
            Stavka = stavka;
        }

        public string Opcija { get; internal set; }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            Opcija = Global.Update;
            Stavka.Cijena = double.Parse(txtCijena.Text);
            Stavka.PDV = int.Parse(txtPdv.Text);
            double pdv = (Stavka.PDV* Stavka.Cijena)/100 ;
            Stavka.CijenaSaPDV = Stavka.Cijena+pdv;
            Stavka.Popust = int.Parse(txtPopust.Text);
            Stavka.Aktivan = cbAktivan.Checked;
            Hide();

        }


        private void frmStavkeMenia_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = Stavka.Naziv;
            txtKategorija.Text = Stavka.Kategorija;
            txtPdv.Text = Stavka.PDV.ToString();
            txtCijena.Text = Stavka.Cijena.ToString();
            txtPopust.Text = Stavka.Popust.ToString();
            cbAktivan.Checked = Stavka.Aktivan;
            pbSlika.Image = Global.ByteToImage(Stavka.Slika);
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtNaziv, e, errorProvider);
        }

        private void txtPdv_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtPdv, e, errorProvider);
            if (String.IsNullOrWhiteSpace(errorProvider.GetError(txtPdv)))
            {
                Global.ValidatingBrojInt(ref txtPdv, e, errorProvider);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtCijena, e, errorProvider);
            if (String.IsNullOrWhiteSpace(errorProvider.GetError(txtCijena)))
            {
                Global.ValidatingBrojFloat(ref txtCijena, e, errorProvider);
            }
        }

        private void txtPopust_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtPopust, e, errorProvider);
            if (String.IsNullOrWhiteSpace(errorProvider.GetError(txtPopust)))
            {
                Global.ValidatingBrojInt(ref txtPopust, e, errorProvider);
            }
        }
    }
}
