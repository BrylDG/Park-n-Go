using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DatabaseFunctions
    {
        private string server = "(localdb)\\MSSQLLocalDB";
        private string databaseName = "ParkingSystem";
        private string userName = "";
        private string password = "";
        private string connectionString;
        private SqlConnection connection;

        public void DatabaseConnection()
        {
            OpenConnection();
            CloseConnection();
        }

        private void OpenConnection()
        {
            connectionString = $"Server={server};Database={databaseName};Uid={userName};Pwd={password}";
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to MySQL Server: " + ex.Message);
            }
        }

        private void CloseConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
                Console.WriteLine("Connection to MySQL Server closed.");
            }
        }

        public void CreateRecord(string plateNumber, string vehicleType, string vehicleBrand)
        {
            OpenConnection();

            try
            {
                string query = "INSERT INTO Vehicle ([Plate Number], [Vehicle Type], [Vehicle Brand]) " +
                               "VALUES (@PlateNumber, @VehicleType, @VehicleBrand)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateRecords(int id, string plateNumber, string vehicleType, string vehicleBrand)
        {
            OpenConnection();
            try
            {
                string query = "UPDATE Vehicle SET [Plate Number] = @PlateNumber, [Vehicle Type] = @VehicleType, [Vehicle Brand] = @VehicleBrand " +
                               "WHERE [Id] = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id); // Make sure to include the id parameter
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void DeleteRecord(int id)
        {
            OpenConnection();
            try
            {

                string deleteQuery = "DELETE FROM Vehicle WHERE [Id] = @Id";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("Id", id);
                deleteCommand.ExecuteNonQuery();

                // Reset the identity seed if the table is empty
                string resetIdentityQuery = "IF NOT EXISTS (SELECT * FROM Vehicle) DBCC CHECKIDENT('Vehicle', RESEED, 0)";
                SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, connection);
                resetIdentityCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }


        public void ViewData(DataGridView dataGridView, string plateNumber)
        {
            OpenConnection();
            try
            {

                string query = $"SELECT [Id], [Plate Number] From Vehicle";

                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }


        }
        public void SelectedData(string plateNumber, TextBox plateN, ComboBox vehicleT, ComboBox vehicleB)
        {
            OpenConnection();
            try
            {
                string query = "SELECT * FROM Vehicle WHERE [Plate Number] = @PlateNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    plateNumber = reader["Plate Number"].ToString();
                    string vehicleType = reader["Vehicle Type"].ToString();
                    string vehicleBrand = reader["Vehicle Brand"].ToString();

                    plateN.Text = plateNumber;
                    vehicleT.Text = vehicleType;
                    vehicleB.Text = vehicleBrand;
                }
                else
                {
                    MessageBox.Show("No data found for the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }


        }


    }


}
