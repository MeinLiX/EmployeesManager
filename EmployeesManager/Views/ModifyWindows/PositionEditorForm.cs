using EmployeesManager.Context;
using EmployeesManager.Models;
using EmployeesManager.Views.ModifyWindows.Interfaces;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;

namespace EmployeesManager.Views.ModifyWindows
{
    public partial class PositionEditorForm : MaterialForm, IEditorForm
    {
        private readonly ILogger _logger;
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly MainCTX _mainCTX;

        private PositionModel? _positionModelToEdit;

        public PositionEditorForm(ILogger<MainForm> logger, MaterialSkinManager materialSkinManager, MainCTX mainCTX)
        {
            _logger = logger;
            _materialSkinManager = materialSkinManager;
            _mainCTX = mainCTX;

            InitializeComponent();

            _materialSkinManager.AddFormToManage(this);
        }

        public void ConfigureEditeMode(Guid ID)
        {
            _positionModelToEdit = _mainCTX.Positions.FirstOrDefault(p => p.PositionID == ID);

            if (_positionModelToEdit is null)
                throw new Exception("Not found possition for editing");

            materialButtonCreate.Text = "Update";
            ParseModelToFields();
        }

        public void ParseModelToFields()
        {
            materialTextBoxPositionName.Text = _positionModelToEdit.PositionName;
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
                await (_positionModelToEdit switch
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
            PositionModel positionToCreate = new()
            {
                PositionName = materialTextBoxPositionName.Text.Trim()
            };

            validateFields(positionToCreate);

            await _mainCTX.Positions.AddAsync(positionToCreate);
            await _mainCTX.SaveChangesAsync();
        }

        private async Task EditModeHendler()
        {
            _positionModelToEdit.PositionName = materialTextBoxPositionName.Text.Trim();

            validateFields(_positionModelToEdit);

            await _mainCTX.SaveChangesAsync();
        }

        private void validateFields(PositionModel model)
        {
            if (string.IsNullOrEmpty(model.PositionName))
                throw new Exception("Incorrect `Position name`.");
        }

        public void BeforeExit()
        {
            materialTextBoxPositionName.Clear();

            _positionModelToEdit = null;
            materialButtonCreate.Text = "Create";
        }
    }
}
