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

        string server_Main;
        string userName_Main;
        string passWord_Main;

        private void Main_Load_1(object sender, EventArgs e)
        {
            server_Main = Authentication.serverName;
            userName_Main = Authentication.userName;
            passWord_Main = Authentication.passWord;

            try
            {
                MySqlConnection con = new MySqlConnection("server=" + server_Main + ";userid=" + userName_Main + ";password=" + passWord_Main + ";database=accountsdb");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Website, Username, Email, Password FROM accountsdb.accounts", con);

                con.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "accounts");
                SQLDataDisplayBox.DataSource = ds.Tables["accounts"];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Closes the Program
        private void EndSession_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thankyou. You have successfully disconnected.");
            this.Close();
            System.Environment.Exit(1);
        }

        private void OpenConn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection("server=" + server_Main + ";userid=" + userName_Main + ";password=" + passWord_Main + ";database=accountsdb");

                // Pull Data from the Database and display it
                string sql = "SELECT * FROM accounts";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cn.Open();

                

                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Website.Text += reader.GetString("Website");
                    Username.Text += reader.GetString("Username");
                    Pass.Text += reader.GetString("Password");
                    Email.Text += reader.GetString("Email");
                }

                cn.Close();
                } catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
        

        private void Website_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Pass_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void SQLDataDisplayBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}