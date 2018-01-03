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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        public MySqlConnection cn = new MySqlConnection();
        public String serverName;
        public String userName;
        public String passWord;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serverName = server.Text;
                userName = username.Text;
                passWord = password.Text;

                cn.ConnectionString = "server=" + serverName + ";userid=" + userName + ";password=" + passWord + ";database=accountsdb";
                cn.Open();

                this.Hide();
                /*Main ss = new Main();
                ss.Show();*/

                using (Main ss = new Main())
                {
                    if (ss.ShowDialog() == DialogResult.OK)
                    {
                        ss.Show();
                        ss.userName_Main = userName;
                        ss.serverName_Main = serverName;
                        ss.passWord_Main = passWord;
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void closeConn()
        {
            cn.Close();
        }

        // Username
        private void label1_Click(object sender, EventArgs e) { }

        // Password
        private void label2_Click(object sender, EventArgs e) { }

        // Server
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void ExitThisProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_TextChanged(object sender, EventArgs e) { }
        private void password_TextChanged(object sender, EventArgs e) { }
        private void server_TextChanged(object sender, EventArgs e) { }
    }
}