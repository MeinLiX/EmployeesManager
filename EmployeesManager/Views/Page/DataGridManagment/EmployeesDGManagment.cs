using EmployeesManager.Context;
using EmployeesManager.Views.Page.DataGridManagment.Interfaces;

namespace EmployeesManager.Views.Page.DataGridManagment;

internal class EmployeesDGManagment : BaseDGManagment, IDataFromDepartment
{
    public EmployeesDGManagment(DataGridView DGView, MainCTX mainCTX) : base(DGView, mainCTX)
    {
    }

    public override void BuildHeader()
    {
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "ID" });
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "FullName" });
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "Department" });
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "Position" });
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "Salary" });
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "KPI" });
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "Premium" });
    }

    public override Task UpdateData()
    {
        _View.Rows.Clear();
        var parsedEmployees = _mainCTX.Employees?.Select(e => new string[]
        {
            e.EmployeeID.ToString(),
            e.GetFullName(),
            e.Department.Department,
            e.Position.PositionName,
            e.Salary.Salary.ToString(),
            e.Salary.KPI,
            e.Salary.GetPremium().ToString()
        });

        if (parsedEmployees is not null)
            foreach (var employee in parsedEmployees)
                _View.Rows.Add(employee);
            

        return Task.CompletedTask;
    }

    public Task UpdateDataByDepartment(Guid departmentID)
    {
        _View.Rows.Clear();
        var parsedEmployees = _mainCTX.Employees.Where(e=>e.Department.DepartmentID==departmentID)?.Select(e => new string[]
        {
            e.EmployeeID.ToString(),
            e.GetFullName(),
            e.Department.Department,
            e.Position.PositionName,
            e.Salary.Salary.ToString(),
            e.Salary.KPI,
            e.Salary.GetPremium().ToString()
        });

        if (parsedEmployees is not null)
            foreach (var employee in parsedEmployees)
                _View.Rows.Add(employee);


        return Task.CompletedTask;
    }
}
