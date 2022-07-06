using EmployeesManager.Views;
using MaterialSkin;
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
                .AddSingleton<MainForm>()
                .AddSingleton<AddingEmployeeForm>()
                .AddSingleton(x => MaterialSkinManager.Instance);

        return services.BuildServiceProvider();
    }

    private static void ConfigureMaterialSkin(MaterialSkinManager materialSkinManager)
    {
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey300, Primary.BlueGrey500, Primary.BlueGrey100, Accent.LightBlue100, TextShade.WHITE);
    }
}
