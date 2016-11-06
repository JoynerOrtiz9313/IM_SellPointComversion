using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InternationalMovile.Clases
{
    class DB_Connection
    {
        

        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter Adap = new SqlDataAdapter();
        DataTable dt = new DataTable();


    }
}
