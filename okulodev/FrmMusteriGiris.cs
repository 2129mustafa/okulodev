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
    public partial class FrmMusteriGiris : System.Windows.Forms.Form
    {
        public string tc;
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand komut = new SqlCommand("Select * from Tbl_MusteriTablosu where MusteriTC=@p1 and MusteriSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                tc = dr[1].ToString();
                //TODO
                MessageBox.Show("BAŞARILI");
                FrmMusteriAnaMenu fr = new FrmMusteriAnaMenu();
                fr._tc = tc;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre girdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void FrmMusteriGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
