using EmployeesManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManager.Models;

public class EmployeeModel : IModel
{
    [Key]
    public Guid EmployeeID { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Patronymic { get; set; }

    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    [Required]
    public string HomeAddress { get; set; }

    public string GetFullName() => $"{FirstName} {LastName} {Patronymic}";

    //EF navigations
    public DepartmentModel Department { get; set; }
    public PositionModel Position { get; set; }
    public SalaryModel Salary { get; set; } //public List<SalaryModel> Salaries { get; set; } = new();
}
