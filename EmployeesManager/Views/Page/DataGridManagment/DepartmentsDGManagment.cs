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
        _View.ColumnCount = 2;
        _View.ColumnHeadersVisible = true;

        _View.Columns[0].Name = "ID";
        _View.Columns[0].Visible = false;

        _View.Columns[1].Name = "Department";
    }

    public override Task UpdateData()
    {
        base.UpdateData();

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
