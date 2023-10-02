
namespace WindowsFormsApp1
{
    partial class login
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
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.groupLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLogin
            // 
            this.groupLogin.Controls.Add(this.user_name);
            this.groupLogin.Controls.Add(this.button1);
            this.groupLogin.Controls.Add(this.password);
            this.groupLogin.Location = new System.Drawing.Point(300, 161);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Size = new System.Drawing.Size(200, 129);
            this.groupLogin.TabIndex = 8;
            this.groupLogin.TabStop = false;
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(28, 21);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(166, 22);
            this.user_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(28, 62);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(166, 22);
            this.password.TabIndex = 2;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupLogin);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLogin;
        public System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox password;
    }
}