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
            panel1 = new Panel();
            categoriesButton = new Button();
            productButton = new Button();
            userButton = new Button();
            userPage1 = new UserPage();
            productPage1 = new ProductPage();
            categoriesPage1 = new CategoriesPage();
            panel2 = new Panel();
            userLabel.SuspendLayout();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.BackColor = Color.Indigo;
            userLabel.Controls.Add(panel1);
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
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 789);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 21);
            panel1.TabIndex = 21;
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
            userPage1.BackColor = Color.White;
            userPage1.Location = new Point(210, 0);
            userPage1.Name = "userPage1";
            userPage1.Size = new Size(1279, 810);
            userPage1.TabIndex = 1;
            userPage1.Load += userPage1_Load;
            // 
            // productPage1
            // 
            productPage1.BackColor = Color.MediumPurple;
            productPage1.Location = new Point(210, 0);
            productPage1.Name = "productPage1";
            productPage1.Size = new Size(1279, 810);
            productPage1.TabIndex = 2;
            productPage1.Load += productPage1_Load;
            // 
            // categoriesPage1
            // 
            categoriesPage1.BackColor = Color.MediumPurple;
            categoriesPage1.Location = new Point(210, 0);
            categoriesPage1.Name = "categoriesPage1";
            categoriesPage1.Size = new Size(1279, 810);
            categoriesPage1.TabIndex = 3;
            categoriesPage1.Load += categoriesPage1_Load;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(214, 789);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1275, 21);
            panel2.TabIndex = 21;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 810);
            Controls.Add(categoriesPage1);
            Controls.Add(panel2);
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
        private Panel panel2;
        private Panel panel1;
    }
}