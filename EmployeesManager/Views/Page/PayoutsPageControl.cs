using EmployeesManager.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views.Page;

public partial class PayoutsPageControl : UserControl
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

    public void ShowUpdate()
    {
        CheckServices();
    }
}
