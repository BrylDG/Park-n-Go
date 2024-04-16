using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{

    public partial class DashBoard : Form
    {
        DatabaseFunctions database = new DatabaseFunctions();
        
        public string plateNumber, vehicleType, vehicleBrand;
        int id;
        public DashBoard()
        {
            InitializeComponent();

        }

        private void SelectedItems()
        {
            switch (cbVehicleType.Text)
            {
                case "Motorbike":
                    cbVehicleBrand.Text = "";
                    cbVehicleBrand.Items.Clear();
                    cbVehicleBrand.Items.AddRange(new string[] { "Kawasaki", "Suzuki", "Honda", "Russi" });
                    break;

                case "SUV":
                    cbVehicleBrand.Text = "";
                    cbVehicleBrand.Items.Clear();
                    cbVehicleBrand.Items.AddRange(new string[] { "Kia", "Toyota", "Ford", "Hyundai", "Mitsubishi", "Isuzu" });
                    break;

                case "Sedan":
                    cbVehicleBrand.Text = "";
                    cbVehicleBrand.Items.Clear();
                    cbVehicleBrand.Items.AddRange(new string[] { "Volkswagen", "Toyota", "Ford", "Hyundai", "Mitsubishi", "Nissan" });
                    break;

                case "Van":
                    cbVehicleBrand.Text = "";
                    cbVehicleBrand.Items.Clear();
                    cbVehicleBrand.Items.AddRange(new string[] { "Toyota", "Nissan", "Hyundai", "Ford", "Kia" });
                    break;

                default:
                    break;
            }

        }
        private void cbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItems();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewRecords();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            ViewRecords();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecords();
            ViewRecords();
        }
        //Methods Sa ubos hehe.
        private void AddData()
        {
            if (cbVehicleType.Text == "" || cbVehicleBrand.Text == "" || textPlateNumber.Text == "")
            {
                MessageBox.Show("Hello, World!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AddRecord();
                ViewRecords();
            }

        }

        private void ViewRecords()
        {
            plateNumber = textPlateNumber.Text;
            database.ViewData(dataView, plateNumber);
        }
        private void AddRecord()
        {

            DataValues(out plateNumber, out vehicleType, out vehicleBrand);
            database.CreateRecord(plateNumber, vehicleType, vehicleBrand);
        }

        private void UpdateRecords()
        {
            DataValues(out plateNumber, out vehicleType, out vehicleBrand);
            database.UpdateRecords(id,plateNumber, vehicleType, vehicleBrand);
        }

        private void DataValues(out string plateNumber, out string vehicleType, out string vehicleBrand)
        {
            plateNumber = textPlateNumber.Text;
            vehicleType = cbVehicleType.Text;
            vehicleBrand = cbVehicleBrand.Text;
        }

        private void DeleteRecords()
        {
            plateNumber = textPlateNumber.Text;
           database.DeleteRecord(id);
        }



        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataView.Rows[e.RowIndex];
                object idCellValue = selectedRow.Cells["Id"].Value;

                int.TryParse(idCellValue.ToString(), out id);

                plateNumber = selectedRow.Cells["Plate Number"].Value.ToString();
                database.SelectedData(plateNumber, textPlateNumber, cbVehicleType, cbVehicleBrand);
            }
        }

        
    }
}
