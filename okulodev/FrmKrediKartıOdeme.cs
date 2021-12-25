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
    public partial class FrmKrediKartıOdeme : Form
    {
        public string TC_NO;
        public FrmKrediKartıOdeme()
        {
            InitializeComponent();
        }

        private void FrmKrediKartıOdeme_Load(object sender, EventArgs e)
        {
            MessageBox.Show("TC: " + TC_NO);
        }

        private void BtnOdemeyiTamamla_Click(object sender, EventArgs e)
        {
            KrediKarti kk = new KrediKarti();
            kk.CCV = Convert.ToInt32(MskCcv.Text);
            kk.KartNo = MskKartNo.Text;
            kk.sipariş.musteri.TC = TC_NO;
            kk.Dogrulama();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKartEkle fr = new FrmKartEkle();
            fr.kimlik = TC_NO;
            fr.Show();
            this.Hide();
        }


        private void btnCıkısKart_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriAnaMenu fr = new FrmMusteriAnaMenu();
            fr.Show();
            this.Hide();
        }
    }
}
