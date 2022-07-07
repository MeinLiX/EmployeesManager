namespace EmployeesManager.Views.ModifyWindows
{
    partial class EmployeeEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabelHeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialCardHeader = new MaterialSkin.Controls.MaterialCard();
            this.materialCardFoother = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonCreate = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelEmployeeFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxEmployeeFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabelEmployeeLastName = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxEmployeeLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabelEmployeePatronymic = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxEmployeePatronymic = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBoxEmployeeDeportment = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabelEmployeeDepartment = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelEmployeePosition = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxEmployeePosition = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabelEmployeeSalary = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxEmployeeKPI = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabelEmployeeKPI = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelEmployeePhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxEmployeeHomeAdress = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabelEmployeeHomeAdress = new MaterialSkin.Controls.MaterialLabel();
            this.materialMaskedTextBoxEmployeePhoneNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialTextBoxEmployeeSalary = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCardHeader.SuspendLayout();
            this.materialCardFoother.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabelHeader
            // 
            this.materialLabelHeader.AutoSize = true;
            this.materialLabelHeader.Depth = 0;
            this.materialLabelHeader.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelHeader.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabelHeader.Location = new System.Drawing.Point(17, 14);
            this.materialLabelHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHeader.Name = "materialLabelHeader";
            this.materialLabelHeader.Size = new System.Drawing.Size(145, 24);
            this.materialLabelHeader.TabIndex = 1;
            this.materialLabelHeader.Text = "Employee editor";
            // 
            // materialCardHeader
            // 
            this.materialCardHeader.AutoSize = true;
            this.materialCardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHeader.Controls.Add(this.materialLabelHeader);
            this.materialCardHeader.Depth = 0;
            this.materialCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCardHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHeader.Location = new System.Drawing.Point(3, 0);
            this.materialCardHeader.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHeader.Name = "materialCardHeader";
            this.materialCardHeader.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHeader.Size = new System.Drawing.Size(549, 52);
            this.materialCardHeader.TabIndex = 0;
            // 
            // materialCardFoother
            // 
            this.materialCardFoother.AutoSize = true;
            this.materialCardFoother.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardFoother.Controls.Add(this.materialButtonCancel);
            this.materialCardFoother.Controls.Add(this.materialButtonCreate);
            this.materialCardFoother.Depth = 0;
            this.materialCardFoother.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialCardFoother.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardFoother.Location = new System.Drawing.Point(3, 275);
            this.materialCardFoother.Margin = new System.Windows.Forms.Padding(10);
            this.materialCardFoother.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardFoother.Name = "materialCardFoother";
            this.materialCardFoother.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.materialCardFoother.Size = new System.Drawing.Size(549, 59);
            this.materialCardFoother.TabIndex = 3;
            // 
            // materialButtonCancel
            // 
            this.materialButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCancel.Depth = 0;
            this.materialButtonCancel.HighEmphasis = true;
            this.materialButtonCancel.Icon = null;
            this.materialButtonCancel.Location = new System.Drawing.Point(454, 12);
            this.materialButtonCancel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.materialButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCancel.Name = "materialButtonCancel";
            this.materialButtonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCancel.Size = new System.Drawing.Size(77, 36);
            this.materialButtonCancel.TabIndex = 1;
            this.materialButtonCancel.Text = "Cancel";
            this.materialButtonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonCancel.UseAccentColor = false;
            this.materialButtonCancel.UseVisualStyleBackColor = true;
            this.materialButtonCancel.Click += new System.EventHandler(this.materialButtonCancel_Click);
            // 
            // materialButtonCreate
            // 
            this.materialButtonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCreate.Depth = 0;
            this.materialButtonCreate.HighEmphasis = true;
            this.materialButtonCreate.Icon = null;
            this.materialButtonCreate.Location = new System.Drawing.Point(366, 12);
            this.materialButtonCreate.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.materialButtonCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCreate.Name = "materialButtonCreate";
            this.materialButtonCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCreate.Size = new System.Drawing.Size(76, 36);
            this.materialButtonCreate.TabIndex = 0;
            this.materialButtonCreate.Text = "Create";
            this.materialButtonCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonCreate.UseAccentColor = true;
            this.materialButtonCreate.UseVisualStyleBackColor = true;
            this.materialButtonCreate.Click += new System.EventHandler(this.materialButtonCreate_Click);
            // 
            // materialLabelEmployeeFirstName
            // 
            this.materialLabelEmployeeFirstName.AutoSize = true;
            this.materialLabelEmployeeFirstName.Depth = 0;
            this.materialLabelEmployeeFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeeFirstName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeeFirstName.Location = new System.Drawing.Point(21, 64);
            this.materialLabelEmployeeFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeeFirstName.Name = "materialLabelEmployeeFirstName";
            this.materialLabelEmployeeFirstName.Size = new System.Drawing.Size(78, 19);
            this.materialLabelEmployeeFirstName.TabIndex = 7;
            this.materialLabelEmployeeFirstName.Text = "First Name";
            // 
            // materialTextBoxEmployeeFirstName
            // 
            this.materialTextBoxEmployeeFirstName.AnimateReadOnly = false;
            this.materialTextBoxEmployeeFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxEmployeeFirstName.Depth = 0;
            this.materialTextBoxEmployeeFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxEmployeeFirstName.Hint = "Type First Name";
            this.materialTextBoxEmployeeFirstName.LeadingIcon = null;
            this.materialTextBoxEmployeeFirstName.Location = new System.Drawing.Point(22, 86);
            this.materialTextBoxEmployeeFirstName.MaxLength = 64;
            this.materialTextBoxEmployeeFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxEmployeeFirstName.Multiline = false;
            this.materialTextBoxEmployeeFirstName.Name = "materialTextBoxEmployeeFirstName";
            this.materialTextBoxEmployeeFirstName.Size = new System.Drawing.Size(167, 36);
            this.materialTextBoxEmployeeFirstName.TabIndex = 6;
            this.materialTextBoxEmployeeFirstName.Text = "";
            this.materialTextBoxEmployeeFirstName.TrailingIcon = null;
            this.materialTextBoxEmployeeFirstName.UseTallSize = false;
            // 
            // materialLabelEmployeeLastName
            // 
            this.materialLabelEmployeeLastName.AutoSize = true;
            this.materialLabelEmployeeLastName.Depth = 0;
            this.materialLabelEmployeeLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeeLastName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeeLastName.Location = new System.Drawing.Point(194, 64);
            this.materialLabelEmployeeLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeeLastName.Name = "materialLabelEmployeeLastName";
            this.materialLabelEmployeeLastName.Size = new System.Drawing.Size(78, 19);
            this.materialLabelEmployeeLastName.TabIndex = 9;
            this.materialLabelEmployeeLastName.Text = "Last Name";
            // 
            // materialTextBoxEmployeeLastName
            // 
            this.materialTextBoxEmployeeLastName.AnimateReadOnly = false;
            this.materialTextBoxEmployeeLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxEmployeeLastName.Depth = 0;
            this.materialTextBoxEmployeeLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxEmployeeLastName.Hint = "Type Last Name";
            this.materialTextBoxEmployeeLastName.LeadingIcon = null;
            this.materialTextBoxEmployeeLastName.Location = new System.Drawing.Point(194, 86);
            this.materialTextBoxEmployeeLastName.MaxLength = 64;
            this.materialTextBoxEmployeeLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxEmployeeLastName.Multiline = false;
            this.materialTextBoxEmployeeLastName.Name = "materialTextBoxEmployeeLastName";
            this.materialTextBoxEmployeeLastName.Size = new System.Drawing.Size(167, 36);
            this.materialTextBoxEmployeeLastName.TabIndex = 8;
            this.materialTextBoxEmployeeLastName.Text = "";
            this.materialTextBoxEmployeeLastName.TrailingIcon = null;
            this.materialTextBoxEmployeeLastName.UseTallSize = false;
            // 
            // materialLabelEmployeePatronymic
            // 
            this.materialLabelEmployeePatronymic.AutoSize = true;
            this.materialLabelEmployeePatronymic.Depth = 0;
            this.materialLabelEmployeePatronymic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeePatronymic.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeePatronymic.Location = new System.Drawing.Point(367, 64);
            this.materialLabelEmployeePatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeePatronymic.Name = "materialLabelEmployeePatronymic";
            this.materialLabelEmployeePatronymic.Size = new System.Drawing.Size(82, 19);
            this.materialLabelEmployeePatronymic.TabIndex = 11;
            this.materialLabelEmployeePatronymic.Text = "Patronymic";
            // 
            // materialTextBoxEmployeePatronymic
            // 
            this.materialTextBoxEmployeePatronymic.AnimateReadOnly = false;
            this.materialTextBoxEmployeePatronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxEmployeePatronymic.Depth = 0;
            this.materialTextBoxEmployeePatronymic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxEmployeePatronymic.Hint = "Type Patronymic";
            this.materialTextBoxEmployeePatronymic.LeadingIcon = null;
            this.materialTextBoxEmployeePatronymic.Location = new System.Drawing.Point(369, 86);
            this.materialTextBoxEmployeePatronymic.MaxLength = 64;
            this.materialTextBoxEmployeePatronymic.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxEmployeePatronymic.Multiline = false;
            this.materialTextBoxEmployeePatronymic.Name = "materialTextBoxEmployeePatronymic";
            this.materialTextBoxEmployeePatronymic.Size = new System.Drawing.Size(165, 36);
            this.materialTextBoxEmployeePatronymic.TabIndex = 10;
            this.materialTextBoxEmployeePatronymic.Text = "";
            this.materialTextBoxEmployeePatronymic.TrailingIcon = null;
            this.materialTextBoxEmployeePatronymic.UseTallSize = false;
            // 
            // materialComboBoxEmployeeDeportment
            // 
            this.materialComboBoxEmployeeDeportment.AutoResize = false;
            this.materialComboBoxEmployeeDeportment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxEmployeeDeportment.Depth = 0;
            this.materialComboBoxEmployeeDeportment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxEmployeeDeportment.DropDownHeight = 118;
            this.materialComboBoxEmployeeDeportment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxEmployeeDeportment.DropDownWidth = 121;
            this.materialComboBoxEmployeeDeportment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxEmployeeDeportment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxEmployeeDeportment.FormattingEnabled = true;
            this.materialComboBoxEmployeeDeportment.Hint = "Select Department";
            this.materialComboBoxEmployeeDeportment.IntegralHeight = false;
            this.materialComboBoxEmployeeDeportment.ItemHeight = 29;
            this.materialComboBoxEmployeeDeportment.Location = new System.Drawing.Point(367, 160);
            this.materialComboBoxEmployeeDeportment.MaxDropDownItems = 4;
            this.materialComboBoxEmployeeDeportment.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployeeDeportment.Name = "materialComboBoxEmployeeDeportment";
            this.materialComboBoxEmployeeDeportment.Size = new System.Drawing.Size(167, 35);
            this.materialComboBoxEmployeeDeportment.StartIndex = 0;
            this.materialComboBoxEmployeeDeportment.TabIndex = 12;
            this.materialComboBoxEmployeeDeportment.UseTallSize = false;
            // 
            // materialLabelEmployeeDepartment
            // 
            this.materialLabelEmployeeDepartment.AutoSize = true;
            this.materialLabelEmployeeDepartment.Depth = 0;
            this.materialLabelEmployeeDepartment.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeeDepartment.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeeDepartment.Location = new System.Drawing.Point(368, 138);
            this.materialLabelEmployeeDepartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeeDepartment.Name = "materialLabelEmployeeDepartment";
            this.materialLabelEmployeeDepartment.Size = new System.Drawing.Size(84, 19);
            this.materialLabelEmployeeDepartment.TabIndex = 13;
            this.materialLabelEmployeeDepartment.Text = "Department";
            // 
            // materialLabelEmployeePosition
            // 
            this.materialLabelEmployeePosition.AutoSize = true;
            this.materialLabelEmployeePosition.Depth = 0;
            this.materialLabelEmployeePosition.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeePosition.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeePosition.Location = new System.Drawing.Point(369, 208);
            this.materialLabelEmployeePosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeePosition.Name = "materialLabelEmployeePosition";
            this.materialLabelEmployeePosition.Size = new System.Drawing.Size(59, 19);
            this.materialLabelEmployeePosition.TabIndex = 15;
            this.materialLabelEmployeePosition.Text = "Position";
            // 
            // materialComboBoxEmployeePosition
            // 
            this.materialComboBoxEmployeePosition.AutoResize = false;
            this.materialComboBoxEmployeePosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxEmployeePosition.Depth = 0;
            this.materialComboBoxEmployeePosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxEmployeePosition.DropDownHeight = 118;
            this.materialComboBoxEmployeePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxEmployeePosition.DropDownWidth = 121;
            this.materialComboBoxEmployeePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxEmployeePosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxEmployeePosition.FormattingEnabled = true;
            this.materialComboBoxEmployeePosition.Hint = "Select Position";
            this.materialComboBoxEmployeePosition.IntegralHeight = false;
            this.materialComboBoxEmployeePosition.ItemHeight = 29;
            this.materialComboBoxEmployeePosition.Location = new System.Drawing.Point(368, 231);
            this.materialComboBoxEmployeePosition.MaxDropDownItems = 4;
            this.materialComboBoxEmployeePosition.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployeePosition.Name = "materialComboBoxEmployeePosition";
            this.materialComboBoxEmployeePosition.Size = new System.Drawing.Size(167, 35);
            this.materialComboBoxEmployeePosition.StartIndex = 0;
            this.materialComboBoxEmployeePosition.TabIndex = 14;
            this.materialComboBoxEmployeePosition.UseTallSize = false;
            // 
            // materialLabelEmployeeSalary
            // 
            this.materialLabelEmployeeSalary.AutoSize = true;
            this.materialLabelEmployeeSalary.Depth = 0;
            this.materialLabelEmployeeSalary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeeSalary.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeeSalary.Location = new System.Drawing.Point(23, 208);
            this.materialLabelEmployeeSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeeSalary.Name = "materialLabelEmployeeSalary";
            this.materialLabelEmployeeSalary.Size = new System.Drawing.Size(46, 19);
            this.materialLabelEmployeeSalary.TabIndex = 17;
            this.materialLabelEmployeeSalary.Text = "Salary";
            // 
            // materialComboBoxEmployeeKPI
            // 
            this.materialComboBoxEmployeeKPI.AutoResize = false;
            this.materialComboBoxEmployeeKPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxEmployeeKPI.Depth = 0;
            this.materialComboBoxEmployeeKPI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxEmployeeKPI.DropDownHeight = 118;
            this.materialComboBoxEmployeeKPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxEmployeeKPI.DropDownWidth = 121;
            this.materialComboBoxEmployeeKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxEmployeeKPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxEmployeeKPI.FormattingEnabled = true;
            this.materialComboBoxEmployeeKPI.Hint = "Select KPI";
            this.materialComboBoxEmployeeKPI.IntegralHeight = false;
            this.materialComboBoxEmployeeKPI.ItemHeight = 29;
            this.materialComboBoxEmployeeKPI.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.materialComboBoxEmployeeKPI.Location = new System.Drawing.Point(145, 231);
            this.materialComboBoxEmployeeKPI.MaxDropDownItems = 4;
            this.materialComboBoxEmployeeKPI.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployeeKPI.Name = "materialComboBoxEmployeeKPI";
            this.materialComboBoxEmployeeKPI.Size = new System.Drawing.Size(67, 35);
            this.materialComboBoxEmployeeKPI.StartIndex = 0;
            this.materialComboBoxEmployeeKPI.TabIndex = 14;
            this.materialComboBoxEmployeeKPI.UseTallSize = false;
            // 
            // materialLabelEmployeeKPI
            // 
            this.materialLabelEmployeeKPI.AutoSize = true;
            this.materialLabelEmployeeKPI.Depth = 0;
            this.materialLabelEmployeeKPI.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeeKPI.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeeKPI.Location = new System.Drawing.Point(146, 209);
            this.materialLabelEmployeeKPI.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeeKPI.Name = "materialLabelEmployeeKPI";
            this.materialLabelEmployeeKPI.Size = new System.Drawing.Size(25, 19);
            this.materialLabelEmployeeKPI.TabIndex = 15;
            this.materialLabelEmployeeKPI.Text = "KPI";
            // 
            // materialLabelEmployeePhoneNumber
            // 
            this.materialLabelEmployeePhoneNumber.AutoSize = true;
            this.materialLabelEmployeePhoneNumber.Depth = 0;
            this.materialLabelEmployeePhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeePhoneNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeePhoneNumber.Location = new System.Drawing.Point(195, 135);
            this.materialLabelEmployeePhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeePhoneNumber.Name = "materialLabelEmployeePhoneNumber";
            this.materialLabelEmployeePhoneNumber.Size = new System.Drawing.Size(106, 19);
            this.materialLabelEmployeePhoneNumber.TabIndex = 7;
            this.materialLabelEmployeePhoneNumber.Text = "Phone Number";
            // 
            // materialTextBoxEmployeeHomeAdress
            // 
            this.materialTextBoxEmployeeHomeAdress.AnimateReadOnly = false;
            this.materialTextBoxEmployeeHomeAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxEmployeeHomeAdress.Depth = 0;
            this.materialTextBoxEmployeeHomeAdress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxEmployeeHomeAdress.Hint = "Type Home Adress";
            this.materialTextBoxEmployeeHomeAdress.LeadingIcon = null;
            this.materialTextBoxEmployeeHomeAdress.Location = new System.Drawing.Point(22, 159);
            this.materialTextBoxEmployeeHomeAdress.MaxLength = 64;
            this.materialTextBoxEmployeeHomeAdress.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxEmployeeHomeAdress.Multiline = false;
            this.materialTextBoxEmployeeHomeAdress.Name = "materialTextBoxEmployeeHomeAdress";
            this.materialTextBoxEmployeeHomeAdress.Size = new System.Drawing.Size(167, 36);
            this.materialTextBoxEmployeeHomeAdress.TabIndex = 6;
            this.materialTextBoxEmployeeHomeAdress.Text = "";
            this.materialTextBoxEmployeeHomeAdress.TrailingIcon = null;
            this.materialTextBoxEmployeeHomeAdress.UseTallSize = false;
            // 
            // materialLabelEmployeeHomeAdress
            // 
            this.materialLabelEmployeeHomeAdress.AutoSize = true;
            this.materialLabelEmployeeHomeAdress.Depth = 0;
            this.materialLabelEmployeeHomeAdress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelEmployeeHomeAdress.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelEmployeeHomeAdress.Location = new System.Drawing.Point(22, 136);
            this.materialLabelEmployeeHomeAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmployeeHomeAdress.Name = "materialLabelEmployeeHomeAdress";
            this.materialLabelEmployeeHomeAdress.Size = new System.Drawing.Size(95, 19);
            this.materialLabelEmployeeHomeAdress.TabIndex = 7;
            this.materialLabelEmployeeHomeAdress.Text = "Home Adress";
            // 
            // materialMaskedTextBoxEmployeePhoneNumber
            // 
            this.materialMaskedTextBoxEmployeePhoneNumber.AllowPromptAsInput = true;
            this.materialMaskedTextBoxEmployeePhoneNumber.AnimateReadOnly = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.AsciiOnly = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxEmployeePhoneNumber.BeepOnError = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxEmployeePhoneNumber.Depth = 0;
            this.materialMaskedTextBoxEmployeePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxEmployeePhoneNumber.HidePromptOnLeave = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.HideSelection = true;
            this.materialMaskedTextBoxEmployeePhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxEmployeePhoneNumber.LeadingIcon = null;
            this.materialMaskedTextBoxEmployeePhoneNumber.Location = new System.Drawing.Point(195, 158);
            this.materialMaskedTextBoxEmployeePhoneNumber.Mask = "+(000)000000000";
            this.materialMaskedTextBoxEmployeePhoneNumber.MaxLength = 32767;
            this.materialMaskedTextBoxEmployeePhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxEmployeePhoneNumber.Name = "materialMaskedTextBoxEmployeePhoneNumber";
            this.materialMaskedTextBoxEmployeePhoneNumber.PasswordChar = '\0';
            this.materialMaskedTextBoxEmployeePhoneNumber.PrefixSuffixText = null;
            this.materialMaskedTextBoxEmployeePhoneNumber.PromptChar = '_';
            this.materialMaskedTextBoxEmployeePhoneNumber.ReadOnly = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.ResetOnPrompt = true;
            this.materialMaskedTextBoxEmployeePhoneNumber.ResetOnSpace = true;
            this.materialMaskedTextBoxEmployeePhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxEmployeePhoneNumber.SelectedText = "";
            this.materialMaskedTextBoxEmployeePhoneNumber.SelectionLength = 0;
            this.materialMaskedTextBoxEmployeePhoneNumber.SelectionStart = 0;
            this.materialMaskedTextBoxEmployeePhoneNumber.ShortcutsEnabled = true;
            this.materialMaskedTextBoxEmployeePhoneNumber.Size = new System.Drawing.Size(166, 36);
            this.materialMaskedTextBoxEmployeePhoneNumber.SkipLiterals = true;
            this.materialMaskedTextBoxEmployeePhoneNumber.TabIndex = 18;
            this.materialMaskedTextBoxEmployeePhoneNumber.TabStop = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.Text = "+(   )";
            this.materialMaskedTextBoxEmployeePhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxEmployeePhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxEmployeePhoneNumber.TrailingIcon = null;
            this.materialMaskedTextBoxEmployeePhoneNumber.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.UseTallSize = false;
            this.materialMaskedTextBoxEmployeePhoneNumber.ValidatingType = null;
            // 
            // materialTextBoxEmployeeSalary
            // 
            this.materialTextBoxEmployeeSalary.AnimateReadOnly = false;
            this.materialTextBoxEmployeeSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxEmployeeSalary.Depth = 0;
            this.materialTextBoxEmployeeSalary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxEmployeeSalary.Hint = "Enter Salary";
            this.materialTextBoxEmployeeSalary.LeadingIcon = null;
            this.materialTextBoxEmployeeSalary.Location = new System.Drawing.Point(23, 231);
            this.materialTextBoxEmployeeSalary.MaxLength = 64;
            this.materialTextBoxEmployeeSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxEmployeeSalary.Multiline = false;
            this.materialTextBoxEmployeeSalary.Name = "materialTextBoxEmployeeSalary";
            this.materialTextBoxEmployeeSalary.Size = new System.Drawing.Size(116, 36);
            this.materialTextBoxEmployeeSalary.TabIndex = 6;
            this.materialTextBoxEmployeeSalary.Text = "";
            this.materialTextBoxEmployeeSalary.TrailingIcon = null;
            this.materialTextBoxEmployeeSalary.UseTallSize = false;
            this.materialTextBoxEmployeeSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxEmployeeSalary_KeyPress);
            // 
            // AddingEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 337);
            this.Controls.Add(this.materialMaskedTextBoxEmployeePhoneNumber);
            this.Controls.Add(this.materialLabelEmployeeSalary);
            this.Controls.Add(this.materialLabelEmployeeKPI);
            this.Controls.Add(this.materialLabelEmployeePosition);
            this.Controls.Add(this.materialComboBoxEmployeeKPI);
            this.Controls.Add(this.materialComboBoxEmployeePosition);
            this.Controls.Add(this.materialLabelEmployeeDepartment);
            this.Controls.Add(this.materialComboBoxEmployeeDeportment);
            this.Controls.Add(this.materialLabelEmployeePatronymic);
            this.Controls.Add(this.materialTextBoxEmployeePatronymic);
            this.Controls.Add(this.materialLabelEmployeeLastName);
            this.Controls.Add(this.materialTextBoxEmployeeLastName);
            this.Controls.Add(this.materialLabelEmployeeHomeAdress);
            this.Controls.Add(this.materialLabelEmployeePhoneNumber);
            this.Controls.Add(this.materialLabelEmployeeFirstName);
            this.Controls.Add(this.materialTextBoxEmployeeSalary);
            this.Controls.Add(this.materialTextBoxEmployeeHomeAdress);
            this.Controls.Add(this.materialTextBoxEmployeeFirstName);
            this.Controls.Add(this.materialCardFoother);
            this.Controls.Add(this.materialCardHeader);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "AddingEmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddingDepartmentForm";
            this.materialCardHeader.ResumeLayout(false);
            this.materialCardHeader.PerformLayout();
            this.materialCardFoother.ResumeLayout(false);
            this.materialCardFoother.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabelHeader;
        private MaterialSkin.Controls.MaterialCard materialCardHeader;
        private MaterialSkin.Controls.MaterialCard materialCardFoother;
        private MaterialSkin.Controls.MaterialButton materialButtonCancel;
        private MaterialSkin.Controls.MaterialButton materialButtonCreate;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeeFirstName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxEmployeeFirstName;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeeLastName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxEmployeeLastName;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeePatronymic;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxEmployeePatronymic;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployeeDeportment;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeeDepartment;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeePosition;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployeePosition;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeeSalary;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployeeKPI;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeeKPI;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeePhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxEmployeeHomeAdress;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmployeeHomeAdress;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxEmployeePhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxEmployeeSalary;
    }
}