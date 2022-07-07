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
        _View.ColumnCount = 2;
        _View.ColumnHeadersVisible = true;

        _View.Columns[0].Name = "ID";
        _View.Columns[0].Visible = false;

        _View.Columns[1].Name = "Position";
    }

    public override Task UpdateData()
    {
        base.UpdateData();

        var parsedPositions = _mainCTX.Positions?.Select(p => new string[]
        {
            p.PositionID.ToString(),
            p.PositionName
        });

        if (parsedPositions is not null)
            foreach (var position in parsedPositions)
                _View.Rows.Add(position);

        return Task.CompletedTask;
    }
}
