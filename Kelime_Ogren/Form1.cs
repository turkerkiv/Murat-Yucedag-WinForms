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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbSozluk;Integrated Security=True");

        public string kullaniciadi;
        public int dogrucevapsayisi;

        Random rastgele = new Random();
        string dgrcvp;
        int sure = 0, sure2 = 100, sure3 = -1, kelime = 0;

        void kelimegetir()
        {
            int id = rastgele.Next(1, 2490);

            conn.Open();

            SqlCommand komut = new SqlCommand("select * from TBLKELIMELER where ID=@p1", conn);
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();

            txtIngilizce.Text = dr[1].ToString();
            dgrcvp = dr[2].ToString().ToLower();


            conn.Close();
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {

            if (txtTurkce.Text == dgrcvp)
            {
                timer3.Start();
                kelime++;
                kelimegetir();
                sure = 0;
                txtTurkce.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            kelimegetir();
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sure3++;

            if (sure3 == 0)
            {
                lblKelime.Text = "DOĞRU!!!";

            }
            else if (sure3 == 5)
            {
                lblKelime.Text = kelime.ToString();
                sure3 = -1;
                timer3.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            sure2--;
            lblSure.Text = sure2.ToString();
            if (sure == 5)
            {
                kelimegetir();
                sure = 0;
                txtTurkce.Text = "";

                lblKelime.Text = kelime.ToString();

            }
            else if (sure2 == 0)
            {
                txtTurkce.Enabled = false;
                txtIngilizce.Enabled = false;
                timer1.Stop();
                button2.Visible = true;
                button3.Visible = true;

                MessageBox.Show("Oyun bitti.\nDoğru sayısı= " + kelime);
               

                if (kelime > dogrucevapsayisi)
                {
                    conn.Open();
                    SqlCommand komut = new SqlCommand("update TBLKULLANICILAR set DOGRUCEVAP=@p1 where KULLANICIADI=@p2", conn);
                    komut.Parameters.AddWithValue("@p1", kelime);
                    komut.Parameters.AddWithValue("@p2", kullaniciadi);
                    komut.ExecuteNonQuery();
                    conn.Close();
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
