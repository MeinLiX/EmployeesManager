using EmployeesManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManager.Models;

public class PositionModel : IModel
{
    [Key]
    public Guid PositionID { get; set; }

    [Required]
    public string PositionName { get; set; }


    //EF navigations
    public List<EmployeeModel> Employees { get; set; } = new();
}
