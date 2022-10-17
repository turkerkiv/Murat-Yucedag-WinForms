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

namespace Kelime_Ogren
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbSozluk;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select KULLANICIADI from TBLKULLANICILAR", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULLANICIADI";
            comboBox1.DataSource = dt;


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            

            conn.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKULLANICILAR where KULLANICIADI=@p1 and SIFRE=@p2", conn);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.dogrucevapsayisi = Convert.ToInt32(dr[2]);
                frm.kullaniciadi = dr[0].ToString();
                frm.Show();
                this.Hide();

            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select DOGRUCEVAP from TBLKULLANICILAR where KULLANICIADI=@p1", conn);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            label4.Text= dr[0].ToString();
            conn.Close();

            maskedTextBox1.Focus();
        }
    }
}
