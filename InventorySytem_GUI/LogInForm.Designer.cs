namespace InventorySytem_GUI
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            panel1 = new Panel();
            logInPanel = new Panel();
            pictureBox1 = new PictureBox();
            forgotPassword = new Label();
            customizedPanel2 = new CustomizedPanel();
            LOGIN = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            password = new TextBox();
            user_img = new PictureBox();
            username = new TextBox();
            pictureBox3 = new PictureBox();
            clear = new Label();
            logo_img = new PictureBox();
            showPassword = new CheckBox();
            label2 = new Label();
            customizedPanel1 = new CustomizedPanel();
            closeLogInButton = new Button();
            createUserPanel = new Panel();
            signUpLabel = new Label();
            accountLabel = new Label();
            customizedPanel3 = new CustomizedPanel();
            logInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customizedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_img).BeginInit();
            customizedPanel1.SuspendLayout();
            createUserPanel.SuspendLayout();
            customizedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(1614, -26);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 249);
            panel1.TabIndex = 0;
            // 
            // logInPanel
            // 
            logInPanel.BackColor = Color.White;
            logInPanel.BackgroundImageLayout = ImageLayout.Stretch;
            logInPanel.Controls.Add(pictureBox1);
            logInPanel.Controls.Add(forgotPassword);
            logInPanel.Controls.Add(customizedPanel2);
            logInPanel.Controls.Add(passwordLabel);
            logInPanel.Controls.Add(usernameLabel);
            logInPanel.Controls.Add(password);
            logInPanel.Controls.Add(user_img);
            logInPanel.Controls.Add(username);
            logInPanel.Controls.Add(pictureBox3);
            logInPanel.Controls.Add(clear);
            logInPanel.Controls.Add(logo_img);
            logInPanel.Controls.Add(showPassword);
            logInPanel.Location = new Point(-9, -5);
            logInPanel.Margin = new Padding(3, 2, 3, 2);
            logInPanel.Name = "logInPanel";
            logInPanel.Size = new Size(428, 563);
            logInPanel.TabIndex = 1;
            logInPanel.Paint += logInPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 223);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // forgotPassword
            // 
            forgotPassword.AccessibleDescription = "clearAll";
            forgotPassword.AutoSize = true;
            forgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            forgotPassword.ForeColor = Color.DarkSlateBlue;
            forgotPassword.Location = new Point(154, 525);
            forgotPassword.Name = "forgotPassword";
            forgotPassword.Size = new Size(100, 15);
            forgotPassword.TabIndex = 42;
            forgotPassword.Text = "Forgot Password?";
            // 
            // customizedPanel2
            // 
            customizedPanel2.BackColor = Color.White;
            customizedPanel2.BorderRadius = 30;
            customizedPanel2.Controls.Add(LOGIN);
            customizedPanel2.ForeColor = Color.Black;
            customizedPanel2.GradientAngle = 90F;
            customizedPanel2.GradientBottomColor = Color.MediumPurple;
            customizedPanel2.GradientTopColor = Color.Violet;
            customizedPanel2.Location = new Point(124, 461);
            customizedPanel2.Name = "customizedPanel2";
            customizedPanel2.Size = new Size(160, 40);
            customizedPanel2.TabIndex = 41;
            // 
            // LOGIN
            // 
            LOGIN.AccessibleName = "loginBtn";
            LOGIN.BackColor = Color.SeaGreen;
            LOGIN.FlatStyle = FlatStyle.Popup;
            LOGIN.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LOGIN.ForeColor = Color.GhostWhite;
            LOGIN.Location = new Point(-11, -9);
            LOGIN.Margin = new Padding(3, 2, 3, 2);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(173, 59);
            LOGIN.TabIndex = 3;
            LOGIN.Text = "Log In";
            LOGIN.UseVisualStyleBackColor = false;
            LOGIN.Click += loginBtn_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.DarkSlateBlue;
            passwordLabel.Location = new Point(62, 347);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 40;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.DarkSlateBlue;
            usernameLabel.Location = new Point(62, 273);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 39;
            usernameLabel.Text = "Username";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(62, 370);
            password.Name = "password";
            password.Size = new Size(314, 29);
            password.TabIndex = 38;
            password.TextChanged += password_TextChanged;
            // 
            // user_img
            // 
            user_img.BackgroundImageLayout = ImageLayout.Stretch;
            user_img.Image = (Image)resources.GetObject("user_img.Image");
            user_img.Location = new Point(24, 296);
            user_img.Margin = new Padding(3, 2, 3, 2);
            user_img.Name = "user_img";
            user_img.Size = new Size(32, 29);
            user_img.SizeMode = PictureBoxSizeMode.Zoom;
            user_img.TabIndex = 4;
            user_img.TabStop = false;
            user_img.Click += pictureBox1_Click;
            // 
            // username
            // 
            username.AccessibleName = "product_Id";
            username.BackColor = SystemColors.Window;
            username.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(61, 296);
            username.Name = "username";
            username.Size = new Size(314, 29);
            username.TabIndex = 37;
            username.TextChanged += username_TextChanged_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 366);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // clear
            // 
            clear.AccessibleDescription = "clearAll";
            clear.AutoSize = true;
            clear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clear.ForeColor = Color.DarkSlateBlue;
            clear.Location = new Point(89, 415);
            clear.Name = "clear";
            clear.Size = new Size(51, 15);
            clear.TabIndex = 3;
            clear.Text = "Clear All";
            clear.Click += clear_Click;
            // 
            // logo_img
            // 
            logo_img.BackgroundImageLayout = ImageLayout.Stretch;
            logo_img.Enabled = false;
            logo_img.Image = (Image)resources.GetObject("logo_img.Image");
            logo_img.Location = new Point(89, 33);
            logo_img.Margin = new Padding(3, 2, 3, 2);
            logo_img.Name = "logo_img";
            logo_img.Size = new Size(235, 186);
            logo_img.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_img.TabIndex = 3;
            logo_img.TabStop = false;
            logo_img.Click += pictureBox2_Click;
            // 
            // showPassword
            // 
            showPassword.AccessibleDescription = "showPassword";
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPassword.ForeColor = Color.DarkSlateBlue;
            showPassword.Location = new Point(231, 415);
            showPassword.Margin = new Padding(3, 2, 3, 2);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(108, 19);
            showPassword.TabIndex = 5;
            showPassword.Text = "Show Password\r\n";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(46, 16);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // customizedPanel1
            // 
            customizedPanel1.BackColor = Color.White;
            customizedPanel1.BorderRadius = 30;
            customizedPanel1.Controls.Add(logInPanel);
            customizedPanel1.ForeColor = Color.Black;
            customizedPanel1.GradientAngle = 90F;
            customizedPanel1.GradientBottomColor = Color.MediumPurple;
            customizedPanel1.GradientTopColor = Color.Violet;
            customizedPanel1.Location = new Point(220, 28);
            customizedPanel1.Name = "customizedPanel1";
            customizedPanel1.Size = new Size(416, 557);
            customizedPanel1.TabIndex = 3;
            // 
            // closeLogInButton
            // 
            closeLogInButton.AccessibleName = "searchBtn";
            closeLogInButton.BackColor = Color.Transparent;
            closeLogInButton.BackgroundImage = (Image)resources.GetObject("closeLogInButton.BackgroundImage");
            closeLogInButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeLogInButton.FlatAppearance.BorderSize = 0;
            closeLogInButton.FlatStyle = FlatStyle.Flat;
            closeLogInButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeLogInButton.ForeColor = Color.Transparent;
            closeLogInButton.ImageAlign = ContentAlignment.MiddleRight;
            closeLogInButton.Location = new Point(796, 0);
            closeLogInButton.Margin = new Padding(0);
            closeLogInButton.Name = "closeLogInButton";
            closeLogInButton.Size = new Size(34, 32);
            closeLogInButton.TabIndex = 45;
            closeLogInButton.UseVisualStyleBackColor = false;
            closeLogInButton.Click += closeLogInButton_Click_1;
            // 
            // createUserPanel
            // 
            createUserPanel.BackColor = Color.White;
            createUserPanel.Controls.Add(signUpLabel);
            createUserPanel.Controls.Add(accountLabel);
            createUserPanel.Location = new Point(-9, -3);
            createUserPanel.Name = "createUserPanel";
            createUserPanel.Size = new Size(434, 71);
            createUserPanel.TabIndex = 46;
            createUserPanel.Paint += createUserPanel_Paint;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            signUpLabel.ForeColor = Color.Indigo;
            signUpLabel.Location = new Point(255, 17);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(61, 20);
            signUpLabel.TabIndex = 41;
            signUpLabel.Text = "Sign up";
            signUpLabel.CursorChanged += signUpLabel_Click;
            signUpLabel.Click += signUpLabel_Click;
            signUpLabel.Enter += signUpLabel_Click;
            signUpLabel.MouseClick += Yes;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            accountLabel.ForeColor = Color.DarkSlateBlue;
            accountLabel.Location = new Point(91, 17);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(169, 20);
            accountLabel.TabIndex = 40;
            accountLabel.Text = " Don't have an Account?";
            // 
            // customizedPanel3
            // 
            customizedPanel3.BackColor = Color.White;
            customizedPanel3.BorderRadius = 30;
            customizedPanel3.Controls.Add(createUserPanel);
            customizedPanel3.ForeColor = Color.Black;
            customizedPanel3.GradientAngle = 90F;
            customizedPanel3.GradientBottomColor = Color.MediumPurple;
            customizedPanel3.GradientTopColor = Color.Violet;
            customizedPanel3.Location = new Point(220, 591);
            customizedPanel3.Name = "customizedPanel3";
            customizedPanel3.Size = new Size(416, 53);
            customizedPanel3.TabIndex = 47;
            customizedPanel3.Paint += customizedPanel3_Paint;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(837, 659);
            Controls.Add(customizedPanel3);
            Controls.Add(closeLogInButton);
            Controls.Add(customizedPanel1);
            Controls.Add(label2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            logInPanel.ResumeLayout(false);
            logInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customizedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)user_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_img).EndInit();
            customizedPanel1.ResumeLayout(false);
            createUserPanel.ResumeLayout(false);
            createUserPanel.PerformLayout();
            customizedPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel logInPanel;
        private Label label1;
        private Label label2;
        private Button LOGIN;
        private PictureBox user_img;
        private PictureBox logo_img;
        private CheckBox showPassword;
        private PictureBox pictureBox3;
        private Label clear;
        private CustomizedPanel customizedPanel1;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox password;
        private TextBox username;
        private CustomizedPanel customizedPanel2;
        private Button closeLogInButton;
        private Label forgotPassword;
        private Panel createUserPanel;
        private Label signUpLabel;
        private Label accountLabel;
        private CustomizedPanel customizedPanel3;
        private PictureBox pictureBox1;
    }
}