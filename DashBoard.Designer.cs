namespace WinFormsApp1
{
    partial class DashBoard
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
            dataView = new DataGridView();
            lblVehicleType = new Label();
            lblVehicleBrand = new Label();
            lblPlateNumber = new Label();
            textPlateNumber = new TextBox();
            cbVehicleType = new ComboBox();
            cbVehicleBrand = new ComboBox();
            btnAdd = new Button();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AllowUserToDeleteRows = false;
            dataView.AllowUserToResizeColumns = false;
            dataView.AllowUserToResizeRows = false;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(646, 12);
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(464, 353);
            dataView.TabIndex = 0;
            dataView.CellClick += dataView_CellClick;
            dataView.CellContentClick += dataView_CellContentClick;
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(12, 21);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(91, 20);
            lblVehicleType.TabIndex = 1;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // lblVehicleBrand
            // 
            lblVehicleBrand.AutoSize = true;
            lblVehicleBrand.Location = new Point(12, 69);
            lblVehicleBrand.Name = "lblVehicleBrand";
            lblVehicleBrand.Size = new Size(99, 20);
            lblVehicleBrand.TabIndex = 2;
            lblVehicleBrand.Text = "Vehicle Brand";
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(12, 125);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(100, 20);
            lblPlateNumber.TabIndex = 3;
            lblPlateNumber.Text = "Plate Number";
            // 
            // textPlateNumber
            // 
            textPlateNumber.Location = new Point(126, 122);
            textPlateNumber.Name = "textPlateNumber";
            textPlateNumber.Size = new Size(314, 27);
            textPlateNumber.TabIndex = 4;
            // 
            // cbVehicleType
            // 
            cbVehicleType.Cursor = Cursors.IBeam;
            cbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVehicleType.FormattingEnabled = true;
            cbVehicleType.Items.AddRange(new object[] { "Motorbike", "SUV", "Sedan", "Van" });
            cbVehicleType.Location = new Point(126, 12);
            cbVehicleType.Name = "cbVehicleType";
            cbVehicleType.Size = new Size(314, 28);
            cbVehicleType.TabIndex = 5;
            cbVehicleType.SelectedIndexChanged += cbVehicleType_SelectedIndexChanged;
            // 
            // cbVehicleBrand
            // 
            cbVehicleBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVehicleBrand.FormattingEnabled = true;
            cbVehicleBrand.Location = new Point(126, 61);
            cbVehicleBrand.Name = "cbVehicleBrand";
            cbVehicleBrand.Size = new Size(314, 28);
            cbVehicleBrand.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(203, 77);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(12, 579);
            btnView.Name = "btnView";
            btnView.Size = new Size(203, 77);
            btnView.TabIndex = 8;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(425, 579);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 77);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(854, 588);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(203, 77);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(646, 431);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(203, 77);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(646, 383);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 27);
            textBox2.TabIndex = 12;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 695);
            Controls.Add(textBox2);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(cbVehicleBrand);
            Controls.Add(cbVehicleType);
            Controls.Add(textPlateNumber);
            Controls.Add(lblPlateNumber);
            Controls.Add(lblVehicleBrand);
            Controls.Add(lblVehicleType);
            Controls.Add(dataView);
            Name = "DashBoard";
            Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataView;
        private Label lblVehicleType;
        private Label lblVehicleBrand;
        private Label lblPlateNumber;
        private TextBox textPlateNumber;
        private ComboBox cbVehicleType;
        private ComboBox cbVehicleBrand;
        private Button btnAdd;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private TextBox textBox2;
    }
}