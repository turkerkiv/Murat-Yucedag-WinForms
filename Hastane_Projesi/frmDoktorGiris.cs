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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select DoktorTc from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p1", mskTcno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            { 
            frmDoktorDetay frmdktrd = new frmDoktorDetay();
                frmdktrd.tcno = mskTcno.Text;
                frmdktrd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Tc veya şifre","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
