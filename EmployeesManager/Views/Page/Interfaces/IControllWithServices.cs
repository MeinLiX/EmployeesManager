
namespace EmployeesManager.Views.Page.Interfaces;

public interface IControllWithServices
{
    public void UpServices(IServiceProvider serviceProvider);
    public Task UpdateView();
}
