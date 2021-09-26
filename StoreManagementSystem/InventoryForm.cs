using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    public partial class InventoryForm : UserControl
    {
        private Button activebtn;


        public InventoryForm()
        {
            InitializeComponent();
            activatedBtn(addItemBtn);
            addItemForm additem = new addItemForm();
            MainControlClass.showControl(additem, Content);
        }
        
        private void activatedBtn(object sender)
        {
            if(sender!=null)
            {
                deactivateBtn();
                activebtn = (Button)sender;
                activebtn.BackColor = Color.FromArgb(72, 78, 102);
                activebtn.ForeColor = Color.White;

            }
        }
        private void deactivateBtn()
        {
            if(activebtn!=null)
            {
                activebtn.BackColor = Color.WhiteSmoke;
                activebtn.ForeColor = Color.Black;
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            activatedBtn(sender);
            addItemForm additem = new addItemForm();
            MainControlClass.showControl(additem, Content);
        }

        private void editItemBtn_Click(object sender, EventArgs e)
        {
            activatedBtn(sender);
        }
    }
}
