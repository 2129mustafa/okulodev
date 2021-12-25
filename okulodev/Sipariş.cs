using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulodev
{
    public class Sipariş
    {
        public int SiparişId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public bool SiparisDurumu { get; set; }
        public SiparişDetay detay { get; set; }
        public Musteri musteri { get; set; }
        public Urün urün { get; set; }

        const decimal vergi = 2;

        public int ver_hes;
       
        public int toplam_agirlik;
        public int tutar;
        
        public Sipariş()
        {
            this.SiparisDurumu = false;
            this.musteri = new Musteri();
            this.detay = new SiparişDetay();

        }

        
        public int  VergiHesapla(int vergisizfiyat)
        {
                ver_hes =  Convert.ToInt32(vergi)*vergisizfiyat;
            return ver_hes;
        }
        public void AgirlikHesapla()
        {
            toplam_agirlik = urün.UrünAgirlik * detay.Adet;
        }

        public int ToplamTutar()
        {
            tutar =  ver_hes+detay.VergisizToplamFiyat;
            return  tutar;
           
       
        }
    }
}
