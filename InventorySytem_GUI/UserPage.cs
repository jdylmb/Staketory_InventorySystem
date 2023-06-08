using StakeTory_InventorySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySytem_GUI
{
    public partial class UserPage : UserControl
    {
        private UserManagement userManagement;
        public UserPage()
        {
            InitializeComponent();

            this.userManagement = new UserManagement("product.json");
            FetchUsers();
        }

        public void FetchUsers()
        {
            listView1.Items.Clear();
            UserManagement userManagement = new UserManagement("user.json");
            List<User> users = userManagement.GetUsers();

            users.ForEach(u =>
            {
                ListViewItem item = new ListViewItem(u.username);
                ListViewItem item2 = new ListViewItem(u.password);
                ListViewItem item3 = new ListViewItem(u.fullName);

                listView1.Items.Add(item);
                listView1.Items.Add(item2);
                listView1.Items.Add(item3);
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Adding Users");

            UserManagement userManagement = new UserManagement("user.json");
            bool isSuccess = userManagement.CreateAccount(username.Text, password.Text, fullName.Text);

            if (isSuccess)
            {
                MessageBox.Show($"Account successfully created!");
                FetchUsers();
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void UserPage_Load(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* if (listView1.SelectedItems.Count > 0)
             {
                 ListViewItem selectedItem = listView1.SelectedItems[0];
                 string username = selectedItem.Text;
                 string fullName = selectedItem.SubItems[1].Text;
                 string password = selectedItem.SubItems[2].Text;

                 userName.Text = username;
                 fullname.Text = fullName;
                 password.Text = password;

             }*/
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            this.userManagement.DeleteItem(username.Text);

            MessageBox.Show($"User successfully deleted!");

            FetchProducts();
        }
    }
}
