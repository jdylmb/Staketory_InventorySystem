namespace InventorySytem_GUI
{
    partial class ProductPage
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
            productQuantity = new TextBox();
            productName = new TextBox();
            product_Id = new TextBox();
            description = new TextBox();
            price = new TextBox();
            panel1 = new Panel();
            mng_productLabel = new Label();
            label1 = new Label();
            categories = new ComboBox();
            editBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            listView1 = new ListView();
            panel2 = new Panel();
            catgryLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productQuantity
            // 
            productQuantity.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            productQuantity.Location = new Point(50, 287);
            productQuantity.Name = "productQuantity";
            productQuantity.PlaceholderText = "Product Quantity";
            productQuantity.Size = new Size(386, 46);
            productQuantity.TabIndex = 18;
            // 
            // productName
            // 
            productName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            productName.Location = new Point(50, 219);
            productName.Name = "productName";
            productName.PlaceholderText = "Product Name";
            productName.Size = new Size(386, 46);
            productName.TabIndex = 17;
            // 
            // product_Id
            // 
            product_Id.AccessibleName = "product_Id";
            product_Id.BackColor = Color.GhostWhite;
            product_Id.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            product_Id.Location = new Point(50, 139);
            product_Id.Name = "product_Id";
            product_Id.PlaceholderText = "Product ID";
            product_Id.Size = new Size(386, 46);
            product_Id.TabIndex = 16;
            // 
            // description
            // 
            description.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            description.Location = new Point(50, 464);
            description.Name = "description";
            description.PlaceholderText = "Description";
            description.Size = new Size(386, 46);
            description.TabIndex = 20;
            // 
            // price
            // 
            price.AccessibleName = "Username";
            price.BackColor = Color.GhostWhite;
            price.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            price.Location = new Point(50, 369);
            price.Name = "price";
            price.PlaceholderText = "Price";
            price.Size = new Size(386, 46);
            price.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(mng_productLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 94);
            panel1.TabIndex = 22;
            // 
            // mng_productLabel
            // 
            mng_productLabel.AutoSize = true;
            mng_productLabel.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mng_productLabel.ForeColor = SystemColors.ButtonHighlight;
            mng_productLabel.Location = new Point(545, 55);
            mng_productLabel.Name = "mng_productLabel";
            mng_productLabel.Size = new Size(197, 29);
            mng_productLabel.TabIndex = 2;
            mng_productLabel.Text = "Manage Product";
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
            // categories
            // 
            categories.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            categories.ForeColor = SystemColors.WindowFrame;
            categories.FormattingEnabled = true;
            categories.Location = new Point(50, 547);
            categories.Name = "categories";
            categories.Size = new Size(386, 48);
            categories.TabIndex = 23;
            categories.Text = "Category";
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Indigo;
            editBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.ForeColor = Color.GhostWhite;
            editBtn.Location = new Point(178, 629);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(126, 50);
            editBtn.TabIndex = 26;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Indigo;
            deleteBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.GhostWhite;
            deleteBtn.Location = new Point(310, 629);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(126, 50);
            deleteBtn.TabIndex = 25;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Indigo;
            addBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.GhostWhite;
            addBtn.Location = new Point(46, 629);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(126, 50);
            addBtn.TabIndex = 24;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.GhostWhite;
            listView1.BorderStyle = BorderStyle.None;
            listView1.GridLines = true;
            listView1.Location = new Point(533, 114);
            listView1.Name = "listView1";
            listView1.Size = new Size(698, 657);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 789);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 21);
            panel2.TabIndex = 28;
            // 
            // catgryLabel
            // 
            catgryLabel.AutoSize = true;
            catgryLabel.ForeColor = Color.Indigo;
            catgryLabel.Location = new Point(62, 513);
            catgryLabel.Name = "catgryLabel";
            catgryLabel.Size = new Size(55, 15);
            catgryLabel.TabIndex = 29;
            catgryLabel.Text = "Category";
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            Controls.Add(catgryLabel);
            Controls.Add(panel2);
            Controls.Add(listView1);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(categories);
            Controls.Add(panel1);
            Controls.Add(description);
            Controls.Add(price);
            Controls.Add(productQuantity);
            Controls.Add(productName);
            Controls.Add(product_Id);
            Name = "ProductPage";
            Size = new Size(1279, 810);
            Load += ProductPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox productQuantity;
        private TextBox productName;
        private TextBox product_Id;
        private TextBox description;
        private TextBox price;
        private Panel panel1;
        private Label mng_productLabel;
        private Label label1;
        private ComboBox categories;
        private Button editBtn;
        private Button deleteBtn;
        private Button addBtn;
        private ListView listView1;
        private Panel panel2;
        private Label catgryLabel;
    }
}
