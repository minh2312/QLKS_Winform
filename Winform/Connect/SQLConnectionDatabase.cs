using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Winform.Connect
{
    class SQLConnectionDatabase
    {
        private static string strcon = "server=localhost;database=QLHOTEL;uid=sa;pwd=123456;MultipleActiveResultSets=true";

        public static string StringConnection
        {
            get
            {
                return strcon;
            }
        }
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                return con;
            }
        }
    }
}
