using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okulodev
{
    public partial class FrmYeniKayit : System.Windows.Forms.Form
    {
        public FrmYeniKayit()
        {
            InitializeComponent();
        }

        private void BtnKayitol_Click(object sender, EventArgs e)
        {
            if (mskTC.Text.Length==11 && TxtAd.Text!=null && TxtAd.Text!="" && TxtSoyad.Text != null && TxtSoyad.Text != "" && rchAdres.Text != null && rchAdres.Text != "" && TxtSifre.Text != null && TxtSifre.Text != "" )
            {
                Musteri musteri = new Musteri();
                musteri.TC = mskTC.Text;
                musteri.Ad = TxtAd.Text;
                musteri.Soyad = TxtSoyad.Text;
                musteri.Telefon = MskTel.Text;
                musteri.Adres = rchAdres.Text;
                musteri.Sifre = TxtSifre.Text;
                musteri.MusteriKayıt();

            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girmiş Olabilirsiniz.Lütfen Bilgilerinizi Kontrol Ediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void FrmYeniKayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            this.Hide();
        }
    }
}
