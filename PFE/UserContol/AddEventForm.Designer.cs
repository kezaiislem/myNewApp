using System.Windows.Forms.VisualStyles;

namespace PFE.UserContol
{
    partial class AddEventForm
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
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.buttonOk = new MetroFramework.Controls.MetroButton();
            this.textEventName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.inputStartDate = new MetroFramework.Controls.MetroDateTime();
            this.inputEndtDate = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Add Mail";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(12, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Event Name";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Location = new System.Drawing.Point(215, 216);
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
            this.buttonOk.Location = new System.Drawing.Point(296, 216);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseCustomBackColor = true;
            this.buttonOk.UseCustomForeColor = true;
            this.buttonOk.UseSelectable = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textEventName
            // 
            this.textEventName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textEventName.CustomButton.Image = null;
            this.textEventName.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.textEventName.CustomButton.Name = "";
            this.textEventName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textEventName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEventName.CustomButton.TabIndex = 1;
            this.textEventName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEventName.CustomButton.UseSelectable = true;
            this.textEventName.CustomButton.Visible = false;
            this.textEventName.ForeColor = System.Drawing.Color.Black;
            this.textEventName.Lines = new string[0];
            this.textEventName.Location = new System.Drawing.Point(98, 50);
            this.textEventName.MaxLength = 32767;
            this.textEventName.Name = "textEventName";
            this.textEventName.PasswordChar = '\0';
            this.textEventName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEventName.SelectedText = "";
            this.textEventName.SelectionLength = 0;
            this.textEventName.SelectionStart = 0;
            this.textEventName.ShortcutsEnabled = true;
            this.textEventName.Size = new System.Drawing.Size(273, 25);
            this.textEventName.TabIndex = 6;
            this.textEventName.UseCustomBackColor = true;
            this.textEventName.UseCustomForeColor = true;
            this.textEventName.UseSelectable = true;
            this.textEventName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEventName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(12, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Start Date";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(12, 133);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "End Date";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(12, 173);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Event Color";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // inputStartDate
            // 
            this.inputStartDate.Location = new System.Drawing.Point(98, 86);
            this.inputStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.inputStartDate.Name = "inputStartDate";
            this.inputStartDate.Size = new System.Drawing.Size(273, 29);
            this.inputStartDate.TabIndex = 10;
            // 
            // inputEndtDate
            // 
            this.inputEndtDate.Location = new System.Drawing.Point(98, 126);
            this.inputEndtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.inputEndtDate.Name = "inputEndtDate";
            this.inputEndtDate.Size = new System.Drawing.Size(273, 29);
            this.inputEndtDate.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(98, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 19);
            this.panel1.TabIndex = 12;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(383, 251);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputEndtDate);
            this.Controls.Add(this.inputStartDate);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textEventName);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buttonOk;
        private MetroFramework.Controls.MetroButton buttonCancel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textEventName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime inputStartDate;
        private MetroFramework.Controls.MetroDateTime inputEndtDate;
        private System.Windows.Forms.Panel panel1;
    }
}