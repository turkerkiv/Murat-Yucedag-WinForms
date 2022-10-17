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

namespace VeritabaniSifreleme
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbRehber;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        string coz(string p)
        {
            string parametrecoz = p;
            byte[] parametrecozumdizisi = Convert.FromBase64String(parametrecoz);
            string parametrecozum = ASCIIEncoding.UTF32.GetString(parametrecozumdizisi);
            return parametrecozum;
        }
        void listele()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLVERILER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            foreach (DataRow dataRow in dt.Rows)
            {
                dataRow["AD"] = coz(dataRow["AD"].ToString());
                dataRow["SOYAD"] = coz(dataRow["SOYAD"].ToString());
                dataRow["MAIL"] = coz(dataRow["MAIL"].ToString());
                dataRow["SIFRE"] = coz(dataRow["SIFRE"].ToString());
                dataRow["HESAPNO"] = coz(dataRow["HESAPNO"].ToString());
            }
            dataGridView1.DataSource = dt;


            //dt.Columns.Add("ID");
            //dt.Columns.Add("AD");
            //dt.Columns.Add("SOYAD");
            //dt.Columns.Add("MAIL");
            //dt.Columns.Add("SIFRE");
            //dt.Columns.Add("HESAPNO");

            //while (dr.Read())
            //{
            //    string adcoz = dr[1].ToString();
            //    byte[] adcozumd = Convert.FromBase64String(adcoz);
            //    string adcozum = ASCIIEncoding.ASCII.GetString(adcozumd);

            //    string soyadcoz = dr[2].ToString();
            //    byte[] soyadcozumd = Convert.FromBase64String(soyadcoz);
            //    string soyadcozum = ASCIIEncoding.ASCII.GetString(soyadcozumd);

            //    string mailcoz = dr[3].ToString();
            //    byte[] mailcozumd = Convert.FromBase64String(mailcoz);
            //    string mailcozum = ASCIIEncoding.ASCII.GetString(mailcozumd);

            //    string sifrecoz = dr[4].ToString();
            //    byte[] sifrecozumd = Convert.FromBase64String(sifrecoz);
            //    string sifrecozum = ASCIIEncoding.ASCII.GetString(sifrecozumd);

            //    string hesapnocoz = dr[5].ToString();
            //    byte[] hesapnocozumd = Convert.FromBase64String(hesapnocoz);
            //    string hesapnocozum = ASCIIEncoding.ASCII.GetString(hesapnocozumd);

            //    string[] veriler = { dr[0].ToString(),adcozum, soyadcozum, mailcozum, sifrecozum, hesapnocozum };
            //    dt.Rows.Add(veriler);
            //}

            //dataGridView1.DataSource = dt;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] addizisi = ASCIIEncoding.UTF32.GetBytes(ad);
            string adsifreleme = Convert.ToBase64String(addizisi);

            string soyad = txtSoyad.Text;
            byte[] soyaddizisi = ASCIIEncoding.UTF32.GetBytes(soyad);
            string soyadsifreleme = Convert.ToBase64String(soyaddizisi);

            string mail = txtMail.Text;
            byte[] maildizisi = ASCIIEncoding.UTF32.GetBytes(mail);
            string mailsifreleme = Convert.ToBase64String(maildizisi);

            string sifre = txtSifre.Text;
            byte[] sifredizisi = ASCIIEncoding.UTF32.GetBytes(sifre);
            string sifresifreleme = Convert.ToBase64String(sifredizisi);

            string hesapno = txtHesapNo.Text;
            byte[] hesapnodizisi = ASCIIEncoding.UTF32.GetBytes(hesapno);
            string hesapnosifreleme = Convert.ToBase64String(hesapnodizisi);

            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", conn);
            komut.Parameters.AddWithValue("@p1", adsifreleme);
            komut.Parameters.AddWithValue("@p2", soyadsifreleme);
            komut.Parameters.AddWithValue("@p3", mailsifreleme);
            komut.Parameters.AddWithValue("@p4", sifresifreleme);
            komut.Parameters.AddWithValue("@p5", hesapnosifreleme);
            komut.ExecuteNonQuery();
            conn.Close();

            listele();
            MessageBox.Show("Veriler Eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cozum = txtAd.Text;
            byte[] cozumdizisi = Convert.FromBase64String(cozum);
            string cozumleme = ASCIIEncoding.UTF32.GetString(cozumdizisi);
            label6.Text = cozumleme;

        }
    }
}
