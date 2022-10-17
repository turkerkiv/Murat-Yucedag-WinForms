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


namespace PassaParola
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=PassaParola;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 1, dogru = 0, yanlis = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from TblPassaParola where ID=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", soruno);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();

            richTextBox1.Text = dr[1].ToString();

            baglanti.Close();

            button25.BackColor = Color.Orange;
            textBox1.Focus();
            this.Text = soruno.ToString();
            button25.Text = harfler[soruno];
        }

        string[] harfler = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            { 
                //SORULARI ÇEKME
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from TblPassaParola where ID=@p1 ", baglanti);
                komut.Parameters.AddWithValue("@p1", soruno);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();



                if (textBox1.Text == dr[2].ToString())
                {

                    foreach (Control l_control in Controls)
                    {
                        if (l_control.Name == "button" + soruno)
                        {
                            l_control.BackColor = Color.Yellow;
                        }
                    }

                    soruno++;
                    dogru++;
                    label3.Text = dogru.ToString();
                }
                else
                {
                    foreach (Control l_control in Controls)
                    {
                        if (l_control.Name == "button" + soruno)
                        {
                            l_control.BackColor = Color.Red;
                        }
                    }
                    soruno++;
                    yanlis++;
                    label4.Text=yanlis.ToString();
                }

                dr.Close();

                SqlCommand komut2 = new SqlCommand("select * from TblPassaParola where ID=@p1 ", baglanti);
                komut2.Parameters.AddWithValue("@p1", soruno);
                SqlDataReader dr2 = komut2.ExecuteReader();
                dr2.Read();

                button25.Text = harfler[soruno];
                textBox1.Clear();
                textBox1.Focus();

                richTextBox1.Text = dr2[1].ToString();
                this.Text = soruno.ToString();


                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Yarışma bitti.\nSonuçlar: " + dogru + " Doğru " + yanlis + " Yanlış");
            }


        }
    }
}
