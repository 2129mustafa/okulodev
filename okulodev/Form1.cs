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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMusteriGirisi_Click(object sender, EventArgs e)
        {

            FrmMusteriGiris frm = new FrmMusteriGiris();
            frm.Show();
            this.Hide();
        }

        private void BtnKayıtMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniKayit frm = new FrmYeniKayit();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnYetkiliGirisi_Click(object sender, EventArgs e)
        {
            FrmYoneticiGiris fr = new FrmYoneticiGiris();
            fr.Show();
            this.Hide();
        }
    }
}
