
using EmployeesManager.Context;
using EmployeesManager.Views.Page.DataGridManagment;
using EmployeesManager.Views.Page.DataGridManagment.Interfaces;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views.Page;

public partial class PageWithDataGridControl : UserControl
{
    private ILogger _logger;
    private MainCTX _mainCTX;
    private ControlMode _currentMode;
    private BaseDGManagment _dgManagment;
    public PageWithDataGridControl()
    {
        InitializeComponent();
    }

    public void UpServices(IServiceProvider serviceProvider, ControlMode mode)
    {
        _currentMode = mode;

        _logger = serviceProvider.GetRequiredService<ILogger<PageWithDataGridControl>>();
        _mainCTX = serviceProvider.GetRequiredService<MainCTX>();

        _dgManagment = _currentMode switch
        {
            ControlMode.Employees => new EmployeesDGManagment(dataGridView, _mainCTX),
            ControlMode.Departments => new DepartmentsDGManagment(dataGridView, _mainCTX),
            ControlMode.Positions => new PositionsDGManagment(dataGridView, _mainCTX),
        };

        _dgManagment.BuildHeader();

        _logger.LogInformation($"{this.Name} services have been successfully registered {DateTime.UtcNow}");
    }

    private void CheckServices()
    {
        if (_logger is null) throw new Exception($"{this.Name} logger service exceptions.");
        if (_mainCTX is null) throw new Exception($"{this.Name} database service exceptions.");
        if (_dgManagment is null) throw new Exception($"{this.Name} data grid managment exceptions.");
    }

    public enum ControlMode
    {
        Employees,
        Departments,
        Positions
    }

    public async Task UpdateView()
    {
        CheckServices();
        await _dgManagment.UpdateData();
    }


    #region Delete Action
    private async void materialButtonDelete_Click(object sender, EventArgs e)
    {
        string resultMessage;
        try
        {
            CheckServices();
            await (_currentMode switch
            {
                ControlMode.Employees => DeleteEmployee(_dgManagment.GetSelectedRow()),
                ControlMode.Departments => DeleteDepartment(_dgManagment.GetSelectedRow()),
                ControlMode.Positions => DeletePosition(_dgManagment.GetSelectedRow()),
            });
            await _dgManagment.UpdateData();
            resultMessage = $"{_currentMode} is deleted.";
        }
        catch (Exception error)
        {
            resultMessage = error.Message;
        }

        MaterialSnackBar SnackBarMessage = new(resultMessage, 1000);
        SnackBarMessage.Show(this);
    }


    private async Task DeleteEmployee(Guid id)
    {
        var employeeToRemove = _mainCTX.Employees.FirstOrDefault(e => e.EmployeeID == id) ?? throw new Exception("Employee not found");
        _mainCTX.Employees.Remove(employeeToRemove);
        await _mainCTX.SaveChangesAsync();
    }
    private async Task DeleteDepartment(Guid id)
    {
        var departmentToRemove = _mainCTX.Departments.FirstOrDefault(e => e.DepartmentID == id) ?? throw new Exception("Department not found");
        _mainCTX.Departments.Remove(departmentToRemove);
        await _mainCTX.SaveChangesAsync();
    }
    private async Task DeletePosition(Guid id)
    {
        var positionToRemove = _mainCTX.Positions.FirstOrDefault(e => e.PositionID == id) ?? throw new Exception("Position not found");
        _mainCTX.Positions.Remove(positionToRemove);
        await _mainCTX.SaveChangesAsync();
    }
    #endregion

}
