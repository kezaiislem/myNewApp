namespace PFE.UserContol
{
    partial class PhaseControl
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
            this.panelSections = new Bunifu.Framework.UI.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddSection = new Guna.UI.WinForms.GunaCircleButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.labelPhaseTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelSectionContent = new System.Windows.Forms.Panel();
            this.buttonBack = new XanderUI.XUIButton();
            this.buttonHost = new XanderUI.XUIButton();
            this.buttonShare = new XanderUI.XUIButton();
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
            this.panelSections.color = System.Drawing.Color.Transparent;
            this.panelSections.Controls.Add(this.panel2);
            this.panelSections.LeftSahddow = false;
            this.panelSections.Location = new System.Drawing.Point(31, 25);
            this.panelSections.Name = "panelSections";
            this.panelSections.RightSahddow = true;
            this.panelSections.ShadowDepth = 50;
            this.panelSections.Size = new System.Drawing.Size(211, 436);
            this.panelSections.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.buttonAddSection);
            this.panel2.Controls.Add(this.metroButton1);
            this.panel2.Controls.Add(this.labelPhaseTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 50);
            this.panel2.TabIndex = 7;
            // 
            // buttonAddSection
            // 
            this.buttonAddSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSection.AnimationHoverSpeed = 0.07F;
            this.buttonAddSection.AnimationSpeed = 0.03F;
            this.buttonAddSection.BaseColor = System.Drawing.Color.Transparent;
            this.buttonAddSection.BorderColor = System.Drawing.Color.Black;
            this.buttonAddSection.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAddSection.FocusedColor = System.Drawing.Color.Empty;
            this.buttonAddSection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddSection.ForeColor = System.Drawing.Color.White;
            this.buttonAddSection.Image = global::PFE.Properties.Resources.add_plus;
            this.buttonAddSection.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonAddSection.Location = new System.Drawing.Point(166, 10);
            this.buttonAddSection.Name = "buttonAddSection";
            this.buttonAddSection.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.buttonAddSection.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonAddSection.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonAddSection.OnHoverImage = null;
            this.buttonAddSection.OnPressedColor = System.Drawing.Color.Black;
            this.buttonAddSection.Size = new System.Drawing.Size(30, 30);
            this.buttonAddSection.TabIndex = 3;
            this.buttonAddSection.Click += new System.EventHandler(this.buttonAddSection_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(912, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Add Section";
            this.metroButton1.UseSelectable = true;
            // 
            // labelPhaseTitle
            // 
            this.labelPhaseTitle.AutoSize = true;
            this.labelPhaseTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPhaseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhaseTitle.ForeColor = System.Drawing.Color.White;
            this.labelPhaseTitle.Location = new System.Drawing.Point(15, 15);
            this.labelPhaseTitle.Name = "labelPhaseTitle";
            this.labelPhaseTitle.Size = new System.Drawing.Size(71, 20);
            this.labelPhaseTitle.TabIndex = 1;
            this.labelPhaseTitle.Text = "Sections";
            // 
            // panelSectionContent
            // 
            this.panelSectionContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSectionContent.Location = new System.Drawing.Point(270, 25);
            this.panelSectionContent.Name = "panelSectionContent";
            this.panelSectionContent.Size = new System.Drawing.Size(760, 561);
            this.panelSectionContent.TabIndex = 8;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.buttonBack.ButtonImage = null;
            this.buttonBack.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.buttonBack.ButtonText = "Back";
            this.buttonBack.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonBack.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonBack.CornerRadius = 20;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonBack.HoverBackgroundColor = System.Drawing.Color.White;
            this.buttonBack.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonBack.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonBack.Location = new System.Drawing.Point(63, 559);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 40);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.TextColor = System.Drawing.Color.White;
            this.buttonBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonHost
            // 
            this.buttonHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.buttonHost.ButtonImage = null;
            this.buttonHost.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.buttonHost.ButtonText = "Host";
            this.buttonHost.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonHost.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonHost.CornerRadius = 20;
            this.buttonHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHost.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonHost.HoverBackgroundColor = System.Drawing.Color.White;
            this.buttonHost.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonHost.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonHost.Location = new System.Drawing.Point(63, 467);
            this.buttonHost.Name = "buttonHost";
            this.buttonHost.Size = new System.Drawing.Size(140, 40);
            this.buttonHost.TabIndex = 9;
            this.buttonHost.TextColor = System.Drawing.Color.White;
            this.buttonHost.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonHost.Click += new System.EventHandler(this.buttonHost_Click);
            // 
            // buttonShare
            // 
            this.buttonShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShare.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.buttonShare.ButtonImage = null;
            this.buttonShare.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.buttonShare.ButtonText = "Share";
            this.buttonShare.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonShare.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonShare.CornerRadius = 20;
            this.buttonShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShare.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonShare.HoverBackgroundColor = System.Drawing.Color.White;
            this.buttonShare.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonShare.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonShare.Location = new System.Drawing.Point(63, 513);
            this.buttonShare.Name = "buttonShare";
            this.buttonShare.Size = new System.Drawing.Size(140, 40);
            this.buttonShare.TabIndex = 11;
            this.buttonShare.TextColor = System.Drawing.Color.White;
            this.buttonShare.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonShare.Click += new System.EventHandler(this.buttonShare_Click);
            // 
            // PhaseControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonShare);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonHost);
            this.Controls.Add(this.panelSections);
            this.Controls.Add(this.panelSectionContent);
            this.Name = "PhaseControl";
            this.Size = new System.Drawing.Size(1064, 607);
            this.panelSections.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards panelSections;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPhaseTitle;
        private Guna.UI.WinForms.GunaCircleButton buttonAddSection;
        private System.Windows.Forms.Panel panelSectionContent;
        private XanderUI.XUIButton buttonBack;
        private XanderUI.XUIButton buttonHost;
        private XanderUI.XUIButton buttonShare;
    }
}
