using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace okulodev
{
    public class Urün
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int BirimFiyati { get; set; }
        public int UrünAgirlik { get; set; }
        public string Kategori { get; set; }

        SqlBaglanti bgl = new SqlBaglanti();
        public void UrunEkle()
        {
            SqlCommand komut = new SqlCommand("insert into Urunler (UrunAd,UrunBirimFiyati,UrunAgirlik,UrunKategori) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", this.UrunAd);
            komut.Parameters.AddWithValue("@p2", this.BirimFiyati);
            komut.Parameters.AddWithValue("@p3", this.UrünAgirlik);
            this.Kategori = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.Kategori);
            komut.Parameters.AddWithValue("@p4", this.Kategori);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void UrunGuncelle()
        {
            SqlCommand komut = new SqlCommand("update Urunler set  UrunAd=@p1,UrunBirimFiyati=@p2,UrunAgirlik=@p3,UrunKategori=@p4 where UrunId=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", this.UrunAd);
            komut.Parameters.AddWithValue("@p2", this.BirimFiyati);
            komut.Parameters.AddWithValue("@p3", this.UrünAgirlik);
            komut.Parameters.AddWithValue("@p4", this.Kategori);
            komut.Parameters.AddWithValue("@p5", this.UrunId);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void UrunSil()
        {
            SqlCommand komut = new SqlCommand("delete from urunler where UrunId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", this.UrunId);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
