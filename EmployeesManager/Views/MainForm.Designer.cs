namespace EmployeesManager.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.materialFloatingActionButtonAddEmployee = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.tabPageDepartments = new System.Windows.Forms.TabPage();
            this.tabPagePositions = new System.Windows.Forms.TabPage();
            this.tabPagePayouts = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageMain);
            this.materialTabControl1.Controls.Add(this.tabPageDepartments);
            this.materialTabControl1.Controls.Add(this.tabPagePositions);
            this.materialTabControl1.Controls.Add(this.tabPagePayouts);
            this.materialTabControl1.Controls.Add(this.tabPageReport);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageListIcons;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 24);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 423);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.materialFloatingActionButtonAddEmployee);
            this.tabPageMain.ImageKey = "home.png";
            this.tabPageMain.Location = new System.Drawing.Point(4, 39);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(786, 380);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButtonAddEmployee
            // 
            this.materialFloatingActionButtonAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFloatingActionButtonAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFloatingActionButtonAddEmployee.Depth = 0;
            this.materialFloatingActionButtonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialFloatingActionButtonAddEmployee.Icon = global::EmployeesManager.Properties.Resources.plus;
            this.materialFloatingActionButtonAddEmployee.ImageKey = "(none)";
            this.materialFloatingActionButtonAddEmployee.Location = new System.Drawing.Point(719, 315);
            this.materialFloatingActionButtonAddEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButtonAddEmployee.Name = "materialFloatingActionButtonAddEmployee";
            this.materialFloatingActionButtonAddEmployee.Size = new System.Drawing.Size(61, 59);
            this.materialFloatingActionButtonAddEmployee.TabIndex = 0;
            this.materialFloatingActionButtonAddEmployee.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButtonAddEmployee.UseVisualStyleBackColor = true;
            this.materialFloatingActionButtonAddEmployee.Click += new System.EventHandler(this.materialFloatingActionButtonAddEmployee_Click);
            // 
            // tabPageDepartments
            // 
            this.tabPageDepartments.ImageKey = "department.png";
            this.tabPageDepartments.Location = new System.Drawing.Point(4, 39);
            this.tabPageDepartments.Name = "tabPageDepartments";
            this.tabPageDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartments.Size = new System.Drawing.Size(786, 380);
            this.tabPageDepartments.TabIndex = 1;
            this.tabPageDepartments.Text = "Departments";
            this.tabPageDepartments.UseVisualStyleBackColor = true;
            // 
            // tabPagePositions
            // 
            this.tabPagePositions.ImageKey = "candidate.png";
            this.tabPagePositions.Location = new System.Drawing.Point(4, 39);
            this.tabPagePositions.Name = "tabPagePositions";
            this.tabPagePositions.Size = new System.Drawing.Size(786, 380);
            this.tabPagePositions.TabIndex = 2;
            this.tabPagePositions.Text = "Positions";
            this.tabPagePositions.UseVisualStyleBackColor = true;
            // 
            // tabPagePayouts
            // 
            this.tabPagePayouts.ImageKey = "money.png";
            this.tabPagePayouts.Location = new System.Drawing.Point(4, 39);
            this.tabPagePayouts.Name = "tabPagePayouts";
            this.tabPagePayouts.Size = new System.Drawing.Size(786, 380);
            this.tabPagePayouts.TabIndex = 3;
            this.tabPagePayouts.Text = "Payouts";
            this.tabPagePayouts.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.ImageKey = "report.png";
            this.tabPageReport.Location = new System.Drawing.Point(4, 39);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Size = new System.Drawing.Size(786, 380);
            this.tabPageReport.TabIndex = 4;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // imageListIcons
            // 
            this.imageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "candidate.png");
            this.imageListIcons.Images.SetKeyName(1, "delete.png");
            this.imageListIcons.Images.SetKeyName(2, "department.png");
            this.imageListIcons.Images.SetKeyName(3, "home.png");
            this.imageListIcons.Images.SetKeyName(4, "money.png");
            this.imageListIcons.Images.SetKeyName(5, "plus.png");
            this.imageListIcons.Images.SetKeyName(6, "report.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "EmployeesManager";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPageMain;
        private TabPage tabPageDepartments;
        private TabPage tabPagePositions;
        private TabPage tabPagePayouts;
        private TabPage tabPageReport;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButtonAddEmployee;
        private ImageList imageListIcons;
    }
}