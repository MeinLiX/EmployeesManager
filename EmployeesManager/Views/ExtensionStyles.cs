using MaterialSkin.Controls;

namespace EmployeesManager.Views;
public static class ExtensionStyle
{
    public static DialogResult OpenDialogWithShadow(this MaterialForm ParentForm, MaterialForm toOpenForm)
    {
        Form _formOverlay = new()
        {
            BackColor = Color.Black,
            Opacity = 0.5,
            MinimizeBox = false,
            MaximizeBox = false,
            Text = "",
            ShowIcon = false,
            ControlBox = false,
            FormBorderStyle = FormBorderStyle.None,
            Size = new Size(ParentForm.Width, ParentForm.Height),
            ShowInTaskbar = false,
            Owner = ParentForm,
            Visible = true,
            Location = new Point(ParentForm.Location.X, ParentForm.Location.Y),
            Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)
        };

        DialogResult dialogResult = toOpenForm.ShowDialog(ParentForm);

        _formOverlay.Visible = false;
        _formOverlay.Close();
        _formOverlay.Dispose();

        return dialogResult;
    }
}
