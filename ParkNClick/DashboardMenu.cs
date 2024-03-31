using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkNClick
{
    public partial class DashboardMenu : Form
    {
        Login loginForm;
        public DashboardMenu(Login loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
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
        private void add()
        {
            if (TypeCB.Text == "Motorbike")
            {
                BrandCB.Text = "";
                BrandCB.Items.Clear();
                BrandCB.Items.Add("Kawasaki");
                BrandCB.Items.Add("Suzuki");
                BrandCB.Items.Add("Honda");
                BrandCB.Items.Add("Russi");
            }
            else if (TypeCB.Text == "SUV")
            {
                BrandCB.Text = "";
                BrandCB.Items.Clear();
                BrandCB.Items.Add("Kia");
                BrandCB.Items.Add("Toyota");
                BrandCB.Items.Add("Ford");
                BrandCB.Items.Add("Hyundai");
                BrandCB.Items.Add("Mitsubishi");
                BrandCB.Items.Add("Isuzu");
            }
            else if (TypeCB.Text == "Sedan")
            {
                BrandCB.Text = "";
                BrandCB.Items.Clear();
                BrandCB.Items.Add("Volkswagen");
                BrandCB.Items.Add("Toyota");
                BrandCB.Items.Add("Ford");
                BrandCB.Items.Add("Hyundai");
                BrandCB.Items.Add("Mitsubishi");
                BrandCB.Items.Add("Nissan");
            }
            else if (TypeCB.Text == "Van")
            {
                BrandCB.Text = "";
                BrandCB.Items.Clear();
                BrandCB.Items.Add("Toyota");
                BrandCB.Items.Add("Nissan");
                BrandCB.Items.Add("Hyundai");
                BrandCB.Items.Add("Ford");
                BrandCB.Items.Add("Kia");
            }
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            add();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrandCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TypeCB.Text == "" || BrandCB.Text == "" || PlateNoBox.Text == "") { ErrorMessageLabel.Text = "Missing Detail Inputs."; ResetLabel(ErrorMessageLabel); }
            else
            {
                TypeCB.Text = "";
                BrandCB.Text = "";
                PlateNoBox.Text = "";

                /* timeIn = DateTime.Now;
                 brand = comboBox1.Text;
                 PlateNumber = textBox1.Text;
                 VD.Details.Add(new VehicleData(number, type, timeIn.ToString(), PlateNumber, brand));
                 DetailPanel detailPanel = new DetailPanel(VD.Details, number);
                 number++;
                 detailPanel.Location = new System.Drawing.Point(nextPanelX, nextPanelY);
                 detailPanel.PanelRemoved += DetailPanel_PanelRemoved;
                 this.Controls.Add(detailPanel);
                 detailPanel.BringToFront();
                 sidePanelRight1.flowLayoutPanel1.Controls.Add(detailPanel);
                 panels.Add(detailPanel);
                 nextPanelY = panels.Count > 0 ? panels.Last().Bottom : nextPanelY;
                 detailPanel.VerticalScroll.Value = detailPanel.VerticalScroll.Maximum;
                 comboBox1.Text = "";
                 textBox1.Text = "";
                 FlagDownLabel.Text = "";
                 RateLabel.Text = "";
                 label4.Text = "";
                 ErrorMessageLabel.Text = "";
                */
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.UsernameBox.Text = "";
            loginForm.PasswordBox.Text = "";
            loginForm.Show();
        }
    }
}
