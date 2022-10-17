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

namespace SorguProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sorgu,listele;
        SqlConnection conn = new SqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            
            sorgu = richTextBox1.Text.ToLower();

            if (sorgu.StartsWith("use"))
            {
                conn.ConnectionString = @"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=" + sorgu.Remove(0, 4) + ";Integrated Security=True";
                MessageBox.Show("Artık Veri Tabanı= " + sorgu.Remove(0, 4));
                richTextBox1.Text = "";
                //conn.Open();
                //conn.ChangeDatabase(sorgu.Remove(0, 4)); 
            }
            else if (sorgu.StartsWith("select"))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    listele = sorgu;
                    richTextBox1.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Sorgunuzu kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.ExecuteNonQuery();
                    conn.Close();

                    SqlDataAdapter da = new SqlDataAdapter(listele, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    richTextBox1.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Sorgunuzu kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            
        }
    }
}
