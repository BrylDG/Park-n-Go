using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public class FileName
    {
        private string connectionString;
        private SqlConnection connection;
        
        public FileName(string server, string database, string username, string password)
        {
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
            connection = new SqlConnection(connectionString);
            // Initialize connection object
            try
            {
                connection.Open();
                Console.WriteLine("Connected to MySQL Server.");
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

        public void AddRecord(string tableName, Dictionary<string, object> data)
        {
            string columns = string.Join(", ", data.Keys);
            string values = string.Join(", ", data.Values);

            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Record added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding record: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void DeleteRecord(string tableName, string condition)
        {
            string query = $"DELETE FROM {tableName} WHERE {condition}";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting record: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateRecord(string tableName, Dictionary<string, object> newData, string condition)
        {
            List<string> updates = new List<string>();
            foreach (var entry in newData)
            {
                updates.Add($"{entry.Key} = {entry.Value}");
            }

            string setClause = string.Join(", ", updates);

            string query = $"UPDATE {tableName} SET {setClause} WHERE {condition}";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Record updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating record: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void SearchRecords(string tableName, string condition)
        {
            string query = $"SELECT * FROM {tableName} WHERE {condition}";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Process retrieved data
                        // Example: Console.WriteLine(reader["ColumnName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching records: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void LoadData(DataGridView dataGridView, string tableName)
        {
            string query = $"SELECT * FROM {tableName}";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    // Create a DataTable to hold the data
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);
                    // Bind the DataTable to the DataGridView
                    dataGridView.DataSource = dataTable;
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
