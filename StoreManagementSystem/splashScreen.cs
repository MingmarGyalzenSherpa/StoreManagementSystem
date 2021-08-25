using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace StoreManagementSystem
{
    public partial class splashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int RightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );


        public splashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressBar.Value = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 4;
            progressBar.Text = progressBar.Value.ToString() + "%";

            if(progressBar.Value == 100)
            {
                timer1.Enabled = false;
                Register rg = new Register();
                rg.Show();
                this.Hide();
            }
        }

      
    }
}
