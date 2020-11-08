namespace PFE
{
    partial class NewProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBoxProjectName = new MetroFramework.Controls.MetroTextBox();
            this.createProjectBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Project Name ";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxProjectName.CustomButton.Image = null;
            this.textBoxProjectName.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.textBoxProjectName.CustomButton.Name = "";
            this.textBoxProjectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxProjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxProjectName.CustomButton.TabIndex = 1;
            this.textBoxProjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxProjectName.CustomButton.UseSelectable = true;
            this.textBoxProjectName.CustomButton.Visible = false;
            this.textBoxProjectName.Lines = new string[0];
            this.textBoxProjectName.Location = new System.Drawing.Point(134, 96);
            this.textBoxProjectName.MaxLength = 32767;
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.PasswordChar = '\0';
            this.textBoxProjectName.PromptText = "My Project";
            this.textBoxProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxProjectName.SelectedText = "";
            this.textBoxProjectName.SelectionLength = 0;
            this.textBoxProjectName.SelectionStart = 0;
            this.textBoxProjectName.ShortcutsEnabled = true;
            this.textBoxProjectName.Size = new System.Drawing.Size(193, 23);
            this.textBoxProjectName.TabIndex = 1;
            this.textBoxProjectName.UseSelectable = true;
            this.textBoxProjectName.WaterMark = "My Project";
            this.textBoxProjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxProjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createProjectBtn
            // 
            this.createProjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createProjectBtn.Location = new System.Drawing.Point(238, 143);
            this.createProjectBtn.Name = "createProjectBtn";
            this.createProjectBtn.Size = new System.Drawing.Size(89, 23);
            this.createProjectBtn.TabIndex = 8;
            this.createProjectBtn.Text = "Create Project";
            this.createProjectBtn.UseSelectable = true;
            this.createProjectBtn.Click += new System.EventHandler(this.createProjectBtn_Click);
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.createProjectBtn);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 400);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "NewProjectForm";
            this.Resizable = false;
            this.Text = "New Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewProjectForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textBoxProjectName;
        private MetroFramework.Controls.MetroButton createProjectBtn;
    }
}