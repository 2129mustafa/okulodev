using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace okulodev
{
    public partial class FrmOdemeSec : Form
    {
        public string _TC;
        public FrmOdemeSec()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            FrmNakitOdeme fr = new FrmNakitOdeme();
            fr.tC = _TC;
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKrediKartıOdeme fr = new FrmKrediKartıOdeme();
            fr.TC_NO = _TC;
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCekOdeme fr = new FrmCekOdeme();
            fr.Tc = _TC;
            fr.Show();
            this.Hide();
        }

        private void FrmOdemeSec_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("tc:" + _TC);
        }
    }
}
