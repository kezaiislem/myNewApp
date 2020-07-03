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
            this.SuspendLayout();
            // 
            // metroCheckBoxPhase1
            // 
            this.metroCheckBoxPhase1.AutoSize = true;
            this.metroCheckBoxPhase1.Location = new System.Drawing.Point(256, 157);
            this.metroCheckBoxPhase1.Name = "metroCheckBoxPhase1";
            this.metroCheckBoxPhase1.Size = new System.Drawing.Size(63, 15);
            this.metroCheckBoxPhase1.TabIndex = 0;
            this.metroCheckBoxPhase1.Text = "Phase 1";
            this.metroCheckBoxPhase1.UseSelectable = true;
            // 
            // metroCheckBoxPhase2
            // 
            this.metroCheckBoxPhase2.AutoSize = true;
            this.metroCheckBoxPhase2.Location = new System.Drawing.Point(256, 189);
            this.metroCheckBoxPhase2.Name = "metroCheckBoxPhase2";
            this.metroCheckBoxPhase2.Size = new System.Drawing.Size(63, 15);
            this.metroCheckBoxPhase2.TabIndex = 1;
            this.metroCheckBoxPhase2.Text = "Phase 2";
            this.metroCheckBoxPhase2.UseSelectable = true;
            // 
            // metroCheckBoxPhase3
            // 
            this.metroCheckBoxPhase3.AutoSize = true;
            this.metroCheckBoxPhase3.Location = new System.Drawing.Point(256, 223);
            this.metroCheckBoxPhase3.Name = "metroCheckBoxPhase3";
            this.metroCheckBoxPhase3.Size = new System.Drawing.Size(63, 15);
            this.metroCheckBoxPhase3.TabIndex = 2;
            this.metroCheckBoxPhase3.Text = "Phase 3";
            this.metroCheckBoxPhase3.UseSelectable = true;
            // 
            // metroButtonSaveModel
            // 
            this.metroButtonSaveModel.Location = new System.Drawing.Point(232, 253);
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
            this.textBoxEvaluationContext.Location = new System.Drawing.Point(218, 113);
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
            // ModelInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBoxEvaluationContext);
            this.Controls.Add(this.metroButtonSaveModel);
            this.Controls.Add(this.metroCheckBoxPhase3);
            this.Controls.Add(this.metroCheckBoxPhase2);
            this.Controls.Add(this.metroCheckBoxPhase1);
            this.Name = "ModelInfo";
            this.Size = new System.Drawing.Size(1064, 607);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPhase1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPhase2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPhase3;
        private MetroFramework.Controls.MetroButton metroButtonSaveModel;
        private MetroFramework.Controls.MetroTextBox textBoxEvaluationContext;
    }
}
