﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace InventorySytem_GUI
{
    public partial class Menu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private Button logoutButton;
        bool sidebarExpand;
        public Menu()
        {
            InitializeComponent();
            InitializeScreens();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void InitializeScreens()
        {
            productPage1.Hide();
            reportPage4.Show();

        }


        private void reportButton_Click(object sender, EventArgs e)
        {
            reportPage4.Show();
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
            productPage1.Show();
            reportPage4.Hide();
        }

        private void reportPage1_Load(object sender, EventArgs e)
        {

        }

        private void categoriesPage2_Load(object sender, EventArgs e)
        {

        }

        private void userLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void customizedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            //set the maximum and minimum size of the sidebar panel
            if (sidebarExpand)
            {
                // if sidebar is expanded, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
                sidebar.Width += 10;
            if (sidebar.Width == sidebar.MaximumSize.Width)
            {
                sidebarExpand = true;
                sideBarTimer.Stop();
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void reportPage1_Load_1(object sender, EventArgs e)
        {

        }

        private void productPage1_Load_1(object sender, EventArgs e)
        {

        }

        public void InitializeLogoutButton()
        {
            logoutButton = new Button();
            logoutButton.Text = "Log Out";
            logoutButton.Click += logOutButton_Click;

            // Add the button to your form or container
            // For example, if you're using a Windows Forms application:
            this.Controls.Add(logoutButton);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            // verify the user wants to exit
            DialogResult result = MessageBox.Show("Are you sure you want to log out of the application?", "Log Out Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                WindowNavigator.ShowLoginForm();
            }

        }

        private void productPage1_Load_2(object sender, EventArgs e)
        {

        }

        private void reportButton_Click_3(object sender, EventArgs e)
        {
            productPage1.Hide();
            reportPage4.Show();
        }

        private void productPage1_Load_3(object sender, EventArgs e)
        {

        }

        private void logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void reportPage4_Load(object sender, EventArgs e)
        {

        }
    }
}
