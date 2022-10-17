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
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Sekreterler where SekreterTc=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTcno.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                
                frmSekreterDetay frskrtd = new frmSekreterDetay();
                frskrtd.tcno2 = mskTcno.Text;
                frskrtd.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya şifre", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            bgl.baglanti().Close();
        }
    }
}
