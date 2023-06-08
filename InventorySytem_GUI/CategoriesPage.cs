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

namespace InventorySytem_GUI
{
    public partial class CategoriesPage : UserControl
    {
        private CategoryManagement categoryManagement;

        public CategoriesPage()
        {
            InitializeComponent();
        }
        private void FetchProducts()
        {
            listView1.Items.Clear();
            List<Category> categories = this.categoryManagement.GetCategories();

            categories.ForEach(p =>
            {
                ListViewItem item = new ListViewItem(p.Code);

                item.SubItems.Add(p.);
                item.SubItems.Add(p.Price.ToString());
                item.SubItems.Add(p.Quantity.ToString());
                item.SubItems.Add(p.Description);
                item.SubItems.Add(p.Category);
                listView1.Items.Add(item);
            });
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
