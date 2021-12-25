using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace okulodev
{
    public partial class FrmKartBilgileri : Form
    {
        public FrmKartBilgileri()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        
        private void FrmKartBilgileri_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute KartBilgiGetir", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
    }
}
