namespace EmployeesManager.Views.Page
{
    partial class PayoutsPageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialComboBoxDepartmentsFilter = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.materialLabelHeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCommonSalary = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialComboBoxDepartmentsFilter
            // 
            this.materialComboBoxDepartmentsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBoxDepartmentsFilter.AutoResize = false;
            this.materialComboBoxDepartmentsFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxDepartmentsFilter.Depth = 0;
            this.materialComboBoxDepartmentsFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxDepartmentsFilter.DropDownHeight = 118;
            this.materialComboBoxDepartmentsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxDepartmentsFilter.DropDownWidth = 121;
            this.materialComboBoxDepartmentsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxDepartmentsFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxDepartmentsFilter.FormattingEnabled = true;
            this.materialComboBoxDepartmentsFilter.IntegralHeight = false;
            this.materialComboBoxDepartmentsFilter.ItemHeight = 29;
            this.materialComboBoxDepartmentsFilter.Location = new System.Drawing.Point(612, 8);
            this.materialComboBoxDepartmentsFilter.MaxDropDownItems = 4;
            this.materialComboBoxDepartmentsFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxDepartmentsFilter.Name = "materialComboBoxDepartmentsFilter";
            this.materialComboBoxDepartmentsFilter.Size = new System.Drawing.Size(161, 35);
            this.materialComboBoxDepartmentsFilter.StartIndex = 0;
            this.materialComboBoxDepartmentsFilter.TabIndex = 4;
            this.materialComboBoxDepartmentsFilter.UseTallSize = false;
            this.materialComboBoxDepartmentsFilter.Visible = false;
            this.materialComboBoxDepartmentsFilter.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxDepartmentsFilter_SelectedIndexChanged);
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.materialLabelHeader);
            this.materialCard.Controls.Add(this.materialComboBoxDepartmentsFilter);
            this.materialCard.Depth = 0;
            this.materialCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(0, 0);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(790, 50);
            this.materialCard.TabIndex = 5;
            // 
            // materialLabelHeader
            // 
            this.materialLabelHeader.AutoSize = true;
            this.materialLabelHeader.Depth = 0;
            this.materialLabelHeader.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelHeader.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabelHeader.Location = new System.Drawing.Point(17, 12);
            this.materialLabelHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHeader.Name = "materialLabelHeader";
            this.materialLabelHeader.Size = new System.Drawing.Size(74, 24);
            this.materialLabelHeader.TabIndex = 5;
            this.materialLabelHeader.Text = "Payouts";
            // 
            // materialLabelCommonSalary
            // 
            this.materialLabelCommonSalary.Depth = 0;
            this.materialLabelCommonSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabelCommonSalary.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelCommonSalary.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.materialLabelCommonSalary.Location = new System.Drawing.Point(0, 50);
            this.materialLabelCommonSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCommonSalary.Name = "materialLabelCommonSalary";
            this.materialLabelCommonSalary.Size = new System.Drawing.Size(790, 334);
            this.materialLabelCommonSalary.TabIndex = 6;
            this.materialLabelCommonSalary.Text = "0000";
            this.materialLabelCommonSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PayoutsPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabelCommonSalary);
            this.Controls.Add(this.materialCard);
            this.Name = "PayoutsPageControl";
            this.Size = new System.Drawing.Size(790, 384);
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox materialComboBoxDepartmentsFilter;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialLabel materialLabelHeader;
        private MaterialSkin.Controls.MaterialLabel materialLabelCommonSalary;
    }
}
