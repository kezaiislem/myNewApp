namespace PFE.UserContol
{
    partial class AddSectionForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.buttonOk = new MetroFramework.Controls.MetroButton();
            this.textBoxTitle = new MetroFramework.Controls.MetroTextBox();
            this.textBoxDescription = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxFactor = new MetroFramework.Controls.MetroComboBox();
            this.formDropShadow1 = new XanderUI.FormDropShadow();
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
            this.metroLabel1.Size = new System.Drawing.Size(149, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Add New Section";
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
            this.metroLabel4.Location = new System.Drawing.Point(521, 57);
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
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(596, 144);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseCustomBackColor = true;
            this.buttonCancel.UseSelectable = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.BackColor = System.Drawing.Color.White;
            this.buttonOk.Location = new System.Drawing.Point(686, 144);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseCustomBackColor = true;
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
            this.textBoxDescription.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.textBoxDescription.CustomButton.Name = "";
            this.textBoxDescription.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBoxDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxDescription.CustomButton.TabIndex = 1;
            this.textBoxDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxDescription.CustomButton.UseSelectable = true;
            this.textBoxDescription.CustomButton.Visible = false;
            this.textBoxDescription.Lines = new string[0];
            this.textBoxDescription.Location = new System.Drawing.Point(126, 100);
            this.textBoxDescription.MaxLength = 32767;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PasswordChar = '\0';
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDescription.SelectedText = "";
            this.textBoxDescription.SelectionLength = 0;
            this.textBoxDescription.SelectionStart = 0;
            this.textBoxDescription.ShortcutsEnabled = true;
            this.textBoxDescription.Size = new System.Drawing.Size(350, 29);
            this.textBoxDescription.TabIndex = 8;
            this.textBoxDescription.UseCustomBackColor = true;
            this.textBoxDescription.UseSelectable = true;
            this.textBoxDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxFactor
            // 
            this.comboBoxFactor.BackColor = System.Drawing.Color.White;
            this.comboBoxFactor.FormattingEnabled = true;
            this.comboBoxFactor.ItemHeight = 23;
            this.comboBoxFactor.Location = new System.Drawing.Point(593, 53);
            this.comboBoxFactor.Name = "comboBoxFactor";
            this.comboBoxFactor.Size = new System.Drawing.Size(168, 29);
            this.comboBoxFactor.TabIndex = 9;
            this.comboBoxFactor.UseCustomBackColor = true;
            this.comboBoxFactor.UseSelectable = true;
            // 
            // formDropShadow1
            // 
            this.formDropShadow1.EffectedForm = this;
            this.formDropShadow1.ShadowAngle = 5;
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(797, 179);
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
            this.Name = "AddSectionForm";
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
        private XanderUI.FormDropShadow formDropShadow1;
    }
}