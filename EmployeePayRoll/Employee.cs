﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayRoll
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string phone_Number { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public int BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public DateTime StartDate { get; set; }
        
    }
}

