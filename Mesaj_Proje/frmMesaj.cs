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

namespace Mesaj_Proje
{
    public partial class frmMesaj : Form
    {
        public frmMesaj()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbMesajProje;Integrated Security=True");
        public int numara;
        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select (AD+' '+SOYAD) as GONDEREN,BASLIK,ICERIK from TBLMESAJLAR inner join TBLKISILER on TBLMESAJLAR.GONDEREN=TBLKISILER.NUMARA where ALICI=" + numara, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select (AD+' '+SOYAD) as ALICI,BASLIK,ICERIK from TBLMESAJLAR inner join TBLKISILER on TBLMESAJLAR.ALICI=TBLKISILER.NUMARA where GONDEREN=" + numara, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void frmMesaj_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara.ToString();
            gelenkutusu();
            gidenkutusu();

            //ADSOYAD
            conn.Open();

            SqlCommand komut = new SqlCommand("select AD,SOYAD from TBLKISILER where NUMARA=" + numara, conn);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();

            lblAdSoyad.Text = dr[0] + " " + dr[1];

            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) values (@p1,@p2,@p3,@p4)", conn);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", mskAlici.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", rchMesaj.Text);
            komut.ExecuteNonQuery();

            conn.Close();
            gidenkutusu();
            rchMesaj.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gelenkutusu();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.Show();
            this.Close();
        }
    }
}
