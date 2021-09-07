using EmployeePayRoll;
using NUnit.Framework;

namespace EmployeePayRollTest
{
    public class Tests
    {
        EmployeeOperation employeeOperation = new EmployeeOperation();
        [Test]
        public void GivenEmployeeDetail_ShouldMatchWithUpdatedDetails()
        {
            int expected = 1;
            int actual = employeeOperation.UpdateEmployeeSalary();
            Assert.AreEqual(expected, actual);
        }
    }
}
