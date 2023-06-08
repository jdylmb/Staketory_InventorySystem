namespace InventorySytem_GUI
{
    partial class CategoriesPage
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
            panel1 = new Panel();
            mng_categoryLabel = new Label();
            label1 = new Label();
            categoryName = new TextBox();
            categories_Id = new TextBox();
            editBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            panel2 = new Panel();
            listView1 = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(mng_categoryLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 94);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // mng_categoryLabel
            // 
            mng_categoryLabel.AutoSize = true;
            mng_categoryLabel.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mng_categoryLabel.ForeColor = SystemColors.ButtonHighlight;
            mng_categoryLabel.Location = new Point(545, 55);
            mng_categoryLabel.Name = "mng_categoryLabel";
            mng_categoryLabel.Size = new Size(212, 29);
            mng_categoryLabel.TabIndex = 2;
            mng_categoryLabel.Text = "Manage Category";
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
            // categoryName
            // 
            categoryName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            categoryName.Location = new Point(57, 285);
            categoryName.Name = "categoryName";
            categoryName.PlaceholderText = "Category Name";
            categoryName.Size = new Size(386, 46);
            categoryName.TabIndex = 25;
            // 
            // categories_Id
            // 
            categories_Id.AccessibleName = "categories_Id";
            categories_Id.BackColor = Color.GhostWhite;
            categories_Id.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            categories_Id.Location = new Point(57, 215);
            categories_Id.Name = "categories_Id";
            categories_Id.PlaceholderText = "Category ID";
            categories_Id.Size = new Size(386, 46);
            categories_Id.TabIndex = 24;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Indigo;
            editBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.ForeColor = Color.GhostWhite;
            editBtn.Location = new Point(189, 382);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(126, 50);
            editBtn.TabIndex = 29;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Indigo;
            deleteBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.GhostWhite;
            deleteBtn.Location = new Point(317, 382);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(126, 50);
            deleteBtn.TabIndex = 28;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Indigo;
            addBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.GhostWhite;
            addBtn.Location = new Point(57, 382);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(126, 50);
            addBtn.TabIndex = 27;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 789);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 21);
            panel2.TabIndex = 30;
            // 
            // listView1
            // 
            listView1.BackColor = Color.GhostWhite;
            listView1.BorderStyle = BorderStyle.None;
            listView1.GridLines = true;
            listView1.Location = new Point(525, 113);
            listView1.Name = "listView1";
            listView1.Size = new Size(698, 657);
            listView1.TabIndex = 31;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CategoriesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            Controls.Add(listView1);
            Controls.Add(panel2);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(categoryName);
            Controls.Add(categories_Id);
            Controls.Add(panel1);
            Name = "CategoriesPage";
            Size = new Size(1279, 810);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label mng_categoryLabel;
        private Label label1;
        private TextBox categoryName;
        private TextBox categories_Id;
        private Button editBtn;
        private Button deleteBtn;
        private Button addBtn;
        private Panel panel2;
        private ListView listView1;
    }
}
