namespace PFE.UserContol
{
    partial class ProjectPlanControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectPlanControl));
            this.buttonAdd = new JImageButton.JImageButton();
            this.calendar1 = new Calendar.NET.Calendar();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.CausesValidation = false;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdd.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.ErrorImage")));
            this.buttonAdd.Image = global::PFE.Properties.Resources.adding_;
            this.buttonAdd.ImageHover = null;
            this.buttonAdd.InitialImage = null;
            this.buttonAdd.Location = new System.Drawing.Point(178, 17);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Size = new System.Drawing.Size(32, 32);
            this.buttonAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Zoom = 1;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // calendar1
            // 
            this.calendar1.AllowEditingEvents = true;
            this.calendar1.CalendarDate = new System.DateTime(2020, 7, 17, 20, 32, 44, 792);
            this.calendar1.CalendarView = Calendar.NET.CalendarViews.Month;
            this.calendar1.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.calendar1.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DaysFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendar1.DimDisabledEvents = true;
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendar1.HighlightCurrentDay = true;
            this.calendar1.LoadPresetHolidays = false;
            this.calendar1.Location = new System.Drawing.Point(0, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.ShowArrowControls = true;
            this.calendar1.ShowDashedBorderOnDisabledEvents = true;
            this.calendar1.ShowDateInHeader = true;
            this.calendar1.ShowDisabledEvents = false;
            this.calendar1.ShowEventTooltips = true;
            this.calendar1.ShowTodayButton = true;
            this.calendar1.Size = new System.Drawing.Size(1064, 607);
            this.calendar1.TabIndex = 0;
            this.calendar1.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // ProjectPlanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.calendar1);
            this.Name = "ProjectPlanControl";
            this.Size = new System.Drawing.Size(1064, 607);
            this.ResumeLayout(false);

        }

        #endregion

        private Calendar.NET.Calendar calendar1;
        private JImageButton.JImageButton buttonAdd;
    }
}
