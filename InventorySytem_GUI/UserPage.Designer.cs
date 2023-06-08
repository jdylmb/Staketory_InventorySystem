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
            listView1 = new ListView();
            deleteBtn = new Button();
            addBtn = new Button();
            password = new TextBox();
            fullName = new TextBox();
            username = new TextBox();
            panel1 = new Panel();
            mng_userLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.GhostWhite;
            listView1.BorderStyle = BorderStyle.None;
            listView1.GridLines = true;
            listView1.Location = new Point(529, 113);
            listView1.Name = "listView1";
            listView1.Size = new Size(698, 657);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Indigo;
            deleteBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.GhostWhite;
            deleteBtn.Location = new Point(210, 377);
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
            addBtn.Location = new Point(66, 377);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(126, 50);
            addBtn.TabIndex = 16;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(30, 298);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(389, 46);
            password.TabIndex = 15;
            password.UseSystemPasswordChar = true;
            // 
            // fullName
            // 
            fullName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            fullName.Location = new Point(30, 221);
            fullName.Name = "fullName";
            fullName.PlaceholderText = "Full Name";
            fullName.Size = new Size(389, 46);
            fullName.TabIndex = 14;
            // 
            // username
            // 
            username.AccessibleName = "Username";
            username.BackColor = Color.GhostWhite;
            username.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(30, 141);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(389, 46);
            username.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(mng_userLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 94);
            panel1.TabIndex = 12;
            // 
            // mng_userLabel
            // 
            mng_userLabel.AutoSize = true;
            mng_userLabel.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mng_userLabel.ForeColor = SystemColors.ButtonHighlight;
            mng_userLabel.Location = new Point(545, 55);
            mng_userLabel.Name = "mng_userLabel";
            mng_userLabel.Size = new Size(162, 29);
            mng_userLabel.TabIndex = 2;
            mng_userLabel.Text = "Manage User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(372, 0);
            label1.Name = "label1";
            label1.Size = new Size(520, 36);
            label1.TabIndex = 0;
            label1.Text = "Staketory Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 789);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 21);
            panel2.TabIndex = 20;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            Controls.Add(panel2);
            Controls.Add(listView1);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(password);
            Controls.Add(fullName);
            Controls.Add(username);
            Controls.Add(panel1);
            Name = "UserPage";
            Size = new Size(1279, 810);
            Load += UserPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button deleteBtn;
        private Button addBtn;
        private TextBox password;
        private TextBox fullName;
        private TextBox username;
        private Panel panel1;
        private Label mng_userLabel;
        private Label label1;
        private Panel panel2;
    }
}
