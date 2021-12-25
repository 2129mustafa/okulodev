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
    public partial class FrmKartEkle : Form
    {
        public string kimlik;
        public FrmKartEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKrediKartıOdeme fr = new FrmKrediKartıOdeme();
            fr.TC_NO = kimlik;
            fr.Show();
            this.Hide();
        }

        private void BtnKartEkle_Click(object sender, EventArgs e)
        {
            KrediKarti kk = new KrediKarti();
            kk.CCV = Convert.ToInt32(MskCcv.Text);
            kk.KartNo = MskKartNo.Text;
            kk.sipariş.musteri.TC = kimlik;
            kk.OdemeYontemi();
            MessageBox.Show("Kartınız Kaydedildi.", "Bilgi");

        }
    }
}
