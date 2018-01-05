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

        string userName_Main;

        private void Main_Load_1(object sender, EventArgs e)
        {
            userName_Main = Authentication.userName;
            MessageBox.Show(userName_Main);
        }

        /*public MySqlConnection cn = new MySqlConnection();
        Authentication test = new Authentication();
        string serverName_Main;
        string userName_Main;
        string passWord_Main;*/

        // Closes the window, does not close the connection
        private void EndSession_Click(object sender, EventArgs e)
        {
            //cn.Close();
            //Authentication.cn.Close();
            //Authentication.closeConn();
            // MessageBox.Show("Thankyou. You have successfully disconnected.");
            this.Close();
            System.Environment.Exit(1);
        }

        private void OpenConn_Click(object sender, EventArgs e)
        {
            //passWord_Main = Authentication.passWord;
            userName_Main = Authentication.userName;
            //serverName_Main = Authentication.serverName;

            try
            {
                //cn.ConnectionString = "server=" + serverName_Main + ";userid=" + userName_Main + ";password=" + passWord_Main + ";database=accountsdb";
                //cn.Open();
                MessageBox.Show("Connection successfully created.");
                //cn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*if (mySQLConnection.State != ConnectionState.Open)
        {
            mySQLConnection.Close();
            mySQLConnection.Open();
        }*/
    }
}