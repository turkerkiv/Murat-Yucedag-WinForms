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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tcno2;
        sqlbaglantisi bgl = new sqlbaglantisi();

       
        
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
           
            
            lblTc.Text = tcno2;


            //Ad soyad

            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreterler where SekreterTc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            dr1.Read();
            lblAdSoyad.Text = dr1[0].ToString();
            bgl.baglanti().Close();

            //Branşları datagride çekme

            DataTable dt1 = new DataTable();

            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları çekme

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar', DoktorBrans from Tbl_Doktorlar", bgl.baglanti());

            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşları cmb çekme

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut3= new SqlCommand("select (DoktorAd+' '+ DoktorSoyad) from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3=komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komutduyuru = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)", bgl.baglanti());
            komutduyuru.Parameters.AddWithValue("@p1", rchDuyuru.Text);
            komutduyuru.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Duyuru Yayınlandı");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Randevu oluşturuldu");
        }

        private void btnDoktorPan_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli frdktrpn = new frmDoktorPaneli();
            frdktrpn.Show();
        }

        private void btnBransPan_Click(object sender, EventArgs e)
        {
            frmBransPaneli frbrnspn = new frmBransPaneli();
            frbrnspn.Show();
            

        }
        
        private void btnRandevuPan_Click(object sender, EventArgs e)
        {

            frmRandevuListesi frrndvl = new frmRandevuListesi();
            frrndvl.fr1 = this;

           
            frrndvl.Show();
            




        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular frdyr= new frmDuyurular();
            frdyr.Show();
        }
    }
}
