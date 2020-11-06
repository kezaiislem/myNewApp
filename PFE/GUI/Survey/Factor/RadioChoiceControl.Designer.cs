namespace PFE.UserContol
{
    partial class RadioChoiceControl
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
            this.buttonRemoveChoice = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBoxEditText = new System.Windows.Forms.TextBox();
            this.labeltext = new MetroFramework.Controls.MetroLabel();
            this.bunifuRadioButton1 = new Bunifu.UI.WinForms.BunifuRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemoveChoice
            // 
            this.buttonRemoveChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveChoice.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveChoice.Image = global::TechEval.Properties.Resources.red_cross;
            this.buttonRemoveChoice.ImageActive = null;
            this.buttonRemoveChoice.Location = new System.Drawing.Point(639, 5);
            this.buttonRemoveChoice.Name = "buttonRemoveChoice";
            this.buttonRemoveChoice.Size = new System.Drawing.Size(24, 24);
            this.buttonRemoveChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRemoveChoice.TabIndex = 9;
            this.buttonRemoveChoice.TabStop = false;
            this.buttonRemoveChoice.Visible = false;
            this.buttonRemoveChoice.Zoom = 10;
            this.buttonRemoveChoice.Click += new System.EventHandler(this.buttonRemoveChoice_Click);
            // 
            // textBoxEditText
            // 
            this.textBoxEditText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditText.BackColor = System.Drawing.Color.White;
            this.textBoxEditText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditText.Location = new System.Drawing.Point(71, 5);
            this.textBoxEditText.Name = "textBoxEditText";
            this.textBoxEditText.Size = new System.Drawing.Size(562, 24);
            this.textBoxEditText.TabIndex = 10;
            this.textBoxEditText.Visible = false;
            this.textBoxEditText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditText_KeyPress);
            // 
            // labeltext
            // 
            this.labeltext.Location = new System.Drawing.Point(71, 7);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(562, 19);
            this.labeltext.TabIndex = 12;
            this.labeltext.Text = "metroLabel1";
            this.labeltext.DoubleClick += new System.EventHandler(this.labelText_DoubleClick);
            // 
            // bunifuRadioButton1
            // 
            this.bunifuRadioButton1.Checked = true;
            this.bunifuRadioButton1.Location = new System.Drawing.Point(48, 10);
            this.bunifuRadioButton1.Name = "bunifuRadioButton1";
            this.bunifuRadioButton1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.bunifuRadioButton1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.bunifuRadioButton1.Size = new System.Drawing.Size(17, 17);
            this.bunifuRadioButton1.TabIndex = 13;
            this.bunifuRadioButton1.Text = null;
            // 
            // RadioChoiceControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bunifuRadioButton1);
            this.Controls.Add(this.labeltext);
            this.Controls.Add(this.buttonRemoveChoice);
            this.Controls.Add(this.textBoxEditText);
            this.Name = "RadioChoiceControl";
            this.Size = new System.Drawing.Size(672, 35);
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton buttonRemoveChoice;
        private System.Windows.Forms.TextBox textBoxEditText;
        private MetroFramework.Controls.MetroLabel labeltext;
        private Bunifu.UI.WinForms.BunifuRadioButton bunifuRadioButton1;
    }
}
