using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BankamatikSimulasyonu
{
    class baglanti
    {
        public SqlConnection conn()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TIMFNTT\SQLEXPRESS;Initial Catalog=DbBankamatik;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
