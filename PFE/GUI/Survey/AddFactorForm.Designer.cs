using System.Windows.Forms.VisualStyles;

namespace PFE.UserContol
{
    partial class AddFactorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFactorForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.buttonOk = new MetroFramework.Controls.MetroButton();
            this.textBoxTitle = new MetroFramework.Controls.MetroTextBox();
            this.textBoxDescription = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxFactor = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonImport = new MetroFramework.Controls.MetroButton();
            this.checkBoxDefaultMta = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.checkBoxEvaluationFactor = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(12, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Add New Factor";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(42, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Title";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(42, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Description";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(524, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Factor";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Location = new System.Drawing.Point(524, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseCustomBackColor = true;
            this.buttonCancel.UseCustomForeColor = true;
            this.buttonCancel.UseSelectable = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Location = new System.Drawing.Point(686, 195);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseCustomBackColor = true;
            this.buttonOk.UseCustomForeColor = true;
            this.buttonOk.UseSelectable = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxTitle.CustomButton.Image = null;
            this.textBoxTitle.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.textBoxTitle.CustomButton.Name = "";
            this.textBoxTitle.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBoxTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxTitle.CustomButton.TabIndex = 1;
            this.textBoxTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxTitle.CustomButton.UseSelectable = true;
            this.textBoxTitle.CustomButton.Visible = false;
            this.textBoxTitle.ForeColor = System.Drawing.Color.Black;
            this.textBoxTitle.Lines = new string[0];
            this.textBoxTitle.Location = new System.Drawing.Point(126, 53);
            this.textBoxTitle.MaxLength = 32767;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.SelectionLength = 0;
            this.textBoxTitle.SelectionStart = 0;
            this.textBoxTitle.ShortcutsEnabled = true;
            this.textBoxTitle.Size = new System.Drawing.Size(350, 29);
            this.textBoxTitle.TabIndex = 6;
            this.textBoxTitle.UseCustomBackColor = true;
            this.textBoxTitle.UseCustomForeColor = true;
            this.textBoxTitle.UseSelectable = true;
            this.textBoxTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxDescription.CustomButton.Image = null;
            this.textBoxDescription.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.textBoxDescription.CustomButton.Name = "";
            this.textBoxDescription.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.textBoxDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxDescription.CustomButton.TabIndex = 1;
            this.textBoxDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxDescription.CustomButton.UseSelectable = true;
            this.textBoxDescription.CustomButton.Visible = false;
            this.textBoxDescription.Lines = new string[0];
            this.textBoxDescription.Location = new System.Drawing.Point(126, 100);
            this.textBoxDescription.MaxLength = 32767;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PasswordChar = '\0';
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.SelectedText = "";
            this.textBoxDescription.SelectionLength = 0;
            this.textBoxDescription.SelectionStart = 0;
            this.textBoxDescription.ShortcutsEnabled = true;
            this.textBoxDescription.Size = new System.Drawing.Size(350, 80);
            this.textBoxDescription.TabIndex = 8;
            this.textBoxDescription.UseCustomBackColor = true;
            this.textBoxDescription.UseSelectable = true;
            this.textBoxDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxFactor
            // 
            this.comboBoxFactor.BackColor = System.Drawing.Color.White;
            this.comboBoxFactor.Enabled = false;
            this.comboBoxFactor.FormattingEnabled = true;
            this.comboBoxFactor.ItemHeight = 23;
            this.comboBoxFactor.Location = new System.Drawing.Point(593, 100);
            this.comboBoxFactor.Name = "comboBoxFactor";
            this.comboBoxFactor.Size = new System.Drawing.Size(168, 29);
            this.comboBoxFactor.TabIndex = 9;
            this.comboBoxFactor.UseCustomBackColor = true;
            this.comboBoxFactor.UseSelectable = true;
            // 
            // metroButtonImport
            // 
            this.metroButtonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.metroButtonImport.Location = new System.Drawing.Point(605, 195);
            this.metroButtonImport.Name = "metroButtonImport";
            this.metroButtonImport.Size = new System.Drawing.Size(75, 23);
            this.metroButtonImport.TabIndex = 10;
            this.metroButtonImport.Text = "Import";
            this.metroButtonImport.UseCustomBackColor = true;
            this.metroButtonImport.UseCustomForeColor = true;
            this.metroButtonImport.UseSelectable = true;
            this.metroButtonImport.Click += new System.EventHandler(this.metroButtonImport_Click);
            // 
            // checkBoxDefaultMta
            // 
            this.checkBoxDefaultMta.AllowBindingControlAnimation = true;
            this.checkBoxDefaultMta.AllowBindingControlColorChanges = false;
            this.checkBoxDefaultMta.AllowBindingControlLocation = true;
            this.checkBoxDefaultMta.AllowCheckBoxAnimation = false;
            this.checkBoxDefaultMta.AllowCheckmarkAnimation = true;
            this.checkBoxDefaultMta.AllowOnHoverStates = true;
            this.checkBoxDefaultMta.AutoCheck = true;
            this.checkBoxDefaultMta.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDefaultMta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxDefaultMta.BackgroundImage")));
            this.checkBoxDefaultMta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxDefaultMta.BindingControl = null;
            this.checkBoxDefaultMta.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBoxDefaultMta.Checked = false;
            this.checkBoxDefaultMta.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.checkBoxDefaultMta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDefaultMta.CustomCheckmarkImage = null;
            this.checkBoxDefaultMta.Location = new System.Drawing.Point(524, 57);
            this.checkBoxDefaultMta.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBoxDefaultMta.Name = "checkBoxDefaultMta";
            this.checkBoxDefaultMta.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxDefaultMta.OnCheck.BorderRadius = 2;
            this.checkBoxDefaultMta.OnCheck.BorderThickness = 2;
            this.checkBoxDefaultMta.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxDefaultMta.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxDefaultMta.OnCheck.CheckmarkThickness = 2;
            this.checkBoxDefaultMta.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBoxDefaultMta.OnDisable.BorderRadius = 2;
            this.checkBoxDefaultMta.OnDisable.BorderThickness = 2;
            this.checkBoxDefaultMta.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxDefaultMta.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBoxDefaultMta.OnDisable.CheckmarkThickness = 2;
            this.checkBoxDefaultMta.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxDefaultMta.OnHoverChecked.BorderRadius = 2;
            this.checkBoxDefaultMta.OnHoverChecked.BorderThickness = 2;
            this.checkBoxDefaultMta.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxDefaultMta.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxDefaultMta.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBoxDefaultMta.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxDefaultMta.OnHoverUnchecked.BorderRadius = 2;
            this.checkBoxDefaultMta.OnHoverUnchecked.BorderThickness = 2;
            this.checkBoxDefaultMta.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxDefaultMta.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxDefaultMta.OnUncheck.BorderRadius = 2;
            this.checkBoxDefaultMta.OnUncheck.BorderThickness = 2;
            this.checkBoxDefaultMta.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxDefaultMta.Size = new System.Drawing.Size(21, 21);
            this.checkBoxDefaultMta.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBoxDefaultMta.TabIndex = 15;
            this.checkBoxDefaultMta.ThreeState = false;
            this.checkBoxDefaultMta.ToolTipText = null;
            this.checkBoxDefaultMta.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkBoxDefaultMta_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(561, 59);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(142, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Use MTA default factor";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(83, 194);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(136, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Is an evaluation factor";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // checkBoxEvaluationFactor
            // 
            this.checkBoxEvaluationFactor.AllowBindingControlAnimation = true;
            this.checkBoxEvaluationFactor.AllowBindingControlColorChanges = false;
            this.checkBoxEvaluationFactor.AllowBindingControlLocation = true;
            this.checkBoxEvaluationFactor.AllowCheckBoxAnimation = false;
            this.checkBoxEvaluationFactor.AllowCheckmarkAnimation = true;
            this.checkBoxEvaluationFactor.AllowOnHoverStates = true;
            this.checkBoxEvaluationFactor.AutoCheck = true;
            this.checkBoxEvaluationFactor.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEvaluationFactor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxEvaluationFactor.BackgroundImage")));
            this.checkBoxEvaluationFactor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxEvaluationFactor.BindingControl = null;
            this.checkBoxEvaluationFactor.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBoxEvaluationFactor.Checked = false;
            this.checkBoxEvaluationFactor.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.checkBoxEvaluationFactor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxEvaluationFactor.CustomCheckmarkImage = null;
            this.checkBoxEvaluationFactor.Location = new System.Drawing.Point(46, 192);
            this.checkBoxEvaluationFactor.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBoxEvaluationFactor.Name = "checkBoxEvaluationFactor";
            this.checkBoxEvaluationFactor.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxEvaluationFactor.OnCheck.BorderRadius = 2;
            this.checkBoxEvaluationFactor.OnCheck.BorderThickness = 2;
            this.checkBoxEvaluationFactor.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxEvaluationFactor.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxEvaluationFactor.OnCheck.CheckmarkThickness = 2;
            this.checkBoxEvaluationFactor.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBoxEvaluationFactor.OnDisable.BorderRadius = 2;
            this.checkBoxEvaluationFactor.OnDisable.BorderThickness = 2;
            this.checkBoxEvaluationFactor.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxEvaluationFactor.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBoxEvaluationFactor.OnDisable.CheckmarkThickness = 2;
            this.checkBoxEvaluationFactor.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxEvaluationFactor.OnHoverChecked.BorderRadius = 2;
            this.checkBoxEvaluationFactor.OnHoverChecked.BorderThickness = 2;
            this.checkBoxEvaluationFactor.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxEvaluationFactor.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxEvaluationFactor.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBoxEvaluationFactor.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxEvaluationFactor.OnHoverUnchecked.BorderRadius = 2;
            this.checkBoxEvaluationFactor.OnHoverUnchecked.BorderThickness = 2;
            this.checkBoxEvaluationFactor.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxEvaluationFactor.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxEvaluationFactor.OnUncheck.BorderRadius = 2;
            this.checkBoxEvaluationFactor.OnUncheck.BorderThickness = 2;
            this.checkBoxEvaluationFactor.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxEvaluationFactor.Size = new System.Drawing.Size(21, 21);
            this.checkBoxEvaluationFactor.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBoxEvaluationFactor.TabIndex = 17;
            this.checkBoxEvaluationFactor.ThreeState = false;
            this.checkBoxEvaluationFactor.ToolTipText = null;
            this.checkBoxEvaluationFactor.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkBoxEvaluationFactor_CheckedChanged);
            // 
            // AddFactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(797, 230);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.checkBoxEvaluationFactor);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.checkBoxDefaultMta);
            this.Controls.Add(this.metroButtonImport);
            this.Controls.Add(this.comboBoxFactor);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFactorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buttonOk;
        private MetroFramework.Controls.MetroButton buttonCancel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox comboBoxFactor;
        private MetroFramework.Controls.MetroTextBox textBoxDescription;
        private MetroFramework.Controls.MetroTextBox textBoxTitle;
        private MetroFramework.Controls.MetroButton metroButtonImport;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBoxDefaultMta;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBoxEvaluationFactor;
    }
}