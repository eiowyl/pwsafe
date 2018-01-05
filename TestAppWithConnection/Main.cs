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

        MySqlConnection cn = new MySqlConnection();
        
        string server_Main;
        string userName_Main;
        string passWord_Main;

        private void Main_Load_1(object sender, EventArgs e)
        {
            server_Main = Authentication.serverName;
            userName_Main = Authentication.userName;
            passWord_Main = Authentication.passWord;
        }

        // Closes the window, does not close the connection
        private void EndSession_Click(object sender, EventArgs e)
        {
            //cn.Close();
            // MessageBox.Show("Thankyou. You have successfully disconnected.");
            this.Close();
            System.Environment.Exit(1);
        }

        private void OpenConn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = "server=" + server_Main + ";userid=" + userName_Main + ";password=" + passWord_Main + ";database=accountsdb";
                cn.Open();
                // Pull Data from the Database and display it

                cn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}