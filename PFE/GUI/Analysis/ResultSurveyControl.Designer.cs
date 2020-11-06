namespace PFE.UserContol
{
    partial class ResultSurveyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultSurveyControl));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEnter = new JImageButton.JImageButton();
            this.labelDescription = new MetroFramework.Controls.MetroLabel();
            this.labelPhase = new MetroFramework.Controls.MetroLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.bunifuCards1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.bunifuCards1.Controls.Add(this.panelMain);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(5, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(326, 280);
            this.bunifuCards1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Controls.Add(this.labelDescription);
            this.panelMain.Controls.Add(this.labelPhase);
            this.panelMain.Controls.Add(this.bunifuSeparator1);
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(326, 280);
            this.panelMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonEnter, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 217);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(181, 42);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEnter.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnter.CausesValidation = false;
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEnter.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonEnter.ErrorImage")));
            this.buttonEnter.Image = global::TechEval.Properties.Resources.register;
            this.buttonEnter.ImageHover = null;
            this.buttonEnter.InitialImage = null;
            this.buttonEnter.Location = new System.Drawing.Point(74, 5);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Padding = new System.Windows.Forms.Padding(2);
            this.buttonEnter.Size = new System.Drawing.Size(32, 32);
            this.buttonEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Zoom = 1;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(17, 59);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(291, 146);
            this.labelDescription.TabIndex = 21;
            this.labelDescription.Text = "lnformation sur le model and what to do ext";
            this.labelDescription.WrapToLine = true;
            // 
            // labelPhase
            // 
            this.labelPhase.AutoSize = true;
            this.labelPhase.Location = new System.Drawing.Point(256, 20);
            this.labelPhase.Name = "labelPhase";
            this.labelPhase.Size = new System.Drawing.Size(52, 19);
            this.labelPhase.TabIndex = 20;
            this.labelPhase.Text = "Phase 1";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 39);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(291, 10);
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 128;
            this.bunifuSeparator1.Vertical = false;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(17, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(233, 25);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Model Info";
            this.labelTitle.UseCustomBackColor = true;
            this.labelTitle.UseCustomForeColor = true;
            // 
            // ResultSurveyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "ResultSurveyControl";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Size = new System.Drawing.Size(336, 280);
            this.bunifuCards1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private JImageButton.JImageButton buttonEnter;
        private MetroFramework.Controls.MetroLabel labelDescription;
        private MetroFramework.Controls.MetroLabel labelPhase;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel labelTitle;
    }
}
