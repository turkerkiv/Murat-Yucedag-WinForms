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

namespace Proje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=Proje6;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proje6DataSet.Proje6Cagir' table. You can move, or remove it, as needed.
            this.proje6CagirTableAdapter.Fill(this.proje6DataSet.Proje6Cagir);
            

            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.ValueMember = "ID";
            cmbUrun.DisplayMember = "URUNAD";
            cmbUrun.DataSource = dt;

            cmbFiyat.DisplayMember = "SATISFIYAT";
            cmbFiyat.DataSource = dt;



            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBLMUSTERILER", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbMusteri.ValueMember = "ID";
            cmbMusteri.DisplayMember = "ADSOYAD";
            cmbMusteri.DataSource = dt2;

            SqlDataAdapter da3 = new SqlDataAdapter("select * from TBLPERSONELLER", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cmbPersonel.ValueMember = "ID";
            cmbPersonel.DisplayMember = "PERSONELAD";
            cmbPersonel.DataSource = dt3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand komut = new SqlCommand("insert into TBLHAREKETLER (URUN,MUSTERI,PERSONEL,FIYAT) values (@p1,@p2,@p3,@p4)", conn);
            komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbMusteri.SelectedValue);
            komut.Parameters.AddWithValue("@p3", cmbPersonel.SelectedValue);
            komut.Parameters.AddWithValue("@p4", cmbFiyat.Text);
            komut.ExecuteNonQuery();

            this.proje6CagirTableAdapter.Fill(this.proje6DataSet.Proje6Cagir);

            conn.Close();
        }
    }
}
