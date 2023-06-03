using StakeTory_InventorySystem;
namespace InventorySytem_GUI
{
    public partial class LogInForm : Form
    {
        private string usernameText;
        private string passwordText;

        public LogInForm
            ()
        {
            InitializeComponent();
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
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }


        private void label3_Click_1(object sender, EventArgs e)
        {
            username.Text = "";
            Password.Text = "";
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
            UserManagement userInventory = new UserManagement("users.json");

            userInventory.Login(username.Text, this.passwordText);

            MessageBox.Show($"Log In Successfully!");
        }
    }
}