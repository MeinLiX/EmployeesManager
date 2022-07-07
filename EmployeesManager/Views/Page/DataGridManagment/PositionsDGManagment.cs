using EmployeesManager.Context;
using EmployeesManager.Views.Page.DataGridManagment.Interfaces;

namespace EmployeesManager.Views.Page.DataGridManagment;

internal class PositionsDGManagment : BaseDGManagment
{
    public PositionsDGManagment(DataGridView DGView, MainCTX mainCTX) : base(DGView, mainCTX)
    {
    }

    public override void BuildHeader()
    {
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "ID" });
        _View.Columns.Add(new DataGridViewColumn() { HeaderText = "Position" });
    }

    public override Task UpdateData()
    {
        var parsedPositions = _mainCTX.Positions?.Select(p => new string[]
        {
            p.PositionID.ToString(),
            p.PositionName
        });

        if (parsedPositions is not null)
            foreach (var department in parsedPositions)
                _View.Rows.Add(department);

        return Task.CompletedTask;
    }
}
