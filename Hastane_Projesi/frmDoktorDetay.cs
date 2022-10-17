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
    public partial class frmDoktorDetay : Form
    {
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcno;
        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tcno;

            //Ad soyad çekme

            SqlCommand komut1 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            dr.Read();
            lblAdSoyad.Text = dr[0] + " " + dr[1];
            bgl.baglanti().Close();

            //Randevu listesi çekme

            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='"+lblAdSoyad.Text+"' and RandevuDurum=1", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Şikayet çekme

            





        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmDoktorBilgiD fr = new frmDoktorBilgiD();
            fr.tcno1 = lblTc.Text;
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }
    }
}
