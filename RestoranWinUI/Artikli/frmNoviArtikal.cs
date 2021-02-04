using Restoran.Model;
using Restoran.Model.Request;
using RestoranWinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RestoranWinUI.Artikli
{
    public partial class frmNoviArtikal : Form
    {
        private APIService service = new APIService("Artikal");
        private APIService serviceJediniceMjere = new APIService("JediniceMjere");
        private APIService serviceKategorija = new APIService("Kategorija");

        public int? _ArtikalID { get; set; }
        public frmNoviArtikal(int? id=null)
        {
            InitializeComponent();
            _ArtikalID = id;
        }
        ArtikalUpsertRequest request = new ArtikalUpsertRequest();
        private void PopuniRequest() {

                request.Popust = int.Parse(txtPopust.Text);
                request.PDV = int.Parse(txtPDV.Text);
            request.Cijena = double.Parse(txtCijena.Text);
            double pdv = (request.PDV * request.Cijena)/ 100 ;
            request.CijenaSaPdv =Math.Round( request.Cijena + pdv,2);
            request.Sastav = txtSastav.Text;
                request.Kolicina = float.Parse(txtKolicina.Text);
                request.Naziv = txtNaziv.Text;
                var objJM = cbxJedinicaMjere.SelectedValue;
                if (int.TryParse(objJM.ToString(), out int jm))
                {
                    request.JedinicaMjereId = jm;
                }

                var objK = cbKategorija.SelectedValue;
                if (int.TryParse(objK.ToString(), out int k))
                {
                    request.KategorijaId = k;
                }
          
         
        }
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                PopuniRequest();
                if (_ArtikalID==null)
                {
                    Restoran.Model.Artikal entity = await service.Insert<Restoran.Model.Artikal>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspjesno dodan artikal.");
                    }
                }
                else
                { 
                    Restoran.Model.Artikal entity = await service.Update<Restoran.Model.Artikal>(_ArtikalID,request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspjesno izmjenjen artikal.");
                    }
                }
            }
        }

        private async void frmNoviArtikal_Load(object sender, EventArgs e)
        {
            var lista = await serviceJediniceMjere.Get<List<JedinicaMjere>>(null);
            cbxJedinicaMjere.DataSource = lista;
            lista.Insert(0, new JedinicaMjere() { Naziv = "Odaberite", JedinicaMjereId = 0 });
            cbxJedinicaMjere.DisplayMember = "Naziv";
            cbxJedinicaMjere.ValueMember = "JedinicaMjereId";
            var kategorije = await serviceKategorija.Get<List<Kategorija>>(null);
            kategorije.Insert(0, new Kategorija() { Naziv = "Odaberite", KategorijaId = 0 });
            cbKategorija.DataSource = kategorije;
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "KategorijaId";
            txtPDV.Text = "17";
            if (_ArtikalID!=null)
            {
              var a=  await service.GetById<Restoran.Model.Artikal>(_ArtikalID);
                cbxJedinicaMjere.SelectedValue = a.JedinicaMjereId;
                cbKategorija.SelectedValue = a.KategorijaId;
                txtCijena.Text = a.Cijena.ToString();
                txtCijenaSaPdv.Text = a.CijenaSaPdv.ToString();
                txtKolicina.Text = a.Kolicina.ToString();
                txtNaziv.Text = a.Naziv;
                txtPDV.Text = a.PDV.ToString();
                txtPopust.Text = a.Popust.ToString();
                txtSastav.Text = a.Sastav;
                pictureBox.Image= Global.ByteToImage(a.Slika);
                request.Slika = a.Slika;

            }
        }
      
        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
           request.Slika= Global.SetSlika(ref openFileDialog1, ref txtSlika,  request.Slika, ref pictureBox);
         
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtNaziv,e,errorProvider);
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtCijena, e, errorProvider);
            if (String.IsNullOrWhiteSpace(errorProvider.GetError(txtCijena)))
            {
                Global.ValidatingBrojFloat(ref txtCijena, e, errorProvider);
            }

        }

  

        private void txtPDV_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtPDV, e, errorProvider);
            if (String.IsNullOrWhiteSpace(errorProvider.GetError(txtPDV)))
            {
                Global.ValidatingBrojInt(ref txtPDV, e, errorProvider);
            }
        }

        private void txtSastav_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtSastav, e, errorProvider);

        }

        private void txtPopust_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtPopust, e, errorProvider);
            if (String.IsNullOrWhiteSpace(errorProvider.GetError(txtPopust)))
            {
                Global.ValidatingBrojInt(ref txtPopust, e, errorProvider);
            }
        }

        private void txtKolicina_Validating(object sender, CancelEventArgs e)
        {
            Global.ValidatingObaveznoPolje(ref txtKolicina, e, errorProvider);

            if (String.IsNullOrWhiteSpace(errorProvider.GetError(txtKolicina)))
            {
                Global.ValidatingBrojInt(ref txtKolicina, e, errorProvider);
            }
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (_ArtikalID==null)
            {
                Global.ValidatingObaveznoPolje(ref txtSlika, e, errorProvider);
            }
        }

        private void cbxJedinicaMjere_Validating(object sender, CancelEventArgs e)
        {
           
                Global.ValidatingObaveznoPoljeComboBox(ref cbxJedinicaMjere, e, errorProvider);
            
        }

        private void cbKategorija_Validating(object sender, CancelEventArgs e)
        {

          
            Global.ValidatingObaveznoPoljeComboBox(ref cbKategorija , e, errorProvider);

        }
    }
}
