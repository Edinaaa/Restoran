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

namespace RestoranWinUI.Meni
{
    public partial class frmStavkeMenia : Form
    {
      public StavkeMeniaVM Stavka { get; set; }
        public frmStavkeMenia(StavkeMeniaVM stavka)
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
            Hide();

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Opcija = Global.Ponisti;
            Hide();
        }

        private void frmStavkeMenia_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = Stavka.Naziv;
            txtKategorija.Text = Stavka.Kategorija;
            txtPdv.Text = Stavka.PDV.ToString();
            txtCijena.Text = Stavka.Cijena.ToString();
            txtPopust.Text = Stavka.Popust.ToString();
            pbSlika.Image = Global.ByteToImage(Stavka.Slika);
        }

  
    }
}
