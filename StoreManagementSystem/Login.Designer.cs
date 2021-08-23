
namespace StoreManagementSystem
{
    partial class Login
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
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showPassword.Location = new System.Drawing.Point(239, 252);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(129, 21);
            this.showPassword.TabIndex = 24;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginLink.LinkColor = System.Drawing.Color.Cyan;
            this.loginLink.Location = new System.Drawing.Point(221, 357);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(72, 17);
            this.loginLink.TabIndex = 26;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Click Here";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(60, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Don\'t have an account?";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password.Location = new System.Drawing.Point(27, 204);
            this.password.Margin = new System.Windows.Forms.Padding(0);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(340, 32);
            this.password.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(18, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 1);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(18, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 1);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.username.Location = new System.Drawing.Point(24, 121);
            this.username.Margin = new System.Windows.Forms.Padding(0);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(341, 32);
            this.username.TabIndex = 17;
            // 
            // login_btn
            // 
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_btn.Location = new System.Drawing.Point(96, 292);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(162, 47);
            this.login_btn.TabIndex = 25;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(15, 178);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 17);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameLabel.Location = new System.Drawing.Point(15, 99);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(94, 17);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(136, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "LOGIN ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formexample";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
    }
}