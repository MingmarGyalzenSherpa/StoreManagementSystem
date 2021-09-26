using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace StoreManagementSystem
{

    public partial class Home : Form
    {
        //Fields
        private IconButton activeBtn;
        private Panel LeftBorderBtn;


       // public Home(string usercredential)
          public Home()
        {
            InitializeComponent();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7,85);
            sideMenuPanel.Controls.Add(LeftBorderBtn);
            ActivatedButton(dashBoard_btn);
            //username_label.Text = usercredential.ToUpper();
        }

        private void ActivatedButton(object senderBtn)
        {
           
            if(senderBtn!= null)
            {
                DeactivateBtn();
                activeBtn = (IconButton)senderBtn;
                activeBtn.Font = new Font(activeBtn.Font.FontFamily, 10);
                activeBtn.BackColor = Color.FromArgb(72, 78, 102);
                activeBtn.ForeColor = Color.IndianRed;
                activeBtn.TextAlign = ContentAlignment.MiddleCenter;
                activeBtn.IconColor = Color.IndianRed;
                activeBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                activeBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                LeftBorderBtn.BackColor = Color.IndianRed;
                LeftBorderBtn.Location = new Point(0, activeBtn.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();

            }
            

        }
        private void DeactivateBtn()
        {
            if (activeBtn != null)
            {

                activeBtn.Font = new Font(activeBtn.Font.FontFamily, 9);
                activeBtn.BackColor = Color.FromArgb(45, 49, 66);
                activeBtn.ForeColor = Color.Gainsboro;
                activeBtn.TextAlign = ContentAlignment.MiddleLeft;
                activeBtn.IconColor = Color.Gainsboro;
                activeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                activeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void dashBoard_btn_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            DashBoardForm dashboard = new DashBoardForm();
            MainControlClass.showControl(dashboard, Content);
            
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            InventoryForm invent = new InventoryForm();
            MainControlClass.showControl(invent, Content);
        }

        private void vendors_btn_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
        }

       

        private void transact_btn_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
            TransactForm trans = new TransactForm();
            MainControlClass.showControl(trans, Content);
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender);
        }

        private void dashBoardForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
