using EmployeesManager.Context;
using EmployeesManager.Views.Page.DataGridManagment.Interfaces;

namespace EmployeesManager.Views.Page.DataGridManagment;

public class DepartmentsDGManagment : BaseDGManagment
{
    public DepartmentsDGManagment(DataGridView DGView, MainCTX mainCTX) : base(DGView, mainCTX)
    {
    }

    public override void BuildHeader()
    {
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "ID" });
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "Department" });
    }

    public override Task UpdateData()
    {
        var parsedDepartments = _mainCTX.Departments?.Select(d => new string[]
        {
            d.DepartmentID.ToString(),
            d.Department
        });

        if (parsedDepartments is not null)
            foreach (var department in parsedDepartments)
                _View.Rows.Add(department);


        return Task.CompletedTask;
    }
}
