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

namespace BankamatikSimulasyonu
{
    public partial class frmHavale : Form
    {
        public frmHavale()
        {
            InitializeComponent();
        }

        public string hesapno;
        double hesapbakiyesi;
        baglanti c = new baglanti();
        private void frmHavale_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBLKISILER where hesapno=@p1", c.conn());
            komut.Parameters.AddWithValue("@p1", hesapno);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            lblAdSoyad.Text = dr[1] + " " + dr[2];
            lblHesapNo.Text = hesapno;
            lblTelefon.Text = dr[4].ToString();
            lblTc.Text = dr[3].ToString();


            SqlCommand komut2 = new SqlCommand("select BAKIYE from TBLHESAP where hesapno=@p1", c.conn());
            komut2.Parameters.AddWithValue("@p1", hesapno);
            SqlDataReader dr2 = komut2.ExecuteReader();
            dr2.Read();
            txtTutar.Text = dr2[0].ToString();
            hesapbakiyesi = Convert.ToDouble(dr2[0]);
            c.conn().Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (hesapbakiyesi>0 && hesapbakiyesi-double.Parse(txtTutar.Text)>=0)
            {
                SqlCommand komut = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", c.conn());
                komut.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
                komut.Parameters.AddWithValue("@p2", mskHesapNo.Text);
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("update TBLHESAP set BAKIYE= BAKIYE-@p1 where HESAPNO=@p2", c.conn());
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@p2", hesapno);
                komut2.ExecuteNonQuery();

                SqlCommand komut4 = new SqlCommand("insert into TBLHAREKETLER (GONDEREN,ALICI,TUTAR) values (@p1,@p2,@p3)", c.conn());
                komut4.Parameters.AddWithValue("@p1", hesapno);
                komut4.Parameters.AddWithValue("@p2", mskHesapNo.Text);
                komut4.Parameters.AddWithValue("@p3", decimal.Parse(txtTutar.Text));
                komut4.ExecuteNonQuery();
                
                MessageBox.Show("İşlem Gerçekleşti.");

                SqlCommand komut3 = new SqlCommand("select BAKIYE from TBLHESAP where hesapno=@p1", c.conn());
                komut3.Parameters.AddWithValue("@p1", hesapno);
                SqlDataReader dr3 = komut3.ExecuteReader();
                dr3.Read();
                txtTutar.Text = dr3[0].ToString();
                hesapbakiyesi = Convert.ToDouble(dr3[0]);
                c.conn().Close();

            }
            else
            {
                MessageBox.Show("Paranız yok");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHareketler frm = new frmHareketler();
            frm.hesapno2 = lblHesapNo.Text;
            frm.Show();
        }
    }
}
