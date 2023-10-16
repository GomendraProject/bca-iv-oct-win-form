using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bca_iv_oct.Providers
{
    public class DbConnectionProvider
    {
        // Method to retrieve new database connection

        public static IDbConnection GetDbConnection()
        {
            return new SqlConnection("Server=KUSHAL\\KUSHAL;Database=bca_iv_test;User Id=sa;Password=admin;");
        }
    }
}
