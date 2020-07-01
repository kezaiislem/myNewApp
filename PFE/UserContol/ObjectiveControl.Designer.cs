namespace PFE
{
    partial class ObjectiveControl
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
            this.objectiveCard = new Bunifu.Framework.UI.BunifuCards();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelObjective = new MetroFramework.Controls.MetroLabel();
            this.textBoxEditObjective = new System.Windows.Forms.TextBox();
            this.objectiveCard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectiveCard
            // 
            this.objectiveCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.objectiveCard.BackColor = System.Drawing.Color.White;
            this.objectiveCard.BorderRadius = 15;
            this.objectiveCard.BottomSahddow = true;
            this.objectiveCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.objectiveCard.Controls.Add(this.tableLayoutPanel1);
            this.objectiveCard.LeftSahddow = false;
            this.objectiveCard.Location = new System.Drawing.Point(2, 2);
            this.objectiveCard.Margin = new System.Windows.Forms.Padding(2);
            this.objectiveCard.Name = "objectiveCard";
            this.objectiveCard.RightSahddow = true;
            this.objectiveCard.ShadowDepth = 20;
            this.objectiveCard.Size = new System.Drawing.Size(956, 56);
            this.objectiveCard.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuImageButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::PFE.Properties.Resources.target__Personnalisé_;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(7, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelObjective);
            this.panel1.Controls.Add(this.textBoxEditObjective);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(53, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 44);
            this.panel1.TabIndex = 1;
            // 
            // labelObjective
            // 
            this.labelObjective.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelObjective.AutoSize = true;
            this.labelObjective.BackColor = System.Drawing.Color.Transparent;
            this.labelObjective.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelObjective.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelObjective.Location = new System.Drawing.Point(13, 12);
            this.labelObjective.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelObjective.Name = "labelObjective";
            this.labelObjective.Size = new System.Drawing.Size(86, 19);
            this.labelObjective.TabIndex = 2;
            this.labelObjective.Text = "metroLabel1";
            this.labelObjective.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelObjective.UseCustomBackColor = true;
            this.labelObjective.DoubleClick += new System.EventHandler(this.labelObjective_DoubleClick);
            // 
            // textBoxEditObjective
            // 
            this.textBoxEditObjective.BackColor = System.Drawing.Color.White;
            this.textBoxEditObjective.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEditObjective.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditObjective.Location = new System.Drawing.Point(10, 10);
            this.textBoxEditObjective.Name = "textBoxEditObjective";
            this.textBoxEditObjective.Size = new System.Drawing.Size(867, 24);
            this.textBoxEditObjective.TabIndex = 3;
            this.textBoxEditObjective.Visible = false;
            this.textBoxEditObjective.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditObjective_KeyPress);
            // 
            // ObjectiveControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.objectiveCard);
            this.Name = "ObjectiveControl";
            this.Size = new System.Drawing.Size(960, 60);
            this.objectiveCard.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards objectiveCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel labelObjective;
        private System.Windows.Forms.TextBox textBoxEditObjective;
    }
}
