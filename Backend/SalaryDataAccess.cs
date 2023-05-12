using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Payroll_Project_2.Backend
{
    internal class SalaryDataAccess
    {
        private readonly string connectionString = DbSettings.ConnectionString;

        public void CreateSalary(Salary salary)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Salary (Id, Salary_Paid_Date, No_pay_value, Base_pay_value, Gross_pay_value) 
                                     VALUES (@Id, @Salary_Paid_Date, @No_Pay_Value, @Base_Pay_Value, @Gross_Pay_Value)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", salary.Id);
                        command.Parameters.AddWithValue("@Salary_Paid_Date", salary.Salary_Paid_Date);
                        command.Parameters.AddWithValue("@No_Pay_Value", salary.No_Pay_Value);
                        command.Parameters.AddWithValue("@Base_Pay_Value", salary.Base_Pay_Value);
                        command.Parameters.AddWithValue("@Gross_Pay_Value", salary.Gross_Pay_Value);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Successfully saved to database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public List<Salary> GetEmployeeSalaryList(int id)
        {
            List<Salary> salaryList = new List<Salary>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT TOP 6 * 
                                     FROM Salary 
                                     WHERE Id = @Id 
                                     ORDER BY [Salary_Paid_Date] DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Salary salary = new Salary
                                {
                                    Id = (int)reader["Id"],
                                    Salary_Paid_Date = (DateTime)reader["Salary_Paid_Date"],
                                    No_Pay_Value = (decimal)reader["No_pay_value"],
                                    Base_Pay_Value = (decimal)reader["Base_pay_value"],
                                    Gross_Pay_Value = (decimal)reader["Gross_pay_value"]
                                };

                                salaryList.Add(salary);
                            }
                        }
                    }
                }

                return salaryList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public List<decimal> GetOverallPayValues(DateTime fromMonth, DateTime toMonth)
        {
            decimal totalNoPay = 0;
            decimal totalBasePay = 0;
            decimal totalGrossPay = 0;
            List<decimal> payvalues = new List<decimal>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT No_pay_value, Base_pay_value, Gross_pay_value " +
                                   "FROM Salary " +
                                   "WHERE Salary_Paid_Date >= @FromDate AND Salary_Paid_Date <= @ToDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FromDate", fromMonth.Date);
                        command.Parameters.AddWithValue("@ToDate", toMonth.Date);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalNoPay += reader.GetDecimal(0);
                                totalBasePay += reader.GetDecimal(1);
                                totalGrossPay += reader.GetDecimal(2);
                            }
                        }
                    }
                }
                payvalues.Add(totalGrossPay);
                payvalues.Add(totalBasePay);
                payvalues.Add(totalNoPay);

                return payvalues;
            }
            catch
            {
                throw;
            }
        }


    }
}


