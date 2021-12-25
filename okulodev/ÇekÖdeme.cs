using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace okulodev
{
    public class ÇekÖdeme : OdemeTipi
    { 
        public Musteri musteri { get; set; }
        public string BankNo { get; set; }  // 7 veya 8 haneli olabilir.
        public Sipariş sipariş { get; set; }
        public ÇekÖdeme()
        {
            this.musteri = new Musteri();
            this.sipariş = new Sipariş();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public override void OdemeYontemi()
        {
            bgl.baglanti();
            SqlCommand komut = new SqlCommand("insert into Cek (BankaNo,MusteriTC) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", this.BankNo);
            komut.Parameters.AddWithValue("@p2", this.sipariş.musteri.TC);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void Dogrulama()
        {
            bgl.baglanti();
            SqlCommand komut = new SqlCommand("select * from Cek where MusteriTC=@p1 and BankaNo=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sipariş.musteri.TC);
            komut.Parameters.AddWithValue("@p2", this.BankNo);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("İşleminiz başarılı bir şekilde alınmıştır .Sağlıklı günler dileriz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                MessageBox.Show("Gecersiz Banko Numarası Lütfen Bilgilerinizi Kontrol Ediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
