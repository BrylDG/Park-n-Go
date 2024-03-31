namespace ParkNClick
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameBox = new TextBox();
            LoginButton = new Button();
            UsernamePanel = new Panel();
            PasswordPanel = new Panel();
            PasswordBox = new TextBox();
            ExitButton = new Button();
            EnterButton = new Button();
            PassErrorLabel = new Label();
            UserErrorLabel = new Label();
            ErrorLabel = new Label();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            UsernamePanel.SuspendLayout();
            PasswordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = Color.FromArgb(51, 68, 113);
            UsernameBox.BorderStyle = BorderStyle.None;
            UsernameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.ForeColor = Color.White;
            UsernameBox.Location = new Point(3, 3);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(231, 22);
            UsernameBox.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Gainsboro;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(117, 347);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(56, 21);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button1_Click;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.FromArgb(51, 68, 113);
            UsernamePanel.BorderStyle = BorderStyle.FixedSingle;
            UsernamePanel.Controls.Add(UsernameBox);
            UsernamePanel.ForeColor = Color.NavajoWhite;
            UsernamePanel.Location = new Point(26, 206);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(239, 30);
            UsernamePanel.TabIndex = 0;
            // 
            // PasswordPanel
            // 
            PasswordPanel.BackColor = Color.FromArgb(51, 68, 113);
            PasswordPanel.BorderStyle = BorderStyle.FixedSingle;
            PasswordPanel.Controls.Add(PasswordBox);
            PasswordPanel.ForeColor = Color.NavajoWhite;
            PasswordPanel.Location = new Point(26, 281);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Size = new Size(239, 30);
            PasswordPanel.TabIndex = 1;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(51, 68, 113);
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.ForeColor = Color.White;
            PasswordBox.Location = new Point(3, 3);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '•';
            PasswordBox.Size = new Size(232, 22);
            PasswordBox.TabIndex = 1;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.Location = new Point(2, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(0, 0);
            ExitButton.TabIndex = 0;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Transparent;
            EnterButton.Location = new Point(1, 1);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(0, 0);
            EnterButton.TabIndex = 0;
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // PassErrorLabel
            // 
            PassErrorLabel.AutoSize = true;
            PassErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassErrorLabel.ForeColor = Color.Red;
            PassErrorLabel.Location = new Point(26, 314);
            PassErrorLabel.Name = "PassErrorLabel";
            PassErrorLabel.Size = new Size(0, 15);
            PassErrorLabel.TabIndex = 3;
            // 
            // UserErrorLabel
            // 
            UserErrorLabel.AutoSize = true;
            UserErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserErrorLabel.ForeColor = Color.Red;
            UserErrorLabel.Location = new Point(26, 239);
            UserErrorLabel.Name = "UserErrorLabel";
            UserErrorLabel.Size = new Size(0, 15);
            UserErrorLabel.TabIndex = 4;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(30, 373);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(23, 263);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.ForeColor = Color.White;
            UsernameLabel.Location = new Point(23, 188);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 7;
            UsernameLabel.Text = "Username";
            // 
            // Login
            // 
            AcceptButton = EnterButton;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(25, 34, 59);
            CancelButton = ExitButton;
            ClientSize = new Size(289, 440);
            ControlBox = false;
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(ErrorLabel);
            Controls.Add(UserErrorLabel);
            Controls.Add(PassErrorLabel);
            Controls.Add(EnterButton);
            Controls.Add(ExitButton);
            Controls.Add(PasswordPanel);
            Controls.Add(UsernamePanel);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox UsernameBox;
        public Button LoginButton;
        private Panel UsernamePanel;
        private Panel PasswordPanel;
        public TextBox PasswordBox;
        public Button ExitButton;
        public Button EnterButton;
        private Label PassErrorLabel;
        private Label UserErrorLabel;
        private Label ErrorLabel;
        private Label PasswordLabel;
        private Label UsernameLabel;
    }
}
