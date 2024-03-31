using System;
using System.Windows.Forms;

namespace ParkNClick
{
    public partial class Login : Form
    {
        Dashboard dashboard;

        public Login()
        {
            InitializeComponent();
            dashboard = new Dashboard();
        }

        private void login()
        {
            if (string.IsNullOrEmpty(UsernameBox.Text) && string.IsNullOrEmpty(PasswordBox.Text) || UsernameBox.Text != "admin" && PasswordBox.Text != "admin")
            {
                ErrorLabel.Text = "Missing/Invalid Username and Password";
                ResetLabelAfterDelay(ErrorLabel);
            }
            else if (UsernameBox.Text != "admin")
            {
                UserErrorLabel.Text = "Invalid Username";
                ResetLabelAfterDelay(UserErrorLabel);
            }
            else if (PasswordBox.Text != "admin")
            {
                PassErrorLabel.Text = "Invalid Password";
                ResetLabelAfterDelay(PassErrorLabel);
            }
            else
            {
                dashboard.Show();
                this.Hide();
            }
        }
        private void ResetLabelAfterDelay(Label label)
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
    }
}
