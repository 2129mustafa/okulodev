using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace okulodev
{
    public class SqlBaglanti
    {
       public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-S9DTQ5O;Initial Catalog=ProjeOkul;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
        
    }
}
