using System.ComponentModel.DataAnnotations;

namespace BlazorAppWithSQLServer.Models
{
    public class Employees
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Designation is required.")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        public double Salary { get; set; }
    }
}
