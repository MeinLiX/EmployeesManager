using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views;

public partial class AddingEmployeeForm : MaterialForm
{
    private readonly ILogger _logger;
    public AddingEmployeeForm(ILogger<MainForm> logger, MaterialSkinManager materialSkinManager)
    {
        _logger = logger;
        InitializeComponent();

        materialSkinManager.AddFormToManage(this);
    }
}
