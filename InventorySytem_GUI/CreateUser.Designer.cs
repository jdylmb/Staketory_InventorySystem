namespace InventorySytem_GUI
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            logInPanel = new Panel();
            pictureBox1 = new PictureBox();
            logo_img = new PictureBox();
            label2 = new Label();
            signUpLabel = new Label();
            accountLabel = new Label();
            label1 = new Label();
            customizedPanel2 = new CustomizedPanel();
            SignUpButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            password = new TextBox();
            user_img = new PictureBox();
            username = new TextBox();
            pictureBox3 = new PictureBox();
            customizedPanel1 = new CustomizedPanel();
            logInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_img).BeginInit();
            customizedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            customizedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // logInPanel
            // 
            logInPanel.BackColor = Color.White;
            logInPanel.BackgroundImageLayout = ImageLayout.Stretch;
            logInPanel.Controls.Add(pictureBox1);
            logInPanel.Controls.Add(logo_img);
            logInPanel.Controls.Add(label2);
            logInPanel.Location = new Point(0, -14);
            logInPanel.Margin = new Padding(3, 2, 3, 2);
            logInPanel.Name = "logInPanel";
            logInPanel.Size = new Size(433, 695);
            logInPanel.TabIndex = 2;
            logInPanel.Paint += logInPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 432);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // logo_img
            // 
            logo_img.BackgroundImageLayout = ImageLayout.Stretch;
            logo_img.Enabled = false;
            logo_img.Image = (Image)resources.GetObject("logo_img.Image");
            logo_img.Location = new Point(47, 117);
            logo_img.Margin = new Padding(3, 2, 3, 2);
            logo_img.Name = "logo_img";
            logo_img.Size = new Size(333, 342);
            logo_img.SizeMode = PictureBoxSizeMode.Zoom;
            logo_img.TabIndex = 3;
            logo_img.TabStop = false;
            logo_img.Click += logo_img_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(3, 562);
            label2.Name = "label2";
            label2.Size = new Size(410, 21);
            label2.TabIndex = 0;
            label2.Text = "Enter your personal details and start your journey with us.";
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.BackColor = Color.Transparent;
            signUpLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            signUpLabel.ForeColor = Color.Indigo;
            signUpLabel.Location = new Point(694, 549);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(59, 21);
            signUpLabel.TabIndex = 45;
            signUpLabel.Text = "Log In";
            signUpLabel.Click += signUpLabel_Click;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.BackColor = Color.Transparent;
            accountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountLabel.ForeColor = Color.White;
            accountLabel.Location = new Point(512, 548);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(186, 21);
            accountLabel.TabIndex = 44;
            accountLabel.Text = "Already have an account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(529, 103);
            label1.Name = "label1";
            label1.Size = new Size(224, 36);
            label1.TabIndex = 43;
            label1.Text = "Create Account";
            // 
            // customizedPanel2
            // 
            customizedPanel2.BackColor = Color.White;
            customizedPanel2.BorderRadius = 30;
            customizedPanel2.Controls.Add(SignUpButton);
            customizedPanel2.ForeColor = Color.Black;
            customizedPanel2.GradientAngle = 90F;
            customizedPanel2.GradientBottomColor = Color.MediumPurple;
            customizedPanel2.GradientTopColor = Color.Violet;
            customizedPanel2.Location = new Point(489, 394);
            customizedPanel2.Name = "customizedPanel2";
            customizedPanel2.Size = new Size(313, 40);
            customizedPanel2.TabIndex = 41;
            // 
            // SignUpButton
            // 
            SignUpButton.AccessibleName = "loginBtn";
            SignUpButton.BackColor = Color.SeaGreen;
            SignUpButton.FlatStyle = FlatStyle.Popup;
            SignUpButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpButton.ForeColor = Color.GhostWhite;
            SignUpButton.Location = new Point(-12, -11);
            SignUpButton.Margin = new Padding(3, 2, 3, 2);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(336, 65);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.DarkSlateBlue;
            passwordLabel.Location = new Point(500, 296);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 40;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.DarkSlateBlue;
            usernameLabel.Location = new Point(499, 222);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 39;
            usernameLabel.Text = "Username";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(500, 319);
            password.Name = "password";
            password.Size = new Size(314, 29);
            password.TabIndex = 38;
            password.UseSystemPasswordChar = true;
            // 
            // user_img
            // 
            user_img.BackgroundImageLayout = ImageLayout.Stretch;
            user_img.Image = (Image)resources.GetObject("user_img.Image");
            user_img.Location = new Point(462, 245);
            user_img.Margin = new Padding(3, 2, 3, 2);
            user_img.Name = "user_img";
            user_img.Size = new Size(32, 29);
            user_img.SizeMode = PictureBoxSizeMode.Zoom;
            user_img.TabIndex = 4;
            user_img.TabStop = false;
            // 
            // username
            // 
            username.AccessibleName = "product_Id";
            username.BackColor = SystemColors.Window;
            username.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(499, 245);
            username.Name = "username";
            username.Size = new Size(314, 29);
            username.TabIndex = 37;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(462, 315);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // customizedPanel1
            // 
            customizedPanel1.BackColor = Color.White;
            customizedPanel1.BorderRadius = 30;
            customizedPanel1.Controls.Add(logInPanel);
            customizedPanel1.Dock = DockStyle.Left;
            customizedPanel1.ForeColor = Color.Black;
            customizedPanel1.GradientAngle = 90F;
            customizedPanel1.GradientBottomColor = Color.MediumPurple;
            customizedPanel1.GradientTopColor = Color.Violet;
            customizedPanel1.Location = new Point(0, 0);
            customizedPanel1.Name = "customizedPanel1";
            customizedPanel1.Size = new Size(420, 659);
            customizedPanel1.TabIndex = 4;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(837, 659);
            Controls.Add(signUpLabel);
            Controls.Add(accountLabel);
            Controls.Add(label1);
            Controls.Add(customizedPanel2);
            Controls.Add(customizedPanel1);
            Controls.Add(passwordLabel);
            Controls.Add(pictureBox3);
            Controls.Add(usernameLabel);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(user_img);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateUser";
            Load += CreateUser_Load;
            logInPanel.ResumeLayout(false);
            logInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_img).EndInit();
            customizedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)user_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            customizedPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel logInPanel;
        private Label forgotPassword;
        private CustomizedPanel customizedPanel2;
        private Button LOGIN;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox password;
        private PictureBox user_img;
        private TextBox username;
        private PictureBox pictureBox3;
        private Label clear;
        private PictureBox logo_img;
        private CheckBox showPassword;
        private Label label1;
        private CustomizedPanel customizedPanel1;
        private Label accountLabel;
        private Label signUpLabel;
        private Label label2;
        private PictureBox pictureBox1;
        private Button SignUpButton;
    }
}