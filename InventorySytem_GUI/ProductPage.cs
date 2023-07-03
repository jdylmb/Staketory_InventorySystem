using StakeTory_InventorySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventorySytem_GUI
{
    public partial class ProductPage :
        UserControl
    {
        private ProductManagement productManagement;
        private int selectedIndex = -1;
        public ProductPage()
        {
            InitializeComponent();

            this.productManagement = new ProductManagement("product.json");
            //FetchProducts();

            displayDatagrid();
        }
        private void ProductPage_Load(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            product_Id.Text = "";
            productName.Text = "";
            productQuantity.Text = "";
            price.Text = "";
            description.Text = "";
            categories.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            Product product = new Product
            {
                Code = product_Id.Text,
                Name = productName.Text,
                Quantity = int.Parse(productQuantity.Text),
                Price = float.Parse(price.Text),
                Description = description.Text,
                Category = categories.Text,
                dateUpdated = DateTime.Now.ToString("yyyy-MM-dd")
            };

            bool isSuccess = productManagement.AddItem(product);

            if (isSuccess)
            {
                MessageBox.Show($"Product successfully created!");

                displayDatagrid();
                clearFields();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            this.productManagement.DeleteItem(product_Id.Text);

            MessageBox.Show($"Product successfully deleted!");

            displayDatagrid();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Code = product_Id.Text,
                Name = productName.Text,
                Quantity = int.Parse(productQuantity.Text),
                Price = float.Parse(price.Text),
                Description = description.Text,
                Category = categories.Text,
                dateUpdated = DateTime.Now.ToString("yyyy-MM-dd")

            };

            if (selectedIndex == -1)
            {
                MessageBox.Show($"Select a product first!");
            }
            else
            {
                this.productManagement.UpdateProduct(product, selectedIndex);

                MessageBox.Show($"Product successfully updated!");

                displayDatagrid();
            }

        }

        private void dataGridView_ProductPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_ProductPage.Rows[e.RowIndex];

                // Access the values of the selected row using the Cells collection
                string selectedProductCode = selectedRow.Cells["prod_Id"].Value.ToString();
                string selectedProductName = selectedRow.Cells["Prod_name"].Value.ToString();
                int selectedProductQuantity = Convert.ToInt32(selectedRow.Cells["qnty"].Value);
                float selectedProductPrice = Convert.ToSingle(selectedRow.Cells["prod_price"].Value);
                string selectedProductDescription = selectedRow.Cells["prod_description"].Value.ToString();
                string selectedProductCategory = selectedRow.Cells["prod_cat"].Value.ToString();


                // Use the retrieved values as needed
                product_Id.Text = selectedProductCode;
                productName.Text = selectedProductName;
                productQuantity.Text = selectedProductQuantity.ToString();
                price.Text = selectedProductPrice.ToString();
                description.Text = selectedProductDescription;
                categories.Text = selectedProductCategory;

                this.selectedIndex = e.RowIndex;
            }
        }

        private void displayDatagrid()
        {
            dataGridView_ProductPage.Rows.Clear();

            List<Product> items = productManagement.inventory;
            foreach (Product product in items)
            {
                dataGridView_ProductPage.Rows.Add(new object[] { product.Code, product.Name, product.Quantity, product.Price, product.Description, product.Category, product.dateUpdated });
            }
        }

        private void filteredProducts(List<Product> products)
        {
            dataGridView_ProductPage.Rows.Clear();

            foreach (Product product in products)
            {
                dataGridView_ProductPage.Rows.Add(new object[] { product.Code, product.Name, product.Quantity, product.Price, product.Description, product.Category, product.dateUpdated });
            }
        }

        private void MngProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void product_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void productNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = productManagement.FilterItems(searchBar.Text);

            filteredProducts(products);
        }

        private void closeProductButton_Click(object sender, EventArgs e)
        {
            // verify the user wants to exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void categories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
