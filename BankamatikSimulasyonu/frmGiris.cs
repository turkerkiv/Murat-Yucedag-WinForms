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
    public partial class frmGiris : Form
    {
        baglanti c = new baglanti();
        public frmGiris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayit frm = new frmKayit();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBLKISILER where HESAPNO=@p1 and SIFRE=@p2", c.conn());
            komut.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmHavale frm = new frmHavale();
                frm.hesapno = mskHesapNo.Text;
                
                frm.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Şifre veya hesap numarası hatalı!!!");
            }
            c.conn().Close();
        }
    }
}
