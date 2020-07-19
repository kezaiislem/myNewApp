namespace Calendar.NET
{
    partial class EditEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.gbBasics = new System.Windows.Forms.GroupBox();
            this.pnlTextColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEventColor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbBasics.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(94, 33);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(200, 20);
            this.txtEventName.TabIndex = 1;
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.pnlTextColor);
            this.gbBasics.Controls.Add(this.label6);
            this.gbBasics.Controls.Add(this.label1);
            this.gbBasics.Controls.Add(this.pnlEventColor);
            this.gbBasics.Controls.Add(this.txtEventName);
            this.gbBasics.Controls.Add(this.label5);
            this.gbBasics.Location = new System.Drawing.Point(12, 12);
            this.gbBasics.Name = "gbBasics";
            this.gbBasics.Size = new System.Drawing.Size(324, 110);
            this.gbBasics.TabIndex = 4;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "Basics";
            // 
            // pnlTextColor
            // 
            this.pnlTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextColor.Location = new System.Drawing.Point(260, 74);
            this.pnlTextColor.Name = "pnlTextColor";
            this.pnlTextColor.Size = new System.Drawing.Size(30, 15);
            this.pnlTextColor.TabIndex = 6;
            this.pnlTextColor.DoubleClick += new System.EventHandler(this.PnlTextColorDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Event Text Color:";
            // 
            // pnlEventColor
            // 
            this.pnlEventColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventColor.Location = new System.Drawing.Point(87, 72);
            this.pnlEventColor.Name = "pnlEventColor";
            this.pnlEventColor.Size = new System.Drawing.Size(30, 15);
            this.pnlEventColor.TabIndex = 4;
            this.pnlEventColor.DoubleClick += new System.EventHandler(this.PnlEventColorDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Event Color:";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ScriptsOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(261, 133);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 168);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbBasics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEvent";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventDetails";
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.GroupBox gbBasics;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlEventColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlTextColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
    }
}