namespace PFE.UserContol
{
    partial class StatisticsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsControl));
            this.panelSections = new Bunifu.Framework.UI.BunifuCards();
            this.buttonConfirmatory = new System.Windows.Forms.Button();
            this.buttonExploratoryAnalysis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBack = new JImageButton.JImageButton();
            this.labelPhaseTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelStepContent = new System.Windows.Forms.Panel();
            this.panelSections.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSections
            // 
            this.panelSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSections.BackColor = System.Drawing.Color.White;
            this.panelSections.BorderRadius = 15;
            this.panelSections.BottomSahddow = true;
            this.panelSections.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panelSections.Controls.Add(this.buttonConfirmatory);
            this.panelSections.Controls.Add(this.buttonExploratoryAnalysis);
            this.panelSections.Controls.Add(this.panel2);
            this.panelSections.LeftSahddow = false;
            this.panelSections.Location = new System.Drawing.Point(31, 25);
            this.panelSections.Name = "panelSections";
            this.panelSections.RightSahddow = true;
            this.panelSections.ShadowDepth = 50;
            this.panelSections.Size = new System.Drawing.Size(211, 561);
            this.panelSections.TabIndex = 7;
            // 
            // buttonConfirmatory
            // 
            this.buttonConfirmatory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.buttonConfirmatory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConfirmatory.FlatAppearance.BorderSize = 0;
            this.buttonConfirmatory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonConfirmatory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonConfirmatory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmatory.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmatory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmatory.Location = new System.Drawing.Point(0, 84);
            this.buttonConfirmatory.Name = "buttonConfirmatory";
            this.buttonConfirmatory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonConfirmatory.Size = new System.Drawing.Size(211, 40);
            this.buttonConfirmatory.TabIndex = 11;
            this.buttonConfirmatory.Text = "Confirmatory analystics";
            this.buttonConfirmatory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmatory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConfirmatory.UseVisualStyleBackColor = false;
            this.buttonConfirmatory.Click += new System.EventHandler(this.buttonConfirmatory_Click);
            // 
            // buttonExploratoryAnalysis
            // 
            this.buttonExploratoryAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.buttonExploratoryAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExploratoryAnalysis.FlatAppearance.BorderSize = 0;
            this.buttonExploratoryAnalysis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonExploratoryAnalysis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonExploratoryAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExploratoryAnalysis.ForeColor = System.Drawing.Color.White;
            this.buttonExploratoryAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExploratoryAnalysis.Location = new System.Drawing.Point(0, 44);
            this.buttonExploratoryAnalysis.Name = "buttonExploratoryAnalysis";
            this.buttonExploratoryAnalysis.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonExploratoryAnalysis.Size = new System.Drawing.Size(211, 40);
            this.buttonExploratoryAnalysis.TabIndex = 9;
            this.buttonExploratoryAnalysis.Text = "Exploratory Analysis";
            this.buttonExploratoryAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExploratoryAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExploratoryAnalysis.UseVisualStyleBackColor = false;
            this.buttonExploratoryAnalysis.Click += new System.EventHandler(this.buttonExploratoryAnalysis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.labelPhaseTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 44);
            this.panel2.TabIndex = 8;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.CausesValidation = false;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.ErrorImage")));
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageHover = null;
            this.buttonBack.InitialImage = null;
            this.buttonBack.Location = new System.Drawing.Point(10, 8);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Padding = new System.Windows.Forms.Padding(2);
            this.buttonBack.Size = new System.Drawing.Size(24, 24);
            this.buttonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Zoom = 1;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelPhaseTitle
            // 
            this.labelPhaseTitle.AutoSize = true;
            this.labelPhaseTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPhaseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhaseTitle.ForeColor = System.Drawing.Color.White;
            this.labelPhaseTitle.Location = new System.Drawing.Point(34, 10);
            this.labelPhaseTitle.Name = "labelPhaseTitle";
            this.labelPhaseTitle.Size = new System.Drawing.Size(51, 20);
            this.labelPhaseTitle.TabIndex = 4;
            this.labelPhaseTitle.Text = "Steps";
            // 
            // panelStepContent
            // 
            this.panelStepContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStepContent.Location = new System.Drawing.Point(270, 25);
            this.panelStepContent.Name = "panelStepContent";
            this.panelStepContent.Size = new System.Drawing.Size(760, 561);
            this.panelStepContent.TabIndex = 8;
            // 
            // StatisticsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelSections);
            this.Controls.Add(this.panelStepContent);
            this.Name = "StatisticsControl";
            this.Size = new System.Drawing.Size(1064, 607);
            this.panelSections.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards panelSections;
        private System.Windows.Forms.Panel panelStepContent;
        private System.Windows.Forms.Panel panel2;
        private JImageButton.JImageButton buttonBack;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPhaseTitle;
        private System.Windows.Forms.Button buttonConfirmatory;
        private System.Windows.Forms.Button buttonExploratoryAnalysis;
    }
}
