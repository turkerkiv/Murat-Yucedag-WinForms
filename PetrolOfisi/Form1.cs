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

namespace PetrolOfisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbPetrolOfisi;Integrated Security=True");
        List<double> alisfiyat = new List<double>();
        void fiyatlistesi()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBENZIN", conn);
            SqlDataReader dr = komut.ExecuteReader();

            List<String> fiyatlistesi = new List<string>();
            List<int> depo = new List<int>();

            while (dr.Read())
            {
                alisfiyat.Add(Convert.ToDouble(dr[2]));
                fiyatlistesi.Add(dr[3].ToString());
                depo.Add(Convert.ToInt32(dr[4]));
            }
            dr.Close();
            SqlCommand komut2 = new SqlCommand("select * from TBLKASA", conn);
            SqlDataReader dr2 = komut2.ExecuteReader();
            dr2.Read();
            lblKasa.Text = dr2[0] + " TL";
            conn.Close();

            lblK95.Text = fiyatlistesi[0];
            lblMDiesel.Text = fiyatlistesi[1];
            lblK97.Text = fiyatlistesi[2];
            lblOtogaz.Text = fiyatlistesi[3];
            lblPDiesel.Text = fiyatlistesi[4];

            progressBar1.Value = depo[0];
            progressBar3.Value = depo[1];
            progressBar2.Value = depo[2];
            progressBar5.Value = depo[3];
            progressBar4.Value = depo[4];

            label16.Text = depo[0].ToString();
            label18.Text = depo[1].ToString();
            label17.Text = depo[2].ToString();
            label20.Text = depo[3].ToString();
            label19.Text = depo[4].ToString();


        }

        decimal litre, tutar;

        string benzinturu;

        private void Form1_Load(object sender, EventArgs e)
        {
            fiyatlistesi();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTK95.Text = (double.Parse(lblK95.Text) * double.Parse(maskedTextBox1.Text)).ToString("0.0");
                maskedTextBox2.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox4.Text = "";
                maskedTextBox5.Text = "";
                benzinturu = "Kurşunsuz 95";

            }
            catch (Exception)
            {
                maskedTextBox1.Text = "";
                txtTK95.Text = "";
            }
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTK97.Text = (double.Parse(lblK97.Text) * double.Parse(maskedTextBox2.Text)).ToString("0.0");
                maskedTextBox1.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox4.Text = "";
                maskedTextBox5.Text = "";
                benzinturu = "Kurşunsuz 97";


            }
            catch (Exception)
            {
                maskedTextBox2.Text = "";
                txtTK97.Text = "";
            }
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTMDiesel.Text = (double.Parse(lblMDiesel.Text) * double.Parse(maskedTextBox3.Text)).ToString("0.0");
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox4.Text = "";
                maskedTextBox5.Text = "";
                benzinturu = "Vmax Diesel";


            }
            catch (Exception)
            {
                maskedTextBox3.Text = "";
                txtTMDiesel.Text = "";
            }
        }

        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTPDiesel.Text = (double.Parse(lblPDiesel.Text) * double.Parse(maskedTextBox4.Text)).ToString("0.0");
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox5.Text = "";
                benzinturu = "Vpro Diesel";

            }
            catch (Exception)
            {
                maskedTextBox4.Text = "";
                txtTPDiesel.Text = "";
            }
        }

        private void maskedTextBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTOtogaz.Text = (double.Parse(lblOtogaz.Text) * double.Parse(maskedTextBox5.Text)).ToString("0.0");
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox4.Text = "";
                benzinturu = "Otogaz";

            }
            catch (Exception)
            {
                maskedTextBox5.Text = "";
                txtTOtogaz.Text = "";
            }
        }
        string petrolturualis;
        double alistutar;
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (petrolturualis)
                {
                    case "Kurşunsuz 95":
                        alistutar = alisfiyat[0] * double.Parse(textBox1.Text);
                        break;
                    case "Kurşunsuz 97":
                        alistutar = alisfiyat[2] * double.Parse(textBox1.Text);
                        break;
                    case "Vmax Diesel":
                        alistutar = alisfiyat[1] * double.Parse(textBox1.Text);
                        break;
                    case "Vpro Diesel":
                        alistutar = alisfiyat[4] * double.Parse(textBox1.Text);
                        break;
                    case "Otogaz":
                        alistutar = alisfiyat[3] * double.Parse(textBox1.Text);
                        break;
                }

                if (textBox11.Text == "alis")
                {
                    conn.Open();
                    SqlCommand komut = new SqlCommand("insert into TBLHAREKET (BENZINTURU,LITRE,FIYAT,PLAKA) values (@p1,@p2,@p3,@p4) ", conn);
                    komut.Parameters.AddWithValue("@p1", petrolturualis);
                    komut.Parameters.AddWithValue("@p2", decimal.Parse(textBox1.Text));
                    komut.Parameters.AddWithValue("@p3", alistutar);
                    komut.Parameters.AddWithValue("@p4", textBox11.Text);
                    komut.ExecuteNonQuery();
                    conn.Close();
                    groupBox5.Text = "Petrol satın alış";
                    fiyatlistesi();
                }
                else
                {
                    MessageBox.Show("Lütfen plaka kısmına alis yazınız");
                }

            }
            catch (Exception)
            {
                groupBox5.Text = "Sayısal değer giriniz";
                conn.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            petrolturualis = "Kurşunsuz 95";
            textBox1.Text = petrolturualis;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            petrolturualis = "Kurşunsuz 97";
            textBox1.Text = petrolturualis;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            petrolturualis = "Vmax Diesel";
            textBox1.Text = petrolturualis;

        }

        private void label12_Click(object sender, EventArgs e)
        {
            petrolturualis = "Vpro Diesel";
            textBox1.Text = petrolturualis;

        }

        private void label10_Click(object sender, EventArgs e)
        {
            petrolturualis = "Otogaz";
            textBox1.Text = petrolturualis;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox2.Controls)
            {
                if (control is MaskedTextBox && string.IsNullOrEmpty(control.Text) != true)
                {
                    litre = decimal.Parse(control.Text);
                }
                if (control is TextBox && string.IsNullOrEmpty(control.Text) != true)
                {
                    tutar = decimal.Parse(control.Text);
                }
            }

            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", conn);
            komut.Parameters.AddWithValue("@p1", textBox11.Text);
            komut.Parameters.AddWithValue("@p2", benzinturu);
            komut.Parameters.AddWithValue("@p3", litre);
            komut.Parameters.AddWithValue("@p4", tutar);
            komut.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Dolum gerçekleşti");

            fiyatlistesi();
        }
    }
}
