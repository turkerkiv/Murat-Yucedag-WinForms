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

namespace BankamatikSimulasyonu
{
    public partial class frmHareketler : Form
    {
        public frmHareketler()
        {
            InitializeComponent();
        }
        public string hesapno2;
        baglanti c = new baglanti();
        private void frmHareketler_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select TBLHAREKETLER.ID as Id,gonderen.AD+' '+gonderen.SOYAD as 'Gönderen ad soyad',alici.AD+' '+alici.SOYAD as 'Alıcı ad soyad',TUTAR as Tutar from TBLHAREKETLER inner join TBLKISILER gonderen on TBLHAREKETLER.GONDEREN = gonderen.HESAPNO inner join TBLKISILER alici on TBLHAREKETLER.ALICI = alici.HESAPNO where GONDEREN=@p1 or ALICI=@p1 ", c.conn());
            da.SelectCommand.Parameters.AddWithValue("@p1", hesapno2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
