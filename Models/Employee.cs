using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Windows.Input;

namespace T1908E_WAD.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }
    }
}