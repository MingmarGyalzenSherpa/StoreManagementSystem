
namespace StoreManagementSystem
{
    partial class splashScreen
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
            this.components = new System.ComponentModel.Container();
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.progressBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(102, 194);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBar.ProgressWidth = 6;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar.Size = new System.Drawing.Size(186, 182);
            this.progressBar.StartAngle = 270;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar.SubscriptText = "";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "";
            this.progressBar.TabIndex = 0;
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBar.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(69, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAMP STORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(29, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANAGEMENT SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(140, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOADING...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(129, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Copyrights © SAMP ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashScreen";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGEMENT SYSTEM";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}