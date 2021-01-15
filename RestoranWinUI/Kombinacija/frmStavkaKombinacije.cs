using Restoran.Model;
using Restoran.Model.Request;
using RestoranWinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI.Kombinacija
{
    public partial class frmStavkaKombinacije : Form
    {

        public Artikal Artikal { get; set; }

        public frmStavkaKombinacije(Artikal a )
        {
            InitializeComponent();
            Artikal = a;
            Kolicina = 0;
        }
        private float Kolicina { get; set; }
        private bool SnimiIzmjene { get; set; }

        public float GetKolicina() { return Kolicina; }
        public bool GetSnimiIzmjene() { return SnimiIzmjene; }



        private void frmStavkaKombinacije_Load(object sender, EventArgs e)
        {
            pbSlika.Image = Global.ByteToImage(Artikal.Slika);
            txtCijena.Text = Artikal.Cijena.ToString();
            txtNaziv.Text = Artikal.Naziv;

        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            SnimiIzmjene = false;
            Hide();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                SnimiIzmjene = true;
                Kolicina = float.Parse(txtKolicina.Text.ToString());
                Hide();
            }
           
        }

        private void txtKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (Global.ValidatingObaveznoPoljeBool(ref txtKolicina, e, errorProvider))
            {
                Global.ValidatingDvaDecimalnaPolja(ref txtKolicina,e,errorProvider);
            } 
        }
    }
}
