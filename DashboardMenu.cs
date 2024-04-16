using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ParkNClick
{
    public partial class DashboardMenu : Form
    {
        VehicleData VD;
        Login loginForm;
        DbConnection database;
        public DashboardMenu(Login loginForm)
        {

            InitializeComponent();
            this.loginForm = loginForm;
            database = new DbConnection("(localdb)\\MSSQLLocalDB", "Clifford", "", "");
            SetRoundedEdges(DetailPanel);
            SetRoundedEdges(DatabasePanel);
            SetRoundedEdges(ParkInPanel);
            SetRoundedEdges(FlagdownPanel);
            SetRoundedEdges(TypePanel);
            SetRoundedEdges(RatePanel);
        }

        private void SetRoundedEdges(Panel panel)
        {
            int borderRadius = 10;

            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = panel.ClientRectangle;
            bounds.Width--;
            bounds.Height--;

            path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
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
                DateTime timeIn = DateTime.Now;
                VD = new VehicleData(TypeCB.Text, BrandCB.Text, PlateNoBox.Text, timeIn.ToString()); //ako g sulod sa usa ka class ang mga details, pwede nimo buahton is: objectSaImoDB  = VD.Variable
                TypeCB.Text = "";
                BrandCB.Text = "";
                PlateNoBox.Text = "";

                //AYAW LNG SANI HILABTI NAA RAKOI G ADD BAGO NA CODE NA SAME UG FUNCTION ANI

                /*brand = comboBox1.Text;
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

        private void DetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("hh:mm tt");
        }
        private void DashboardMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            // Call the LoadData method of FileName class to load data into DataGridView
            database.LoadData(dataView, "Vehicle");
        }
        private void view_Click(object sender, EventArgs e)
        {
            //ako rani gi butang para makita nako if naka sulod ba ang values sa Vehicle na class, ayaw lng nya ni tangtanga kai gamiton koni sa pag display
            VType.Text = VD.type;
            VBrand.Text = VD.brand;
            VPlateNo.Text = VD.plateNo;
            VTimeIn.Text = VD.timeIn;
            LoadData();
        }

        private void DashboardMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ViewTimeIn_Click(object sender, EventArgs e)
        {

        }

        private void VBrand_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
