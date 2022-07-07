using EmployeesManager.Context;
using EmployeesManager.Views;
using EmployeesManager.Views.ModifyWindows;
using MaterialSkin;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeesManager;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using ServiceProvider serviceProvider = ConfigureServices(new ServiceCollection());

        ConfigureMaterialSkin(serviceProvider.GetRequiredService<MaterialSkinManager>());

        Application.Run(serviceProvider.GetRequiredService<MainForm>());
    }

    private static ServiceProvider ConfigureServices(ServiceCollection services)
    {
        services.AddLogging(configure => configure.AddConsole())
                .AddDbContext<MainCTX>(options => options.UseSqlite("Filename=MainCTX.db")) // It would be possible to export it to the configuration file, but not today...
                .AddSingleton(x => MaterialSkinManager.Instance)
                .AddSingleton<MainForm>()
                .AddSingleton<DepartmentEditorForm>()
                .AddSingleton<EmployeeEditorForm>()
                .AddSingleton<PositionEditorForm>();


        return services.BuildServiceProvider();
    }

    private static void ConfigureMaterialSkin(MaterialSkinManager materialSkinManager)
    {
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey300, Primary.BlueGrey500, Primary.BlueGrey100, Accent.LightBlue100, TextShade.WHITE);
    }
}
