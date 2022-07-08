using EmployeesManager.Context;
using EmployeesManager.Views.ModifyWindows;
using EmployeesManager.Views.ModifyWindows.Interfaces;
using EmployeesManager.Views.Page.DataGridManagment;
using EmployeesManager.Views.Page.DataGridManagment.Interfaces;
using EmployeesManager.Views.Page.Interfaces;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views.Page;

public partial class PageWithDataGridControl : UserControl, IControllWithServices
{
    private IServiceProvider _serviceProvider;
    private ILogger _logger;
    private MainCTX _mainCTX;
    private ControlMode _currentMode;
    private BaseDGManagment _dgManagment;

    private KeyValuePair<Guid, string> _currentDepartmentFilter;

    public PageWithDataGridControl()
    {
        InitializeComponent();
    }

    public void UpServices(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _logger = serviceProvider.GetRequiredService<ILogger<PageWithDataGridControl>>();
        _mainCTX = serviceProvider.GetRequiredService<MainCTX>();

        _logger.LogInformation($"{this.Name} services have been successfully registered {DateTime.UtcNow}");
    }

    public void UpServices(IServiceProvider serviceProvider, ControlMode mode)
    {
        UpServices(serviceProvider);
        _currentMode = mode;

        _dgManagment = _currentMode switch
        {
            ControlMode.Employees => new EmployeesDGManagment(dataGridView, _mainCTX),
            ControlMode.Departments => new DepartmentsDGManagment(dataGridView, _mainCTX),
            ControlMode.Positions => new PositionsDGManagment(dataGridView, _mainCTX),
        };
        materialLabelHeader.Text = _currentMode.ToString();
        _dgManagment.BuildHeader();
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
        if (updateDepartmentFilterIfNeed())
        {
            await UpdateViewWithFilter();
        }
        else
        {
            await _dgManagment.UpdateData();
        }
    }

    private async Task UpdateViewWithFilter() => await (_dgManagment as IDataFromDepartment).UpdateDataByDepartment(_currentDepartmentFilter.Key);


    #region Delete Action
    private async void materialButtonDelete_Click(object sender, EventArgs e)
    {
        string resultMessage;
        try
        {
            DialogResult resultToDelete = new MaterialDialog(this.Parent.Parent.Parent as MainForm, "Delete item", "Are you sure you want to delete the item?", "Delete", true, "Cancel").ShowDialog(this);
            if (resultToDelete == DialogResult.Cancel)
            {
                return;
            }

            await (_currentMode switch
            {
                ControlMode.Employees => DeleteEmployee(_dgManagment.GetSelectedRowID()),
                ControlMode.Departments => DeleteDepartment(_dgManagment.GetSelectedRowID()),
                ControlMode.Positions => DeletePosition(_dgManagment.GetSelectedRowID()),
            });
            await UpdateView();
            resultMessage = $"{_currentMode.ToString()[..^1]} is deleted.";
        }
        catch (Exception error)
        {
            resultMessage = error.Message;
        }

        new MaterialSnackBar(resultMessage, 1000).Show(this);
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

    private async void materialButtonAdd_Click(object sender, EventArgs e)
    {
        MaterialForm editForm = GetEditForm();

        if (GetParentWindow() is MainForm parentForm)
        {
            DialogResult dialogResult = parentForm.OpenDialogWithShadow(editForm);

            if (dialogResult == DialogResult.OK)
            {
                await UpdateView();
                new MaterialSnackBar($"{_currentMode.ToString()[..^1]} is created.", 1000).Show(this);
            }
        }
    }

    private async void materialButtonEdit_Click(object sender, EventArgs e)
    {
        MaterialForm editForm = GetEditForm();

        if (GetParentWindow() is MainForm parentForm)
        {
            if (editForm is IEditorForm editorForm)
            {
                try
                {
                    editorForm.ConfigureEditeMode(_dgManagment.GetSelectedRowID());
                }
                catch (Exception error)
                {
                    new MaterialSnackBar(error.Message, 1000).Show(this);
                    return;
                }

                DialogResult dialogResult = parentForm.OpenDialogWithShadow(editForm);

                if (dialogResult == DialogResult.OK)
                {
                    await UpdateView();
                    new MaterialSnackBar($"{_currentMode.ToString()[..^1]} is updated.", 1000).Show(this);
                }
            }
        }
    }

    private MainForm? GetParentWindow()
    {
        if (this.Parent is TabPage parentPage)
            if (parentPage.Parent is MaterialTabControl parentTabControll)
                if (parentTabControll.Parent is MainForm parentForm)
                    return parentForm;
        return null;
    }

    private MaterialForm GetEditForm() => _currentMode switch
    {
        ControlMode.Employees => _serviceProvider.GetRequiredService<EmployeeEditorForm>(),
        ControlMode.Departments => _serviceProvider.GetRequiredService<DepartmentEditorForm>(),
        ControlMode.Positions => _serviceProvider.GetRequiredService<PositionEditorForm>(),
    };

    /// <returns>true when need update with filter</returns>
    private bool updateDepartmentFilterIfNeed()
    {
        if (_currentMode == ControlMode.Employees)
        {
            materialComboBoxDepartmentsFilter.DataSource = null;
            materialComboBoxDepartmentsFilter.Visible = true;
            var avaliableDepartments = _mainCTX.Departments.Select(d => new KeyValuePair<Guid, string>(d.DepartmentID, d.Department))
                                                           .ToList()
                                                           .Prepend(new KeyValuePair<Guid, string>(Guid.Empty, "All")) //default `No Filter`
                                                           .ToList(); // i'm clown

            materialComboBoxDepartmentsFilter.DisplayMember = "Value";
            materialComboBoxDepartmentsFilter.SelectedValue = "Key";

            materialComboBoxDepartmentsFilter.DataSource = avaliableDepartments;

            return true;
        }
        return false;
    }

    private async void materialComboBoxDepartmentsFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if ((sender is ComboBox comboBox))
            if (comboBox.SelectedItem is not null)
            {
                _currentDepartmentFilter = (KeyValuePair<Guid, string>)(comboBox.SelectedItem);
            }

        await UpdateViewWithFilter();
    }
}
