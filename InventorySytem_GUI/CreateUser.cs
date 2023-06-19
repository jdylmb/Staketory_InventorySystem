using StakeTory_InventorySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySytem_GUI
{
    public partial class CreateUser : Form
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
        public CreateUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void logInPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement("user.json");

            bool isSuccess = userManagement.CreateAccount(username.Text, password.Text);

            if (isSuccess)
            {
                MessageBox.Show("Account Created Succesfully!", "Create Account");
            }
            else
            {
                MessageBox.Show("Account Creation Failed!", "Create Account Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }

        }

        private void logo_img_Click(object sender, EventArgs e)
        {

        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            WindowNavigator.ShowLoginForm();
        }
    }
}
