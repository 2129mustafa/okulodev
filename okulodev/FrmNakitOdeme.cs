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
    public partial class FrmNakitOdeme : Form
    {
        public string tC;
        public FrmNakitOdeme()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnOdemeyiTamamla_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand komut = new SqlCommand("insert into Nakit (MusteriTc) values (@p1)", bgl.baglanti()) ;
            komut.Parameters.AddWithValue("@p1", tC);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("başarılı");
          
        }

        

        private void BtnCıkısNakit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriAnaMenu fr = new FrmMusteriAnaMenu();
            fr.Show();
            this.Hide();
        }
    }
}
