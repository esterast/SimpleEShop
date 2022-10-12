namespace EShop_System.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }  
        public bool DepartmentIsActive { get; set; }   
        public int virtual ICollection<Employee> Employees { get; set;  }
    }
}
