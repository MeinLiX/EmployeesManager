using EmployeesManager.Context;
using EmployeesManager.Views.Page;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views;

public partial class MainForm : MaterialForm
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger _logger;
    private readonly MaterialSkinManager _materialSkinManager;
    private readonly MainCTX _mainCTX;

    public MainForm(IServiceProvider serviceProvider, ILogger<MainForm> logger, MaterialSkinManager materialSkinManager, MainCTX mainCTX)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
        _materialSkinManager = materialSkinManager;
        _mainCTX = mainCTX;
        InitializeComponent();

        _logger.LogInformation($"Session started at {DateTime.UtcNow}");

        _materialSkinManager.AddFormToManage(this);


        pageWithDataGridControlMain.UpServices(_serviceProvider, PageWithDataGridControl.ControlMode.Employees);
        pageWithDataGridControlDepartments.UpServices(_serviceProvider, PageWithDataGridControl.ControlMode.Departments);
        pageWithDataGridControlPositions.UpServices(_serviceProvider, PageWithDataGridControl.ControlMode.Positions);
        payoutsPageControl.UpServices(_serviceProvider);
        reportPageControl.UpServices(_serviceProvider);

        materialTabControl1_SelectedIndexChanged(materialTabControl, null); //invoke to load default tab (main)
    }
    private async void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            switch ((sender as TabControl)?.SelectedIndex)
            {
                case 0:
                    await pageWithDataGridControlMain.UpdateView();
                    break;
                case 1:
                    await pageWithDataGridControlDepartments.UpdateView();
                    break;
                case 2:
                    await pageWithDataGridControlPositions.UpdateView();
                    break;
                case 3:
                    payoutsPageControl.ShowUpdate();
                    break;
                case 4:
                    reportPageControl.ShowUpdate();
                    break;
                default:
                    throw new Exception("Unvaliable page.");
            };
        }
        catch (Exception error)
        {
            new MaterialDialog(this, "Error", error.Message).ShowDialog(this);
        }
    }
}
