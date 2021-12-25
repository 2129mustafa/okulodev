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
    public partial class FrmMusteriAnaMenu : System.Windows.Forms.Form
    {
        public string _tc;
        
        public FrmMusteriAnaMenu()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmMusteriAnaMenu_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("tc: " + _tc);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Urunler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            TxtId.Enabled = false;
            TxtUrunAdi.Enabled = false;
            TxtUrunAgirligi.Enabled = false;
            TxtBirimFiyati.Enabled = false;
            TxtUrunKategori.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtBirimFiyati.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtUrunAgirligi.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtUrunKategori.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnSiparişEkle_Click(object sender, EventArgs e)
        {
            if (TxtUrunAdet.Text!=null && TxtUrunAdet.Text!="")
            {
                FrmBilgiGir fr = new FrmBilgiGir();
                fr.TC = _tc;
                fr.adet = Convert.ToInt32(TxtUrunAdet.Text);
                fr.toplam = Convert.ToInt32(TxtVergiliToplam.Text);
                fr.urunid = Convert.ToInt32(TxtId.Text);
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Ürün adetini giriniz!!!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            SiparişDetay detay = new SiparişDetay();
            Sipariş sipariş = new Sipariş();
            detay.urün = new Urün();
            detay.VergisizToplamHesap(Convert.ToInt32(TxtUrunAdet.Text), Convert.ToInt32(TxtBirimFiyati.Text));
            TxtVergisizToplam.Text = detay.VergisizToplamFiyat.ToString();
            sipariş.VergiHesapla(detay.VergisizToplamFiyat);
            TxtVergiliToplam.Text =  sipariş.ver_hes.ToString();

        }

        private void btnCıkısAnaMenu_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            this.Hide();
            
        }
    }
}
