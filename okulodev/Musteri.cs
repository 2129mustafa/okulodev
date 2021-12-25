using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace okulodev
{
    public class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Adres { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        

        SqlBaglanti bgl = new SqlBaglanti();
        public void MusteriKayıt()
        {
            bgl.baglanti();
            SqlCommand komut = new SqlCommand("insert into Tbl_MusteriTablosu (MusteriTC,MusteriAd,MusteriSoyad,MusteriTel,MusteriAdress,MusteriSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            komut.Parameters.AddWithValue("@p2", Ad);
            komut.Parameters.AddWithValue("@p3", Soyad);
            komut.Parameters.AddWithValue("@p4", Telefon);
            komut.Parameters.AddWithValue("@p5", Adres);
            komut.Parameters.AddWithValue("@p6", Sifre);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri kaydınız yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
