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

namespace BankamatikSimulasyonu
{
    public partial class frmKayit : Form
    {
        baglanti c = new baglanti();
        
        public frmKayit()
        {
            InitializeComponent();
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {
            
        }
        int randomhesapno;
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                Random rdm = new Random();
                randomhesapno = rdm.Next(100000, 1000000);
                SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TCNO,TELNO,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", c.conn());

                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", mskTc.Text);
                komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komut.Parameters.AddWithValue("@p5", randomhesapno);
                komut.Parameters.AddWithValue("@p6", txtSifre.Text);
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("insert into TBLHESAP (HESAPNO,BAKIYE) values (@p1,@p2)", c.conn());
                komut2.Parameters.AddWithValue("@p1", randomhesapno);
                komut2.Parameters.AddWithValue("@p2", 0.000);
                komut2.ExecuteNonQuery();
                c.conn().Close();

                MessageBox.Show("Kayıt oldunuz.\nHesap Numaranız " + randomhesapno);
            }
            catch (Exception)
            {
                MessageBox.Show("Hesap Numaranızda sorun var. Lütfen tekrar deneyin");
            }
            

        }
    }
}
