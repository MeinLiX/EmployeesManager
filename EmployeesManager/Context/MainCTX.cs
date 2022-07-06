using EmployeesManager.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManager.Context;

public class MainCTX : DbContext
{
    public MainCTX(DbContextOptions<MainCTX> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<DepartmentModel> Departments { get; set; }
    public DbSet<EmployeeModel> Employees { get; set; }
    public DbSet<PositionModel> Positions { get; set; }
    public DbSet<SalaryModel> Salaries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        // All relations has cascade delete.

        // relation one to one do'nt work beheviour without existents foreignKeys.
        modelBuilder.Entity<EmployeeModel>()
                    .HasOne(e => e.Salary)
                    .WithOne(s=>s.Employee)
                    .HasForeignKey<SalaryModel>(s => s.SalaryID);

        modelBuilder.Entity<SalaryModel>()
                    .HasOne(s => s.Employee)
                    .WithOne(e => e.Salary)
                    .HasForeignKey<EmployeeModel>(e => e.EmployeeID);
    }
}
