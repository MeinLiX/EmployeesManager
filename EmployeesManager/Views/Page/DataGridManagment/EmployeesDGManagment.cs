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
        _View.ColumnCount = 7;
        _View.ColumnHeadersVisible = true;

        _View.Columns[0].Name = "ID";
        _View.Columns[0].Visible = false;

        _View.Columns[1].Name = "FullName";
        _View.Columns[2].Name = "Department";
        _View.Columns[3].Name = "Position";
        _View.Columns[4].Name = "Salary";
        _View.Columns[5].Name = "KPI";
        _View.Columns[6].Name = "Premium";
    }

    public override Task UpdateData()
    {
        base.UpdateData();

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
        var parsedEmployees = _mainCTX.Employees.Where(e => e.Department.DepartmentID == departmentID)?.Select(e => new string[]
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
