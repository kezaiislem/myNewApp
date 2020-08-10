namespace PFE.UserContol
{
    partial class QuestionResultControl
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
            this.labelQuestion = new MetroFramework.Controls.MetroLabel();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestion.Location = new System.Drawing.Point(24, 19);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(360, 213);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "metroLabel1";
            // 
            // pieChart
            // 
            this.pieChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart.Location = new System.Drawing.Point(349, 19);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(421, 213);
            this.pieChart.TabIndex = 1;
            this.pieChart.Text = "pieChart1";
            this.pieChart.Visible = false;
            // 
            // QuestionResultControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.labelQuestion);
            this.Name = "QuestionResultControl";
            this.Size = new System.Drawing.Size(792, 254);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelQuestion;
        private LiveCharts.WinForms.PieChart pieChart;
    }
}
