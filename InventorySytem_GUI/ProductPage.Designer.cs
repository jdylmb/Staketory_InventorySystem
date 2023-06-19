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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            productQuantity = new TextBox();
            productName = new TextBox();
            product_Id = new TextBox();
            description = new TextBox();
            price = new TextBox();
            categories = new ComboBox();
            editBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            dataGridView_ProductPage = new DataGridView();
            prod_Id = new DataGridViewTextBoxColumn();
            Prod_name = new DataGridViewTextBoxColumn();
            qnty = new DataGridViewTextBoxColumn();
            prod_price = new DataGridViewTextBoxColumn();
            prod_description = new DataGridViewTextBoxColumn();
            prod_cat = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            customizedPanel1 = new CustomizedPanel();
            prodIdLabel = new Label();
            productNameLabel = new Label();
            productQuantityLabel = new Label();
            priceLabel = new Label();
            descriptionLabel = new Label();
            categoryLabel = new Label();
            customizedPanel2 = new CustomizedPanel();
            searchPic = new PictureBox();
            searchBar = new TextBox();
            TitleLabel = new Label();
            mng_productLabel = new Label();
            MngProductPanel = new CustomizedPanel();
            closeProductButton = new Button();
            productLowerDockPanel = new CustomizedPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ProductPage).BeginInit();
            customizedPanel1.SuspendLayout();
            customizedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).BeginInit();
            MngProductPanel.SuspendLayout();
            SuspendLayout();
            // 
            // productQuantity
            // 
            productQuantity.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            productQuantity.Location = new Point(46, 331);
            productQuantity.Name = "productQuantity";
            productQuantity.Size = new Size(386, 39);
            productQuantity.TabIndex = 18;
            // 
            // productName
            // 
            productName.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            productName.Location = new Point(45, 243);
            productName.Name = "productName";
            productName.Size = new Size(386, 39);
            productName.TabIndex = 17;
            productName.TextChanged += productName_TextChanged;
            // 
            // product_Id
            // 
            product_Id.AccessibleName = "product_Id";
            product_Id.BackColor = SystemColors.Window;
            product_Id.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product_Id.Location = new Point(46, 151);
            product_Id.Name = "product_Id";
            product_Id.Size = new Size(386, 39);
            product_Id.TabIndex = 16;
            product_Id.TextChanged += product_Id_TextChanged;
            // 
            // description
            // 
            description.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            description.Location = new Point(46, 503);
            description.Name = "description";
            description.Size = new Size(386, 39);
            description.TabIndex = 20;
            // 
            // price
            // 
            price.AccessibleName = "";
            price.BackColor = SystemColors.Window;
            price.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(46, 415);
            price.Name = "price";
            price.Size = new Size(386, 39);
            price.TabIndex = 19;
            // 
            // categories
            // 
            categories.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point);
            categories.ForeColor = SystemColors.ActiveCaptionText;
            categories.FormattingEnabled = true;
            categories.Location = new Point(45, 587);
            categories.Name = "categories";
            categories.Size = new Size(386, 40);
            categories.TabIndex = 23;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.DodgerBlue;
            editBtn.BackgroundImageLayout = ImageLayout.None;
            editBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.ForeColor = Color.GhostWhite;
            editBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editBtn.Location = new Point(177, 654);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(126, 50);
            editBtn.TabIndex = 26;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Crimson;
            deleteBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.GhostWhite;
            deleteBtn.Location = new Point(309, 654);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(126, 50);
            deleteBtn.TabIndex = 25;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.SeaGreen;
            addBtn.BackgroundImageLayout = ImageLayout.None;
            addBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.GhostWhite;
            addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBtn.Location = new Point(45, 654);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(126, 50);
            addBtn.TabIndex = 24;
            addBtn.Text = "Add";
            addBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dataGridView_ProductPage
            // 
            dataGridView_ProductPage.AllowUserToAddRows = false;
            dataGridView_ProductPage.AllowUserToDeleteRows = false;
            dataGridView_ProductPage.AllowUserToResizeColumns = false;
            dataGridView_ProductPage.AllowUserToResizeRows = false;
            dataGridView_ProductPage.BackgroundColor = Color.White;
            dataGridView_ProductPage.BorderStyle = BorderStyle.None;
            dataGridView_ProductPage.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_ProductPage.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Lavender;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Indigo;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Indigo;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_ProductPage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_ProductPage.ColumnHeadersHeight = 54;
            dataGridView_ProductPage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_ProductPage.Columns.AddRange(new DataGridViewColumn[] { prod_Id, Prod_name, qnty, prod_price, prod_description, prod_cat, date });
            dataGridView_ProductPage.EnableHeadersVisualStyles = false;
            dataGridView_ProductPage.GridColor = Color.White;
            dataGridView_ProductPage.Location = new Point(0, 0);
            dataGridView_ProductPage.MultiSelect = false;
            dataGridView_ProductPage.Name = "dataGridView_ProductPage";
            dataGridView_ProductPage.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_ProductPage.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_ProductPage.RowHeadersVisible = false;
            dataGridView_ProductPage.RowHeadersWidth = 40;
            dataGridView_ProductPage.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Lavender;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Indigo;
            dataGridViewCellStyle3.SelectionBackColor = Color.Indigo;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_ProductPage.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_ProductPage.RowTemplate.DividerHeight = 3;
            dataGridView_ProductPage.RowTemplate.Height = 40;
            dataGridView_ProductPage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ProductPage.Size = new Size(746, 540);
            dataGridView_ProductPage.TabIndex = 40;
            dataGridView_ProductPage.CellClick += dataGridView_ProductPage_CellContentClick;
            dataGridView_ProductPage.CellContentClick += dataGridView_ProductPage_CellContentClick;
            // 
            // prod_Id
            // 
            prod_Id.DividerWidth = 1;
            prod_Id.FillWeight = 60F;
            prod_Id.HeaderText = "Product ID";
            prod_Id.Name = "prod_Id";
            prod_Id.Width = 70;
            // 
            // Prod_name
            // 
            Prod_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prod_name.FillWeight = 80F;
            Prod_name.HeaderText = "Product Name";
            Prod_name.MinimumWidth = 110;
            Prod_name.Name = "Prod_name";
            // 
            // qnty
            // 
            qnty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            qnty.FillWeight = 50F;
            qnty.HeaderText = "Quantity";
            qnty.Name = "qnty";
            // 
            // prod_price
            // 
            prod_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prod_price.FillWeight = 50F;
            prod_price.HeaderText = "Price";
            prod_price.Name = "prod_price";
            // 
            // prod_description
            // 
            prod_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prod_description.FillWeight = 70F;
            prod_description.HeaderText = "Description";
            prod_description.Name = "prod_description";
            // 
            // prod_cat
            // 
            prod_cat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prod_cat.FillWeight = 60F;
            prod_cat.HeaderText = "Category";
            prod_cat.Name = "prod_cat";
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.FillWeight = 40F;
            date.HeaderText = "Date";
            date.Name = "date";
            // 
            // customizedPanel1
            // 
            customizedPanel1.BackColor = Color.White;
            customizedPanel1.BorderRadius = 30;
            customizedPanel1.Controls.Add(dataGridView_ProductPage);
            customizedPanel1.ForeColor = Color.Black;
            customizedPanel1.GradientAngle = 90F;
            customizedPanel1.GradientBottomColor = Color.CadetBlue;
            customizedPanel1.GradientTopColor = Color.DodgerBlue;
            customizedPanel1.Location = new Point(480, 176);
            customizedPanel1.Name = "customizedPanel1";
            customizedPanel1.Size = new Size(746, 540);
            customizedPanel1.TabIndex = 31;
            // 
            // prodIdLabel
            // 
            prodIdLabel.AutoSize = true;
            prodIdLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            prodIdLabel.Location = new Point(46, 128);
            prodIdLabel.Name = "prodIdLabel";
            prodIdLabel.Size = new Size(82, 20);
            prodIdLabel.TabIndex = 35;
            prodIdLabel.Text = "Product ID";
            prodIdLabel.Click += prodIdLabel_Click;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            productNameLabel.Location = new Point(45, 220);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(108, 20);
            productNameLabel.TabIndex = 36;
            productNameLabel.Text = "Product Name";
            productNameLabel.Click += productNameLabel_Click;
            // 
            // productQuantityLabel
            // 
            productQuantityLabel.AutoSize = true;
            productQuantityLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            productQuantityLabel.Location = new Point(45, 308);
            productQuantityLabel.Name = "productQuantityLabel";
            productQuantityLabel.Size = new Size(126, 20);
            productQuantityLabel.TabIndex = 37;
            productQuantityLabel.Text = "Product Quantity";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            priceLabel.Location = new Point(46, 392);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(43, 20);
            priceLabel.TabIndex = 38;
            priceLabel.Text = "Price";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(46, 480);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(87, 20);
            descriptionLabel.TabIndex = 39;
            descriptionLabel.Text = "Description";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLabel.Location = new Point(45, 564);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(72, 20);
            categoryLabel.TabIndex = 40;
            categoryLabel.Text = "Category";
            // 
            // customizedPanel2
            // 
            customizedPanel2.BackColor = Color.Transparent;
            customizedPanel2.BorderRadius = 30;
            customizedPanel2.Controls.Add(searchPic);
            customizedPanel2.Controls.Add(searchBar);
            customizedPanel2.ForeColor = Color.Black;
            customizedPanel2.GradientAngle = 90F;
            customizedPanel2.GradientBottomColor = Color.MediumPurple;
            customizedPanel2.GradientTopColor = Color.Violet;
            customizedPanel2.Location = new Point(910, 131);
            customizedPanel2.Name = "customizedPanel2";
            customizedPanel2.Size = new Size(307, 35);
            customizedPanel2.TabIndex = 41;
            // 
            // searchPic
            // 
            searchPic.BackgroundImage = (Image)resources.GetObject("searchPic.BackgroundImage");
            searchPic.BackgroundImageLayout = ImageLayout.Center;
            searchPic.Location = new Point(270, 0);
            searchPic.Name = "searchPic";
            searchPic.Size = new Size(37, 35);
            searchPic.SizeMode = PictureBoxSizeMode.StretchImage;
            searchPic.TabIndex = 43;
            searchPic.TabStop = false;
            // 
            // searchBar
            // 
            searchBar.AccessibleName = "searchBar";
            searchBar.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBar.Location = new Point(16, 3);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search";
            searchBar.Size = new Size(251, 29);
            searchBar.TabIndex = 42;
            searchBar.TextChanged += username_TextChanged;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Indigo;
            TitleLabel.Location = new Point(381, 22);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(520, 36);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Staketory Management System";
            // 
            // mng_productLabel
            // 
            mng_productLabel.AutoSize = true;
            mng_productLabel.BackColor = Color.Transparent;
            mng_productLabel.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mng_productLabel.ForeColor = Color.White;
            mng_productLabel.Location = new Point(609, 84);
            mng_productLabel.Name = "mng_productLabel";
            mng_productLabel.Size = new Size(99, 29);
            mng_productLabel.TabIndex = 2;
            mng_productLabel.Text = "Product";
            // 
            // MngProductPanel
            // 
            MngProductPanel.BackColor = Color.Transparent;
            MngProductPanel.BackgroundImageLayout = ImageLayout.Zoom;
            MngProductPanel.BorderRadius = 30;
            MngProductPanel.Controls.Add(closeProductButton);
            MngProductPanel.Controls.Add(mng_productLabel);
            MngProductPanel.Controls.Add(TitleLabel);
            MngProductPanel.Dock = DockStyle.Top;
            MngProductPanel.ForeColor = Color.Black;
            MngProductPanel.GradientAngle = 90F;
            MngProductPanel.GradientBottomColor = Color.MediumPurple;
            MngProductPanel.GradientTopColor = Color.Violet;
            MngProductPanel.Location = new Point(0, 0);
            MngProductPanel.Name = "MngProductPanel";
            MngProductPanel.Size = new Size(1279, 125);
            MngProductPanel.TabIndex = 32;
            MngProductPanel.Paint += MngProductPanel_Paint;
            // 
            // closeProductButton
            // 
            closeProductButton.AccessibleName = "searchBtn";
            closeProductButton.BackColor = Color.Transparent;
            closeProductButton.BackgroundImage = (Image)resources.GetObject("closeProductButton.BackgroundImage");
            closeProductButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeProductButton.FlatAppearance.BorderSize = 0;
            closeProductButton.FlatStyle = FlatStyle.Flat;
            closeProductButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeProductButton.ForeColor = Color.Transparent;
            closeProductButton.ImageAlign = ContentAlignment.MiddleRight;
            closeProductButton.Location = new Point(1221, 2);
            closeProductButton.Margin = new Padding(3, 2, 3, 2);
            closeProductButton.Name = "closeProductButton";
            closeProductButton.Size = new Size(34, 32);
            closeProductButton.TabIndex = 43;
            closeProductButton.UseVisualStyleBackColor = false;
            closeProductButton.Click += closeProductButton_Click;
            // 
            // productLowerDockPanel
            // 
            productLowerDockPanel.BackColor = Color.White;
            productLowerDockPanel.BorderRadius = 30;
            productLowerDockPanel.ForeColor = Color.Black;
            productLowerDockPanel.GradientAngle = 90F;
            productLowerDockPanel.GradientBottomColor = Color.Violet;
            productLowerDockPanel.GradientTopColor = Color.MediumPurple;
            productLowerDockPanel.Location = new Point(0, 747);
            productLowerDockPanel.Name = "productLowerDockPanel";
            productLowerDockPanel.Size = new Size(1279, 63);
            productLowerDockPanel.TabIndex = 33;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customizedPanel2);
            Controls.Add(categoryLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(priceLabel);
            Controls.Add(productQuantityLabel);
            Controls.Add(productNameLabel);
            Controls.Add(prodIdLabel);
            Controls.Add(productLowerDockPanel);
            Controls.Add(MngProductPanel);
            Controls.Add(customizedPanel1);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(categories);
            Controls.Add(description);
            Controls.Add(price);
            Controls.Add(productQuantity);
            Controls.Add(productName);
            Controls.Add(product_Id);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ProductPage";
            Size = new Size(1279, 810);
            Load += ProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_ProductPage).EndInit();
            customizedPanel1.ResumeLayout(false);
            customizedPanel2.ResumeLayout(false);
            customizedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPic).EndInit();
            MngProductPanel.ResumeLayout(false);
            MngProductPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox productQuantity;
        private TextBox productName;
        private TextBox product_Id;
        private TextBox description;
        private TextBox price;
        private ComboBox categories;
        private Button editBtn;
        private Button deleteBtn;
        private Button addBtn;
        private DataGridView dataGridView_ProductPage;
        private CustomizedPanel customizedPanel1;
        private Label prodIdLabel;
        private Label productNameLabel;
        private Label productQuantityLabel;
        private Label priceLabel;
        private Label descriptionLabel;
        private Label categoryLabel;
        private CustomizedPanel customizedPanel2;
        private Label TitleLabel;
        private Label mng_productLabel;
        private CustomizedPanel MngProductPanel;
        private Button closeProductButton;
        private CustomizedPanel productLowerDockPanel;
        private TextBox searchBar;
        private PictureBox searchPic;
        private DataGridViewTextBoxColumn prod_Id;
        private DataGridViewTextBoxColumn Prod_name;
        private DataGridViewTextBoxColumn qnty;
        private DataGridViewTextBoxColumn prod_price;
        private DataGridViewTextBoxColumn prod_description;
        private DataGridViewTextBoxColumn prod_cat;
        private DataGridViewTextBoxColumn date;
    }
}
