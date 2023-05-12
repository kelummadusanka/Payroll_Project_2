using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Payroll_Project_2.Backend
{
    internal class SettingDataAccess
    {
        private readonly string connectionString = DbSettings.ConnectionString;

        public void SetSettingValues(int date_Range, int begin_Date, int end_Date, int no_of_Leaves, decimal Tax_Rate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string countQuery = "SELECT COUNT(*) as total_rows FROM Settings";
                    string createQuery = "INSERT INTO Settings (Date_Range, Begin_Date, End_Date, No_of_Leaves, Tax_Rate) VALUES (@Date_Range, @Begin_Date, @End_Date, @No_of_Leaves, @Tax_Rate)";
                    string updateQuery = "UPDATE Settings SET Date_Range = @Date_Range, Begin_Date = @Begin_Date, End_Date = @End_Date, No_of_Leaves = @No_of_Leaves, Tax_Rate = @Tax_Rate WHERE Id = 1";

                    SqlCommand countCommand = new SqlCommand(countQuery, connection);
                    int totalRows = (int)countCommand.ExecuteScalar();

                    SqlCommand command;
                    if (totalRows > 0)
                    {
                        command = new SqlCommand(updateQuery, connection);
                    }
                    else
                    {
                        command = new SqlCommand(createQuery, connection);
                    }

                    command.Parameters.AddWithValue("@Date_Range", date_Range);
                    command.Parameters.AddWithValue("@Begin_Date", begin_Date);
                    command.Parameters.AddWithValue("@End_Date", end_Date);
                    command.Parameters.AddWithValue("@No_of_Leaves", no_of_Leaves);
                    command.Parameters.AddWithValue("@Tax_Rate", Tax_Rate);
                    command.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Updated Successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
            }
        }

        public Setting GetSettingValue()
        {
            string query = "SELECT * FROM Settings WHERE Id = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Setting setting = new Setting
                        {
                            Date_Range = Convert.ToInt32(reader["Date_Range"]),
                            Begin_Date = Convert.ToInt32(reader["Begin_Date"]),
                            End_Date = Convert.ToInt32(reader["End_Date"]),
                            No_of_Leaves = Convert.ToInt32(reader["No_of_Leaves"]),
                            Tax_Rate = Convert.ToDecimal(reader["Tax_Rate"])
                        };
                        return setting;
                    }

                    MessageBox.Show("Internal Error! Please Check");
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
            }
        }
    }
}
