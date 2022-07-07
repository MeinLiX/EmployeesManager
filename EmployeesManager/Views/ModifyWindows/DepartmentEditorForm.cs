using EmployeesManager.Context;
using EmployeesManager.Models;
using EmployeesManager.Views.ModifyWindows.Interfaces;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views.ModifyWindows
{
    public partial class DepartmentEditorForm : MaterialForm, IEditorForm
    {
        private readonly ILogger _logger;
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly MainCTX _mainCTX;

        private DepartmentModel? _departmentModelToEdit;

        public DepartmentEditorForm(ILogger<MainForm> logger, MaterialSkinManager materialSkinManager, MainCTX mainCTX)
        {
            _logger = logger;
            _materialSkinManager = materialSkinManager;
            _mainCTX = mainCTX;

            InitializeComponent();

            _materialSkinManager.AddFormToManage(this);
        }

        public void ConfigureEditeMode(Guid ID)
        {
            _departmentModelToEdit = _mainCTX.Departments.FirstOrDefault(d => d.DepartmentID == ID);

            if (_departmentModelToEdit is null)
                throw new Exception("Not found department for editing");

            materialButtonCreate.Text = "Update";
            ParseModelToFields();
        }

        public void ParseModelToFields()
        {
            materialTextBoxDepartmentName.Text = _departmentModelToEdit.Department;
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
                await (_departmentModelToEdit switch
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
            DepartmentModel departmentToCreate = new()
            {
                Department = materialTextBoxDepartmentName.Text.Trim()
            };

            validateFields(departmentToCreate);

            await _mainCTX.Departments.AddAsync(departmentToCreate);
            await _mainCTX.SaveChangesAsync();
        }

        private async Task EditModeHendler()
        {
            _departmentModelToEdit.Department = materialTextBoxDepartmentName.Text.Trim();

            validateFields(_departmentModelToEdit);
            await _mainCTX.SaveChangesAsync();
        }

        private void validateFields(DepartmentModel model)
        {
            if (string.IsNullOrEmpty(model.Department))
                throw new Exception("Incorrect `Department name`.");
        }

        public void BeforeExit()
        {
            materialTextBoxDepartmentName.Clear();

            _departmentModelToEdit = null;
            materialButtonCreate.Text = "Create";
        }
    }
}
