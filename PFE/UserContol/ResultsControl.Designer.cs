namespace PFE.UserContol
{
    partial class ResultsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsControl));
            this.panelSectionContainer = new System.Windows.Forms.Panel();
            this.panelSections = new Bunifu.Framework.UI.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPhaseTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonResults = new JImageButton.JImageButton();
            this.panelSections.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSectionContainer
            // 
            this.panelSectionContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSectionContainer.Location = new System.Drawing.Point(272, 23);
            this.panelSectionContainer.Name = "panelSectionContainer";
            this.panelSectionContainer.Size = new System.Drawing.Size(760, 561);
            this.panelSectionContainer.TabIndex = 10;
            // 
            // panelSections
            // 
            this.panelSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSections.BackColor = System.Drawing.Color.White;
            this.panelSections.BorderRadius = 15;
            this.panelSections.BottomSahddow = true;
            this.panelSections.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panelSections.Controls.Add(this.panel2);
            this.panelSections.LeftSahddow = false;
            this.panelSections.Location = new System.Drawing.Point(33, 23);
            this.panelSections.Name = "panelSections";
            this.panelSections.RightSahddow = true;
            this.panelSections.ShadowDepth = 50;
            this.panelSections.Size = new System.Drawing.Size(211, 561);
            this.panelSections.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.buttonResults);
            this.panel2.Controls.Add(this.labelPhaseTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 44);
            this.panel2.TabIndex = 1;
            // 
            // labelPhaseTitle
            // 
            this.labelPhaseTitle.AutoSize = true;
            this.labelPhaseTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPhaseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhaseTitle.ForeColor = System.Drawing.Color.White;
            this.labelPhaseTitle.Location = new System.Drawing.Point(35, 10);
            this.labelPhaseTitle.Name = "labelPhaseTitle";
            this.labelPhaseTitle.Size = new System.Drawing.Size(71, 20);
            this.labelPhaseTitle.TabIndex = 1;
            this.labelPhaseTitle.Text = "Sections";
            // 
            // buttonResults
            // 
            this.buttonResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResults.BackColor = System.Drawing.Color.Transparent;
            this.buttonResults.CausesValidation = false;
            this.buttonResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonResults.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonResults.ErrorImage")));
            this.buttonResults.Image = ((System.Drawing.Image)(resources.GetObject("buttonResults.Image")));
            this.buttonResults.ImageHover = null;
            this.buttonResults.InitialImage = null;
            this.buttonResults.Location = new System.Drawing.Point(11, 8);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Padding = new System.Windows.Forms.Padding(2);
            this.buttonResults.Size = new System.Drawing.Size(24, 24);
            this.buttonResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonResults.TabIndex = 3;
            this.buttonResults.Zoom = 1;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // ResultsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelSections);
            this.Controls.Add(this.panelSectionContainer);
            this.Name = "ResultsControl";
            this.Size = new System.Drawing.Size(1064, 607);
            this.panelSections.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSectionContainer;
        private Bunifu.Framework.UI.BunifuCards panelSections;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPhaseTitle;
        private JImageButton.JImageButton buttonResults;
    }
}
