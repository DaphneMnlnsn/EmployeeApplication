﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInterface
{
    internal interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get;  set; }

        void computeSalary(int hoursWorked, double ratePerHour);

    }
}
