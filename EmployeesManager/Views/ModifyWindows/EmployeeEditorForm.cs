using EmployeesManager.Context;
using EmployeesManager.Models;
using EmployeesManager.Views.ModifyWindows.Interfaces;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
            _employeeModelToEdit = _mainCTX.Employees.Where(e => e.EmployeeID == ID)
                                                     .Include(e => e.Department)
                                                     .Include(e => e.Position)
                                                     .FirstOrDefault();

            if (_employeeModelToEdit is null)
                throw new Exception("Not found employee for editing");

            materialButtonCreate.Text = "Update";

            LoadComboBoxes();

            ParseModelToFields();
        }

        public void ParseModelToFields()
        {
            materialTextBoxEmployeeFirstName.Text = _employeeModelToEdit.FirstName;
            materialTextBoxEmployeeLastName.Text = _employeeModelToEdit.LastName;
            materialTextBoxEmployeePatronymic.Text = _employeeModelToEdit.Patronymic;

            materialTextBoxEmployeeHomeAdress.Text = _employeeModelToEdit.HomeAddress;
            materialMaskedTextBoxEmployeePhoneNumber.Text = _employeeModelToEdit.PhoneNumber;
            materialComboBoxEmployeeDepartment.SelectedItem = (materialComboBoxEmployeeDepartment.DataSource as List<KeyValuePair<DepartmentModel, string>>)?.FirstOrDefault(ds => ds.Key.DepartmentID == _employeeModelToEdit.Department.DepartmentID) ?? throw new Exception("Department not found"); //new KeyValuePair<DepartmentModel, string>(_employeeModelToEdit.Department, _employeeModelToEdit.Department.Department);

            materialTextBoxEmployeeSalary.Text = _employeeModelToEdit.Salary.Salary.ToString();
            materialComboBoxEmployeeKPI.Text = _employeeModelToEdit.Salary.KPI;
            materialComboBoxEmployeePosition.SelectedItem = (materialComboBoxEmployeePosition.DataSource as List<KeyValuePair<PositionModel, string>>)?.FirstOrDefault(ds => ds.Key.PositionID == _employeeModelToEdit.Position.PositionID) ?? throw new Exception("Position not found"); //new KeyValuePair<PositionModel, string>(_employeeModelToEdit.Position, _employeeModelToEdit.Position.PositionName);
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
                FirstName = materialTextBoxEmployeeFirstName.Text.Trim(),
                LastName = materialTextBoxEmployeeLastName.Text.Trim(),
                Patronymic = materialTextBoxEmployeePatronymic.Text.Trim(),

                HomeAddress = materialTextBoxEmployeeHomeAdress.Text.Trim(),
                PhoneNumber = materialMaskedTextBoxEmployeePhoneNumber.Text.Trim(),
                Department = ((KeyValuePair<DepartmentModel, string>)materialComboBoxEmployeeDepartment.SelectedItem).Key,

                Salary = new()
                {
                    Salary = decimal.Parse(materialTextBoxEmployeeSalary.Text),
                    KPI = materialComboBoxEmployeeKPI.Text
                },
                Position = ((KeyValuePair<PositionModel, string>)materialComboBoxEmployeePosition.SelectedItem).Key
            };

            validateFields(employeesToCreate);

            await _mainCTX.Employees.AddAsync(employeesToCreate);
            await _mainCTX.SaveChangesAsync();
        }

        private async Task EditModeHendler()
        {
            _employeeModelToEdit.FirstName = materialTextBoxEmployeeFirstName.Text.Trim();
            _employeeModelToEdit.LastName = materialTextBoxEmployeeLastName.Text.Trim();
            _employeeModelToEdit.Patronymic = materialTextBoxEmployeePatronymic.Text.Trim();

            _employeeModelToEdit.HomeAddress = materialTextBoxEmployeeHomeAdress.Text.Trim();
            _employeeModelToEdit.PhoneNumber = materialMaskedTextBoxEmployeePhoneNumber.Text.Trim();
            _employeeModelToEdit.Department = ((KeyValuePair<DepartmentModel, string>)materialComboBoxEmployeeDepartment.SelectedItem).Key;

            _employeeModelToEdit.Salary.Salary = decimal.Parse(materialTextBoxEmployeeSalary.Text);
            _employeeModelToEdit.Salary.KPI = materialComboBoxEmployeeKPI.Text;
            _employeeModelToEdit.Position = ((KeyValuePair<PositionModel, string>)materialComboBoxEmployeePosition.SelectedItem).Key;

            validateFields(_employeeModelToEdit);
            await _mainCTX.SaveChangesAsync();
        }

        private void validateFields(EmployeeModel model)
        {

        }

        public void BeforeExit()
        {
            materialTextBoxEmployeeFirstName.Clear();
            materialTextBoxEmployeeLastName.Clear();
            materialTextBoxEmployeePatronymic.Clear();

            materialTextBoxEmployeeHomeAdress.Clear();
            materialMaskedTextBoxEmployeePhoneNumber.Clear();
            materialComboBoxEmployeeDepartment.DataSource = null;

            materialTextBoxEmployeeSalary.Clear();
            materialComboBoxEmployeeKPI.SelectedIndex = 0;
            materialComboBoxEmployeePosition.DataSource = null;

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

        private void EmployeeEditorForm_Load(object sender, EventArgs e)
        {
            if(materialComboBoxEmployeeDepartment.DataSource is null || materialComboBoxEmployeePosition.DataSource is null)
            {
                LoadComboBoxes();
            }
        }

        private void LoadComboBoxes()
        {
            var avaliableDepartments = _mainCTX.Departments.Select(d => new KeyValuePair<DepartmentModel, string>(d, d.Department)).ToList();
            var avaliablePositions = _mainCTX.Positions.Select(p => new KeyValuePair<PositionModel, string>(p, p.PositionName)).ToList();

            materialComboBoxEmployeeDepartment.DisplayMember = "Value";
            materialComboBoxEmployeeDepartment.SelectedValue = "Key";
            materialComboBoxEmployeeDepartment.DataSource = avaliableDepartments;

            materialComboBoxEmployeePosition.DisplayMember = "Value";
            materialComboBoxEmployeePosition.SelectedValue = "Key";
            materialComboBoxEmployeePosition.DataSource = avaliablePositions;
        }
    }
}
