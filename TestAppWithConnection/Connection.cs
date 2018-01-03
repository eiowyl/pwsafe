using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestAppWithConnection
{
    class Connection
    {
        public MySqlConnection cn;

        public void setCon()
        {
            cn = new MySqlConnection();
        }

        public void openCon()
        {
            cn.Open();
        }

        public MySqlConnection getCon()
        {
            return cn;
        }

        public void closeCon()
        {
            cn.Close();
        }
    }
}
