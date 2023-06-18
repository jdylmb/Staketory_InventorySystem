using StakeTory_InventorySystem;
using System.Runtime.InteropServices;

namespace InventorySytem_GUI
{
    public partial class LogInForm : Form
    {
        private string usernameText;
        private string passwordText;

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

        public LogInForm
            ()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }


        private void clear_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
                SystemColors.ControlLightLight, 10, ButtonBorderStyle.Solid,
                SystemColors.ControlLightLight, 10, ButtonBorderStyle.Solid,
                SystemColors.ControlLightLight, 10, ButtonBorderStyle.Solid,
                SystemColors.ControlLightLight, 10, ButtonBorderStyle.Solid);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserManagement userInventory = new UserManagement("user.json");

            bool isSuccess = userInventory.Login(username.Text, password.Text);

            if (isSuccess == true)
            {
                MessageBox.Show($"Log In Successfully!", "Log In");
                WindowNavigator.ShowMenu();
            }
            else
            {
                MessageBox.Show($"Log In Failed!", "Log In");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void closeLogInButton_Click(object sender, EventArgs e)
        {
            // verify the user wants to exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                closeLogInButton.Enabled = true;
            }
        }
    }
}