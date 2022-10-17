using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DovizIslemleri;Integrated Security=True");
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDOVIZ", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label6.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            label13.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            label15.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

            

            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = eurosatis;

        }

        private void btnDolarAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarAlis.Text;
            islem = "dolaralis";

        }

        private void btnDolarSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatis.Text;
            islem = "dolarsatis";

        }

        private void btnEuroAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroAlis.Text;
            islem = "euroalis";
        }

        private void btnEuroSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroSatis.Text;
            islem = "eurosatis";
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {

            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = miktar * kur;

            txtTutar.Text = tutar.ToString();

            if (islem == "dolaralis")
            {
                baglanti.Open();
                double dolar, tl;
                SqlCommand komut = new SqlCommand("select * from TBLDOVIZ", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                dolar = Convert.ToDouble(dr[2]) - miktar;
                tl = Convert.ToDouble(dr[3]) + tutar;

                label6.Text = dr[2].ToString();

                dr.Close();

                SqlCommand komut2 = new SqlCommand("update TBLDOVIZ set DOLAR=@p1,TL=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", dolar);
                komut2.Parameters.AddWithValue("@p2", tl);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                listele();
            }
            if (islem == "dolarsatis")
            {
                baglanti.Open();
                double dolar, tl;
                SqlCommand komut = new SqlCommand("select * from TBLDOVIZ", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                dolar = Convert.ToDouble(dr[2]) + miktar;
                tl = Convert.ToDouble(dr[3]) - tutar;

                label6.Text = dr[2].ToString();

                dr.Close();

                SqlCommand komut2 = new SqlCommand("update TBLDOVIZ set DOLAR=@p1,TL=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", dolar);
                komut2.Parameters.AddWithValue("@p2", tl);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                listele();
            }
            if (islem == "euroalis")
            {
                baglanti.Open();
                double euro, tl;
                SqlCommand komut = new SqlCommand("select * from TBLDOVIZ", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                euro = Convert.ToDouble(dr[1]) - miktar;
                tl = Convert.ToDouble(dr[3]) + tutar;

                label6.Text = dr[2].ToString();

                dr.Close();

                SqlCommand komut2 = new SqlCommand("update TBLDOVIZ set EURO=@p1,TL=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", euro);
                komut2.Parameters.AddWithValue("@p2", tl);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                listele();
            }
            if (islem == "eurosatis")
            {
                baglanti.Open();
                double euro, tl;
                SqlCommand komut = new SqlCommand("select * from TBLDOVIZ", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                euro = Convert.ToDouble(dr[1]) + miktar;
                tl = Convert.ToDouble(dr[3]) - tutar;

                label6.Text = dr[2].ToString();

                dr.Close();

                SqlCommand komut2 = new SqlCommand("update TBLDOVIZ set EURO=@p1,TL=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", euro);
                komut2.Parameters.AddWithValue("@p2", tl);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                listele();
            }

        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".", ",");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int miktar, tutar;
            double kur = Convert.ToDouble(txtKur.Text);
            tutar = Convert.ToInt32(txtTutar.Text);
            miktar = Convert.ToInt32(tutar / kur);

            double kalan = tutar % kur;
            txtKalan.Text = kalan.ToString();

            txtMiktar.Text = miktar.ToString();

        }
    }
}
