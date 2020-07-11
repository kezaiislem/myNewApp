namespace PFE.UserContol
{
    partial class ModelInfo
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
            this.metroCheckBoxPhase1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxPhase2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxPhase3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroButtonSaveModel = new MetroFramework.Controls.MetroButton();
            this.textBoxEvaluationContext = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPhasesContainer = new System.Windows.Forms.Panel();
            this.buttonAddPhase = new Guna.UI.WinForms.GunaCircleButton();
            this.bunifuCards2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroCheckBoxPhase1
            // 
            this.metroCheckBoxPhase1.AutoSize = true;
            this.metroCheckBoxPhase1.Location = new System.Drawing.Point(227, 125);
            this.metroCheckBoxPhase1.Name = "metroCheckBoxPhase1";
            this.metroCheckBoxPhase1.Size = new System.Drawing.Size(63, 15);
            this.metroCheckBoxPhase1.TabIndex = 0;
            this.metroCheckBoxPhase1.Text = "Phase 1";
            this.metroCheckBoxPhase1.UseSelectable = true;
            // 
            // metroCheckBoxPhase2
            // 
            this.metroCheckBoxPhase2.AutoSize = true;
            this.metroCheckBoxPhase2.Location = new System.Drawing.Point(227, 158);
            this.metroCheckBoxPhase2.Name = "metroCheckBoxPhase2";
            this.metroCheckBoxPhase2.Size = new System.Drawing.Size(63, 15);
            this.metroCheckBoxPhase2.TabIndex = 1;
            this.metroCheckBoxPhase2.Text = "Phase 2";
            this.metroCheckBoxPhase2.UseSelectable = true;
            // 
            // metroCheckBoxPhase3
            // 
            this.metroCheckBoxPhase3.AutoSize = true;
            this.metroCheckBoxPhase3.Location = new System.Drawing.Point(227, 191);
            this.metroCheckBoxPhase3.Name = "metroCheckBoxPhase3";
            this.metroCheckBoxPhase3.Size = new System.Drawing.Size(63, 15);
            this.metroCheckBoxPhase3.TabIndex = 2;
            this.metroCheckBoxPhase3.Text = "Phase 3";
            this.metroCheckBoxPhase3.UseSelectable = true;
            // 
            // metroButtonSaveModel
            // 
            this.metroButtonSaveModel.Location = new System.Drawing.Point(378, 167);
            this.metroButtonSaveModel.Name = "metroButtonSaveModel";
            this.metroButtonSaveModel.Size = new System.Drawing.Size(121, 23);
            this.metroButtonSaveModel.TabIndex = 3;
            this.metroButtonSaveModel.Text = "Save";
            this.metroButtonSaveModel.UseSelectable = true;
            this.metroButtonSaveModel.Click += new System.EventHandler(this.metroButtonSaveModel_Click);
            // 
            // textBoxEvaluationContext
            // 
            // 
            // 
            // 
            this.textBoxEvaluationContext.CustomButton.Image = null;
            this.textBoxEvaluationContext.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.textBoxEvaluationContext.CustomButton.Name = "";
            this.textBoxEvaluationContext.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxEvaluationContext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxEvaluationContext.CustomButton.TabIndex = 1;
            this.textBoxEvaluationContext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxEvaluationContext.CustomButton.UseSelectable = true;
            this.textBoxEvaluationContext.CustomButton.Visible = false;
            this.textBoxEvaluationContext.Lines = new string[0];
            this.textBoxEvaluationContext.Location = new System.Drawing.Point(170, 73);
            this.textBoxEvaluationContext.MaxLength = 32767;
            this.textBoxEvaluationContext.Name = "textBoxEvaluationContext";
            this.textBoxEvaluationContext.PasswordChar = '\0';
            this.textBoxEvaluationContext.PromptText = "Evaluation Context";
            this.textBoxEvaluationContext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEvaluationContext.SelectedText = "";
            this.textBoxEvaluationContext.SelectionLength = 0;
            this.textBoxEvaluationContext.SelectionStart = 0;
            this.textBoxEvaluationContext.ShortcutsEnabled = true;
            this.textBoxEvaluationContext.Size = new System.Drawing.Size(188, 23);
            this.textBoxEvaluationContext.TabIndex = 4;
            this.textBoxEvaluationContext.UseSelectable = true;
            this.textBoxEvaluationContext.WaterMark = "Evaluation Context";
            this.textBoxEvaluationContext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxEvaluationContext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 15;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.metroLabel3);
            this.bunifuCards2.Controls.Add(this.metroButtonSaveModel);
            this.bunifuCards2.Controls.Add(this.metroCheckBoxPhase3);
            this.bunifuCards2.Controls.Add(this.textBoxEvaluationContext);
            this.bunifuCards2.Controls.Add(this.metroCheckBoxPhase2);
            this.bunifuCards2.Controls.Add(this.metroCheckBoxPhase1);
            this.bunifuCards2.Controls.Add(this.panel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(403, 18);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 50;
            this.bunifuCards2.Size = new System.Drawing.Size(643, 254);
            this.bunifuCards2.TabIndex = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(117, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Evaluation Context";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.buttonAddPhase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 50);
            this.panel1.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(17, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Model Info";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.Location = new System.Drawing.Point(15, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(333, 224);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "lnformation sur le model and what to do ext";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Location = new System.Drawing.Point(18, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(363, 254);
            this.panel2.TabIndex = 9;
            // 
            // panelPhasesContainer
            // 
            this.panelPhasesContainer.Location = new System.Drawing.Point(18, 291);
            this.panelPhasesContainer.Name = "panelPhasesContainer";
            this.panelPhasesContainer.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panelPhasesContainer.Size = new System.Drawing.Size(1028, 298);
            this.panelPhasesContainer.TabIndex = 11;
            // 
            // buttonAddPhase
            // 
            this.buttonAddPhase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPhase.AnimationHoverSpeed = 0.07F;
            this.buttonAddPhase.AnimationSpeed = 0.03F;
            this.buttonAddPhase.BaseColor = System.Drawing.Color.Transparent;
            this.buttonAddPhase.BorderColor = System.Drawing.Color.Black;
            this.buttonAddPhase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAddPhase.FocusedColor = System.Drawing.Color.Empty;
            this.buttonAddPhase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddPhase.ForeColor = System.Drawing.Color.White;
            this.buttonAddPhase.Image = global::PFE.Properties.Resources.add_plus;
            this.buttonAddPhase.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonAddPhase.Location = new System.Drawing.Point(601, 10);
            this.buttonAddPhase.Name = "buttonAddPhase";
            this.buttonAddPhase.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.buttonAddPhase.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonAddPhase.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonAddPhase.OnHoverImage = null;
            this.buttonAddPhase.OnPressedColor = System.Drawing.Color.Black;
            this.buttonAddPhase.Size = new System.Drawing.Size(30, 30);
            this.buttonAddPhase.TabIndex = 4;
            this.buttonAddPhase.Click += new System.EventHandler(this.buttonAddPhase_Click);
            // 
            // ModelInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelPhasesContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuCards2);
            this.Name = "ModelInfo";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(1064, 607);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPhase1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPhase2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPhase3;
        private MetroFramework.Controls.MetroButton metroButtonSaveModel;
        private MetroFramework.Controls.MetroTextBox textBoxEvaluationContext;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCircleButton buttonAddPhase;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panelPhasesContainer;
    }
}
