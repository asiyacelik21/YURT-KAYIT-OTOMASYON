using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public class SqlBaglantim
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=YurtKayit;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
