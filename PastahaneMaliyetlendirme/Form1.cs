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

namespace PastahaneMaliyetlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbPastahane;Integrated Security=True");
        double stok, fiyat, maliyet;
        void malzemelistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEME", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            stok = Convert.ToDouble(dataGridView1.Rows[Convert.ToInt32(cmbMalzeme.SelectedValue)-1].Cells[2].Value);
            fiyat = Convert.ToDouble(dataGridView1.Rows[Convert.ToInt32(cmbMalzeme.SelectedValue)-1].Cells[3].Value);
           
        }
        void urunlistesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select AD,SFIYAT,STOK from TBLURUN", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select * from TBLKASA", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void uruncmbcekme()
        {
            SqlDataAdapter da4 = new SqlDataAdapter("select * from TBLURUN", conn);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cmbUrun.ValueMember = "URUNID";
            cmbUrun.DisplayMember = "AD";
            cmbUrun.DataSource = dt4;
        }
        void malzemecmbcekme()
        {
            SqlDataAdapter da5 = new SqlDataAdapter("select * from TBLMALZEME", conn);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            cmbMalzeme.ValueMember = "MALZEMEID";
            cmbMalzeme.DisplayMember = "AD";
            cmbMalzeme.DataSource = dt5;
        }
        void malzemetemizle()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        void uruntemizle()
        {
            foreach (Control control in groupBox3.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        void satistemizle()
        {
            foreach (Control control in groupBox4.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uruncmbcekme();
            malzemecmbcekme();
            malzemelistesi();
            urunlistesi();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            urunlistesi();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            malzemelistesi();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            kasa();
        }


        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEME (AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", conn);
            komut.Parameters.AddWithValue("@p1", txtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", txtMalzemeNot.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Malzeme sisteme eklendi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            malzemelistesi();
            malzemetemizle();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUN (AD) values (@p1)", conn);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ürün sisteme eklendi");
            urunlistesi();
            uruncmbcekme();
            uruntemizle();

        }

        private void cmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            malzemelistesi();
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)", conn);
            komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", maliyet);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update TBLURUN set AD=@p1,MFIYAT=@p2,SFIYAT=@p3,STOK=STOK+1 where URUNID=@p4", conn);
            komut2.Parameters.AddWithValue("@p1", cmbUrun.Text);
            komut2.Parameters.AddWithValue("@p2", maliyet);
            komut2.Parameters.AddWithValue("@p3", maliyet + (maliyet * 25 / 100));
            komut2.Parameters.AddWithValue("@p4", cmbUrun.SelectedValue);
            komut2.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Pişirildi");
            satistemizle();
            urunlistesi();
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            if (txtMiktar.Text == "")
            {
                txtMiktar.Text = "0";
            }
            if (double.Parse(txtMiktar.Text)<= stok)
            {
                txtMaliyet.Text = (fiyat * double.Parse(txtMiktar.Text)).ToString("0.00");
                maliyet = double.Parse(txtMaliyet.Text);
            }
            else
            {
                MessageBox.Show("Stoğumuzda o kadar bulunmamaktadır.");
            }
        }
    }
}
