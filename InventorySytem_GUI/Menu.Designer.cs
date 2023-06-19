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
            productPage1 = new ProductPage();
            productButton = new Button();
            reportButton = new Button();
            sidebar = new CustomizedPanel();
            logo = new Panel();
            pictureBox1 = new PictureBox();
            logOutButton = new Button();
            label1 = new Label();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            reportPage4 = new ReportPage();
            sidebar.SuspendLayout();
            logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // productPage1
            // 
            productPage1.BackColor = Color.White;
            productPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productPage1.Location = new Point(233, 1);
            productPage1.Name = "productPage1";
            productPage1.Size = new Size(1378, 810);
            productPage1.TabIndex = 2;
            productPage1.Load += productPage1_Load_3;
            // 
            // productButton
            // 
            productButton.AccessibleName = "productButton";
            productButton.BackColor = Color.Transparent;
            productButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            productButton.FlatStyle = FlatStyle.Flat;
            productButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            productButton.Image = (Image)resources.GetObject("productButton.Image");
            productButton.Location = new Point(-1, 228);
            productButton.Name = "productButton";
            productButton.Size = new Size(228, 59);
            productButton.TabIndex = 2;
            productButton.Text = "     Product";
            productButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            productButton.UseVisualStyleBackColor = false;
            productButton.Click += productButton_Click;
            // 
            // reportButton
            // 
            reportButton.AccessibleName = "reportButton";
            reportButton.BackColor = Color.Transparent;
            reportButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            reportButton.FlatStyle = FlatStyle.Flat;
            reportButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            reportButton.Image = (Image)resources.GetObject("reportButton.Image");
            reportButton.Location = new Point(-1, 166);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(228, 68);
            reportButton.TabIndex = 3;
            reportButton.Text = "   Dashboard";
            reportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click_3;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Transparent;
            sidebar.BorderRadius = 30;
            sidebar.BorderStyle = BorderStyle.FixedSingle;
            sidebar.Controls.Add(logo);
            sidebar.Controls.Add(logOutButton);
            sidebar.Controls.Add(label1);
            sidebar.Controls.Add(productButton);
            sidebar.Controls.Add(reportButton);
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
            // logo
            // 
            logo.BackColor = Color.White;
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Controls.Add(pictureBox1);
            logo.Dock = DockStyle.Top;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(226, 171);
            logo.TabIndex = 44;
            logo.Paint += logo_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // logOutButton
            // 
            logOutButton.AccessibleName = "logOutButton";
            logOutButton.BackColor = Color.Transparent;
            logOutButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.Image = (Image)resources.GetObject("logOutButton.Image");
            logOutButton.Location = new Point(-1, 626);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(228, 59);
            logOutButton.TabIndex = 43;
            logOutButton.Text = "    Log Out";
            logOutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 42;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // reportPage4
            // 
            reportPage4.BackColor = Color.White;
            reportPage4.Location = new Point(234, 1);
            reportPage4.Name = "reportPage4";
            reportPage4.Size = new Size(1254, 810);
            reportPage4.TabIndex = 45;
            reportPage4.Load += reportPage4_Load;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1489, 810);
            Controls.Add(reportPage4);
            Controls.Add(sidebar);
            Controls.Add(productPage1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            Load += Form2_Load;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ProductPage productPage1;
        private Button productButton;
        private Button reportButton;
        private CustomizedPanel sidebar;
        private Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private Button logOutButton;
        private ReportPage reportPage3;
        private ReportPage reportPage1;
        private Panel logo;
        private PictureBox pictureBox1;
        private ReportPage reportPage2;
        private ReportPage reportPage4;
    }
}