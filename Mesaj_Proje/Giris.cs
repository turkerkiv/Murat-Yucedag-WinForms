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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbMesajProje;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand komut = new SqlCommand("select * from TBLKISILER where NUMARA=@p1 and SIFRE=@p2", conn);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            
            if (dr.Read())
            {
                frmMesaj frm = new frmMesaj();
                frm.numara = int.Parse(maskedTextBox1.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı numara veya şifre");
            }

            conn.Close();

        }
    }
}
