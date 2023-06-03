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
            clear = new Label();
            logo_img = new PictureBox();
            pictureBox3 = new PictureBox();
            username = new TextBox();
            showPassword = new CheckBox();
            user_img = new PictureBox();
            LOGIN = new Button();
            Password = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user_img).BeginInit();
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
            panel2.Controls.Add(clear);
            panel2.Controls.Add(logo_img);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(username);
            panel2.Controls.Add(showPassword);
            panel2.Controls.Add(user_img);
            panel2.Controls.Add(LOGIN);
            panel2.Controls.Add(Password);
            panel2.Location = new Point(176, 95);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 435);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // clear
            // 
            clear.AccessibleDescription = "clearAll";
            clear.AutoSize = true;
            clear.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            clear.ForeColor = Color.DarkSlateBlue;
            clear.Location = new Point(51, 359);
            clear.Name = "clear";
            clear.Size = new Size(49, 13);
            clear.TabIndex = 3;
            clear.Text = "Clear All";
            clear.Click += label3_Click_1;
            // 
            // logo_img
            // 
            logo_img.BackgroundImageLayout = ImageLayout.Stretch;
            logo_img.Image = (Image)resources.GetObject("logo_img.Image");
            logo_img.Location = new Point(33, 44);
            logo_img.Margin = new Padding(3, 2, 3, 2);
            logo_img.Name = "logo_img";
            logo_img.Size = new Size(274, 160);
            logo_img.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_img.TabIndex = 3;
            logo_img.TabStop = false;
            logo_img.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(53, 253);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // username
            // 
            username.BackColor = Color.GhostWhite;
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.DarkSlateBlue;
            username.Location = new Point(95, 226);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(118, 21);
            username.TabIndex = 7;
            username.TextChanged += username_TextChanged;
            // 
            // showPassword
            // 
            showPassword.AccessibleDescription = "showPassword";
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            showPassword.ForeColor = Color.DarkSlateBlue;
            showPassword.Location = new Point(142, 359);
            showPassword.Margin = new Padding(3, 2, 3, 2);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(107, 17);
            showPassword.TabIndex = 5;
            showPassword.Text = "Show Password\r\n";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // user_img
            // 
            user_img.BackgroundImageLayout = ImageLayout.Stretch;
            user_img.Image = (Image)resources.GetObject("user_img.Image");
            user_img.Location = new Point(53, 217);
            user_img.Margin = new Padding(3, 2, 3, 2);
            user_img.Name = "user_img";
            user_img.Size = new Size(36, 30);
            user_img.SizeMode = PictureBoxSizeMode.StretchImage;
            user_img.TabIndex = 4;
            user_img.TabStop = false;
            user_img.Click += pictureBox1_Click;
            // 
            // LOGIN
            // 
            LOGIN.AccessibleName = "loginBtn";
            LOGIN.BackColor = Color.SlateBlue;
            LOGIN.FlatStyle = FlatStyle.Popup;
            LOGIN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LOGIN.ForeColor = Color.GhostWhite;
            LOGIN.Location = new Point(93, 306);
            LOGIN.Margin = new Padding(3, 2, 3, 2);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(88, 34);
            LOGIN.TabIndex = 3;
            LOGIN.Text = "LOGIN";
            LOGIN.UseVisualStyleBackColor = false;
            LOGIN.Click += loginBtn_Click;
            // 
            // Password
            // 
            Password.BackColor = Color.GhostWhite;
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.DarkSlateBlue;
            Password.Location = new Point(93, 263);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(118, 21);
            Password.TabIndex = 2;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += textBox2_TextChanged;
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
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(671, 639);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)user_img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox Password;
        private Button LOGIN;
        private PictureBox user_img;
        private PictureBox logo_img;
        private CheckBox showPassword;
        private TextBox username;
        private PictureBox pictureBox3;
        private Label clear;
    }
}