using EmployeesManager.Context;
using EmployeesManager.Models;
using EmployeesManager.Views.ModifyWindows.Interfaces;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views.ModifyWindows
{
    public partial class EmployeeEditorForm : MaterialForm, IEditorForm
    {
        private readonly ILogger _logger;
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly MainCTX _mainCTX;

        private EmployeeModel? _employeeModelToEdit;
        public EmployeeEditorForm(ILogger<MainForm> logger, MaterialSkinManager materialSkinManager, MainCTX mainCTX)
        {
            _logger = logger;
            _materialSkinManager = materialSkinManager;
            _mainCTX = mainCTX;

            InitializeComponent();

            _materialSkinManager.AddFormToManage(this);
        }

        public void ConfigureEditeMode(Guid ID)
        {
            _employeeModelToEdit = _mainCTX.Employees.FirstOrDefault(d => d.EmployeeID == ID);

            if (_employeeModelToEdit is null)
                throw new Exception("Not found employee for editing");

            materialButtonCreate.Text = "Update";
            ParseModelToFields();
        }

        public void ParseModelToFields()
        {
        }

        private void materialButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            BeforeExit();

            this.Close();
        }

        private async void materialButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                await (_employeeModelToEdit switch
                {
                    null => CreateModeHendler(),
                    _ => EditModeHendler()
                });
            }
            catch (Exception error)
            {
                new MaterialSnackBar(error.Message, 1000).Show(this);
                return;
            }

            this.DialogResult = DialogResult.OK;
            BeforeExit();
            this.Close();
        }

        private async Task CreateModeHendler()
        {
            EmployeeModel employeesToCreate = new()
            {
                //TODO
            };

            validateFields(employeesToCreate);

            await _mainCTX.Employees.AddAsync(employeesToCreate);
            await _mainCTX.SaveChangesAsync();
        }

        private async Task EditModeHendler()
        {
            validateFields(_employeeModelToEdit);
            await _mainCTX.SaveChangesAsync();
        }

        private void validateFields(EmployeeModel model)
        {

        }

        public void BeforeExit()
        {
            _employeeModelToEdit = null;
            materialButtonCreate.Text = "Create";
        }

        private void materialTextBoxEmployeeSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
