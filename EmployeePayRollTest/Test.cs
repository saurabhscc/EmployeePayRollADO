using EmployeePayRoll;
using NUnit.Framework;
using System;
using System.Data.SqlClient;

namespace EmployeePayRollTest
{
    public class Tests
    {
        EmployeeOperation employeeOperation = new EmployeeOperation();
        [Test]
        public void GivenEmployeeDetail_ShouldMatchWithUpdatedDetails()
        {
            int expected = 2;
            int actual = employeeOperation.UpdateEmployeeSalary();
            Assert.AreEqual(expected, actual);
        }
    }
}