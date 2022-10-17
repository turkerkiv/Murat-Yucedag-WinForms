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

namespace Hastane_Projesi
{
    public partial class frmHastaGiris : Form
    {
        public frmHastaGiris()
        {
            InitializeComponent();

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void lnkUyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayit frmhstkyt = new frmHastaKayit();
            frmhstkyt.Show();
        }



        private void btnGiris_Click(object sender, EventArgs e)
        {



            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTc= @p1 and HastaSifre= @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTcno.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                frmHastaDetay frmhstdty = new frmHastaDetay();
                frmhstdty.tc = mskTcno.Text;

                frmhstdty.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Hatalı şifre veya TC no", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bgl.baglanti().Close();



        }
    }
}
