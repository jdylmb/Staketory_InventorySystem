namespace InventorySytem_GUI
{
    partial class ManageUsers
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
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            username = new TextBox();
            fullName = new TextBox();
            password = new TextBox();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            listView1 = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1505, 94);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(634, 64);
            label3.Name = "label3";
            label3.Size = new Size(162, 29);
            label3.TabIndex = 2;
            label3.Text = "Manage User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(461, 9);
            label1.Name = "label1";
            label1.Size = new Size(520, 36);
            label1.TabIndex = 0;
            label1.Text = "Staketory Management System";
            label1.Click += label1_Click;
            // 
            // username
            // 
            username.AccessibleName = "Username";
            username.BackColor = Color.GhostWhite;
            username.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(177, 222);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(233, 46);
            username.TabIndex = 5;
            username.TextChanged += textBox1_TextChanged;
            // 
            // fullName
            // 
            fullName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            fullName.Location = new Point(177, 302);
            fullName.Name = "fullName";
            fullName.PlaceholderText = "Full Name";
            fullName.Size = new Size(233, 46);
            fullName.TabIndex = 6;
            fullName.TextChanged += textBox2_TextChanged;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(177, 379);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(233, 46);
            password.TabIndex = 7;
            password.TextChanged += textBox3_TextChanged;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Indigo;
            addBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.GhostWhite;
            addBtn.Location = new Point(144, 487);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(126, 50);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Indigo;
            editBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.ForeColor = Color.GhostWhite;
            editBtn.Location = new Point(276, 487);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(126, 50);
            editBtn.TabIndex = 10;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Indigo;
            deleteBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.GhostWhite;
            deleteBtn.Location = new Point(426, 487);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(126, 50);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.MediumPurple;
            listView1.GridLines = true;
            listView1.Location = new Point(737, 108);
            listView1.Name = "listView1";
            listView1.Size = new Size(676, 550);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 849);
            Controls.Add(listView1);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(password);
            Controls.Add(fullName);
            Controls.Add(username);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private TextBox username;
        private TextBox password;
        private TextBox fullName;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private ListView listView1;
    }
}