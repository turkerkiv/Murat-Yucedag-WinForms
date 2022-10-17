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

namespace WindowsFormsApp1
{
    public partial class frmGrafikler : Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbSecimProjesi;Integrated Security=True");

        private void frmGrafikler_Load(object sender, EventArgs e)
        {
            //COMBOBOXA İSİMLERİ ÇEKME
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }

            baglanti.Close();

            //GRAFİĞE TOPLAM SONUÇLARI GETİRME
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI),sum(EPARTI) from TBLILCE ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            dr2.Read();

            chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
            chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
            chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
            chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
            chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);

            baglanti.Close();





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SEÇİLEN İLÇEYE GÖRE PROGRESSBARA VERİ ÇEKME
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("select * from TBLILCE where ILCEAD=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            dr3.Read();

            int s1, s2, s3, s4, s5;
            s1 = int.Parse(dr3[2].ToString());
            s2 = int.Parse(dr3[3].ToString());
            s3 = int.Parse(dr3[4].ToString());
            s4 = int.Parse(dr3[5].ToString());
            s5 = int.Parse(dr3[6].ToString());

            progressBar1.Maximum = s1 + s2 + s3 + s4 + s5;
            progressBar2.Maximum = s1 + s2 + s3 + s4 + s5;
            progressBar3.Maximum = s1 + s2 + s3 + s4 + s5;
            progressBar4.Maximum = s1 + s2 + s3 + s4 + s5;
            progressBar5.Maximum = s1 + s2 + s3 + s4 + s5;

            progressBar1.Value = int.Parse(dr3[2].ToString());
            progressBar2.Value = int.Parse(dr3[3].ToString());
            progressBar3.Value = int.Parse(dr3[4].ToString());
            progressBar4.Value = int.Parse(dr3[5].ToString());
            progressBar5.Value = int.Parse(dr3[6].ToString());

            label7.Text = dr3[2].ToString();
            label8.Text = dr3[3].ToString();
            label9.Text = dr3[4].ToString();
            label10.Text = dr3[5].ToString();
            label11.Text = dr3[6].ToString();

            baglanti.Close();



        }
    }
}
