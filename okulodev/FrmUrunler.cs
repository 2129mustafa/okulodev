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
using System.Globalization;

namespace okulodev
{
    public partial class FrmUrunler : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
     
        public FrmUrunler()
        {
            InitializeComponent();
        }
        
       
        
        void UrunleriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Urunler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunleriListele();
            
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
                Urün urün = new Urün();
                //urün.UrunId = Convert.ToInt32(TxtUrunId.Text);
                urün.UrunAd = TxtUrunAdi.Text;
                urün.UrünAgirlik = Convert.ToInt32(TxtUrunAgirlik.Text);
                urün.BirimFiyati = Convert.ToInt32(TxtUrunFiyati.Text);
                urün.Kategori = TxtUrunKategori.Text;
                if (TxtUrunKategori.Text=="Kırtasiye" || TxtUrunKategori.Text == "kırtasiye" || TxtUrunKategori.Text == "KIRTASİYE" )
                {
                    urün.UrunEkle();
                    MessageBox.Show("Ürününüz başarılı bir şekilde listeye eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Gecersiz Urun Kategorisi Lütfen Urun Katgeorisini Kontorl Edin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
             
            UrunleriListele();
           
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {            
            Urün urün = new Urün();
            urün.UrunId = Convert.ToInt32(TxtUrunId.Text);
            urün.UrunAd = TxtUrunAdi.Text;
            urün.UrünAgirlik = Convert.ToInt32(TxtUrunAgirlik.Text);
            urün.BirimFiyati = Convert.ToInt32(TxtUrunFiyati.Text);
            urün.Kategori = TxtUrunKategori.Text;
            if (TxtUrunKategori.Text == "Kırtasiye" || TxtUrunKategori.Text == "kırtasiye" || TxtUrunKategori.Text == "KIRTASİYE")
            {
                urün.UrunGuncelle();
                MessageBox.Show("Ürününüz başarılı bir şekilde Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Gecersiz Urun Kategorisi Lütfen Urun Katgeorisini Kontorl Edin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UrunleriListele();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunId.Text = dataGridView1.Rows[secilenindex].Cells[0].Value.ToString();
            TxtUrunAdi.Text = dataGridView1.Rows[secilenindex].Cells[1].Value.ToString();
            TxtUrunFiyati.Text = dataGridView1.Rows[secilenindex].Cells[2].Value.ToString();
            TxtUrunAgirlik.Text = dataGridView1.Rows[secilenindex].Cells[3].Value.ToString();
            TxtUrunKategori.Text = dataGridView1.Rows[secilenindex].Cells[4].Value.ToString();
        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            Urün urün = new Urün();
            urün.UrunId = Convert.ToInt32(TxtUrunId.Text);
            urün.UrunSil();
            MessageBox.Show("Ürününüz başarılı bir şekilde Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            UrunleriListele();
        }

        private void BtnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            FrmYonetici fr = new FrmYonetici();
            fr.Show();
            this.Hide();
           
        }
    }
}
