using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views;

public partial class MainForm : MaterialForm
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger _logger;
    private readonly MaterialSkinManager _materialSkinManager;

    public MainForm(IServiceProvider serviceProvider, ILogger<MainForm> logger, MaterialSkinManager materialSkinManager)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
        _materialSkinManager= materialSkinManager;
        InitializeComponent();
        _logger.LogInformation($"Session started at {DateTime.UtcNow}");

        _materialSkinManager.AddFormToManage(this);
    }

    #region Main Page
    private void materialFloatingActionButtonAddEmployee_Click(object sender, EventArgs e)
    {
        this.OpenDialogWithShadow(_serviceProvider.GetRequiredService<AddingEmployeeForm>());
    }
    #endregion
}
