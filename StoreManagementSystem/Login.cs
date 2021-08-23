using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-0HA7MU0\SQLEXPRESS;Initial Catalog=StoreManagementSystem;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e) //show and hide password
        {
            if(showPassword.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                string query = "select * from UserCredential where UserName = '" + username.Text + "'and PassWord = '" + password.Text + "'";
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    MessageBox.Show("Successfully logged in :)");
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg1 = new Register();
            this.Hide();
            reg1.Show();
        }
    }
}
