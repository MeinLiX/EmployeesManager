namespace EmployeesManager.Views.Page
{
    partial class ReportPageControl
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
            this.materialLabelHeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonExport = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxExportType = new MaterialSkin.Controls.MaterialComboBox();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.materialCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.materialLabelHeader);
            this.materialCard.Depth = 0;
            this.materialCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(0, 0);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(790, 50);
            this.materialCard.TabIndex = 2;
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
            this.materialLabelHeader.Size = new System.Drawing.Size(60, 24);
            this.materialLabelHeader.TabIndex = 6;
            this.materialLabelHeader.Text = "Report";
            // 
            // materialButtonExport
            // 
            this.materialButtonExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonExport.Depth = 0;
            this.materialButtonExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButtonExport.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialButtonExport.HighEmphasis = true;
            this.materialButtonExport.Icon = null;
            this.materialButtonExport.Location = new System.Drawing.Point(0, 348);
            this.materialButtonExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonExport.Name = "materialButtonExport";
            this.materialButtonExport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonExport.Size = new System.Drawing.Size(790, 36);
            this.materialButtonExport.TabIndex = 3;
            this.materialButtonExport.Text = "Export";
            this.materialButtonExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonExport.UseAccentColor = false;
            this.materialButtonExport.UseVisualStyleBackColor = true;
            this.materialButtonExport.Click += new System.EventHandler(this.materialButtonExport_Click);
            // 
            // materialComboBoxExportType
            // 
            this.materialComboBoxExportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBoxExportType.AutoResize = true;
            this.materialComboBoxExportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxExportType.Depth = 0;
            this.materialComboBoxExportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxExportType.DropDownHeight = 174;
            this.materialComboBoxExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxExportType.DropDownWidth = 121;
            this.materialComboBoxExportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxExportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxExportType.FormattingEnabled = true;
            this.materialComboBoxExportType.Hint = "Select export type";
            this.materialComboBoxExportType.IntegralHeight = false;
            this.materialComboBoxExportType.ItemHeight = 43;
            this.materialComboBoxExportType.Items.AddRange(new object[] {
            "*.txt"});
            this.materialComboBoxExportType.Location = new System.Drawing.Point(328, 67);
            this.materialComboBoxExportType.MaxDropDownItems = 4;
            this.materialComboBoxExportType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxExportType.Name = "materialComboBoxExportType";
            this.materialComboBoxExportType.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxExportType.StartIndex = 0;
            this.materialComboBoxExportType.TabIndex = 4;
            this.materialComboBoxExportType.UseAccent = false;
            // 
            // ReportPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialComboBoxExportType);
            this.Controls.Add(this.materialButtonExport);
            this.Controls.Add(this.materialCard);
            this.Name = "ReportPageControl";
            this.Size = new System.Drawing.Size(790, 384);
            this.ClientSizeChanged += new System.EventHandler(this.ReportPageControl_ClientSizeChanged);
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialLabel materialLabelHeader;
        private MaterialSkin.Controls.MaterialButton materialButtonExport;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxExportType;
        private SaveFileDialog saveFileDialogExport;
    }
}
