namespace PFE.UserContol
{
    partial class RadioQuestionContol
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelQuestion = new MetroFramework.Controls.MetroLabel();
            this.buttonRemoveQuestion = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBoxEditQuestion = new System.Windows.Forms.TextBox();
            this.bunifuCards2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 15;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.bunifuCards2.Controls.Add(this.panel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(43, 5);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 50;
            this.bunifuCards2.Size = new System.Drawing.Size(706, 90);
            this.bunifuCards2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 84);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 44);
            this.panel3.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BackgroundImage = global::PFE.Properties.Resources.addGreen;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(666, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelQuestion);
            this.panel2.Controls.Add(this.buttonRemoveQuestion);
            this.panel2.Controls.Add(this.textBoxEditQuestion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 40);
            this.panel2.TabIndex = 0;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(17, 11);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(80, 19);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question 1 ?";
            this.labelQuestion.DoubleClick += new System.EventHandler(this.labelQuestion_DoubleClick);
            // 
            // buttonRemoveQuestion
            // 
            this.buttonRemoveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveQuestion.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveQuestion.Image = global::PFE.Properties.Resources.criss_cross;
            this.buttonRemoveQuestion.ImageActive = null;
            this.buttonRemoveQuestion.Location = new System.Drawing.Point(666, 8);
            this.buttonRemoveQuestion.Name = "buttonRemoveQuestion";
            this.buttonRemoveQuestion.Size = new System.Drawing.Size(24, 24);
            this.buttonRemoveQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRemoveQuestion.TabIndex = 5;
            this.buttonRemoveQuestion.TabStop = false;
            this.buttonRemoveQuestion.Visible = false;
            this.buttonRemoveQuestion.Zoom = 10;
            this.buttonRemoveQuestion.Click += new System.EventHandler(this.buttonRemoveQuestion_Click);
            // 
            // textBoxEditQuestion
            // 
            this.textBoxEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditQuestion.BackColor = System.Drawing.Color.White;
            this.textBoxEditQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEditQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditQuestion.Location = new System.Drawing.Point(9, 8);
            this.textBoxEditQuestion.Name = "textBoxEditQuestion";
            this.textBoxEditQuestion.Size = new System.Drawing.Size(651, 24);
            this.textBoxEditQuestion.TabIndex = 6;
            this.textBoxEditQuestion.Visible = false;
            this.textBoxEditQuestion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditQuestion_KeyPress);
            // 
            // RadioQuestionContol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bunifuCards2);
            this.Name = "RadioQuestionContol";
            this.Size = new System.Drawing.Size(792, 100);
            this.bunifuCards2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel labelQuestion;
        private Bunifu.Framework.UI.BunifuImageButton buttonRemoveQuestion;
        private System.Windows.Forms.TextBox textBoxEditQuestion;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
