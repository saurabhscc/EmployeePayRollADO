using System;
using System.Collections.Generic;

namespace EmployeePayRoll
{
    class Program
    {
        static List<Employee> empList = new List<Employee>();
        static EmployeeOperation employeeOperation = new EmployeeOperation();
        /// <summary>
        /// invoke the EmployeeOperation methods.
        /// </summary>
        public static void DisplayEmployeeDetails()
        {
            empList = employeeOperation.GetAllEmployeeDetails();
            if (empList.Count > 0)
            {
                foreach (Employee emp in empList)
                {
                    Console.WriteLine(emp.ID + " " + emp.Name + " " + emp.Gender + " " + emp.phone_Number + emp.Address + " "
                        + emp.Department + " " + emp.BasicPay + " " + emp.Deduction + " " + emp.TaxablePay + " " + emp.Tax + " "
                        + emp.NetPay + " " + emp.StartDate + " " +  "\n");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll ADO");
            DisplayEmployeeDetails();
            employeeOperation.UpdateEmployeeSalary();
            Console.WriteLine("Employee Details between Start date and End date");
            employeeOperation.GetEmployeeDetailsByDate();
        }
    }
}
