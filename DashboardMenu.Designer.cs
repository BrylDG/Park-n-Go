namespace ParkNClick
{
    partial class DashboardMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMenu));
            MenuPanel = new Panel();
            LogoutButton = new Button();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TypePanel = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label5 = new Label();
            label16 = new Label();
            FlagdownPanel = new Panel();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label6 = new Label();
            label17 = new Label();
            RatePanel = new Panel();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label7 = new Label();
            label18 = new Label();
            ParkInPanel = new Panel();
            view = new Button();
            label9 = new Label();
            ErrorMessageLabel = new Label();
            button1 = new Button();
            label4 = new Label();
            TypeCB = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            PlateNoBox = new TextBox();
            BrandCB = new ComboBox();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            DatabasePanel = new Panel();
            dataView = new DataGridView();
            label10 = new Label();
            DetailPanel = new Panel();
            VTimeIn = new Label();
            VPlateNo = new Label();
            VBrand = new Label();
            VType = new Label();
            ViewTimeIn = new Label();
            ViewPlateNo = new Label();
            ViewBrand = new Label();
            ViewType = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            panel4 = new Panel();
            MenuPanel.SuspendLayout();
            TypePanel.SuspendLayout();
            FlagdownPanel.SuspendLayout();
            RatePanel.SuspendLayout();
            ParkInPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            DatabasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            DetailPanel.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.DimGray;
            MenuPanel.Controls.Add(panel4);
            MenuPanel.Controls.Add(LogoutButton);
            MenuPanel.Controls.Add(label8);
            MenuPanel.Controls.Add(flowLayoutPanel1);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(144, 431);
            MenuPanel.TabIndex = 0;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.IndianRed;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.Snow;
            LogoutButton.Location = new Point(36, 384);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(72, 27);
            LogoutButton.TabIndex = 10;
            LogoutButton.Text = "Sign Out";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(31, 131);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 0;
            label8.Text = "Administrator";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.GhostWhite;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Location = new Point(36, 56);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(69, 67);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // TypePanel
            // 
            TypePanel.BackColor = Color.SlateGray;
            TypePanel.Controls.Add(label15);
            TypePanel.Controls.Add(label14);
            TypePanel.Controls.Add(label13);
            TypePanel.Controls.Add(label12);
            TypePanel.Controls.Add(label5);
            TypePanel.Controls.Add(label16);
            TypePanel.Location = new Point(150, 12);
            TypePanel.Name = "TypePanel";
            TypePanel.Size = new Size(185, 111);
            TypePanel.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(70, 88);
            label15.Name = "label15";
            label15.Size = new Size(43, 15);
            label15.TabIndex = 11;
            label15.Text = "Sedan";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(77, 71);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 10;
            label14.Text = "Van";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(77, 55);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 9;
            label13.Text = "SUV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(63, 37);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 8;
            label12.Text = "Motorbike";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(46, 11);
            label5.Name = "label5";
            label5.Size = new Size(88, 16);
            label5.TabIndex = 7;
            label5.Text = "Vehicle Type";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.WhiteSmoke;
            label16.Location = new Point(9, 21);
            label16.Name = "label16";
            label16.Size = new Size(168, 15);
            label16.TabIndex = 12;
            label16.Text = "_______________________";
            label16.Click += label16_Click;
            // 
            // FlagdownPanel
            // 
            FlagdownPanel.BackColor = Color.LightSlateGray;
            FlagdownPanel.Controls.Add(label22);
            FlagdownPanel.Controls.Add(label21);
            FlagdownPanel.Controls.Add(label20);
            FlagdownPanel.Controls.Add(label19);
            FlagdownPanel.Controls.Add(label6);
            FlagdownPanel.Controls.Add(label17);
            FlagdownPanel.Location = new Point(341, 12);
            FlagdownPanel.Name = "FlagdownPanel";
            FlagdownPanel.Size = new Size(238, 111);
            FlagdownPanel.TabIndex = 2;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.WhiteSmoke;
            label22.Location = new Point(100, 86);
            label22.Name = "label22";
            label22.Size = new Size(38, 15);
            label22.TabIndex = 17;
            label22.Text = "30.00";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.WhiteSmoke;
            label21.Location = new Point(100, 71);
            label21.Name = "label21";
            label21.Size = new Size(38, 15);
            label21.TabIndex = 16;
            label21.Text = "40.00";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.WhiteSmoke;
            label20.Location = new Point(100, 55);
            label20.Name = "label20";
            label20.Size = new Size(38, 15);
            label20.TabIndex = 15;
            label20.Text = "40.00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.WhiteSmoke;
            label19.Location = new Point(100, 39);
            label19.Name = "label19";
            label19.Size = new Size(38, 15);
            label19.TabIndex = 14;
            label19.Text = "20.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(87, 11);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 8;
            label6.Text = "Flagdown";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.WhiteSmoke;
            label17.Location = new Point(32, 21);
            label17.Name = "label17";
            label17.Size = new Size(182, 15);
            label17.TabIndex = 13;
            label17.Text = "_________________________";
            // 
            // RatePanel
            // 
            RatePanel.BackColor = Color.LightSlateGray;
            RatePanel.Controls.Add(label26);
            RatePanel.Controls.Add(label25);
            RatePanel.Controls.Add(label24);
            RatePanel.Controls.Add(label23);
            RatePanel.Controls.Add(label7);
            RatePanel.Controls.Add(label18);
            RatePanel.Location = new Point(585, 12);
            RatePanel.Name = "RatePanel";
            RatePanel.Size = new Size(183, 111);
            RatePanel.TabIndex = 3;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.WhiteSmoke;
            label26.Location = new Point(66, 88);
            label26.Name = "label26";
            label26.Size = new Size(38, 15);
            label26.TabIndex = 18;
            label26.Text = "15.00";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.WhiteSmoke;
            label25.Location = new Point(67, 71);
            label25.Name = "label25";
            label25.Size = new Size(38, 15);
            label25.TabIndex = 17;
            label25.Text = "20.00";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.WhiteSmoke;
            label24.Location = new Point(67, 54);
            label24.Name = "label24";
            label24.Size = new Size(38, 15);
            label24.TabIndex = 16;
            label24.Text = "20.00";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.WhiteSmoke;
            label23.Location = new Point(73, 38);
            label23.Name = "label23";
            label23.Size = new Size(31, 15);
            label23.TabIndex = 15;
            label23.Text = "5.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(69, 11);
            label7.Name = "label7";
            label7.Size = new Size(36, 16);
            label7.TabIndex = 9;
            label7.Text = "Rate";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.WhiteSmoke;
            label18.Location = new Point(13, 21);
            label18.Name = "label18";
            label18.Size = new Size(161, 15);
            label18.TabIndex = 14;
            label18.Text = "______________________";
            // 
            // ParkInPanel
            // 
            ParkInPanel.BackColor = Color.DimGray;
            ParkInPanel.Controls.Add(view);
            ParkInPanel.Controls.Add(ErrorMessageLabel);
            ParkInPanel.Controls.Add(button1);
            ParkInPanel.Controls.Add(label4);
            ParkInPanel.Controls.Add(TypeCB);
            ParkInPanel.Controls.Add(panel1);
            ParkInPanel.Controls.Add(PlateNoBox);
            ParkInPanel.Controls.Add(BrandCB);
            ParkInPanel.Controls.Add(panel2);
            ParkInPanel.Controls.Add(panel3);
            ParkInPanel.Location = new Point(150, 129);
            ParkInPanel.Margin = new Padding(1);
            ParkInPanel.Name = "ParkInPanel";
            ParkInPanel.Size = new Size(185, 300);
            ParkInPanel.TabIndex = 3;
            // 
            // view
            // 
            view.BackColor = Color.Honeydew;
            view.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view.Location = new Point(54, 242);
            view.Name = "view";
            view.Size = new Size(85, 21);
            view.TabIndex = 12;
            view.Text = "Show Data";
            view.UseVisualStyleBackColor = false;
            view.Click += view_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Visitor TT1 BRK", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(12, 11);
            label9.Name = "label9";
            label9.Size = new Size(124, 24);
            label9.TabIndex = 11;
            label9.Text = "00:00:00";
            label9.Click += label9_Click;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.AutoSize = true;
            ErrorMessageLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorMessageLabel.ForeColor = Color.Red;
            ErrorMessageLabel.Location = new Point(41, 266);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(0, 13);
            ErrorMessageLabel.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(54, 215);
            button1.Name = "button1";
            button1.Size = new Size(85, 21);
            button1.TabIndex = 9;
            button1.Text = "Park In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(54, 11);
            label4.Name = "label4";
            label4.Size = new Size(80, 24);
            label4.TabIndex = 6;
            label4.Text = "Park In";
            // 
            // TypeCB
            // 
            TypeCB.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeCB.ForeColor = Color.Black;
            TypeCB.FormattingEnabled = true;
            TypeCB.Items.AddRange(new object[] { "Motorbike", "SUV", "Sedan", "Van" });
            TypeCB.Location = new Point(50, 63);
            TypeCB.Margin = new Padding(2);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new Size(128, 21);
            TypeCB.TabIndex = 0;
            TypeCB.SelectedIndexChanged += TypeCB_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(5, 63);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 21);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 3);
            label1.Name = "label1";
            label1.Size = new Size(33, 14);
            label1.TabIndex = 4;
            label1.Text = "Type";
            label1.Click += label1_Click_1;
            // 
            // PlateNoBox
            // 
            PlateNoBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlateNoBox.Location = new Point(50, 168);
            PlateNoBox.Margin = new Padding(2);
            PlateNoBox.Name = "PlateNoBox";
            PlateNoBox.Size = new Size(128, 22);
            PlateNoBox.TabIndex = 2;
            // 
            // BrandCB
            // 
            BrandCB.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrandCB.FormattingEnabled = true;
            BrandCB.Location = new Point(50, 117);
            BrandCB.Margin = new Padding(2);
            BrandCB.Name = "BrandCB";
            BrandCB.Size = new Size(128, 21);
            BrandCB.TabIndex = 1;
            BrandCB.SelectedIndexChanged += BrandCB_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 117);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(79, 21);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(39, 14);
            label2.TabIndex = 5;
            label2.Text = "Brand";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PeachPuff;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(5, 168);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(79, 22);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PeachPuff;
            label3.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(43, 14);
            label3.TabIndex = 6;
            label3.Text = "Plate #";
            // 
            // DatabasePanel
            // 
            DatabasePanel.BackColor = Color.DarkSlateGray;
            DatabasePanel.Controls.Add(textBox1);
            DatabasePanel.Controls.Add(dataView);
            DatabasePanel.Controls.Add(label10);
            DatabasePanel.Location = new Point(341, 129);
            DatabasePanel.Name = "DatabasePanel";
            DatabasePanel.Size = new Size(238, 300);
            DatabasePanel.TabIndex = 3;
            // 
            // dataView
            // 
            dataView.BackgroundColor = Color.DimGray;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(-8, -1);
            dataView.Margin = new Padding(3, 2, 3, 2);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(251, 303);
            dataView.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(75, 155);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 8;
            label10.Text = "database ari";
            // 
            // DetailPanel
            // 
            DetailPanel.BackColor = Color.DimGray;
            DetailPanel.Controls.Add(VTimeIn);
            DetailPanel.Controls.Add(VPlateNo);
            DetailPanel.Controls.Add(VBrand);
            DetailPanel.Controls.Add(VType);
            DetailPanel.Controls.Add(ViewTimeIn);
            DetailPanel.Controls.Add(ViewPlateNo);
            DetailPanel.Controls.Add(ViewBrand);
            DetailPanel.Controls.Add(ViewType);
            DetailPanel.Location = new Point(585, 129);
            DetailPanel.Name = "DetailPanel";
            DetailPanel.Size = new Size(183, 299);
            DetailPanel.TabIndex = 3;
            DetailPanel.Paint += DetailPanel_Paint;
            // 
            // VTimeIn
            // 
            VTimeIn.AutoSize = true;
            VTimeIn.ForeColor = Color.Gainsboro;
            VTimeIn.Location = new Point(121, 180);
            VTimeIn.Name = "VTimeIn";
            VTimeIn.Size = new Size(0, 15);
            VTimeIn.TabIndex = 16;
            // 
            // VPlateNo
            // 
            VPlateNo.AutoSize = true;
            VPlateNo.ForeColor = Color.Gainsboro;
            VPlateNo.Location = new Point(121, 135);
            VPlateNo.Name = "VPlateNo";
            VPlateNo.Size = new Size(0, 15);
            VPlateNo.TabIndex = 15;
            // 
            // VBrand
            // 
            VBrand.AutoSize = true;
            VBrand.ForeColor = Color.Gainsboro;
            VBrand.Location = new Point(121, 88);
            VBrand.Name = "VBrand";
            VBrand.Size = new Size(0, 15);
            VBrand.TabIndex = 14;
            VBrand.Click += VBrand_Click;
            // 
            // VType
            // 
            VType.AutoSize = true;
            VType.ForeColor = Color.Gainsboro;
            VType.Location = new Point(121, 37);
            VType.Name = "VType";
            VType.Size = new Size(0, 15);
            VType.TabIndex = 13;
            // 
            // ViewTimeIn
            // 
            ViewTimeIn.AutoSize = true;
            ViewTimeIn.ForeColor = Color.Gainsboro;
            ViewTimeIn.Location = new Point(19, 180);
            ViewTimeIn.Name = "ViewTimeIn";
            ViewTimeIn.Size = new Size(51, 15);
            ViewTimeIn.TabIndex = 12;
            ViewTimeIn.Text = "TIME IN:";
            ViewTimeIn.Click += ViewTimeIn_Click;
            // 
            // ViewPlateNo
            // 
            ViewPlateNo.AutoSize = true;
            ViewPlateNo.ForeColor = Color.Gainsboro;
            ViewPlateNo.Location = new Point(19, 135);
            ViewPlateNo.Name = "ViewPlateNo";
            ViewPlateNo.Size = new Size(63, 15);
            ViewPlateNo.TabIndex = 11;
            ViewPlateNo.Text = "PLATE NO:";
            // 
            // ViewBrand
            // 
            ViewBrand.AutoSize = true;
            ViewBrand.ForeColor = Color.Gainsboro;
            ViewBrand.Location = new Point(19, 88);
            ViewBrand.Name = "ViewBrand";
            ViewBrand.Size = new Size(49, 15);
            ViewBrand.TabIndex = 10;
            ViewBrand.Text = "BRAND:";
            // 
            // ViewType
            // 
            ViewType.AutoSize = true;
            ViewType.ForeColor = Color.Gainsboro;
            ViewType.Location = new Point(19, 37);
            ViewType.Name = "ViewType";
            ViewType.Size = new Size(36, 15);
            ViewType.TabIndex = 9;
            ViewType.Text = "TYPE:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(15, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(142, 20);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label9);
            panel4.Location = new Point(0, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 46);
            panel4.TabIndex = 11;
            // 
            // DashboardMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(780, 440);
            Controls.Add(DatabasePanel);
            Controls.Add(FlagdownPanel);
            Controls.Add(DetailPanel);
            Controls.Add(ParkInPanel);
            Controls.Add(RatePanel);
            Controls.Add(TypePanel);
            Controls.Add(MenuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardMenu";
            Load += DashboardMenu_Load_1;
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            TypePanel.ResumeLayout(false);
            TypePanel.PerformLayout();
            FlagdownPanel.ResumeLayout(false);
            FlagdownPanel.PerformLayout();
            RatePanel.ResumeLayout(false);
            RatePanel.PerformLayout();
            ParkInPanel.ResumeLayout(false);
            ParkInPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            DatabasePanel.ResumeLayout(false);
            DatabasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            DetailPanel.ResumeLayout(false);
            DetailPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel TypePanel;
        private Panel FlagdownPanel;
        private Panel RatePanel;
        private Panel ParkInPanel;
        private Panel DatabasePanel;
        private Panel DetailPanel;
        private ComboBox TypeCB;
        private ComboBox BrandCB;
        private TextBox PlateNoBox;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Button button1;
        private Label label10;
        private Label ViewType;
        private Label ErrorMessageLabel;
        private Button LogoutButton;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label17;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Button view;
        private DataGridView dataView;
        private Label ViewBrand;
        private Label ViewTimeIn;
        private Label ViewPlateNo;
        private Label VTimeIn;
        private Label VPlateNo;
        private Label VBrand;
        private Label VType;
        private TextBox textBox1;
        private Panel panel4;
    }
}