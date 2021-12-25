using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulodev
{
    public class SiparişDetay
    {

        public int Adet { get; set; }
        public int VergisizToplamFiyat { get; set; }
        public Urün urün { get; set; }

        public int VergisizToplamHesap(int birimfiyat,int miktar)
        {
            VergisizToplamFiyat = birimfiyat * miktar;
            return VergisizToplamFiyat;
        }



    }
}
