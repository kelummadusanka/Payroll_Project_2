using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Payroll_Project_2.Backend
{
    internal class EmployeeDataAccess
    {
        private readonly string connectionString = DbSettings.ConnectionString;

        public void AddEmployee(Employee employee)
        {
            if (employee.Name == null || employee.Monthly_Salary == 0 || employee.Over_Time_Rate == 0 || employee.Allowance == 0)
            {
                Console.WriteLine("Please enter all fields!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Employee (Name, Monthly_Salary, Over_Time_Rate, Allowance) VALUES (@Name, @Monthly_Salary, @Over_Time_Rate, @Allowance)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", employee.Name.TrimEnd());
                    command.Parameters.AddWithValue("@Monthly_Salary", employee.Monthly_Salary);
                    command.Parameters.AddWithValue("@Over_Time_Rate", employee.Over_Time_Rate);
                    command.Parameters.AddWithValue("@Allowance", employee.Allowance);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee created successfully!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryString = "UPDATE Employee SET Name=@Name, Monthly_Salary=@Monthly_Salary, Over_Time_Rate=@Over_Time_Rate, Allowance=@Allowance WHERE Id=@Id";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Monthly_Salary", employee.Monthly_Salary);
                    command.Parameters.AddWithValue("@Over_Time_Rate", employee.Over_Time_Rate);
                    command.Parameters.AddWithValue("@Allowance", employee.Allowance);
                    command.Parameters.AddWithValue("@Id", employee.Id);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee updated successfully!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public void DeleteEmployee(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryString = "DELETE FROM Employee WHERE Id=@Id";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@Id", Id);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee deleted successfully!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string getAllQuery = "SELECT * from Employee";
                    connection.Open();
                    SqlCommand command = new SqlCommand(getAllQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = new Employee
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString().Trim(),
                            Monthly_Salary = Convert.ToDecimal(reader["Monthly_Salary"]),
                            Over_Time_Rate = Convert.ToDecimal(reader["Over_Time_Rate"]),
                            Allowance = Convert.ToDecimal(reader["Allowance"])
                        };
                        employees.Add(employee);
                    }

                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                throw e;
            }

            return employees;
        }

        public Employee GetEmployee(int id)
        {
            string query = "SELECT Id, Name, Monthly_Salary, Over_Time_Rate, Allowance FROM Employee WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Monthly_Salary = reader.GetDecimal(2),
                                Over_Time_Rate = reader.GetDecimal(3),
                                Allowance = reader.GetDecimal(4)
                            };

                            return employee;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }

        public List<int> GetEmployeeIds()
        {
            List<int> employeeIds = new List<int>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id FROM Employee";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employeeIds.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while getting employee IDs: " + ex.Message);
                throw;
            }
            return employeeIds;
        }

    }
}