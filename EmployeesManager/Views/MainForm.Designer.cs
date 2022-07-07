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
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.pageWithDataGridControlMain = new EmployeesManager.Views.Page.PageWithDataGridControl();
            this.tabPageDepartments = new System.Windows.Forms.TabPage();
            this.pageWithDataGridControlDepartments = new EmployeesManager.Views.Page.PageWithDataGridControl();
            this.tabPagePositions = new System.Windows.Forms.TabPage();
            this.pageWithDataGridControlPositions = new EmployeesManager.Views.Page.PageWithDataGridControl();
            this.tabPagePayouts = new System.Windows.Forms.TabPage();
            this.payoutsPageControl = new EmployeesManager.Views.Page.PayoutsPageControl();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.reportPageControl = new EmployeesManager.Views.Page.ReportPageControl();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageDepartments.SuspendLayout();
            this.tabPagePositions.SuspendLayout();
            this.tabPagePayouts.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPageMain);
            this.materialTabControl.Controls.Add(this.tabPageDepartments);
            this.materialTabControl.Controls.Add(this.tabPagePositions);
            this.materialTabControl.Controls.Add(this.tabPagePayouts);
            this.materialTabControl.Controls.Add(this.tabPageReport);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl.ImageList = this.imageListIcons;
            this.materialTabControl.Location = new System.Drawing.Point(3, 24);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(804, 433);
            this.materialTabControl.TabIndex = 0;
            this.materialTabControl.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.pageWithDataGridControlMain);
            this.tabPageMain.ImageKey = "home.png";
            this.tabPageMain.Location = new System.Drawing.Point(4, 39);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(796, 390);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // pageWithDataGridControlMain
            // 
            this.pageWithDataGridControlMain.AutoSize = true;
            this.pageWithDataGridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageWithDataGridControlMain.Location = new System.Drawing.Point(3, 3);
            this.pageWithDataGridControlMain.Name = "pageWithDataGridControlMain";
            this.pageWithDataGridControlMain.Size = new System.Drawing.Size(790, 384);
            this.pageWithDataGridControlMain.TabIndex = 0;
            // 
            // tabPageDepartments
            // 
            this.tabPageDepartments.Controls.Add(this.pageWithDataGridControlDepartments);
            this.tabPageDepartments.ImageKey = "department.png";
            this.tabPageDepartments.Location = new System.Drawing.Point(4, 39);
            this.tabPageDepartments.Name = "tabPageDepartments";
            this.tabPageDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartments.Size = new System.Drawing.Size(796, 390);
            this.tabPageDepartments.TabIndex = 1;
            this.tabPageDepartments.Text = "Departments";
            this.tabPageDepartments.UseVisualStyleBackColor = true;
            // 
            // pageWithDataGridControlDepartments
            // 
            this.pageWithDataGridControlDepartments.AutoSize = true;
            this.pageWithDataGridControlDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageWithDataGridControlDepartments.Location = new System.Drawing.Point(3, 3);
            this.pageWithDataGridControlDepartments.Name = "pageWithDataGridControlDepartments";
            this.pageWithDataGridControlDepartments.Size = new System.Drawing.Size(790, 384);
            this.pageWithDataGridControlDepartments.TabIndex = 0;
            // 
            // tabPagePositions
            // 
            this.tabPagePositions.Controls.Add(this.pageWithDataGridControlPositions);
            this.tabPagePositions.ImageKey = "candidate.png";
            this.tabPagePositions.Location = new System.Drawing.Point(4, 39);
            this.tabPagePositions.Name = "tabPagePositions";
            this.tabPagePositions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePositions.Size = new System.Drawing.Size(796, 390);
            this.tabPagePositions.TabIndex = 2;
            this.tabPagePositions.Text = "Positions";
            this.tabPagePositions.UseVisualStyleBackColor = true;
            // 
            // pageWithDataGridControlPositions
            // 
            this.pageWithDataGridControlPositions.AutoSize = true;
            this.pageWithDataGridControlPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageWithDataGridControlPositions.Location = new System.Drawing.Point(3, 3);
            this.pageWithDataGridControlPositions.Name = "pageWithDataGridControlPositions";
            this.pageWithDataGridControlPositions.Size = new System.Drawing.Size(790, 384);
            this.pageWithDataGridControlPositions.TabIndex = 1;
            // 
            // tabPagePayouts
            // 
            this.tabPagePayouts.Controls.Add(this.payoutsPageControl);
            this.tabPagePayouts.ImageKey = "money.png";
            this.tabPagePayouts.Location = new System.Drawing.Point(4, 39);
            this.tabPagePayouts.Name = "tabPagePayouts";
            this.tabPagePayouts.Size = new System.Drawing.Size(796, 390);
            this.tabPagePayouts.TabIndex = 3;
            this.tabPagePayouts.Text = "Payouts";
            this.tabPagePayouts.UseVisualStyleBackColor = true;
            // 
            // payoutsPageControl
            // 
            this.payoutsPageControl.AutoSize = true;
            this.payoutsPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payoutsPageControl.Location = new System.Drawing.Point(0, 0);
            this.payoutsPageControl.Name = "payoutsPageControl";
            this.payoutsPageControl.Size = new System.Drawing.Size(796, 390);
            this.payoutsPageControl.TabIndex = 0;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.reportPageControl);
            this.tabPageReport.ImageKey = "report.png";
            this.tabPageReport.Location = new System.Drawing.Point(4, 39);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Size = new System.Drawing.Size(796, 390);
            this.tabPageReport.TabIndex = 4;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // reportPageControl
            // 
            this.reportPageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPageControl.Location = new System.Drawing.Point(0, 0);
            this.reportPageControl.Name = "reportPageControl";
            this.reportPageControl.Size = new System.Drawing.Size(796, 390);
            this.reportPageControl.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(810, 460);
            this.Controls.Add(this.materialTabControl);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "EmployeesManager";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageDepartments.ResumeLayout(false);
            this.tabPageDepartments.PerformLayout();
            this.tabPagePositions.ResumeLayout(false);
            this.tabPagePositions.PerformLayout();
            this.tabPagePayouts.ResumeLayout(false);
            this.tabPagePayouts.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private TabPage tabPageMain;
        private TabPage tabPageDepartments;
        private TabPage tabPagePositions;
        private TabPage tabPagePayouts;
        private TabPage tabPageReport;
        private ImageList imageListIcons;
        private Page.PageWithDataGridControl pageWithDataGridControlDepartments;
        private Page.PageWithDataGridControl pageWithDataGridControlMain;
        private Page.PageWithDataGridControl pageWithDataGridControlPositions;
        private Page.PayoutsPageControl payoutsPageControl;
        private Page.ReportPageControl reportPageControl;
    }
}