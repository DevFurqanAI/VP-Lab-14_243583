using System.ComponentModel.DataAnnotations;
namespace VP_Lab_14.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}
