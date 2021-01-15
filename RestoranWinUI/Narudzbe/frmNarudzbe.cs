using Restoran.Model;
using Restoran.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI.Narudzbe
{
    public partial class frmNarudzbe : Form
    {
        private APIService service = new APIService("Narudzba");
        private APIService serviceStavke = new APIService("StavkeNarudzbe");

        public frmNarudzbe()
        {
            InitializeComponent();
        }
        private List<NarudzbaVM> narudzbe = new List<NarudzbaVM>();

        private void dgvNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var narusdbaid = int.Parse(dgvNarudzbe.Rows[e.RowIndex].Cells[0].Value.ToString());

            frmNarudzba frm = new frmNarudzba(narusdbaid);
            frm.Show();
        }

        private async void frmNarudzbeLista_Load(object sender, EventArgs e)
        {
            NarudzbaSearchRequest request = new NarudzbaSearchRequest() {
                DatumNarudzbe=DateTime.Now, PretragaPoDatumu=true };
            var n = await service.Get<List<Restoran.Model.Narudzba>>(null);
            foreach (var item in n)
            {
                StavkeNarudzbeSearchRequest r = new StavkeNarudzbeSearchRequest() { NaruszbaId=item.NarudzbaId};
                var stavke = await serviceStavke.Get<List<StavkaNarudzbe>>(r);
                string s = "";
                for (int i = 0; i < stavke.Count; i++)
                {
                    if (stavke[i].StavkeMeniaId == null)
                    {
                        s+= stavke[i].Kombinacija.Naziv;
                    }
                    else
                    {

                        s+= stavke[i].StavkeMenia.Artikal.Naziv;
                    }
                   
                    if (i+1!=stavke.Count)
                    {
                        s += ", ";
                    }

                }

                narudzbe.Add(new NarudzbaVM() { 
                NarudzbaId=item.NarudzbaId,
                Naplaceno=item.Naplaceno,
                BrojStola=item.BrojStola,
                Cijena=item.Cijena,
                CijenaSaPdv=item.CijenaSaPdv,
                Odbijena=item.Odbijena,
                Odobrena=item.Odobrena,
                Narudzba=s,
                Naplati=item.Naplati
                
                });
            }
            dgvNarudzbe.AutoGenerateColumns = false;
            dgvNarudzbe.DataSource = narudzbe;
        }
    }
}
