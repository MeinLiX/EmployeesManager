namespace EmployeesManager.Views.ModifyWindows.Interfaces;

public interface IEditorForm
{
    void ConfigureEditeMode(Guid ID);

    void BeforeExit();

    void ParseModelToFields();
}
