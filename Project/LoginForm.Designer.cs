namespace real_loginForm
{
    partial class loginForm
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
            this.registrationBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // registrationBtn
            // 
            this.registrationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registrationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.registrationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationBtn.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.registrationBtn.Location = new System.Drawing.Point(484, 607);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(163, 58);
            this.registrationBtn.TabIndex = 0;
            this.registrationBtn.Text = "Register!";
            this.registrationBtn.UseVisualStyleBackColor = false;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.usernameLbl.Location = new System.Drawing.Point(121, 153);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(149, 28);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username: ";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLbl.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.welcomeLbl.Location = new System.Drawing.Point(171, 23);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(557, 40);
            this.welcomeLbl.TabIndex = 3;
            this.welcomeLbl.Text = "Welcome to the I.T. Helpdesk!";
            // 
            // loginLbl
            // 
            this.loginLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginLbl.AutoSize = true;
            this.loginLbl.BackColor = System.Drawing.Color.Transparent;
            this.loginLbl.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.loginLbl.Location = new System.Drawing.Point(348, 98);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(202, 37);
            this.loginLbl.TabIndex = 4;
            this.loginLbl.Text = "Login Here!";
            this.loginLbl.Click += new System.EventHandler(this.loginLbl_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameBox.BackColor = System.Drawing.Color.White;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Location = new System.Drawing.Point(251, 153);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(396, 29);
            this.usernameBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordBox.BackColor = System.Drawing.Color.White;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Location = new System.Drawing.Point(251, 198);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(396, 29);
            this.passwordBox.TabIndex = 6;
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.passwordLbl.Location = new System.Drawing.Point(123, 198);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(141, 28);
            this.passwordLbl.TabIndex = 7;
            this.passwordLbl.Text = "Password: ";
            this.passwordLbl.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(159, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Still Need an Account?";
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.continueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueBtn.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.continueBtn.Location = new System.Drawing.Point(251, 261);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(193, 58);
            this.continueBtn.TabIndex = 9;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.btnAdminLogin.Location = new System.Drawing.Point(484, 261);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(163, 58);
            this.btnAdminLogin.TabIndex = 10;
            this.btnAdminLogin.Text = "Admin";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(675, 204);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(176, 23);
            this.chkShowPassword.TabIndex = 13;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            this.chkShowPassword.CheckStateChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //this.flowLayoutPanel1.BackgroundImage = global::real_loginForm.Properties.Resources.GreenLogo;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(88, 88);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 729);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.registrationBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "loginForm";
            this.Text = "I.T. Helpdesk - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
