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
        
        MySqlConnection cn = new MySqlConnection();
        public static string serverName = "";
        public static string userName = "";
        public static string passWord = "";

        private void button1_Click(object sender, EventArgs e)
        {
            serverName = server.Text;
            userName = username.Text;
            passWord = password.Text;

            try
            {
                cn.ConnectionString = "server=" + serverName + ";userid=" + userName + ";password=" + passWord + ";database=accountsdb";
                cn.Open();
                this.Hide();
                cn.Close();

                Main ss = new Main();
                ss.Show();

                /*using (Main ss = new Main())
                {
                    if (ss.ShowDialog() == DialogResult.OK)
                    {
                        ss.Show();
                        MessageBox.Show("Here 1");
                        ss.userName_Main = userName;
                        ss.serverName_Main = serverName;
                        ss.passWord_Main = passWord;
                        MessageBox.Show("Here");
                    }
                }*/
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void username_TextChanged(object sender, EventArgs e) { userName = this.Text; }

        public string getUser()
        {
            return userName;
        }

        private void password_TextChanged(object sender, EventArgs e) { passWord = this.Text; }

        public string getPw()
        {
            return passWord;
        }

        private void server_TextChanged(object sender, EventArgs e) { serverName = this.Text; }

        public string getServer()
        {
            return serverName;
        }
    }
}