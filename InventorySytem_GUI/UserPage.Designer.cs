namespace InventorySytem_GUI
{
    partial class UserPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            deleteBtn = new Button();
            addBtn = new Button();
            MngProductPanel = new CustomizedPanel();
            mngUser_Label = new Label();
            TitleLabel = new Label();
            customizedPanel1 = new CustomizedPanel();
            dataGridView_ProductPage = new DataGridView();
            dataGridViewTextBoxUserName = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxFullName = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            userLowerDockPanel = new CustomizedPanel();
            passwordLabel = new Label();
            fullNameLabel = new Label();
            userNameLabel = new Label();
            productQuantity = new TextBox();
            productName = new TextBox();
            product_Id = new TextBox();
            MngProductPanel.SuspendLayout();
            customizedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ProductPage).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Indigo;
            deleteBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.GhostWhite;
            deleteBtn.Location = new Point(178, 414);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(126, 50);
            deleteBtn.TabIndex = 17;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Indigo;
            addBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.GhostWhite;
            addBtn.Location = new Point(46, 414);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(126, 50);
            addBtn.TabIndex = 16;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // MngProductPanel
            // 
            MngProductPanel.BackColor = Color.Transparent;
            MngProductPanel.BorderRadius = 30;
            MngProductPanel.Controls.Add(mngUser_Label);
            MngProductPanel.Controls.Add(TitleLabel);
            MngProductPanel.Dock = DockStyle.Top;
            MngProductPanel.ForeColor = Color.Black;
            MngProductPanel.GradientAngle = 90F;
            MngProductPanel.GradientBottomColor = Color.MediumPurple;
            MngProductPanel.GradientTopColor = Color.Violet;
            MngProductPanel.Location = new Point(0, 0);
            MngProductPanel.Name = "MngProductPanel";
            MngProductPanel.Size = new Size(1279, 110);
            MngProductPanel.TabIndex = 33;
            MngProductPanel.Paint += MngProductPanel_Paint;
            // 
            // mngUser_Label
            // 
            mngUser_Label.AutoSize = true;
            mngUser_Label.BackColor = Color.Transparent;
            mngUser_Label.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mngUser_Label.ForeColor = Color.Indigo;
            mngUser_Label.Location = new Point(541, 69);
            mngUser_Label.Name = "mngUser_Label";
            mngUser_Label.Size = new Size(162, 29);
            mngUser_Label.TabIndex = 2;
            mngUser_Label.Text = "Manage User";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Indigo;
            TitleLabel.Location = new Point(375, 24);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(520, 36);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Staketory Management System";
            // 
            // customizedPanel1
            // 
            customizedPanel1.BackColor = Color.White;
            customizedPanel1.BorderRadius = 30;
            customizedPanel1.Controls.Add(dataGridView_ProductPage);
            customizedPanel1.ForeColor = Color.Black;
            customizedPanel1.GradientAngle = 90F;
            customizedPanel1.GradientBottomColor = Color.MediumPurple;
            customizedPanel1.GradientTopColor = Color.Violet;
            customizedPanel1.Location = new Point(530, 168);
            customizedPanel1.Name = "customizedPanel1";
            customizedPanel1.Size = new Size(646, 531);
            customizedPanel1.TabIndex = 36;
            // 
            // dataGridView_ProductPage
            // 
            dataGridView_ProductPage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ProductPage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_ProductPage.BackgroundColor = SystemColors.Control;
            dataGridView_ProductPage.BorderStyle = BorderStyle.None;
            dataGridView_ProductPage.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Indigo;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_ProductPage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_ProductPage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ProductPage.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxUserName, dataGridViewTextBoxFullName, password });
            dataGridView_ProductPage.Dock = DockStyle.Fill;
            dataGridView_ProductPage.EnableHeadersVisualStyles = false;
            dataGridView_ProductPage.GridColor = Color.MediumPurple;
            dataGridView_ProductPage.Location = new Point(0, 0);
            dataGridView_ProductPage.Name = "dataGridView_ProductPage";
            dataGridView_ProductPage.RowTemplate.Height = 25;
            dataGridView_ProductPage.Size = new Size(646, 531);
            dataGridView_ProductPage.TabIndex = 36;
            dataGridView_ProductPage.CellContentClick += dataGridView_ProductPage_CellContentClick;
            // 
            // dataGridViewTextBoxUserName
            // 
            dataGridViewTextBoxUserName.DividerWidth = 1;
            dataGridViewTextBoxUserName.HeaderText = "Username";
            dataGridViewTextBoxUserName.Name = "dataGridViewTextBoxUserName";
            // 
            // dataGridViewTextBoxFullName
            // 
            dataGridViewTextBoxFullName.HeaderText = "Full Name";
            dataGridViewTextBoxFullName.Name = "dataGridViewTextBoxFullName";
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.Name = "password";
            // 
            // userLowerDockPanel
            // 
            userLowerDockPanel.BackColor = Color.White;
            userLowerDockPanel.BorderRadius = 30;
            userLowerDockPanel.ForeColor = Color.Black;
            userLowerDockPanel.GradientAngle = 90F;
            userLowerDockPanel.GradientBottomColor = Color.Violet;
            userLowerDockPanel.GradientTopColor = Color.MediumPurple;
            userLowerDockPanel.Location = new Point(0, 747);
            userLowerDockPanel.Name = "userLowerDockPanel";
            userLowerDockPanel.Size = new Size(1279, 63);
            userLowerDockPanel.TabIndex = 34;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(46, 308);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 43;
            passwordLabel.Text = "Password";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            fullNameLabel.Location = new Point(46, 224);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(79, 20);
            fullNameLabel.TabIndex = 42;
            fullNameLabel.Text = "Full Name";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLabel.Location = new Point(42, 143);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(78, 20);
            userNameLabel.TabIndex = 41;
            userNameLabel.Text = "Username";
            // 
            // productQuantity
            // 
            productQuantity.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            productQuantity.Location = new Point(46, 322);
            productQuantity.Name = "productQuantity";
            productQuantity.Size = new Size(386, 46);
            productQuantity.TabIndex = 40;
            // 
            // productName
            // 
            productName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            productName.Location = new Point(46, 247);
            productName.Name = "productName";
            productName.Size = new Size(386, 46);
            productName.TabIndex = 39;
            // 
            // product_Id
            // 
            product_Id.AccessibleName = "product_Id";
            product_Id.BackColor = SystemColors.Window;
            product_Id.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            product_Id.Location = new Point(46, 157);
            product_Id.Name = "product_Id";
            product_Id.Size = new Size(386, 46);
            product_Id.TabIndex = 38;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(passwordLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(userNameLabel);
            Controls.Add(productQuantity);
            Controls.Add(productName);
            Controls.Add(product_Id);
            Controls.Add(customizedPanel1);
            Controls.Add(userLowerDockPanel);
            Controls.Add(MngProductPanel);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Name = "UserPage";
            Size = new Size(1279, 810);
            Load += UserPage_Load;
            MngProductPanel.ResumeLayout(false);
            MngProductPanel.PerformLayout();
            customizedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_ProductPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button deleteBtn;
        private Button addBtn;
        private CustomizedPanel MngProductPanel;
        private Label mngUser_Label;
        private Label TitleLabel;
        private CustomizedPanel customizedPanel1;
        private DataGridView dataGridView_ProductPage;
        private CustomizedPanel userLowerDockPanel;
        private Label passwordLabel;
        private Label fullNameLabel;
        private Label userNameLabel;
        private TextBox productQuantity;
        private TextBox productName;
        private TextBox product_Id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxUserName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxFullName;
        private DataGridViewTextBoxColumn password;
    }
}
