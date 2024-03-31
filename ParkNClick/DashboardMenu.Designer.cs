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
            MenuPanel = new Panel();
            LogoutButton = new Button();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TypePanel = new Panel();
            label5 = new Label();
            FlagdownPanel = new Panel();
            label6 = new Label();
            RatePanel = new Panel();
            label7 = new Label();
            ParkInPanel = new Panel();
            ErrorMessageLabel = new Label();
            button1 = new Button();
            label9 = new Label();
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
            label10 = new Label();
            DetailPanel = new Panel();
            label11 = new Label();
            MenuPanel.SuspendLayout();
            TypePanel.SuspendLayout();
            FlagdownPanel.SuspendLayout();
            RatePanel.SuspendLayout();
            ParkInPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            DatabasePanel.SuspendLayout();
            DetailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(27, 37, 65);
            MenuPanel.Controls.Add(LogoutButton);
            MenuPanel.Controls.Add(label8);
            MenuPanel.Controls.Add(flowLayoutPanel1);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(130, 440);
            MenuPanel.TabIndex = 0;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(147, 154, 172);
            LogoutButton.Dock = DockStyle.Bottom;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Location = new Point(0, 405);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(130, 35);
            LogoutButton.TabIndex = 10;
            LogoutButton.Text = "Sign Out";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 129);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 0;
            label8.Text = "Administrator";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 192, 192);
            flowLayoutPanel1.Location = new Point(12, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(104, 100);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // TypePanel
            // 
            TypePanel.BackColor = Color.FromArgb(38, 52, 88);
            TypePanel.Controls.Add(label5);
            TypePanel.Location = new Point(136, 12);
            TypePanel.Name = "TypePanel";
            TypePanel.Size = new Size(205, 111);
            TypePanel.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 7;
            label5.Text = "Vehicle Type";
            // 
            // FlagdownPanel
            // 
            FlagdownPanel.BackColor = Color.FromArgb(44, 59, 100);
            FlagdownPanel.Controls.Add(label6);
            FlagdownPanel.Location = new Point(336, 12);
            FlagdownPanel.Name = "FlagdownPanel";
            FlagdownPanel.Size = new Size(118, 111);
            FlagdownPanel.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 8;
            label6.Text = "Flagdown";
            // 
            // RatePanel
            // 
            RatePanel.BackColor = Color.FromArgb(51, 68, 113);
            RatePanel.Controls.Add(label7);
            RatePanel.Location = new Point(450, 12);
            RatePanel.Name = "RatePanel";
            RatePanel.Size = new Size(106, 111);
            RatePanel.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 9;
            label7.Text = "Rate";
            // 
            // ParkInPanel
            // 
            ParkInPanel.BackColor = Color.FromArgb(38, 52, 88);
            ParkInPanel.Controls.Add(ErrorMessageLabel);
            ParkInPanel.Controls.Add(button1);
            ParkInPanel.Controls.Add(label9);
            ParkInPanel.Controls.Add(label4);
            ParkInPanel.Controls.Add(TypeCB);
            ParkInPanel.Controls.Add(panel1);
            ParkInPanel.Controls.Add(PlateNoBox);
            ParkInPanel.Controls.Add(BrandCB);
            ParkInPanel.Controls.Add(panel2);
            ParkInPanel.Controls.Add(panel3);
            ParkInPanel.Location = new Point(136, 129);
            ParkInPanel.Margin = new Padding(1);
            ParkInPanel.Name = "ParkInPanel";
            ParkInPanel.Size = new Size(194, 300);
            ParkInPanel.TabIndex = 3;
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
            button1.Location = new Point(54, 242);
            button1.Name = "button1";
            button1.Size = new Size(85, 21);
            button1.TabIndex = 9;
            button1.Text = "Park In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(41, 59);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 7;
            label9.Text = "katong clock ari";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 6;
            label4.Text = "Park In";
            // 
            // TypeCB
            // 
            TypeCB.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeCB.ForeColor = Color.Black;
            TypeCB.FormattingEnabled = true;
            TypeCB.Items.AddRange(new object[] { "Motorbike", "SUV", "Sedan", "Van" });
            TypeCB.Location = new Point(54, 111);
            TypeCB.Margin = new Padding(2);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new Size(128, 21);
            TypeCB.TabIndex = 0;
            TypeCB.SelectedIndexChanged += TypeCB_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(147, 154, 172);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 111);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(76, 21);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 3);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Type";
            label1.Click += label1_Click_1;
            // 
            // PlateNoBox
            // 
            PlateNoBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlateNoBox.Location = new Point(54, 200);
            PlateNoBox.Margin = new Padding(2);
            PlateNoBox.Name = "PlateNoBox";
            PlateNoBox.Size = new Size(128, 22);
            PlateNoBox.TabIndex = 2;
            // 
            // BrandCB
            // 
            BrandCB.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrandCB.FormattingEnabled = true;
            BrandCB.Location = new Point(54, 155);
            BrandCB.Margin = new Padding(2);
            BrandCB.Name = "BrandCB";
            BrandCB.Size = new Size(128, 21);
            BrandCB.TabIndex = 1;
            BrandCB.SelectedIndexChanged += BrandCB_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(147, 154, 172);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 155);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(76, 21);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Brand";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(147, 154, 172);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 200);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(76, 21);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 2);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Plate #";
            // 
            // DatabasePanel
            // 
            DatabasePanel.BackColor = Color.FromArgb(38, 52, 88);
            DatabasePanel.Controls.Add(label10);
            DatabasePanel.Location = new Point(336, 129);
            DatabasePanel.Name = "DatabasePanel";
            DatabasePanel.Size = new Size(220, 300);
            DatabasePanel.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(75, 155);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 8;
            label10.Text = "database ari";
            // 
            // DetailPanel
            // 
            DetailPanel.BackColor = Color.FromArgb(33, 44, 90);
            DetailPanel.Controls.Add(label11);
            DetailPanel.Location = new Point(562, 12);
            DetailPanel.Name = "DetailPanel";
            DetailPanel.Size = new Size(206, 416);
            DetailPanel.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(56, 228);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 9;
            label11.Text = "display details ari";
            // 
            // DashboardMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 71);
            ClientSize = new Size(780, 440);
            Controls.Add(FlagdownPanel);
            Controls.Add(DetailPanel);
            Controls.Add(DatabasePanel);
            Controls.Add(ParkInPanel);
            Controls.Add(RatePanel);
            Controls.Add(TypePanel);
            Controls.Add(MenuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardMenu";
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
            DetailPanel.ResumeLayout(false);
            DetailPanel.PerformLayout();
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
        private Label label9;
        private Label label10;
        private Label label11;
        private Button LogoutButton;
        private Label ErrorMessageLabel;
    }
}