using System.Windows.Forms.VisualStyles;

namespace PFE.UserContol
{
    partial class HostSuccessForm
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
            this.buttonCopy = new MetroFramework.Controls.MetroButton();
            this.buttonOk = new MetroFramework.Controls.MetroButton();
            this.textBoxLink = new MetroFramework.Controls.MetroTextBox();
            this.buttonAdd = new MetroFramework.Controls.MetroButton();
            this.buttonShare = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.buttonDelete = new MetroFramework.Controls.MetroButton();
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
            this.metroLabel1.Size = new System.Drawing.Size(114, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Share Survey";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(42, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Link";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.Location = new System.Drawing.Point(397, 53);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(49, 23);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseCustomBackColor = true;
            this.buttonCopy.UseCustomForeColor = true;
            this.buttonCopy.UseSelectable = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Location = new System.Drawing.Point(397, 246);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseCustomBackColor = true;
            this.buttonOk.UseCustomForeColor = true;
            this.buttonOk.UseSelectable = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxLink.CustomButton.Image = null;
            this.textBoxLink.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.textBoxLink.CustomButton.Name = "";
            this.textBoxLink.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxLink.CustomButton.TabIndex = 1;
            this.textBoxLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxLink.CustomButton.UseSelectable = true;
            this.textBoxLink.CustomButton.Visible = false;
            this.textBoxLink.ForeColor = System.Drawing.Color.Black;
            this.textBoxLink.Lines = new string[0];
            this.textBoxLink.Location = new System.Drawing.Point(105, 53);
            this.textBoxLink.MaxLength = 32767;
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.PasswordChar = '\0';
            this.textBoxLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxLink.SelectedText = "";
            this.textBoxLink.SelectionLength = 0;
            this.textBoxLink.SelectionStart = 0;
            this.textBoxLink.ShortcutsEnabled = true;
            this.textBoxLink.Size = new System.Drawing.Size(280, 23);
            this.textBoxLink.TabIndex = 6;
            this.textBoxLink.UseCustomBackColor = true;
            this.textBoxLink.UseCustomForeColor = true;
            this.textBoxLink.UseSelectable = true;
            this.textBoxLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Location = new System.Drawing.Point(397, 95);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseCustomBackColor = true;
            this.buttonAdd.UseCustomForeColor = true;
            this.buttonAdd.UseSelectable = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShare
            // 
            this.buttonShare.BackColor = System.Drawing.Color.Transparent;
            this.buttonShare.Location = new System.Drawing.Point(397, 153);
            this.buttonShare.Name = "buttonShare";
            this.buttonShare.Size = new System.Drawing.Size(75, 23);
            this.buttonShare.TabIndex = 9;
            this.buttonShare.Text = "Share";
            this.buttonShare.UseCustomBackColor = true;
            this.buttonShare.UseCustomForeColor = true;
            this.buttonShare.UseSelectable = true;
            this.buttonShare.Click += new System.EventHandler(this.buttonShare_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(42, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Emails";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.Items.AddRange(new object[] {
            "hamada@gmail.com",
            "hamada@gmail.com",
            "hamada@gmail.com",
            "hamada@gmail.com",
            "hamada@gmail.com"});
            this.listBoxEmails.Location = new System.Drawing.Point(105, 95);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(280, 121);
            this.listBoxEmails.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(397, 124);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseCustomBackColor = true;
            this.buttonDelete.UseCustomForeColor = true;
            this.buttonDelete.UseSelectable = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // HostSuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxEmails);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.buttonShare);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HostSuccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buttonOk;
        private MetroFramework.Controls.MetroButton buttonCopy;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBoxLink;
        private MetroFramework.Controls.MetroButton buttonAdd;
        private MetroFramework.Controls.MetroButton buttonShare;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListBox listBoxEmails;
        private MetroFramework.Controls.MetroButton buttonDelete;
    }
}