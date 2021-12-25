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
    public partial class FrmCekEkle : Form
    {
        public string  _kimlik;
        public FrmCekEkle()
        {
            InitializeComponent();
        }

        private void BtnBankaNoEkle_Click(object sender, EventArgs e)
        {
            ÇekÖdeme cek = new ÇekÖdeme();
            cek.BankNo = MskBankaNo.Text;
            cek.sipariş.musteri.TC = _kimlik;
            cek.OdemeYontemi();
            MessageBox.Show("başarılı");
            this.Hide();

        }
    }
}
