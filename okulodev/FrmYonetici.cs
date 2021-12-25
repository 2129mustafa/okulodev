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
using System.Xml;

namespace okulodev
{
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        void SiparisListele()
        {
            bgl.baglanti();
            SqlDataAdapter da = new SqlDataAdapter("execute SiparisGoruntule", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        void doviz()
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            LblDolar.Text = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblEuro.Text= xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
        }
        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            doviz();
            SiparisListele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
            int durum = Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[4].Value);
            int Id = Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[0].Value);
            string ad = dataGridView1.Rows[secilenindex].Cells[5].Value.ToString();
            string alıcıAd = dataGridView1.Rows[secilenindex].Cells[6].Value.ToString();

            if (durum == 0)
                durum = 1;
            else if (durum == 1)
                durum = 0;
            SqlCommand cmd = new SqlCommand("update Sipariş set SiparisDurumu=@p1 where  SiparişId=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", durum);
            cmd.Parameters.AddWithValue("@p2", Id);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
       if(durum==1)
                MessageBox.Show(ad + " ürünü " + alıcıAd + " kişisine verilmek üzere kargoya çıkmıştır.", "Kargo Bilgi");
            else if (durum == 0)
                MessageBox.Show(ad + " ürünü " + alıcıAd + " kişisinin kargosu iptal edilmiştir.", "Kargo Bilgi");

            SiparisListele();
        }

        private void BtnMusteriBilgileri_Click(object sender, EventArgs e)
        {
            FrmMusteriBilgileri fr = new FrmMusteriBilgileri();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKartBilgileri fr = new FrmKartBilgileri();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.Show();
            this.Hide();
        }
    }
}
