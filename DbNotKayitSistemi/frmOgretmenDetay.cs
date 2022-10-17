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

namespace WindowsFormsApp2
{
    public partial class frmOgretmenDetay : Form
    {
        public frmOgretmenDetay()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(*) from TBLDERS where ORTALAMA >= 50", baglanti);
            SqlDataReader dr= komut.ExecuteReader();
            dr.Read();
            lblGecenSayisi.Text = dr[0].ToString();
            dr.Close();

            SqlCommand komut2 = new SqlCommand("select count(*) from TBLDERS where ORTALAMA < 50", baglanti);
            SqlDataReader dr2= komut2.ExecuteReader();
            dr2.Read(); 
            lblKalanSayisi.Text= dr2[0].ToString();
            dr2.Close();

            SqlCommand komut3 = new SqlCommand("select avg(ORTALAMA) from TBLDERS",baglanti);
            SqlDataReader dr3= komut3.ExecuteReader();
            dr3.Read();
            double sinifort = Convert.ToDouble( dr3[0]);
            lblSinifOrt.Text = sinifort.ToString("0.00");
            baglanti.Close();

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TA7KUE7\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Kayıt Edildi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
        }

        bool durum;

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLDERS set OGRS1=@p1, OGRS2=@p2, OGRS3=@p3, ORTALAMA=@p5, DURUM=@p6 ,OGRAD=@p7,OGRSOYAD=@p8 where OGRNUMARA=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSinav1.Text);
            komut.Parameters.AddWithValue("@p2", txtSinav2.Text);
            komut.Parameters.AddWithValue("@p3", txtSinav3.Text);
            komut.Parameters.AddWithValue("@p4", mskNumara.Text);
            komut.Parameters.AddWithValue("@p5", decimal.Parse(lblOrt.Text));
            komut.Parameters.AddWithValue("@p6", durum);
            komut.Parameters.AddWithValue("@p7", txtAd.Text);
            komut.Parameters.AddWithValue("@p8", txtSoyad.Text);
            komut.ExecuteNonQuery();
            
            MessageBox.Show("Güncellendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);


            
            SqlCommand komut2 = new SqlCommand("select count(*) from TBLDERS where ORTALAMA >= 50", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            dr2.Read();
            lblGecenSayisi.Text = dr2[0].ToString();
            dr2.Close();

            SqlCommand komut3 = new SqlCommand("select count(*) from TBLDERS where ORTALAMA < 50", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            dr3.Read();
            lblKalanSayisi.Text = dr3[0].ToString();
            dr3.Close();

            SqlCommand komut4 = new SqlCommand("select avg(ORTALAMA) from TBLDERS", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            dr4.Read();
            lblSinifOrt.Text = dr4[0].ToString();

            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskNumara.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtAd.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (txtSinav3.Text == "")
            {
                lblOrt.Text = "";
            }

            

        }

        private void txtSinav3_TextChanged(object sender, EventArgs e)
        {
            if (txtSinav3.Text != "")
            {
                double ortalama;
                ortalama = (double.Parse(txtSinav1.Text) + double.Parse(txtSinav2.Text) + double.Parse(txtSinav3.Text))/3;
                lblOrt.Text = ortalama.ToString("0.00");
            }

            if (lblOrt.Text != "" && double.Parse(lblOrt.Text) >= 50)
            {
                durum = true;
            }
            else { durum = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
