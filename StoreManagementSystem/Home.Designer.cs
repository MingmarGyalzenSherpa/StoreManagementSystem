
namespace StoreManagementSystem
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.userLogoPanel = new System.Windows.Forms.Panel();
            this.dashBoard_btn = new FontAwesome.Sharp.IconButton();
            this.inventory_btn = new FontAwesome.Sharp.IconButton();
            this.vendors_btn = new FontAwesome.Sharp.IconButton();
            this.customers_btn = new FontAwesome.Sharp.IconButton();
            this.transact_btn = new FontAwesome.Sharp.IconButton();
            this.settings_btn = new FontAwesome.Sharp.IconButton();
            this.sideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.sideMenuPanel.Controls.Add(this.settings_btn);
            this.sideMenuPanel.Controls.Add(this.transact_btn);
            this.sideMenuPanel.Controls.Add(this.customers_btn);
            this.sideMenuPanel.Controls.Add(this.vendors_btn);
            this.sideMenuPanel.Controls.Add(this.inventory_btn);
            this.sideMenuPanel.Controls.Add(this.dashBoard_btn);
            this.sideMenuPanel.Controls.Add(this.userLogoPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(290, 907);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // userLogoPanel
            // 
            this.userLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.userLogoPanel.Name = "userLogoPanel";
            this.userLogoPanel.Size = new System.Drawing.Size(290, 204);
            this.userLogoPanel.TabIndex = 0;
            // 
            // dashBoard_btn
            // 
            this.dashBoard_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashBoard_btn.FlatAppearance.BorderSize = 0;
            this.dashBoard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBoard_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashBoard_btn.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.dashBoard_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.dashBoard_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashBoard_btn.IconSize = 55;
            this.dashBoard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBoard_btn.Location = new System.Drawing.Point(0, 204);
            this.dashBoard_btn.Name = "dashBoard_btn";
            this.dashBoard_btn.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.dashBoard_btn.Size = new System.Drawing.Size(290, 87);
            this.dashBoard_btn.TabIndex = 0;
            this.dashBoard_btn.Text = "Dash Board";
            this.dashBoard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBoard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashBoard_btn.UseVisualStyleBackColor = true;
            this.dashBoard_btn.Click += new System.EventHandler(this.dashBoard_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventory_btn.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.inventory_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.inventory_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inventory_btn.IconSize = 55;
            this.inventory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_btn.Location = new System.Drawing.Point(0, 291);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.inventory_btn.Size = new System.Drawing.Size(290, 87);
            this.inventory_btn.TabIndex = 1;
            this.inventory_btn.Text = "Inventory ";
            this.inventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventory_btn.UseVisualStyleBackColor = true;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // vendors_btn
            // 
            this.vendors_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vendors_btn.FlatAppearance.BorderSize = 0;
            this.vendors_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendors_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vendors_btn.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.vendors_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.vendors_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vendors_btn.IconSize = 55;
            this.vendors_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vendors_btn.Location = new System.Drawing.Point(0, 378);
            this.vendors_btn.Name = "vendors_btn";
            this.vendors_btn.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.vendors_btn.Size = new System.Drawing.Size(290, 87);
            this.vendors_btn.TabIndex = 2;
            this.vendors_btn.Text = "Vendors";
            this.vendors_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vendors_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vendors_btn.UseVisualStyleBackColor = true;
            this.vendors_btn.Click += new System.EventHandler(this.vendors_btn_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customers_btn.FlatAppearance.BorderSize = 0;
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customers_btn.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.customers_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.customers_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customers_btn.IconSize = 55;
            this.customers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers_btn.Location = new System.Drawing.Point(0, 465);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.customers_btn.Size = new System.Drawing.Size(290, 87);
            this.customers_btn.TabIndex = 3;
            this.customers_btn.Text = "Customers";
            this.customers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // transact_btn
            // 
            this.transact_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.transact_btn.FlatAppearance.BorderSize = 0;
            this.transact_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transact_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transact_btn.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.transact_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.transact_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.transact_btn.IconSize = 55;
            this.transact_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transact_btn.Location = new System.Drawing.Point(0, 552);
            this.transact_btn.Name = "transact_btn";
            this.transact_btn.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.transact_btn.Size = new System.Drawing.Size(290, 87);
            this.transact_btn.TabIndex = 4;
            this.transact_btn.Text = "Transact";
            this.transact_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transact_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transact_btn.UseVisualStyleBackColor = true;
            this.transact_btn.Click += new System.EventHandler(this.transact_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_btn.FlatAppearance.BorderSize = 0;
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings_btn.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.settings_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.settings_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settings_btn.IconSize = 55;
            this.settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_btn.Location = new System.Drawing.Point(0, 639);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.settings_btn.Size = new System.Drawing.Size(290, 87);
            this.settings_btn.TabIndex = 5;
            this.settings_btn.Text = "Settings";
            this.settings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 907);
            this.Controls.Add(this.sideMenuPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.sideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private FontAwesome.Sharp.IconButton dashBoard_btn;
        private System.Windows.Forms.Panel userLogoPanel;
        private FontAwesome.Sharp.IconButton settings_btn;
        private FontAwesome.Sharp.IconButton transact_btn;
        private FontAwesome.Sharp.IconButton customers_btn;
        private FontAwesome.Sharp.IconButton vendors_btn;
        private FontAwesome.Sharp.IconButton inventory_btn;
    }
}