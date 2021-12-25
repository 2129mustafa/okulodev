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
    public partial class FrmCekOdeme : Form
    {
        public string Tc;
        public FrmCekOdeme()
        {
            InitializeComponent();
        }

        private void BtnOdemeyiTamamla_Click(object sender, EventArgs e)
        {
            ÇekÖdeme odeme = new ÇekÖdeme();
            odeme.BankNo = MskBankaNo.Text;
            odeme.sipariş.musteri.TC = Tc;
            odeme.Dogrulama();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCekEkle fr = new FrmCekEkle();
            fr._kimlik = Tc;
            fr.Show();
        }

        private void FrmCekOdeme_Load(object sender, EventArgs e)
        {

        }

        

        private void btnCıkısCek_Click(object sender, EventArgs e)
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
