namespace PFE.UserContol
{
    partial class ACPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACPForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.buttonOk = new MetroFramework.Controls.MetroButton();
            this.buttonParallelAnalysis = new MetroFramework.Controls.MetroButton();
            this.checkBoxCustomFactor = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.textboxNumberOfFactors = new MetroFramework.Controls.MetroTextBox();
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
            this.metroLabel1.Size = new System.Drawing.Size(247, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Principal Component Analysis";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(40, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(715, 63);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = resources.GetString("metroLabel2.Text");
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.WrapToLine = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(67, 194);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(192, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Use custom number of factors :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Location = new System.Drawing.Point(599, 236);
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
            this.buttonOk.Location = new System.Drawing.Point(680, 236);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Run PCA";
            this.buttonOk.UseCustomBackColor = true;
            this.buttonOk.UseCustomForeColor = true;
            this.buttonOk.UseSelectable = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonParallelAnalysis
            // 
            this.buttonParallelAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParallelAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.buttonParallelAnalysis.Location = new System.Drawing.Point(636, 143);
            this.buttonParallelAnalysis.Name = "buttonParallelAnalysis";
            this.buttonParallelAnalysis.Size = new System.Drawing.Size(119, 23);
            this.buttonParallelAnalysis.TabIndex = 11;
            this.buttonParallelAnalysis.Text = "Run parallel analysis";
            this.buttonParallelAnalysis.UseCustomBackColor = true;
            this.buttonParallelAnalysis.UseCustomForeColor = true;
            this.buttonParallelAnalysis.UseSelectable = true;
            this.buttonParallelAnalysis.Click += new System.EventHandler(this.buttonParallelAnalysis_Click);
            // 
            // checkBoxCustomFactor
            // 
            this.checkBoxCustomFactor.AllowBindingControlAnimation = true;
            this.checkBoxCustomFactor.AllowBindingControlColorChanges = false;
            this.checkBoxCustomFactor.AllowBindingControlLocation = true;
            this.checkBoxCustomFactor.AllowCheckBoxAnimation = false;
            this.checkBoxCustomFactor.AllowCheckmarkAnimation = true;
            this.checkBoxCustomFactor.AllowOnHoverStates = true;
            this.checkBoxCustomFactor.AutoCheck = true;
            this.checkBoxCustomFactor.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCustomFactor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxCustomFactor.BackgroundImage")));
            this.checkBoxCustomFactor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxCustomFactor.BindingControl = null;
            this.checkBoxCustomFactor.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBoxCustomFactor.Checked = false;
            this.checkBoxCustomFactor.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.checkBoxCustomFactor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCustomFactor.CustomCheckmarkImage = null;
            this.checkBoxCustomFactor.Location = new System.Drawing.Point(40, 193);
            this.checkBoxCustomFactor.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBoxCustomFactor.Name = "checkBoxCustomFactor";
            this.checkBoxCustomFactor.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxCustomFactor.OnCheck.BorderRadius = 2;
            this.checkBoxCustomFactor.OnCheck.BorderThickness = 2;
            this.checkBoxCustomFactor.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxCustomFactor.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxCustomFactor.OnCheck.CheckmarkThickness = 2;
            this.checkBoxCustomFactor.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBoxCustomFactor.OnDisable.BorderRadius = 2;
            this.checkBoxCustomFactor.OnDisable.BorderThickness = 2;
            this.checkBoxCustomFactor.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxCustomFactor.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBoxCustomFactor.OnDisable.CheckmarkThickness = 2;
            this.checkBoxCustomFactor.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxCustomFactor.OnHoverChecked.BorderRadius = 2;
            this.checkBoxCustomFactor.OnHoverChecked.BorderThickness = 2;
            this.checkBoxCustomFactor.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxCustomFactor.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBoxCustomFactor.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBoxCustomFactor.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.checkBoxCustomFactor.OnHoverUnchecked.BorderRadius = 2;
            this.checkBoxCustomFactor.OnHoverUnchecked.BorderThickness = 2;
            this.checkBoxCustomFactor.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxCustomFactor.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.checkBoxCustomFactor.OnUncheck.BorderRadius = 2;
            this.checkBoxCustomFactor.OnUncheck.BorderThickness = 2;
            this.checkBoxCustomFactor.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBoxCustomFactor.Size = new System.Drawing.Size(21, 21);
            this.checkBoxCustomFactor.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBoxCustomFactor.TabIndex = 18;
            this.checkBoxCustomFactor.ThreeState = false;
            this.checkBoxCustomFactor.ToolTipText = null;
            this.checkBoxCustomFactor.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkBoxCustomFactor_CheckedChanged);
            // 
            // textboxNumberOfFactors
            // 
            // 
            // 
            // 
            this.textboxNumberOfFactors.CustomButton.Image = null;
            this.textboxNumberOfFactors.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.textboxNumberOfFactors.CustomButton.Name = "";
            this.textboxNumberOfFactors.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxNumberOfFactors.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxNumberOfFactors.CustomButton.TabIndex = 1;
            this.textboxNumberOfFactors.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxNumberOfFactors.CustomButton.UseSelectable = true;
            this.textboxNumberOfFactors.CustomButton.Visible = false;
            this.textboxNumberOfFactors.Lines = new string[0];
            this.textboxNumberOfFactors.Location = new System.Drawing.Point(265, 193);
            this.textboxNumberOfFactors.MaxLength = 32767;
            this.textboxNumberOfFactors.Name = "textboxNumberOfFactors";
            this.textboxNumberOfFactors.PasswordChar = '\0';
            this.textboxNumberOfFactors.PromptText = "ex : 2";
            this.textboxNumberOfFactors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxNumberOfFactors.SelectedText = "";
            this.textboxNumberOfFactors.SelectionLength = 0;
            this.textboxNumberOfFactors.SelectionStart = 0;
            this.textboxNumberOfFactors.ShortcutsEnabled = true;
            this.textboxNumberOfFactors.Size = new System.Drawing.Size(47, 23);
            this.textboxNumberOfFactors.TabIndex = 19;
            this.textboxNumberOfFactors.UseSelectable = true;
            this.textboxNumberOfFactors.WaterMark = "ex : 2";
            this.textboxNumberOfFactors.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxNumberOfFactors.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ACPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(791, 271);
            this.Controls.Add(this.textboxNumberOfFactors);
            this.Controls.Add(this.checkBoxCustomFactor);
            this.Controls.Add(this.buttonParallelAnalysis);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ACPForm";
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton buttonParallelAnalysis;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBoxCustomFactor;
        private MetroFramework.Controls.MetroTextBox textboxNumberOfFactors;
    }
}