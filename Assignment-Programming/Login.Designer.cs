namespace Assignment_Project1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblErrorMssg = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblErrorMssg
            // 
            lblErrorMssg.AutoSize = true;
            lblErrorMssg.BackColor = SystemColors.ControlDarkDark;
            lblErrorMssg.Font = new Font("Segoe UI", 10F);
            lblErrorMssg.Location = new Point(121, 258);
            lblErrorMssg.Name = "lblErrorMssg";
            lblErrorMssg.Size = new Size(0, 19);
            lblErrorMssg.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(140, 190);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 19);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ActiveCaptionText;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(140, 115);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(145, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(100, 137);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 23);
            txtUsername.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(121, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 39);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(42, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 101);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(lblErrorMssg);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Location = new Point(544, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 358);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
          
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1589, 624);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            ImeMode = ImeMode.Katakana;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label lblErrorMssg;
        private GroupBox groupBox1;
    }
}