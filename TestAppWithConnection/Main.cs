using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestAppWithConnection
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public String serverName_Main;
        public String userName_Main;
        public String passWord_Main;

        // Closes the window, does not close the connection
        private void EndSession_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thankyou. You have successfully disconnected.");
            this.Close();
        }
    }
}