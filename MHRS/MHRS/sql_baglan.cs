using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MHRS
{
    internal class sql_baglan
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MONSTER\\MONSTERS;Initial Catalog=MHRS;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
