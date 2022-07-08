using EmployeesManager.Context;
using EmployeesManager.Views.Page.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views.Page;

public partial class PayoutsPageControl : UserControl, IControllWithServices
{
    private ILogger _logger;
    private MainCTX _mainCTX;

    public PayoutsPageControl()
    {
        InitializeComponent();
    }

    public void UpServices(IServiceProvider serviceProvider)
    {
        _logger = serviceProvider.GetRequiredService<ILogger<PayoutsPageControl>>();
        _mainCTX = serviceProvider.GetRequiredService<MainCTX>();

        _logger.LogInformation($"{this.Name} services have been successfully registered {DateTime.UtcNow}");
    }

    private void CheckServices()
    {
        if (_logger is null) throw new Exception($"{this.Name} logger service exceptions.");
        if (_mainCTX is null) throw new Exception($"{this.Name} database service exceptions.");
    }

    public Task UpdateView()
    {
        CheckServices();
        updateDepartmentFilter();

        return Task.CompletedTask;
    }

    private void materialComboBoxDepartmentsFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        updateSalaryLabel();
    }

    private void updateDepartmentFilter()
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

        updateSalaryLabel();
    }

    private void updateSalaryLabel()
    {
        var selectedDepartment = (KeyValuePair<Guid, string>?)materialComboBoxDepartmentsFilter.SelectedItem;

        materialLabelCommonSalary.Text = (selectedDepartment?.Key switch
        {
            Guid selectedGuid when selectedGuid == Guid.Empty => _mainCTX.Salaries.Sum(S => (double)S.Salary),
            Guid selectedGuid => _mainCTX.Salaries.Where(s => s.Employee.Department.DepartmentID == selectedGuid).Sum(S => (double)S.Salary),
            null => _mainCTX.Salaries.Sum(S => (double)S.Salary)

        }).ToString();
    }
}
