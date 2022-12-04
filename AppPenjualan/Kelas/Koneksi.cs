using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Kelas
{
    class Koneksi
    {
        public SqlConnection getConn()
        {
            SqlConnection kon = new SqlConnection();
            kon.ConnectionString = "Data Source=MSI;Initial Catalog=Percobaan;Integrated Security=True";
            return kon;
        }
    }
}
