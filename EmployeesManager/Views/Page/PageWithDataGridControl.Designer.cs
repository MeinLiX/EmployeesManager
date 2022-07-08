namespace EmployeesManager.Views.Page
{
    partial class PageWithDataGridControl
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
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBoxDepartmentsFilter = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.materialLabelHeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.materialLabelHeader);
            this.materialCard.Controls.Add(this.materialComboBoxDepartmentsFilter);
            this.materialCard.Controls.Add(this.materialButtonDelete);
            this.materialCard.Controls.Add(this.materialButtonEdit);
            this.materialCard.Controls.Add(this.materialButtonAdd);
            this.materialCard.Depth = 0;
            this.materialCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(0, 0);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(790, 50);
            this.materialCard.TabIndex = 1;
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
            this.materialComboBoxDepartmentsFilter.Location = new System.Drawing.Point(416, 8);
            this.materialComboBoxDepartmentsFilter.MaxDropDownItems = 4;
            this.materialComboBoxDepartmentsFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxDepartmentsFilter.Name = "materialComboBoxDepartmentsFilter";
            this.materialComboBoxDepartmentsFilter.Size = new System.Drawing.Size(121, 35);
            this.materialComboBoxDepartmentsFilter.StartIndex = 0;
            this.materialComboBoxDepartmentsFilter.TabIndex = 3;
            this.materialComboBoxDepartmentsFilter.UseTallSize = false;
            this.materialComboBoxDepartmentsFilter.Visible = false;
            this.materialComboBoxDepartmentsFilter.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxDepartmentsFilter_SelectedIndexChanged);
            // 
            // materialButtonDelete
            // 
            this.materialButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDelete.Depth = 0;
            this.materialButtonDelete.HighEmphasis = true;
            this.materialButtonDelete.Icon = null;
            this.materialButtonDelete.Location = new System.Drawing.Point(555, 7);
            this.materialButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDelete.Name = "materialButtonDelete";
            this.materialButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDelete.Size = new System.Drawing.Size(73, 36);
            this.materialButtonDelete.TabIndex = 2;
            this.materialButtonDelete.Text = "Delete";
            this.materialButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDelete.UseAccentColor = false;
            this.materialButtonDelete.UseVisualStyleBackColor = true;
            this.materialButtonDelete.Click += new System.EventHandler(this.materialButtonDelete_Click);
            // 
            // materialButtonEdit
            // 
            this.materialButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonEdit.Depth = 0;
            this.materialButtonEdit.HighEmphasis = true;
            this.materialButtonEdit.Icon = null;
            this.materialButtonEdit.Location = new System.Drawing.Point(636, 7);
            this.materialButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonEdit.Name = "materialButtonEdit";
            this.materialButtonEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonEdit.Size = new System.Drawing.Size(64, 36);
            this.materialButtonEdit.TabIndex = 1;
            this.materialButtonEdit.Text = "Edit";
            this.materialButtonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonEdit.UseAccentColor = false;
            this.materialButtonEdit.UseVisualStyleBackColor = true;
            this.materialButtonEdit.Click += new System.EventHandler(this.materialButtonEdit_Click);
            // 
            // materialButtonAdd
            // 
            this.materialButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAdd.Depth = 0;
            this.materialButtonAdd.HighEmphasis = true;
            this.materialButtonAdd.Icon = null;
            this.materialButtonAdd.Location = new System.Drawing.Point(708, 7);
            this.materialButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAdd.Name = "materialButtonAdd";
            this.materialButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAdd.Size = new System.Drawing.Size(64, 36);
            this.materialButtonAdd.TabIndex = 0;
            this.materialButtonAdd.Text = "Add";
            this.materialButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAdd.UseAccentColor = false;
            this.materialButtonAdd.UseVisualStyleBackColor = true;
            this.materialButtonAdd.Click += new System.EventHandler(this.materialButtonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(0, 52);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(787, 329);
            this.dataGridView.TabIndex = 5;
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
            this.materialLabelHeader.Size = new System.Drawing.Size(63, 24);
            this.materialLabelHeader.TabIndex = 6;
            this.materialLabelHeader.Text = "Viewer";
            // 
            // PageWithDataGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.materialCard);
            this.Name = "PageWithDataGridControl";
            this.Size = new System.Drawing.Size(790, 384);
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialButton materialButtonDelete;
        private MaterialSkin.Controls.MaterialButton materialButtonEdit;
        private MaterialSkin.Controls.MaterialButton materialButtonAdd;
        private DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxDepartmentsFilter;
        private MaterialSkin.Controls.MaterialLabel materialLabelHeader;
    }
}
