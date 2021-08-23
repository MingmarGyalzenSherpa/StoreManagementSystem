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
    
    public partial class Register : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-0HA7MU0\SQLEXPRESS;Initial Catalog=StoreManagementSystem;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login1 = new Login();
             this.Hide();
             login1.Show();
            
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open(); // Open Sql connection

                if(password.Text == confirmPassword.Text)
                {
                    if(IsValidEmail(email.Text))
                    {
                        string query = "select * from UserCredential where UserName = '" + username.Text + "'and PassWord = '" + password.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, sql);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        
                        if (dt.Rows.Count < 1) // TO CHECK IF THE USERNAME IS ALREADY TAKEN
                        {
                            query = "insert into UserCredential (UserName, PassWord, Email) values (@parameter_name, @parameter_password, @parameter_email)";
                            cmd = new SqlCommand(query, sql);
                            cmd.Parameters.AddWithValue("@parameter_name", username.Text);
                            cmd.Parameters.AddWithValue("@parameter_password", password.Text);
                            cmd.Parameters.AddWithValue("@parameter_email", email.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Account Created Successfully!!");
                            Login login1 = new Login();
                            login1.Show();
                            this.Hide();

                            
                        }
                        else
                        {
                            MessageBox.Show("The username is already taken. Please use another username.", "USERNAME ALREADY TAKEN");
                        }
                       

                    }
                    else
                    {
                        MessageBox.Show("Please Check your Email ID!!", "Invalid Email");
                    }

                }
                else
                {
                    MessageBox.Show("Password do not match. Please try again!","PASSWORD ERROR" );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close Sql connection
                sql.Close();

            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e) //showing and hiding password
        {
            if(showPassword.Checked)
            {
                password.PasswordChar = '\0';
                confirmPassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                confirmPassword.PasswordChar = '*';
            }
        }

        private bool IsValidEmail(string email) // to check validity of email
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
