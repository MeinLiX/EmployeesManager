namespace EmployeesManager.Views.ModifyWindows
{
    partial class DepartmentEditorForm
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
            this.materialTextBoxDepartmentName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabelHeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialCardHeader = new MaterialSkin.Controls.MaterialCard();
            this.materialCardFoother = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonCreate = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelDepartmentName = new MaterialSkin.Controls.MaterialLabel();
            this.materialCardHeader.SuspendLayout();
            this.materialCardFoother.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTextBoxDepartmentName
            // 
            this.materialTextBoxDepartmentName.AnimateReadOnly = false;
            this.materialTextBoxDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDepartmentName.Depth = 0;
            this.materialTextBoxDepartmentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDepartmentName.Hint = "Type Department Name";
            this.materialTextBoxDepartmentName.LeadingIcon = null;
            this.materialTextBoxDepartmentName.Location = new System.Drawing.Point(21, 86);
            this.materialTextBoxDepartmentName.MaxLength = 64;
            this.materialTextBoxDepartmentName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDepartmentName.Multiline = false;
            this.materialTextBoxDepartmentName.Name = "materialTextBoxDepartmentName";
            this.materialTextBoxDepartmentName.Size = new System.Drawing.Size(358, 36);
            this.materialTextBoxDepartmentName.TabIndex = 2;
            this.materialTextBoxDepartmentName.Text = "";
            this.materialTextBoxDepartmentName.TrailingIcon = null;
            this.materialTextBoxDepartmentName.UseTallSize = false;
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
            this.materialLabelHeader.Size = new System.Drawing.Size(164, 24);
            this.materialLabelHeader.TabIndex = 1;
            this.materialLabelHeader.Text = "Department editor";
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
            this.materialCardHeader.Size = new System.Drawing.Size(394, 52);
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
            this.materialCardFoother.Location = new System.Drawing.Point(3, 166);
            this.materialCardFoother.Margin = new System.Windows.Forms.Padding(10);
            this.materialCardFoother.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardFoother.Name = "materialCardFoother";
            this.materialCardFoother.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.materialCardFoother.Size = new System.Drawing.Size(394, 59);
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
            this.materialButtonCancel.Location = new System.Drawing.Point(211, 12);
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
            this.materialButtonCreate.Location = new System.Drawing.Point(300, 12);
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
            // materialLabelDepartmentName
            // 
            this.materialLabelDepartmentName.AutoSize = true;
            this.materialLabelDepartmentName.Depth = 0;
            this.materialLabelDepartmentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDepartmentName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelDepartmentName.Location = new System.Drawing.Point(21, 64);
            this.materialLabelDepartmentName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDepartmentName.Name = "materialLabelDepartmentName";
            this.materialLabelDepartmentName.Size = new System.Drawing.Size(128, 19);
            this.materialLabelDepartmentName.TabIndex = 4;
            this.materialLabelDepartmentName.Text = "Department name";
            // 
            // DepartmentEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 228);
            this.Controls.Add(this.materialLabelDepartmentName);
            this.Controls.Add(this.materialCardFoother);
            this.Controls.Add(this.materialCardHeader);
            this.Controls.Add(this.materialTextBoxDepartmentName);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "DepartmentEditorForm";
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

        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDepartmentName;
        private MaterialSkin.Controls.MaterialLabel materialLabelHeader;
        private MaterialSkin.Controls.MaterialCard materialCardHeader;
        private MaterialSkin.Controls.MaterialCard materialCardFoother;
        private MaterialSkin.Controls.MaterialButton materialButtonCancel;
        private MaterialSkin.Controls.MaterialButton materialButtonCreate;
        private MaterialSkin.Controls.MaterialLabel materialLabelDepartmentName;
    }
}