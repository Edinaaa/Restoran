using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranWinUI.Helper
{
  public static  class Global
    {
        public static int KorisnikId { get; set; }
        public static string Update { get; set; } = "update";
        public static string Ponisti { get; set; } = "ponisti";


        public static byte[] ResizeImage(byte[] myBytes, int newWidth, int newHeight)
        {
            System.IO.MemoryStream myMemStream = new System.IO.MemoryStream(myBytes);
            System.Drawing.Image fullsizeImage = System.Drawing.Image.FromStream(myMemStream);
            System.Drawing.Image newImage = fullsizeImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
            System.IO.MemoryStream myResult = new System.IO.MemoryStream();
            newImage.Save(myResult, System.Drawing.Imaging.ImageFormat.Gif);  //Or whatever format you want.
            return myResult.ToArray();  //Returns a new byte array.
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        public static byte[] ImageToByte(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public static void Lokacija(Form f)
        {

            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(170, 100);
        }

        public static void ValidatingObaveznoPolje(ref TextBox tb, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (String.IsNullOrEmpty(tb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tb, Properties.Resources.Validacija_Obavezno_polje);
            }
            else
            {
                errorProvider.SetError(tb, null);

            }
        }
        public static void ValidatingBrojFloat(ref TextBox tb, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (!float.TryParse(tb.Text, out float br))
            {
                e.Cancel = true;
                errorProvider.SetError(tb,"Mozete unjeti samo broj npr 1.00");
            }
            else
            {
                errorProvider.SetError(tb, null);

            }
        }
        public static void ValidatingBrojInt(ref TextBox tb, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (!int.TryParse(tb.Text, out int br))
            {
                e.Cancel = true;
                errorProvider.SetError(tb, "Mozete unjeti samo cijeli broj, npr 100.");
            }
            else
            {
                errorProvider.SetError(tb, null);

            }
        }
        public static void ValidatingUnique(ref TextBox tb,bool uslov, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (uslov)
            {
                e.Cancel = true;
                errorProvider.SetError(tb, "Isti sadrzaj vec postoji, probajte unjeti nesto drugo.");
            }
            else
            {
                errorProvider.SetError(tb, null);

            }
        }
        public static bool ValidatingObaveznoPoljeBool(ref TextBox tb, CancelEventArgs e, ErrorProvider errorProvider)
        {

            bool validno = false;
            if (String.IsNullOrEmpty(tb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tb, Properties.Resources.Validacija_Obavezno_polje);
            }
            else
            {
                validno = true;
                errorProvider.SetError(tb, null);

            }
            return validno;
        }
        public static void ValidatingDvaDecimalnaPolja(ref TextBox tb, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (!System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "[1-9]{1,4}(\\.[1-9]{1,2})?"))
            {
                e.Cancel = true;
                errorProvider.SetError(tb, Properties.Resources.DecimalniBrSaDvijeDecimale);
            }
            else
            {
                errorProvider.SetError(tb, null);

            }
        }

        public static void ValidatingPassPassPotvrda(ref TextBox tb, TextBox tb2, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (tb.Text.ToString()!=tb2.Text.ToString() )
            {
                e.Cancel = true;
                errorProvider.SetError(tb, Properties.Resources.ValidacijaLozinka);
            }
            else
            {
                errorProvider.SetError(tb, null);

            }
        }
        public static void ValidatingSpolObaveznoPolje(ref RadioButton rb1,RadioButton rb2 ,CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (!rb2.Checked && !rb1.Checked)
            {

                e.Cancel = true;
                errorProvider.SetError(rb1, Properties.Resources.Validacija_Obavezno_polje);
            }
            else
            {
                errorProvider.SetError(rb1, null);
            }
        }
        public static void ValidatingGodiste( DateTime date2, ref DateTimePicker date1,int broj, string poruka, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (date2.Year - date1.Value.Year < broj)
            {
                e.Cancel = true;
                errorProvider.SetError(date1, poruka);
            }
            else
            { errorProvider.SetError(date1, null); }
        }
        public static void ValidatingDatumVeci(DateTime date2, ref DateTimePicker date1, string poruka, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (date1.Value.Date.Year < date2.Date.Year
                || (date1.Value.Date.Year == date2.Date.Year && date1.Value.Date.Month < date2.Date.Month)
                || (date1.Value.Date.Year == date2.Date.Year && date1.Value.Date.Month == date2.Date.Month && date1.Value.Date.Day < date2.Date.Day))
            { 
                e.Cancel = true;
                errorProvider.SetError(date1, poruka);
            }
            else
            { errorProvider.SetError(date1, null); }
        }
        public static void ValidatingDatumManji(DateTime date2, ref DateTimePicker date1, string poruka, CancelEventArgs e, ErrorProvider errorProvider)
        {

            if (date1.Value.Date.Year > date2.Date.Year
                            || (date1.Value.Date.Year == date2.Date.Year && date1.Value.Date.Month > date2.Date.Month)
                            || (date1.Value.Date.Year == date2.Date.Year && date1.Value.Date.Month == date2.Date.Month && date1.Value.Date.Day > date2.Date.Day))
            {
                e.Cancel = true;
                errorProvider.SetError(date1, poruka);
            }
            else
            { errorProvider.SetError(date1, null); }


        }
        public static void ValidatingDatumManjiOdTrenutnog(ref DateTimePicker date1,string poruka, CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (date1.Value.Date.Year<DateTime.Now.Date.Year
                ||  (date1.Value.Date.Year == DateTime.Now.Date.Year && date1.Value.Date.Month < DateTime.Now.Date.Month) 
                || (date1.Value.Date.Year == DateTime.Now.Date.Year && date1.Value.Date.Month == DateTime.Now.Date.Month && date1.Value.Date.Day <DateTime.Now.Date.Day))
            {
                e.Cancel = true;
                errorProvider.SetError(date1, poruka);
            }
            else
            { errorProvider.SetError(date1, null); }
        }
        public static void ValidatingObaveznoPoljeClb( ref CheckedListBox clb, bool vrijednost,  CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (vrijednost)
            {
                e.Cancel = true;
                errorProvider.SetError(clb, Properties.Resources.Validacija_Obavezno_polje);
            }
            else
            { errorProvider.SetError(clb, null); }
        }
        public static void ValidatingObaveznoPoljeDataGridView( ref DataGridView dgv, bool vrijednost,  CancelEventArgs e, ErrorProvider errorProvider)
        {


            if (vrijednost)
            {
                e.Cancel = true;
                errorProvider.SetError(dgv, Properties.Resources.Validacija_Obavezno_polje);
            }
            else
            { errorProvider.SetError(dgv, null); }
        }
        public static void ValidatingObaveznoPoljeComboBox(ref ComboBox cbx, CancelEventArgs e, ErrorProvider errorProvider)
        {

           var obj = cbx.SelectedValue;

            if (int.TryParse(obj.ToString(), out int k) && k==0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbx, Properties.Resources.Validacija_Obavezno_polje);
            }
            else
            { errorProvider.SetError(cbx, null); }
        }
        public static byte[] SetSlika(ref OpenFileDialog openFileDialog, ref TextBox txtSlika,  byte[] Slika, ref PictureBox pictureBox)
        {

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                var file = File.ReadAllBytes(fileName);

                txtSlika.Text = fileName;

                //  Image image = Image.FromFile(fileName);
               Slika = Global.ResizeImage(file, 150, 150);
                pictureBox.Image = Global.ByteToImage(Slika);
            }
            return Slika;
        }
    }
}
