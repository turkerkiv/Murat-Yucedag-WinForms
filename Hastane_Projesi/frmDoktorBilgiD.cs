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

namespace Hastane_Projesi
{
    public partial class frmDoktorBilgiD : Form
    {
        public frmDoktorBilgiD()
        {
            InitializeComponent();
        }
        public string tcno1;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmDoktorBilgiD_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcno1;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTc= @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                comboBox1.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
            adsoyad = txtAd.Text + " " + txtSoyad.Text;


        }
        string adsoyad;
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTc=@p4", bgl.baglanti());
            SqlCommand komut2 = new SqlCommand("update Tbl_Randevular set RandevuDoktor= @p6 where RandevuDoktor=@p7", bgl.baglanti());
            
            komut2.Parameters.AddWithValue("@p7", adsoyad);
            komut2.Parameters.AddWithValue("@p6", txtAd.Text + " " + txtSoyad.Text);
            komut2.ExecuteNonQuery();
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
