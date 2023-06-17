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
            button1 = new Button();
            label1 = new Label();
            reportPage1 = new ReportPage();

            sideBarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // productPage1
            // 
            productPage1.BackColor = Color.White;
            productPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productPage1.Location = new Point(214, 0);
            productPage1.Name = "productPage1";
            productPage1.Size = new Size(1279, 810);
            productPage1.TabIndex = 2;
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
            productButton.Text = "    Product";
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
            reportButton.Text = "    Report";
            reportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportButton.UseVisualStyleBackColor = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Transparent;
            sidebar.BorderRadius = 30;
            sidebar.BorderStyle = BorderStyle.FixedSingle;
            sidebar.Controls.Add(button1);
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
            // reportPage1
            // 
            reportPage1.BackColor = Color.White;
            reportPage1.Location = new Point(234, 0);
            reportPage1.Name = "reportPage1";
            reportPage1.Size = new Size(1279, 810);
            reportPage1.TabIndex = 3;

            // 
            // button1
            // 
            button1.AccessibleName = "productButton";
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-1, 626);
            button1.Name = "button1";
            button1.Size = new Size(228, 59);
            button1.TabIndex = 43;
            button1.Text = "    Product";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
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
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1489, 810);
            Controls.Add(sidebar);
            Controls.Add(productPage1);
            Controls.Add(reportPage1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            Load += Form2_Load;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ProductPage productPage1;
        private ReportPage categoriesPage1;
        private Button productButton;
        private Button reportButton;
        private CustomizedPanel sidebar;
        private Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private ReportPage reportPage1;
        private Button button1;
    }
}