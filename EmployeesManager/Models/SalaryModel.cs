using EmployeesManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManager.Models;

public class SalaryModel : IModel
{
    [Key]
    public Guid SalaryID { get; set; }

    [Required]
    public decimal Salary { get; set; }

    [Required]
    [RegularExpression(@"A|B|C", ErrorMessage = "Character are not allowed.")]
    public string KPI { get; set; }

    /*
    [Required]
    public DateTime StartDatePeriod { get; set; } = DateTime.Today.AddMonths(1);

    [Required]
    public DateTime EndDatePeriod { get; set; } = DateTime.Today;
    */
    public decimal GetPremium() => KPI switch
    {
        "A" => Salary * 0.2m,
        "B" => Salary * 0.3m,
        "C" => Salary * 0.4m,
        _ => throw new Exception($"Unsupported KPI: ${KPI}")
    };

    public decimal GetSalaryWithKPI() => KPI switch
    {
        "A" => Salary + GetPremium(), //*1.2
        "B" => Salary + GetPremium(), //*1.3
        "C" => Salary + GetPremium(), //*1.4
        _ => throw new Exception($"Unsupported KPI: ${KPI}")
    };

    //EF navigations
    public EmployeeModel Employee { get; set; }
}
