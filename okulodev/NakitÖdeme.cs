using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulodev
{
    public class NakitÖdeme : OdemeTipi
    {
     
        public Sipariş sipariş { get; set; }
        public NakitÖdeme()
        {
            this.sipariş = new Sipariş();
        }
        public override void OdemeYontemi()
        {
           //ews
        }

        
    }
}
