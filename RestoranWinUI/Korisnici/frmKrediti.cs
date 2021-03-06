﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restoran.Model;
using Restoran.Model.Request;
using RestoranWinUI.Helper;

namespace RestoranWinUI.Korisnici
{
    public partial class frmKrediti : Form
    {
        private APIService service = new APIService("Korisnik");
        Korisnik korisnik = null;
        public frmKrediti()
        {
            InitializeComponent();
        }



        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (korisnik == null)
                {
                    MessageBox.Show("Morate pronaci korisnika kojem zelite izmjenitit stanje kredita!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                KorisniciUpsertReqests r = new KorisniciUpsertReqests()
                {
                    IznosKredita = double.Parse(txtIznosUplate.Text.ToString()),//salje se samo koliko je dodano, a na api cese sabrati sa trenutnim stanjem
                    Ime = korisnik.Ime,
                    DatumRodenja = korisnik.DatumRodenja,
                    Prezime = korisnik.Prezime,
                    Spol = korisnik.Spol,
                    KorisnickoIme = korisnik.KorisnickoIme,
                    DatumZaposljavanja = korisnik.DatumZaposljavanja,
                    Slika = korisnik.Slika


                };
                Korisnik k = await service.Update<Restoran.Model.Korisnik>(korisnik.KorisnikId, r);
                if (k != null)
                {
                    if (MessageBox.Show("Uspjesno izmjenjeno stanje kredita", "Krediti", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Stanje kredita nije izmjenjeno.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
          
        }


        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            frmPretragaKorisnika frm = new frmPretragaKorisnika();
            frm.ShowDialog();

            korisnik = await service.GetById<Korisnik>(frm.SendData());
            frm.Close();
            txtIznosKredita.Text = korisnik.IznosKredita.ToString();
            txtKorisnickoIme.Text = korisnik.KorisnickoIme;
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtKorisnickoIme,e,errorProvider);
        }

        private void txtIznosUplate_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtIznosKredita, e, errorProvider);
            if (String.IsNullOrWhiteSpace(errorProvider.GetError(txtIznosKredita)))
            {
                Global.ValidatingBrojFloat(ref txtIznosKredita, e, errorProvider);
            }
        }
    }
}
