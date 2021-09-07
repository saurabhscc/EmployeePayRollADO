using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayRoll
{
    //business logic
    public class EmployeeOperation
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeePayRoll";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        //instance
        public static Employee employee = new Employee();
        readonly List<Employee> empList = new List<Employee>();
        /// <summary>
        /// get the employee detail by store procedure
        /// </summary>
        public List<Employee> GetAllEmployeeDetails()
        {
            this.sqlConnection.Open();
            try
            {
                SqlCommand command = new SqlCommand("spGetAllEmployee", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow data in dataTable.Rows)
                {
                    Console.WriteLine("No record found");
                    empList.Add
                        (
                            new Employee
                            {
                                ID = Convert.ToInt32(data["Id"]),
                                Name = Convert.ToString(data["Name"]),
                                Gender = Convert.ToString(data["Gender"]),
                                phone_Number = Convert.ToString(data["phone_Number"]),
                                Address = Convert.ToString(data["Address"]),
                                Department = Convert.ToString(data["Department"]),
                                BasicPay = Convert.ToInt32(data["BasicPay"]),
                                Deduction = Convert.ToDouble(data["Deduction"]),
                                TaxablePay = Convert.ToDouble(data["TaxablePay"]),
                                Tax = Convert.ToDouble(data["Tax"]),
                                NetPay = Convert.ToDouble(data["NetPay"]),
                                StartDate = Convert.ToDateTime(data["StartDate"]),
                                
                            }
                        );
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }
            return empList;
        }
        public int UpdateEmployeeSalary()
        {
            Employee emp = new Employee();
            emp.Name = "Terissa";
            emp.BasicPay = 3000000;
            try
            {
                this.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("spUpdateEmployee", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", emp.Name);
                sqlCommand.Parameters.AddWithValue("@BasicPay", emp.BasicPay);
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 1)
                    Console.WriteLine("Salary is updated...");
                else
                    Console.WriteLine("Salary not updated!");
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }
    }
}
