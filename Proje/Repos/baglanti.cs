using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace GetConnection
{
    class baglanti
    {
        public SqlConnection GetConnection()
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["proje"].ConnectionString;
            sc.Open();
            return sc;
        }
    }

}
