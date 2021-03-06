﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PropertyManagement.API.Models
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public bool HasCar { get; set; }
        public decimal HourlyPay { get; set; }

        public virtual Role Role { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<EmployeeTrade> EmployeeTrades { get; set; }

        public Employee()
        {
            EmployeeTrades = new Collection<EmployeeTrade>();
        }
    }
}