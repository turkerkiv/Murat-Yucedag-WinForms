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
using System.IO;


namespace EtutDersKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbEtut;Integrated Security=True");
        List<string> dersadlari = new List<string>();
        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERS", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbDers.ValueMember = "DERSID";
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.DataSource = dt;

            cmbDers2.ValueMember = "DERSID";
            cmbDers2.DisplayMember = "DERSAD";
            cmbDers2.DataSource = dt;

            foreach (DataRow dr in dt.Rows)
            {
                string ders = dr["DERSAD"].ToString();
                dersadlari.Add(ders);
            }
        }
        void ogretmenlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select AD+' '+SOYAD as AD, OGRTID from TBLOGRETMEN where BRANSID=" + cmbDers.SelectedValue, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbOgretmen.ValueMember = "OGRTID";
            cmbOgretmen.DisplayMember = "AD";
            cmbOgretmen.DataSource = dt;
        }
        void etutlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute etut", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool durum = Convert.ToBoolean(dt.Rows[i]["DURUM"]);
                if (durum == true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }

            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ogretmenlistesi();
        }

        private void btnEtutOlustur_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", conn);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Etüt oluşturuldu.");
            etutlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEtutId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("update TBLETUT set OGRENCIID=@p1,DURUM=1 where ETUTID=@p2", conn);
            komut.Parameters.AddWithValue("@p1", txtOgrNo.Text);
            komut.Parameters.AddWithValue("@p2", txtEtutId.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("İşlem gerçekleşti");
            etutlistesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnYOgr_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", txtOgrAd.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", txtOgrSinif.Text);
            komut.Parameters.AddWithValue("@p5", txtOgrTel.Text);
            komut.Parameters.AddWithValue("@p6", txtOgrMail.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ogrenci Eklendi.");
        }

        private void btnYOgrt_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,BRANSID) values (@p1,@p2,@p3)", conn);
            komut.Parameters.AddWithValue("@p1", txtOgrtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbDers2.SelectedValue);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ogretmen Eklendi.");
            ogretmenlistesi();
        }

        private void btnYDers_Click(object sender, EventArgs e)
        {
            if (dersadlari.Contains(txtDersAd.Text) == false)
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into TBLDERS (DERSAD) values (@p1)", conn);
                komut.Parameters.AddWithValue("@p1", txtDersAd.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ders Eklendi.");
                derslistesi();
            }
            else
            {
                MessageBox.Show("Bu ders zaten var");
            }
        }
    }
}
