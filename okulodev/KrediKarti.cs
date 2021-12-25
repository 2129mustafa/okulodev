using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace okulodev
{
    
    public class KrediKarti : OdemeTipi
    {
        public string KartNo { get; set; }
        public int CCV { get; set; }
        public Sipariş sipariş { get; set; }

        public KrediKarti()
        {
            this.sipariş = new Sipariş();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public override void  OdemeYontemi()
        {
            bgl.baglanti();
            SqlCommand komut = new SqlCommand("insert into Kart (KartNo,Ccv,MusteriTC) values (@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", this.KartNo);
            komut.Parameters.AddWithValue("@p2", this.CCV);
            komut.Parameters.AddWithValue("@p3", this.sipariş.musteri.TC);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void  Dogrulama()
        {
            bgl.baglanti();
            SqlCommand komut = new SqlCommand("select * from Kart where MusteriTC=@p1 and KartNo=@p2 and Ccv=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sipariş.musteri.TC);
            komut.Parameters.AddWithValue("@p2", this.KartNo);
            komut.Parameters.AddWithValue("@p3", this.CCV);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("İşleminiz başarılı bir şekilde alınmıştır .Sağlıklı günler dileriz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                MessageBox.Show("KartNo veya Ccv numaralarınız hatalıdır.Lütfen Kontrol Edin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
