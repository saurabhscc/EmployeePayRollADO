using System;

namespace EmployeePayRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll ADO");
            EmployeeOperation employeeOperation = new EmployeeOperation();
            employeeOperation.GetAllEmployeeDetail();
        }
    }
}
