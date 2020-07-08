namespace PFE
{
    partial class SurveyTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurveyTabControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabelPhase = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabelStatus = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.xuiSuperButton2 = new XanderUI.XUISuperButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabelStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelPhase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 50);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // metroLabelPhase
            // 
            this.metroLabelPhase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabelPhase.AutoSize = true;
            this.metroLabelPhase.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelPhase.ForeColor = System.Drawing.Color.Black;
            this.metroLabelPhase.Location = new System.Drawing.Point(15, 15);
            this.metroLabelPhase.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.metroLabelPhase.Name = "metroLabelPhase";
            this.metroLabelPhase.Size = new System.Drawing.Size(17, 19);
            this.metroLabelPhase.TabIndex = 1;
            this.metroLabelPhase.Text = "1";
            this.metroLabelPhase.UseCustomForeColor = true;
            // 
            // metroLabelDate
            // 
            this.metroLabelDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabelDate.AutoSize = true;
            this.metroLabelDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDate.ForeColor = System.Drawing.Color.Black;
            this.metroLabelDate.Location = new System.Drawing.Point(241, 15);
            this.metroLabelDate.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.metroLabelDate.Name = "metroLabelDate";
            this.metroLabelDate.Size = new System.Drawing.Size(83, 19);
            this.metroLabelDate.TabIndex = 2;
            this.metroLabelDate.Text = "12/12/2012";
            this.metroLabelDate.UseCustomForeColor = true;
            // 
            // metroLabelStatus
            // 
            this.metroLabelStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabelStatus.AutoSize = true;
            this.metroLabelStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelStatus.ForeColor = System.Drawing.Color.Black;
            this.metroLabelStatus.Location = new System.Drawing.Point(467, 15);
            this.metroLabelStatus.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.metroLabelStatus.Name = "metroLabelStatus";
            this.metroLabelStatus.Size = new System.Drawing.Size(49, 19);
            this.metroLabelStatus.TabIndex = 3;
            this.metroLabelStatus.Text = "Online";
            this.metroLabelStatus.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.xuiSuperButton2);
            this.panel1.Controls.Add(this.xuiSuperButton1);
            this.panel1.Location = new System.Drawing.Point(747, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 32);
            this.panel1.TabIndex = 4;
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ButtonImage = global::PFE.Properties.Resources.close;
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "";
            this.xuiSuperButton1.CornerRadius = 5;
            this.xuiSuperButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(0, 0);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(32, 32);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 0;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiSuperButton2
            // 
            this.xuiSuperButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiSuperButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton2.ButtonImage")));
            this.xuiSuperButton2.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton2.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton2.ButtonText = "";
            this.xuiSuperButton2.CornerRadius = 5;
            this.xuiSuperButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.xuiSuperButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton2.Location = new System.Drawing.Point(58, 0);
            this.xuiSuperButton2.Name = "xuiSuperButton2";
            this.xuiSuperButton2.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton2.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.Size = new System.Drawing.Size(32, 32);
            this.xuiSuperButton2.SuperSelected = false;
            this.xuiSuperButton2.TabIndex = 1;
            this.xuiSuperButton2.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // SurveyTabControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SurveyTabControl";
            this.Size = new System.Drawing.Size(906, 55);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel metroLabelStatus;
        private MetroFramework.Controls.MetroLabel metroLabelDate;
        private MetroFramework.Controls.MetroLabel metroLabelPhase;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUISuperButton xuiSuperButton2;
        private XanderUI.XUISuperButton xuiSuperButton1;
    }
}
