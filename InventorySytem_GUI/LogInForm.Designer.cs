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
            panel2 = new Panel();
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
            panel2.SuspendLayout();
            customizedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_img).BeginInit();
            customizedPanel1.SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(customizedPanel2);
            panel2.Controls.Add(passwordLabel);
            panel2.Controls.Add(usernameLabel);
            panel2.Controls.Add(password);
            panel2.Controls.Add(user_img);
            panel2.Controls.Add(username);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(clear);
            panel2.Controls.Add(logo_img);
            panel2.Controls.Add(showPassword);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 557);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            LOGIN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LOGIN.ForeColor = Color.GhostWhite;
            LOGIN.Location = new Point(-11, -9);
            LOGIN.Margin = new Padding(3, 2, 3, 2);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(173, 59);
            LOGIN.TabIndex = 3;
            LOGIN.Text = "LOGIN";
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
            logo_img.Location = new Point(91, 61);
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
            customizedPanel1.Controls.Add(panel2);
            customizedPanel1.ForeColor = Color.Black;
            customizedPanel1.GradientAngle = 90F;
            customizedPanel1.GradientBottomColor = Color.MediumPurple;
            customizedPanel1.GradientTopColor = Color.Violet;
            customizedPanel1.Location = new Point(221, 41);
            customizedPanel1.Name = "customizedPanel1";
            customizedPanel1.Size = new Size(416, 557);
            customizedPanel1.TabIndex = 3;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(832, 639);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            customizedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)user_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_img).EndInit();
            customizedPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
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
    }
}