using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocVaGuiXe
{
    public class My_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MBGJS2K\SQLSERVER;Initial Catalog=ChamSocVaGuiXe;Integrated Security=True");
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
