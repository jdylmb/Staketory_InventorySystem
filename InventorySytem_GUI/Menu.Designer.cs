namespace InventorySytem_GUI
{
    partial class Form2
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
            userLabel = new Panel();
            categoriesButton = new Button();
            productButton = new Button();
            userButton = new Button();
            userPage1 = new UserPage();
            productPage1 = new ProductPage();
            categoriesPage1 = new CategoriesPage();
            userLabel.SuspendLayout();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.BackColor = Color.MediumPurple;
            userLabel.Controls.Add(categoriesButton);
            userLabel.Controls.Add(productButton);
            userLabel.Controls.Add(userButton);
            userLabel.Dock = DockStyle.Left;
            userLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.ForeColor = Color.GhostWhite;
            userLabel.Location = new Point(0, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(214, 810);
            userLabel.TabIndex = 0;
            // 
            // categoriesButton
            // 
            categoriesButton.AccessibleName = "categoriesButton";
            categoriesButton.BackColor = Color.Indigo;
            categoriesButton.FlatStyle = FlatStyle.Flat;
            categoriesButton.Font = new Font("Footlight MT Light", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesButton.Location = new Point(0, 246);
            categoriesButton.Name = "categoriesButton";
            categoriesButton.Size = new Size(223, 85);
            categoriesButton.TabIndex = 3;
            categoriesButton.Text = "CATEGORIES";
            categoriesButton.UseVisualStyleBackColor = false;
            categoriesButton.Click += button3_Click;
            // 
            // productButton
            // 
            productButton.AccessibleName = "productButton";
            productButton.BackColor = Color.Indigo;
            productButton.FlatStyle = FlatStyle.Flat;
            productButton.Font = new Font("Footlight MT Light", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            productButton.Location = new Point(0, 166);
            productButton.Name = "productButton";
            productButton.Size = new Size(211, 85);
            productButton.TabIndex = 2;
            productButton.Text = "PRODUCTS";
            productButton.UseVisualStyleBackColor = false;
            productButton.Click += productButton_Click;
            // 
            // userButton
            // 
            userButton.AccessibleName = "userButton";
            userButton.BackColor = Color.Indigo;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Footlight MT Light", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            userButton.Location = new Point(0, 94);
            userButton.Name = "userButton";
            userButton.Size = new Size(214, 85);
            userButton.TabIndex = 1;
            userButton.Text = "USER";
            userButton.UseVisualStyleBackColor = false;
            userButton.Click += userButton_Click;
            // 
            // userPage1
            // 
            userPage1.BackColor = SystemColors.ActiveBorder;
            userPage1.Location = new Point(320, 65);
            userPage1.Name = "userPage1";
            userPage1.Size = new Size(995, 640);
            userPage1.TabIndex = 1;
            userPage1.Load += userPage1_Load;
            // 
            // productPage1
            // 
            productPage1.BackColor = SystemColors.ActiveCaption;
            productPage1.Location = new Point(332, 65);
            productPage1.Name = "productPage1";
            productPage1.Size = new Size(938, 554);
            productPage1.TabIndex = 2;
            productPage1.Load += productPage1_Load;
            // 
            // categoriesPage1
            // 
            categoriesPage1.BackColor = SystemColors.GrayText;
            categoriesPage1.Location = new Point(278, 65);
            categoriesPage1.Name = "categoriesPage1";
            categoriesPage1.Size = new Size(1065, 597);
            categoriesPage1.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 810);
            Controls.Add(categoriesPage1);
            Controls.Add(productPage1);
            Controls.Add(userPage1);
            Controls.Add(userLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Menu";
            Load += Form2_Load;
            userLabel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel userLabel;
        private Button userButton;
        private Button categoriesButton;
        private Button productButton;
        private UserPage userPage1;
        private ProductPage productPage1;
        private CategoriesPage categoriesPage1;
    }
}