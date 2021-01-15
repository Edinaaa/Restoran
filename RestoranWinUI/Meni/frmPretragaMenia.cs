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

namespace RestoranWinUI.Meni
{
    public partial class frmPretragaMenia : Form
    {
        private APIService serviceMeni = new APIService("Meni");
        private int meniId { get; set; }
        private string Pretraga { get; set; }

        public frmPretragaMenia(string pretraga="")
        {
            InitializeComponent();
            Pretraga = pretraga;
        }
        public int SendData() { return meniId; }
        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
           var p= txtPretraga.Text;
            MeniSearchRequest request = new MeniSearchRequest() { 
            Naziv = txtPretraga.Text.ToString(),
            NeVazeci=rbtnNeVazeci.Checked,
            Vazeci=rbtnVazeci.Checked
        };
            var meni = await serviceMeni.Get<List< Restoran.Model.Meni>>(request);
            dgvMeni.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = meni;
            dgvMeni.DataSource = bs;
            bs.ResetBindings(false);
        }


        private void dgvMeni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            meniId = int.Parse(dgvMeni.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (Pretraga.Equals(Global.Update))
            {
                frmNoviMeni frm = new frmNoviMeni(meniId);
                Global.Lokacija(frm);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            Hide();
        }
    }
}
