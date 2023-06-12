namespace InventorySytem_GUI
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            userPage1 = new UserPage();
            productPage1 = new ProductPage();
            categoriesPage1 = new ReportPage();
            userButton = new Button();
            productButton = new Button();
            categoriesButton = new Button();
            sidebar = new CustomizedPanel();
            label1 = new Label();
            menuButton = new PictureBox();
            reportPictureBox = new PictureBox();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            reportPage1 = new ReportPage();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportPictureBox).BeginInit();
            SuspendLayout();
            // 
            // userPage1
            // 
            userPage1.BackColor = Color.White;
            userPage1.Location = new Point(198, 0);
            userPage1.Name = "userPage1";
            userPage1.Size = new Size(1279, 810);
            userPage1.TabIndex = 1;
            userPage1.Load += userPage1_Load;
            // 
            // productPage1
            // 
            productPage1.BackColor = Color.White;
            productPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productPage1.Location = new Point(198, 4);
            productPage1.Name = "productPage1";
            productPage1.Size = new Size(1279, 810);
            productPage1.TabIndex = 2;
            productPage1.Load += productPage1_Load;
            // 
            // categoriesPage1
            // 
            categoriesPage1.BackColor = Color.White;
            categoriesPage1.Location = new Point(0, 0);
            categoriesPage1.Name = "categoriesPage1";
            categoriesPage1.Size = new Size(1279, 810);
            categoriesPage1.TabIndex = 0;
            // 
            // userButton
            // 
            userButton.AccessibleName = "userButton";
            userButton.BackColor = Color.Transparent;
            userButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Footlight MT Light", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            userButton.ImageAlign = ContentAlignment.TopCenter;
            userButton.Location = new Point(3, 147);
            userButton.Name = "userButton";
            userButton.Size = new Size(224, 58);
            userButton.TabIndex = 1;
            userButton.Text = "USER";
            userButton.TextAlign = ContentAlignment.MiddleLeft;
            userButton.UseVisualStyleBackColor = false;
            userButton.Click += userButton_Click;
            // 
            // productButton
            // 
            productButton.AccessibleName = "productButton";
            productButton.BackColor = Color.Transparent;
            productButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            productButton.FlatStyle = FlatStyle.Flat;
            productButton.Font = new Font("Footlight MT Light", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            productButton.ImageAlign = ContentAlignment.MiddleRight;
            productButton.Location = new Point(3, 199);
            productButton.Name = "productButton";
            productButton.Size = new Size(239, 51);
            productButton.TabIndex = 2;
            productButton.Text = "  PRODUCT";
            productButton.UseVisualStyleBackColor = false;
            productButton.Click += productButton_Click;
            // 
            // categoriesButton
            // 
            categoriesButton.AccessibleName = "categoriesButton";
            categoriesButton.BackColor = Color.Transparent;
            categoriesButton.FlatStyle = FlatStyle.Flat;
            categoriesButton.Font = new Font("Footlight MT Light", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesButton.Location = new Point(0, 251);
            categoriesButton.Name = "categoriesButton";
            categoriesButton.Size = new Size(227, 68);
            categoriesButton.TabIndex = 3;
            categoriesButton.Text = "Report";
            categoriesButton.UseVisualStyleBackColor = false;
            categoriesButton.Click += button3_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Transparent;
            sidebar.BorderRadius = 30;
            sidebar.BorderStyle = BorderStyle.FixedSingle;
            sidebar.Controls.Add(label1);
            sidebar.Controls.Add(menuButton);
            sidebar.Controls.Add(reportPictureBox);
            sidebar.Controls.Add(productButton);
            sidebar.Controls.Add(categoriesButton);
            sidebar.Controls.Add(userButton);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = Color.Black;
            sidebar.GradientAngle = 90F;
            sidebar.GradientBottomColor = Color.MediumPurple;
            sidebar.GradientTopColor = Color.Violet;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(228, 810);
            sidebar.MinimumSize = new Size(67, 810);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(228, 810);
            sidebar.TabIndex = 22;
            sidebar.Paint += customizedPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 77);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 42;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(23, 69);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(34, 33);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 6;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // reportPictureBox
            // 
            reportPictureBox.Image = Properties.Resources.record;
            reportPictureBox.Location = new Point(23, 266);
            reportPictureBox.Name = "reportPictureBox";
            reportPictureBox.Size = new Size(30, 34);
            reportPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            reportPictureBox.TabIndex = 5;
            reportPictureBox.TabStop = false;
            reportPictureBox.Click += pictureBox2_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // reportPage1
            // 
            reportPage1.BackColor = Color.White;
            reportPage1.Location = new Point(234, 0);
            reportPage1.Name = "reportPage1";
            reportPage1.Size = new Size(1279, 810);
            reportPage1.TabIndex = 23;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1489, 810);
            Controls.Add(reportPage1);
            Controls.Add(sidebar);
            Controls.Add(productPage1);
            Controls.Add(userPage1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            Load += Form2_Load;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private UserPage userPage1;
        private ProductPage productPage1;
        private ReportPage categoriesPage1;
        private Button userButton;
        private Button productButton;
        private Button categoriesButton;
        private CustomizedPanel sidebar;
        private PictureBox reportPictureBox;
        private PictureBox menuButton;
        private Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private ReportPage reportPage1;
    }
}