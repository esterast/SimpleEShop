﻿namespace EShop_System.Models
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeMobile { get; set; }  
        public string EmployeeEmail { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}