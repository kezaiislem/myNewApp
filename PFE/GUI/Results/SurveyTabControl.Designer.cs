﻿namespace PFE
{
    partial class SurveyTabControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurveyTabControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabelStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPhase = new MetroFramework.Controls.MetroLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.buttonRemove = new JImageButton.JImageButton();
            this.buttonStatus = new JImageButton.JImageButton();
            this.buttonResults = new JImageButton.JImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNumberOfAnswers = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabelStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelPhase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNumberOfAnswers, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroLabelStatus
            // 
            this.metroLabelStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabelStatus.AutoSize = true;
            this.metroLabelStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelStatus.ForeColor = System.Drawing.Color.Black;
            this.metroLabelStatus.Location = new System.Drawing.Point(331, 15);
            this.metroLabelStatus.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.metroLabelStatus.Name = "metroLabelStatus";
            this.metroLabelStatus.Size = new System.Drawing.Size(49, 19);
            this.metroLabelStatus.TabIndex = 3;
            this.metroLabelStatus.Text = "Online";
            this.metroLabelStatus.UseCustomBackColor = true;
            this.metroLabelStatus.UseCustomForeColor = true;
            // 
            // metroLabelDate
            // 
            this.metroLabelDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabelDate.AutoSize = true;
            this.metroLabelDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDate.ForeColor = System.Drawing.Color.Black;
            this.metroLabelDate.Location = new System.Drawing.Point(105, 15);
            this.metroLabelDate.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.metroLabelDate.Name = "metroLabelDate";
            this.metroLabelDate.Size = new System.Drawing.Size(83, 19);
            this.metroLabelDate.TabIndex = 2;
            this.metroLabelDate.Text = "12/12/2012";
            this.metroLabelDate.UseCustomBackColor = true;
            this.metroLabelDate.UseCustomForeColor = true;
            // 
            // metroLabelPhase
            // 
            this.metroLabelPhase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabelPhase.AutoSize = true;
            this.metroLabelPhase.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelPhase.ForeColor = System.Drawing.Color.Black;
            this.metroLabelPhase.Location = new System.Drawing.Point(15, 15);
            this.metroLabelPhase.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.metroLabelPhase.Name = "metroLabelPhase";
            this.metroLabelPhase.Size = new System.Drawing.Size(17, 19);
            this.metroLabelPhase.TabIndex = 1;
            this.metroLabelPhase.Text = "1";
            this.metroLabelPhase.UseCustomBackColor = true;
            this.metroLabelPhase.UseCustomForeColor = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 50);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(906, 5);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 128;
            this.bunifuSeparator1.Vertical = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.CausesValidation = false;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRemove.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonRemove.ErrorImage")));
            this.buttonRemove.Image = global::TechEval.Properties.Resources.trash_10_32;
            this.buttonRemove.ImageHover = null;
            this.buttonRemove.InitialImage = null;
            this.buttonRemove.Location = new System.Drawing.Point(63, 7);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Zoom = 1;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStatus.BackColor = System.Drawing.Color.Transparent;
            this.buttonStatus.CausesValidation = false;
            this.buttonStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStatus.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonStatus.ErrorImage")));
            this.buttonStatus.Image = global::TechEval.Properties.Resources.no_wifi;
            this.buttonStatus.ImageHover = null;
            this.buttonStatus.InitialImage = null;
            this.buttonStatus.Location = new System.Drawing.Point(115, 5);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Padding = new System.Windows.Forms.Padding(2);
            this.buttonStatus.Size = new System.Drawing.Size(32, 32);
            this.buttonStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonStatus.TabIndex = 1;
            this.buttonStatus.Zoom = 1;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonResults
            // 
            this.buttonResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResults.BackColor = System.Drawing.Color.Transparent;
            this.buttonResults.CausesValidation = false;
            this.buttonResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonResults.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonResults.ErrorImage")));
            this.buttonResults.Image = global::TechEval.Properties.Resources.register;
            this.buttonResults.ImageHover = null;
            this.buttonResults.InitialImage = null;
            this.buttonResults.Location = new System.Drawing.Point(13, 7);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Padding = new System.Windows.Forms.Padding(2);
            this.buttonResults.Size = new System.Drawing.Size(32, 32);
            this.buttonResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonResults.TabIndex = 2;
            this.buttonResults.Zoom = 1;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.buttonResults);
            this.panel1.Controls.Add(this.buttonStatus);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Location = new System.Drawing.Point(711, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 42);
            this.panel1.TabIndex = 4;
            // 
            // labelNumberOfAnswers
            // 
            this.labelNumberOfAnswers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNumberOfAnswers.AutoSize = true;
            this.labelNumberOfAnswers.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelNumberOfAnswers.ForeColor = System.Drawing.Color.Black;
            this.labelNumberOfAnswers.Location = new System.Drawing.Point(512, 15);
            this.labelNumberOfAnswers.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.labelNumberOfAnswers.Name = "labelNumberOfAnswers";
            this.labelNumberOfAnswers.Size = new System.Drawing.Size(25, 19);
            this.labelNumberOfAnswers.TabIndex = 5;
            this.labelNumberOfAnswers.Text = "20";
            this.labelNumberOfAnswers.UseCustomBackColor = true;
            this.labelNumberOfAnswers.UseCustomForeColor = true;
            // 
            // SurveyTabControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SurveyTabControl";
            this.Size = new System.Drawing.Size(906, 55);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel metroLabelStatus;
        private MetroFramework.Controls.MetroLabel metroLabelDate;
        private MetroFramework.Controls.MetroLabel metroLabelPhase;
        private System.Windows.Forms.Panel panel1;
        private JImageButton.JImageButton buttonResults;
        private JImageButton.JImageButton buttonStatus;
        private JImageButton.JImageButton buttonRemove;
        private MetroFramework.Controls.MetroLabel labelNumberOfAnswers;
    }
}
