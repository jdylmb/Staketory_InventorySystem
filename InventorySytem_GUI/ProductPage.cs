using StakeTory_InventorySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventorySytem_GUI
{
    public partial class ProductPage : UserControl
    {
        private ProductManagement productManagement;
        public ProductPage()
        {
            InitializeComponent();

            this.productManagement = new ProductManagement("product.json");
            FetchProducts();
        }

        private void FetchProducts()
        {
            listView1.Items.Clear();
            List<Product> products = this.productManagement.GetProducts();

            products.ForEach(p =>
            {
                ListViewItem item = new ListViewItem(p.Code);

                item.SubItems.Add(p.Name);
                item.SubItems.Add(p.Price.ToString());
                item.SubItems.Add(p.Quantity.ToString());
                item.SubItems.Add(p.Description);
                item.SubItems.Add(p.Category);
                listView1.Items.Add(item);
            });
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {

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
                Category = categories.Text

            };

            bool isSuccess = productManagement.AddItem(product);

            if (isSuccess)
            {
                MessageBox.Show($"Product successfully created!");

                FetchProducts();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string idText = selectedItem.Text;
                string nameText = selectedItem.SubItems[1].Text;
                string priceText = selectedItem.SubItems[2].Text;
                string quantityText = selectedItem.SubItems[3].Text;
                string descriptionText = selectedItem.SubItems[4].Text;
                string categoryText = selectedItem.SubItems[5].Text;

                product_Id.Text = idText;
                productName.Text = nameText;
                productQuantity.Text = quantityText;
                price.Text = priceText;
                description.Text = descriptionText;
                categories.Text = categoryText;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            this.productManagement.DeleteItem(product_Id.Text);

            MessageBox.Show($"Product successfully deleted!");

            FetchProducts();
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
                Category = categories.Text

            };

            this.productManagement.UpdateProduct(product);

            MessageBox.Show($"Product successfully updated!");

            FetchProducts();
        }
    }
}
