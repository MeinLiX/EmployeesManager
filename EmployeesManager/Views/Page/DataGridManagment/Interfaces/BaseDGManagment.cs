using EmployeesManager.Context;

namespace EmployeesManager.Views.Page.DataGridManagment.Interfaces;

public abstract class BaseDGManagment
{
    protected readonly DataGridView _View;
    protected readonly MainCTX _mainCTX;
    public BaseDGManagment(DataGridView DGView, MainCTX mainCTX)
    {
        _View = DGView;
        _mainCTX = mainCTX;
    }

    public abstract void BuildHeader();
    public abstract Task UpdateData();

    public virtual Guid GetSelectedRow()
    {
        if(_View.Rows.Count == 0)
        {
            throw new Exception("List is empty");
        }

        var firstSelectedRow = _View.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

        if (firstSelectedRow is null)
        {
            throw new Exception("Not found selected item");
        }

        return new Guid(firstSelectedRow.Cells["ID"].ToString());
    }
}
