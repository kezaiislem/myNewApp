namespace PFE
{
    partial class HypothesisTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HypothesisTabControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabelDescription = new MetroFramework.Controls.MetroLabel();
            this.metroLabelNumber = new MetroFramework.Controls.MetroLabel();
            this.buttonRemove = new JImageButton.JImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabelDescription, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemove, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroLabelDescription
            // 
            this.metroLabelDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabelDescription.AutoSize = true;
            this.metroLabelDescription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDescription.ForeColor = System.Drawing.Color.Black;
            this.metroLabelDescription.Location = new System.Drawing.Point(105, 15);
            this.metroLabelDescription.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.metroLabelDescription.Name = "metroLabelDescription";
            this.metroLabelDescription.Size = new System.Drawing.Size(78, 19);
            this.metroLabelDescription.TabIndex = 2;
            this.metroLabelDescription.Text = "Description";
            this.metroLabelDescription.UseCustomBackColor = true;
            this.metroLabelDescription.UseCustomForeColor = true;
            // 
            // metroLabelNumber
            // 
            this.metroLabelNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabelNumber.AutoSize = true;
            this.metroLabelNumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelNumber.ForeColor = System.Drawing.Color.Black;
            this.metroLabelNumber.Location = new System.Drawing.Point(15, 15);
            this.metroLabelNumber.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.metroLabelNumber.Name = "metroLabelNumber";
            this.metroLabelNumber.Size = new System.Drawing.Size(23, 19);
            this.metroLabelNumber.TabIndex = 1;
            this.metroLabelNumber.Text = "H ";
            this.metroLabelNumber.UseCustomBackColor = true;
            this.metroLabelNumber.UseCustomForeColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.CausesValidation = false;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRemove.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonRemove.ErrorImage")));
            this.buttonRemove.Image = global::PFE.Properties.Resources.trash_10_32;
            this.buttonRemove.ImageHover = null;
            this.buttonRemove.InitialImage = null;
            this.buttonRemove.Location = new System.Drawing.Point(844, 9);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Zoom = 1;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 50);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(906, 5);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 128;
            this.bunifuSeparator1.Vertical = false;
            // 
            // HypothesisTabControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HypothesisTabControl";
            this.Size = new System.Drawing.Size(906, 55);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel metroLabelDescription;
        private MetroFramework.Controls.MetroLabel metroLabelNumber;
        private JImageButton.JImageButton buttonRemove;
    }
}
