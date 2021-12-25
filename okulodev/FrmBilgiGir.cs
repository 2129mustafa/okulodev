using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace okulodev
{
    public partial class FrmBilgiGir : Form
    {
        public string TC;
        public int adet;
        public int toplam;
        public int urunid;
        public FrmBilgiGir()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            Sipariş sipariş = new Sipariş();
            bgl.baglanti();
            SqlCommand komut = new SqlCommand("insert into Sipariş (SiparişAdet,ToplamFiyat,SiparisTarih,SiparisDurumu,Urun,MusterıTC,AlıcıAd,AlıcıSoyad,AlıcıTelefon,AlıcıAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adet) ;
            komut.Parameters.AddWithValue("@p2", toplam);
            komut.Parameters.AddWithValue("@p3", DateTime.Parse(DateTime.Now.ToShortDateString())) ;
            komut.Parameters.AddWithValue("@p4", sipariş.SiparisDurumu);
            komut.Parameters.AddWithValue("@p5", urunid);
            komut.Parameters.AddWithValue("@p6", TC);
            komut.Parameters.AddWithValue("@p7", TxtAlıcıAd.Text);
            komut.Parameters.AddWithValue("@p8", TxtAlıcıSoyad.Text);
            komut.Parameters.AddWithValue("@p9", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p10", RchAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            MessageBox.Show("başarılı");


            FrmOdemeSec fr = new FrmOdemeSec();
            fr._TC = TC;
            fr.Show();
            this.Hide();
        }

        private void FrmBilgiGir_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("tc: " + TC);
        }
    }
}
