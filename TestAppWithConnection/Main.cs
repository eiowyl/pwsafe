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

            //disp_data();

            
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

        // Closes the window, does not close the connection
        private void EndSession_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thankyou. You have successfully disconnected.");
            this.Close();
            System.Environment.Exit(1);
        }

        private void SQLDataDisplayBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Website_Click(object sender, EventArgs e)
        {
            
        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void pw_Click(object sender, EventArgs e)
        {

        }

        private void category_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Text box for filling in the website
        private void websiteTB_TextChanged(object sender, EventArgs e)
        {

        }

        // Text box for filling in the username
        private void usernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        // Text box for filling in the password
        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }

        // Text box for filling in the email
        private void emailTB_TextChanged(object sender, EventArgs e)
        {

        }

        // Submit button for adding in a new entry to the DB
        private void Submit_Click(object sender, EventArgs e)
        {
            
        }

        private void SubmitSQL_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=" + server_Main + ";userid=" + userName_Main + ";password=" + passWord_Main + ";database=accountsdb");

                string sql = "INSERT into accounts(Website, Username, Password, Email, Category) VALUES ('" + websiteTB.Text + "', '" + usernameTB.Text + "', '" + passwordTB.Text + "', '" + emailTB.Text + "', '" + options.Text + "'); commit;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
        public void disp_data()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=" + server_Main + ";userid=" + userName_Main + ";password=" + passWord_Main + ";database=accountsdb");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Website, Username, Email, Password FROM accountsdb.accounts";
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                SQLDataDisplayBox.DataSource = dataTable;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Could Not Establish a Connection");
            }
        }*/
    }
}