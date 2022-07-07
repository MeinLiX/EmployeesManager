using EmployeesManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManager.Models;

public class DepartmentModel : IModel
{
    [Key]
    public Guid DepartmentID { get; set; }

    [Required]
    public string Department { get; set; }

    //[Required]
    //public string DepartmentAdress { get; set; }
    
    //EF navigations
    public List<EmployeeModel> Employees { get; set; } = new();
}
