using System.ComponentModel.DataAnnotations;

namespace EmployeesManager.Models;

public class SalaryModel
{
    [Key]
    public Guid SalaryID { get; set; }

    [Required]
    public decimal Salary { get; set; }

    [Required]
    [RegularExpression(@"A|B|C", ErrorMessage = "Character are not allowed.")]
    public string KPI { get; set; }

    [Required]
    public DateTime StartDatePeriod { get; set; } = DateTime.Today.AddMonths(1);

    [Required]
    public DateTime EndDatePeriod { get; set; } = DateTime.Today;


    public decimal GetSalaryWithKPI() => KPI switch
    {
        "A" => Salary * 1.2m,
        "B" => Salary * 1.3m,
        "C" => Salary * 1.4m,
        _ => throw new Exception($"Unsupported KPI: ${KPI}")
    };

    //EF navigations
    public EmployeeModel Employee { get; set; }
}
