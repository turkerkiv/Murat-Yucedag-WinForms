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
namespace RezervasyonTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbRezervasyon;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLYOLCU (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Yolcu kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKAPTAN (KAPTANNO,KAPTANADSOYAD,TELEFON) values (@p1,@p2,@p3)", conn);
            komut.Parameters.AddWithValue("@p1", mskKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", txtKaptanAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskKaptanTelefon.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kaptan kaydedildi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSEFER (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", txtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", txtVaris.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", mskKaptan.Text);
            komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sefer kaydedildi");
            seferlistesi();
        }
        int s1;
        private void button3_Click(object sender, EventArgs e)
        {
            s1++;
            if (s1 % 2 == 1)
            {
                this.Height = 727;
            }
            else
            {
                this.Height = 500;
            }

        }
        bool tumkoltuklardolumu;
        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            foreach (Control cntrl2 in groupBox1.Controls)
            {
                if (cntrl2 is Button)
                {
                    if (cntrl2.Enabled == false)
                    {
                        tumkoltuklardolumu = true;
                    }
                    else
                    {
                        tumkoltuklardolumu = false;
                        break;
                    }
                }
            }
            if (tumkoltuklardolumu == false)
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (SEFERNO,YOLCUTC,KOLTUKNO) values (@p1,@p2,@p3)", conn);
                komut.Parameters.AddWithValue("@p1", txtSeferNo2.Text);
                komut.Parameters.AddWithValue("@p2", mskTc2.Text);
                komut.Parameters.AddWithValue("@p3", txtKoltukNo.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("İşlem tamamlandı");
            }
            else
            {
                MessageBox.Show("Tüm koltuklar dolu");
            }

            koltuk();
            txtKoltukNo.Text = "";

        }
        int koltukno;

        void seferlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSEFER where DURUM=0", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            seferlistesi();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKoltukNo.Text = "";
            foreach (Control btn in groupBox1.Controls)
            {
                btn.Enabled = true;
                btn.BackColor = SystemColors.ScrollBar;
            }
            txtSeferNo2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            koltuk();

        }
        void koltuk()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from TBLHAREKET inner join TBLYOLCU on TBLHAREKET.YOLCUTC=TBLYOLCU.TC where seferno=@p1", conn);
            komut.Parameters.AddWithValue("@p1", txtSeferNo2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control btn in groupBox1.Controls)
                {
                    if (btn.Name == "btn" + dr[3].ToString())
                    {
                        if (dr[9].ToString() == "Erkek")
                        {
                            btn.Enabled = false;
                            btn.BackColor = Color.Blue;
                        }
                        else
                        {
                            btn.Enabled = false;
                            btn.BackColor = Color.Green;
                        }
                    }
                }
            }
            conn.Close();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            koltukno = 0;
            txtKoltukNo.Text = koltukno.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            koltukno = 1;
            txtKoltukNo.Text = koltukno.ToString();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            koltukno = 2;
            txtKoltukNo.Text = koltukno.ToString();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            koltukno = 3;
            txtKoltukNo.Text = koltukno.ToString();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            koltukno = 4;
            txtKoltukNo.Text = koltukno.ToString();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            koltukno = 5;
            txtKoltukNo.Text = koltukno.ToString();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            koltukno = 6;
            txtKoltukNo.Text = koltukno.ToString();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            koltukno = 7;
            txtKoltukNo.Text = koltukno.ToString();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            koltukno = 8;
            txtKoltukNo.Text = koltukno.ToString();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            koltukno = 9;
            txtKoltukNo.Text = koltukno.ToString();

        }
    }
}
