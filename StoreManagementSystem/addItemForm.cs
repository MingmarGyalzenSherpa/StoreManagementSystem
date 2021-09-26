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
    public partial class addItemForm : UserControl
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-0HA7MU0\SQLEXPRESS;Initial Catalog=StoreManagementSystem;Integrated Security=True");
        private string query;
     
        

        private void categComboBoxSetup()
        {
            
            categoryComboBox.Items.Clear();
            sql.Open();
            query = "Select * from Categories";
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                categoryComboBox.Items.Add(dr["category_name"].ToString());
            }
            sql.Close();
        }


        public addItemForm()
        {
            InitializeComponent();
            categComboBoxSetup();
           
        }

      

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subCategoryComboBox.Items.Clear();
            sql.Open();
            int index;
            index = categoryComboBox.SelectedIndex;
            index += 1;
            string query = "Select subcateg_name from SubCategories where category_id =" + index;
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                subCategoryComboBox.Items.Add(dr["subcateg_name"].ToString());

            }
        }
    }
}
