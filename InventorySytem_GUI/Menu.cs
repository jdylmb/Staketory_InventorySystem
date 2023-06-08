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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeScreens();
        }

        private void InitializeScreens()
        {
            userPage1.Show();
            productPage1.Hide();
            categoriesPage1.Hide();
        }


        private void userButton_Click(object sender, EventArgs e)
        {
            // Hide other user control
            categoriesPage1.Hide();
            userPage1.Show();
            productPage1.Hide();
            // Show the current user control which is the UserPage

        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoriesPage1.Show();
            userPage1.Hide();
            productPage1.Hide();
        }

        private void userPage1_Load(object sender, EventArgs e)
        {

        }

        private void productPage1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            categoriesPage1.Hide();
            userPage1.Hide();
            productPage1.Show();
        }

        private void categoriesPage1_Load(object sender, EventArgs e)
        {

        }

        private void categoriesPage2_Load(object sender, EventArgs e)
        {

        }
    }
}
