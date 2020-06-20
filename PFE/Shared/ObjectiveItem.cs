using Bunifu.Framework.UI;
using Guna.UI2.WinForms.Suite;
using System.Drawing;
using System.Windows.Forms;

namespace PFE.Shared
{
    class ObjectiveItem
    {
        public System.Windows.Forms.Panel panel { get; set; }
        public TableLayoutPanel tableLayout { get; set;}
        public BunifuImageButton bunifuImageButton { get; set; }
        public Label label { get; set; }
        public BunifuCards bunifuCards { get; set; }

        public static int tabTndex = 2;

        public ObjectiveItem(string text, int x)
        {
            this.panel = new System.Windows.Forms.Panel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCards = new BunifuCards();
            this.bunifuImageButton = new BunifuImageButton();
            this.label = new Label();

            this.panel.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.bunifuCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton)).BeginInit();
            this.label.SuspendLayout();

            this.panel.Controls.Add(this.bunifuCards);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panelObj"+tabTndex;
            this.panel.Size = new System.Drawing.Size(x+20, 60);
            this.panel.TabIndex = tabTndex;

            this.bunifuCards.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            this.bunifuCards.BackColor = System.Drawing.Color.White;
            this.bunifuCards.BorderRadius = 15;
            this.bunifuCards.BottomSahddow = true;
            this.bunifuCards.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.bunifuCards.Controls.Add(this.tableLayout);
            this.bunifuCards.LeftSahddow = false;
            this.bunifuCards.Location = new System.Drawing.Point(2, 2);
            this.bunifuCards.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuCards.Name = "bunifuCardsObj"+tabTndex;
            this.bunifuCards.RightSahddow = true;
            this.bunifuCards.ShadowDepth = 20;
            this.bunifuCards.Size = new System.Drawing.Size(x, 56);
            this.bunifuCards.TabIndex = 0;

            this.tableLayout.BackColor = System.Drawing.Color.White;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.bunifuImageButton, 0, 0);
            this.tableLayout.Controls.Add(this.label, 1, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayoutPanelObj"+tabTndex;
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(x, 56);
            this.tableLayout.TabIndex = 1;

            this.bunifuImageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton.Image = global::PFE.Properties.Resources.target__Personnalisé_;
            this.bunifuImageButton.ImageActive = null;
            this.bunifuImageButton.Location = new System.Drawing.Point(7, 10);
            this.bunifuImageButton.Name = "bunifuImageButtonObj"+tabTndex;
            this.bunifuImageButton.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton.TabIndex = 0;
            this.bunifuImageButton.TabStop = false;
            this.bunifuImageButton.Zoom = 10;

            this.label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(53, 18);
            this.label.Name = "labelObj"+tabTndex;
            this.label.TabIndex = 1;
            this.label.Text = text;

            this.panel.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.bunifuCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton)).EndInit();
            this.label.ResumeLayout(false);

            tabTndex++;
        }
    }
}
