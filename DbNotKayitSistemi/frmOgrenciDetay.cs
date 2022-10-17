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
    public partial class frmOgrenciDetay : Form
    {
        public frmOgrenciDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TA7KUE7\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");

        public string ogrno;

        private void frmOgrenciDetay_Load(object sender, EventArgs e)
        {
            try
            {
                lblNumara.Text = ogrno;

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from TBLDERS where OGRNUMARA=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", ogrno);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();

                lblAdSoyad.Text = dr[2] + " " + dr[3];
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();
                baglanti.Close();
                if (lblDurum.Text == "True")
                {
                    lblDurum.Text = "Geçti";
                }
                else { lblDurum.Text = "Kaldı"; }
            }
            catch (Exception)
            {

                MessageBox.Show("Öğrenci numara hatalı");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
