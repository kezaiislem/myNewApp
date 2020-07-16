using MetroFramework.Controls;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace PFE
{
    partial class MainForm
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnAnalistics = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.ButtonProjectPlan = new System.Windows.Forms.Button();
            this.buttonProjectContext = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new XanderUI.XUISuperButton();
            this.labelPageName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelCurrentView = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panelSideMenu.Controls.Add(this.buttonAbout);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelToolsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTools);
            this.panelSideMenu.Controls.Add(this.btnAnalistics);
            this.panelSideMenu.Controls.Add(this.btnModel);
            this.panelSideMenu.Controls.Add(this.ButtonProjectPlan);
            this.panelSideMenu.Controls.Add(this.buttonProjectContext);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 681);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Image = global::PFE.Properties.Resources.about;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(0, 384);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonAbout.Size = new System.Drawing.Size(200, 45);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "  About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::PFE.Properties.Resources.logout;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 636);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(200, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::PFE.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 339);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(200, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "  Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panelToolsSubMenu.Controls.Add(this.button13);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 299);
            this.panelToolsSubMenu.Name = "panelToolsSubMenu";
            this.panelToolsSubMenu.Size = new System.Drawing.Size(200, 40);
            this.panelToolsSubMenu.TabIndex = 7;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(200, 40);
            this.button13.TabIndex = 0;
            this.button13.Text = "Media converter";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnTools
            // 
            this.btnTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.ForeColor = System.Drawing.Color.White;
            this.btnTools.Image = global::PFE.Properties.Resources.stamp;
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 254);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(200, 45);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "  Validation";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = false;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnAnalistics
            // 
            this.btnAnalistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnAnalistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalistics.FlatAppearance.BorderSize = 0;
            this.btnAnalistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnAnalistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAnalistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalistics.ForeColor = System.Drawing.Color.White;
            this.btnAnalistics.Image = global::PFE.Properties.Resources.result;
            this.btnAnalistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalistics.Location = new System.Drawing.Point(0, 209);
            this.btnAnalistics.Name = "btnAnalistics";
            this.btnAnalistics.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAnalistics.Size = new System.Drawing.Size(200, 45);
            this.btnAnalistics.TabIndex = 5;
            this.btnAnalistics.Text = "  Results";
            this.btnAnalistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalistics.UseVisualStyleBackColor = false;
            this.btnAnalistics.Click += new System.EventHandler(this.btnEqualizer_Click);
            // 
            // btnModel
            // 
            this.btnModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModel.FlatAppearance.BorderSize = 0;
            this.btnModel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnModel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModel.ForeColor = System.Drawing.Color.White;
            this.btnModel.Image = global::PFE.Properties.Resources.model;
            this.btnModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModel.Location = new System.Drawing.Point(0, 164);
            this.btnModel.Name = "btnModel";
            this.btnModel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnModel.Size = new System.Drawing.Size(200, 45);
            this.btnModel.TabIndex = 3;
            this.btnModel.Text = "  Model";
            this.btnModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModel.UseVisualStyleBackColor = false;
            this.btnModel.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // ButtonProjectPlan
            // 
            this.ButtonProjectPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ButtonProjectPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonProjectPlan.FlatAppearance.BorderSize = 0;
            this.ButtonProjectPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ButtonProjectPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ButtonProjectPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProjectPlan.ForeColor = System.Drawing.Color.White;
            this.ButtonProjectPlan.Image = global::PFE.Properties.Resources.leader;
            this.ButtonProjectPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonProjectPlan.Location = new System.Drawing.Point(0, 119);
            this.ButtonProjectPlan.Name = "ButtonProjectPlan";
            this.ButtonProjectPlan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonProjectPlan.Size = new System.Drawing.Size(200, 45);
            this.ButtonProjectPlan.TabIndex = 2;
            this.ButtonProjectPlan.Text = "  Project Plan";
            this.ButtonProjectPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonProjectPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonProjectPlan.UseVisualStyleBackColor = false;
            this.ButtonProjectPlan.Click += new System.EventHandler(this.ButtonProjectPlan_Click);
            // 
            // buttonProjectContext
            // 
            this.buttonProjectContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.buttonProjectContext.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProjectContext.FlatAppearance.BorderSize = 0;
            this.buttonProjectContext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonProjectContext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonProjectContext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjectContext.ForeColor = System.Drawing.Color.White;
            this.buttonProjectContext.Image = global::PFE.Properties.Resources.project__2_;
            this.buttonProjectContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjectContext.Location = new System.Drawing.Point(0, 74);
            this.buttonProjectContext.Name = "buttonProjectContext";
            this.buttonProjectContext.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonProjectContext.Size = new System.Drawing.Size(200, 45);
            this.buttonProjectContext.TabIndex = 1;
            this.buttonProjectContext.Text = "  Project Context";
            this.buttonProjectContext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjectContext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProjectContext.UseVisualStyleBackColor = false;
            this.buttonProjectContext.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 74);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PFE.Properties.Resources.AppLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.labelPageName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 74);
            this.panel1.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.saveButton.ButtonImage = global::PFE.Properties.Resources.save__3_;
            this.saveButton.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.saveButton.ButtonStyle = XanderUI.XUISuperButton.Style.Flat;
            this.saveButton.ButtonText = "";
            this.saveButton.CornerRadius = 800;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Horizontal_Alignment = System.Drawing.StringAlignment.Far;
            this.saveButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.saveButton.HoverTextColor = System.Drawing.Color.White;
            this.saveButton.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.saveButton.Location = new System.Drawing.Point(1012, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.saveButton.SelectedTextColor = System.Drawing.Color.White;
            this.saveButton.Size = new System.Drawing.Size(30, 30);
            this.saveButton.SuperSelected = false;
            this.saveButton.TabIndex = 3;
            this.saveButton.TextColor = System.Drawing.Color.White;
            this.saveButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelPageName
            // 
            this.labelPageName.AutoSize = true;
            this.labelPageName.BackColor = System.Drawing.Color.Transparent;
            this.labelPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageName.ForeColor = System.Drawing.Color.White;
            this.labelPageName.Location = new System.Drawing.Point(28, 21);
            this.labelPageName.Name = "labelPageName";
            this.labelPageName.Size = new System.Drawing.Size(131, 29);
            this.labelPageName.TabIndex = 2;
            this.labelPageName.Text = "Dashboard";
            // 
            // panelCurrentView
            // 
            this.panelCurrentView.AutoScroll = true;
            this.panelCurrentView.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelCurrentView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(246)))));
            this.panelCurrentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrentView.Location = new System.Drawing.Point(200, 74);
            this.panelCurrentView.Name = "panelCurrentView";
            this.panelCurrentView.Size = new System.Drawing.Size(1064, 607);
            this.panelCurrentView.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelCurrentView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Eval";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonProjectContext;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelToolsSubMenu;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnAnalistics;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCurrentView;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPageName;
        private XanderUI.XUISuperButton saveButton;
        private System.Windows.Forms.Button ButtonProjectPlan;
        private System.Windows.Forms.Button buttonAbout;
    }
}