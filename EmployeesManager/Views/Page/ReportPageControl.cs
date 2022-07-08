using EmployeesManager.Context;
using EmployeesManager.Views.Page.Interfaces;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views.Page;

public partial class ReportPageControl : UserControl, IControllWithServices
{
    private ILogger _logger;
    private MainCTX _mainCTX;

    public ReportPageControl()
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

        return Task.CompletedTask;
    }

    private void ReportPageControl_ClientSizeChanged(object sender, EventArgs e)
    {
        materialComboBoxExportType.Left = (this.ClientSize.Width - materialComboBoxExportType.Width) / 2;
    }

    private async void materialButtonExport_Click(object sender, EventArgs e)
    {
        await (materialComboBoxExportType.SelectedItem switch
        {
            string ext when ext == "*.txt" => exportTXT()
        });
    }

    private async Task exportTXT()
    {
        using SaveFileDialog saveFileDialogExport = new();
        saveFileDialogExport.Title = "Choose file to export";
        saveFileDialogExport.CheckPathExists = true;
        saveFileDialogExport.Filter = "Text Files | *.txt";
        saveFileDialogExport.DefaultExt = "txt";
        saveFileDialogExport.RestoreDirectory = true;
        if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
        {
            using (StreamWriter writer = new(Path.GetFullPath(saveFileDialogExport.FileName), false))
            {
                await _mainCTX.Employees.Include(e => e.Department)
                                        .Include(e => e.Position)
                                        .Include(e => e.Salary)
                                        .ForEachAsync(e =>
                {
                    writer.WriteLine($"{e.GetFullName()}\\{e.Department.Department}\\{e.Position.PositionName}\\{e.Salary.Salary}\\{e.Salary.KPI}\\{e.Salary.GetPremium()}");
                });
            };
            new MaterialSnackBar($"Export successful complete.", 1000).Show(this);
        }
        else
        {
            new MaterialSnackBar($"Export canceled.", 1000).Show(this);
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
}
