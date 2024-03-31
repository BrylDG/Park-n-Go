namespace ParkNClick
{
    partial class Dashboard
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
            SidePanel = new FlowLayoutPanel();
            RatePanel = new FlowLayoutPanel();
            ParkinPanel = new FlowLayoutPanel();
            DisplayPanel = new FlowLayoutPanel();
            DatabasePanel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(27, 37, 65);
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(150, 440);
            SidePanel.TabIndex = 0;
            // 
            // RatePanel
            // 
            RatePanel.BackColor = Color.FromArgb(38, 52, 88);
            RatePanel.Location = new Point(166, 12);
            RatePanel.Name = "RatePanel";
            RatePanel.Size = new Size(192, 111);
            RatePanel.TabIndex = 1;
            // 
            // ParkinPanel
            // 
            ParkinPanel.BackColor = Color.FromArgb(38, 52, 88);
            ParkinPanel.Location = new Point(166, 129);
            ParkinPanel.Name = "ParkinPanel";
            ParkinPanel.Size = new Size(164, 299);
            ParkinPanel.TabIndex = 2;
            ParkinPanel.Paint += ParkinPanel_Paint;
            // 
            // DisplayPanel
            // 
            DisplayPanel.BackColor = Color.FromArgb(32, 44, 76);
            DisplayPanel.Location = new Point(571, 12);
            DisplayPanel.Name = "DisplayPanel";
            DisplayPanel.Size = new Size(197, 416);
            DisplayPanel.TabIndex = 3;
            // 
            // DatabasePanel
            // 
            DatabasePanel.BackColor = Color.FromArgb(38, 52, 88);
            DatabasePanel.Location = new Point(336, 129);
            DatabasePanel.Name = "DatabasePanel";
            DatabasePanel.Size = new Size(220, 299);
            DatabasePanel.TabIndex = 3;
            DatabasePanel.Paint += DatabasePanel_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(44, 59, 100);
            flowLayoutPanel1.Location = new Point(355, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(106, 111);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(51, 68, 113);
            flowLayoutPanel2.Location = new Point(450, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(106, 111);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 41, 71);
            ClientSize = new Size(780, 440);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(DatabasePanel);
            Controls.Add(DisplayPanel);
            Controls.Add(RatePanel);
            Controls.Add(SidePanel);
            Controls.Add(ParkinPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel SidePanel;
        private FlowLayoutPanel RatePanel;
        private FlowLayoutPanel ParkinPanel;
        private FlowLayoutPanel DisplayPanel;
        private FlowLayoutPanel DatabasePanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}