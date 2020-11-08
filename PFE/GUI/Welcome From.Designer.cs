namespace PFE
{
    partial class WelcomeFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeFrom));
            this.menuPanel = new MetroFramework.Controls.MetroPanel();
            this.loadProjects = new MetroFramework.Controls.MetroTile();
            this.logOut = new MetroFramework.Controls.MetroTile();
            this.newProject = new MetroFramework.Controls.MetroTile();
            this.loadPanel = new MetroFramework.Controls.MetroPanel();
            this.backButton = new MetroFramework.Controls.MetroButton();
            this.loadButton = new MetroFramework.Controls.MetroButton();
            this.projectListView = new MetroFramework.Controls.MetroListView();
            this.projetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technologyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.domain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuPanel.SuspendLayout();
            this.loadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPanel.Controls.Add(this.loadProjects);
            this.menuPanel.Controls.Add(this.logOut);
            this.menuPanel.Controls.Add(this.newProject);
            this.menuPanel.HorizontalScrollbarBarColor = true;
            this.menuPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.menuPanel.HorizontalScrollbarSize = 10;
            this.menuPanel.Location = new System.Drawing.Point(20, 74);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(360, 206);
            this.menuPanel.TabIndex = 4;
            this.menuPanel.VerticalScrollbarBarColor = true;
            this.menuPanel.VerticalScrollbarHighlightOnWheel = false;
            this.menuPanel.VerticalScrollbarSize = 10;
            // 
            // loadProjects
            // 
            this.loadProjects.ActiveControl = null;
            this.loadProjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadProjects.Location = new System.Drawing.Point(0, 106);
            this.loadProjects.Name = "loadProjects";
            this.loadProjects.Size = new System.Drawing.Size(177, 100);
            this.loadProjects.Style = MetroFramework.MetroColorStyle.Blue;
            this.loadProjects.TabIndex = 1;
            this.loadProjects.Text = "Load Project";
            this.loadProjects.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.loadProjects.UseSelectable = true;
            this.loadProjects.Click += new System.EventHandler(this.loadProjects_Click);
            // 
            // logOut
            // 
            this.logOut.ActiveControl = null;
            this.logOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logOut.Location = new System.Drawing.Point(183, 106);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(177, 100);
            this.logOut.TabIndex = 2;
            this.logOut.Text = "Log Out";
            this.logOut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.logOut.UseSelectable = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // newProject
            // 
            this.newProject.ActiveControl = null;
            this.newProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProject.BackColor = System.Drawing.Color.Turquoise;
            this.newProject.Location = new System.Drawing.Point(0, 0);
            this.newProject.Name = "newProject";
            this.newProject.Size = new System.Drawing.Size(360, 100);
            this.newProject.TabIndex = 0;
            this.newProject.Text = "New Project";
            this.newProject.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.newProject.UseSelectable = true;
            this.newProject.Click += new System.EventHandler(this.newProject_Click);
            // 
            // loadPanel
            // 
            this.loadPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadPanel.Controls.Add(this.backButton);
            this.loadPanel.Controls.Add(this.loadButton);
            this.loadPanel.Controls.Add(this.projectListView);
            this.loadPanel.HorizontalScrollbarBarColor = true;
            this.loadPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.loadPanel.HorizontalScrollbarSize = 10;
            this.loadPanel.Location = new System.Drawing.Point(20, 74);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(360, 206);
            this.loadPanel.TabIndex = 5;
            this.loadPanel.VerticalScrollbarBarColor = true;
            this.loadPanel.VerticalScrollbarHighlightOnWheel = false;
            this.loadPanel.VerticalScrollbarSize = 10;
            this.loadPanel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Location = new System.Drawing.Point(201, 180);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseSelectable = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(282, 180);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseSelectable = true;
            // 
            // projectListView
            // 
            this.projectListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projetName,
            this.technologyName,
            this.domain});
            this.projectListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projectListView.FullRowSelect = true;
            this.projectListView.Location = new System.Drawing.Point(3, 3);
            this.projectListView.Name = "projectListView";
            this.projectListView.OwnerDraw = true;
            this.projectListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectListView.Size = new System.Drawing.Size(354, 162);
            this.projectListView.TabIndex = 2;
            this.projectListView.UseCompatibleStateImageBehavior = false;
            this.projectListView.UseSelectable = true;
            this.projectListView.View = System.Windows.Forms.View.Details;
            // 
            // projetName
            // 
            this.projetName.Text = "Project Name";
            this.projetName.Width = 115;
            // 
            // technologyName
            // 
            this.technologyName.Text = "Technology Name";
            this.technologyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.technologyName.Width = 115;
            // 
            // domain
            // 
            this.domain.Text = "Domain";
            this.domain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domain.Width = 120;
            // 
            // WelcomeFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.loadPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeFrom";
            this.Text = "Welcome";
            this.Shown += new System.EventHandler(this.WelcomeFrom_Shown);
            this.ResizeEnd += new System.EventHandler(this.pageResized);
            this.menuPanel.ResumeLayout(false);
            this.loadPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel menuPanel;
        private MetroFramework.Controls.MetroTile loadProjects;
        private MetroFramework.Controls.MetroTile logOut;
        private MetroFramework.Controls.MetroTile newProject;
        private MetroFramework.Controls.MetroPanel loadPanel;
        private MetroFramework.Controls.MetroListView projectListView;
        private MetroFramework.Controls.MetroButton backButton;
        private MetroFramework.Controls.MetroButton loadButton;
        private System.Windows.Forms.ColumnHeader projetName;
        private System.Windows.Forms.ColumnHeader technologyName;
        private System.Windows.Forms.ColumnHeader domain;
    }
}