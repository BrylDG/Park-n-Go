using System;
using System.Windows.Forms;

namespace ParkNClick
{
    public partial class Login : Form
    {
        DashboardMenu dashboard;

        public Login()
        {
            InitializeComponent();
            dashboard = new DashboardMenu(this);
        }

        private void login()
        {
            if (string.IsNullOrEmpty(UsernameBox.Text) && string.IsNullOrEmpty(PasswordBox.Text) || UsernameBox.Text != "admin" && PasswordBox.Text != "admin")
            {
                ErrorLabel.Text = "Missing / Invalid Username and Password";
                ResetLabel(ErrorLabel);
            }
            else if (UsernameBox.Text != "admin")
            {
                UserErrorLabel.Text = "Invalid Username";
                ResetLabel(UserErrorLabel);
            }
            else if (PasswordBox.Text != "admin")
            {
                PassErrorLabel.Text = "Invalid Password";
                ResetLabel(PassErrorLabel);
            }
            else
            {
                dashboard.Show();
                this.Hide();
            }
        }
        private void ResetLabel(Label label)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += (sender, e) =>
            {
                label.Text = "";
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            login();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
