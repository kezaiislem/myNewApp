namespace PFE.UserContol
{
    partial class FactorControl
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
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDescription = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddQuestion = new Guna.UI.WinForms.GunaCircleButton();
            this.labelTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 15;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.mainPanel);
            this.bunifuCards2.Controls.Add(this.panel1);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 50;
            this.bunifuCards2.Size = new System.Drawing.Size(760, 561);
            this.bunifuCards2.TabIndex = 9;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(760, 511);
            this.mainPanel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 49);
            this.panel2.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(28, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(74, 19);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.buttonAddQuestion);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 50);
            this.panel1.TabIndex = 7;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddQuestion.AnimationHoverSpeed = 0.07F;
            this.buttonAddQuestion.AnimationSpeed = 0.03F;
            this.buttonAddQuestion.BaseColor = System.Drawing.Color.Transparent;
            this.buttonAddQuestion.BorderColor = System.Drawing.Color.Black;
            this.buttonAddQuestion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAddQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.buttonAddQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonAddQuestion.Image = global::PFE.Properties.Resources.add_plus;
            this.buttonAddQuestion.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonAddQuestion.Location = new System.Drawing.Point(718, 10);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.buttonAddQuestion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonAddQuestion.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonAddQuestion.OnHoverImage = null;
            this.buttonAddQuestion.OnPressedColor = System.Drawing.Color.Black;
            this.buttonAddQuestion.Size = new System.Drawing.Size(30, 30);
            this.buttonAddQuestion.TabIndex = 4;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(15, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(63, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Section";
            // 
            // SectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards2);
            this.Name = "SectionControl";
            this.Size = new System.Drawing.Size(760, 561);
            this.bunifuCards2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCircleButton buttonAddQuestion;
        private Bunifu.Framework.UI.BunifuCustomLabel labelTitle;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel labelDescription;
    }
}
