using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.ViewModel;
using PFE.Shared;
using Microsoft.VisualBasic;
using PFE.CustomObjects;
using PFE.Model;

namespace PFE.UserContol
{
    public partial class ValidationControl : UserControl
    {

        ValidationControlViewModel viewModel;

        StatisticsControl currentControl;

        public ValidationControl(Model.Model model)
        {
            InitializeComponent();
            viewModel = new ValidationControlViewModel(model);
            labelStepDescription.Text = "This application allows you to apply both exploratory and confirmatory analyzes to your surveys data within these conditions\n\n" +
                "   1 - R must be installed in your pc with the folowing libraries (psych, nFactors, GridExrtra)\n" +
                "   2 - Your survey must have at least two factors\n" +
                "   3 - Your survey must be hosted\n" +
                "   4 - The number of answers must be greater than the total number of questions";
            loadSurveys();
        }

        private void loadSurveys()
        {
            foreach (Survey s in viewModel.model.surveys)
            {
                ResultSurveyControl surveyTab = new ResultSurveyControl(s);
                surveyTab.AutoScaleMode = AutoScaleMode.None;
                surveyTab.Dock = DockStyle.Left;
                surveyTab.PropertyChanged += CurrentPhaseChanged;
                this.panelSurveysContainer.Controls.Add(surveyTab);
                this.panelSurveysContainer.Controls.SetChildIndex(surveyTab, 0);
            }
        }

        private void SurveysControl_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                if (this.currentControl != null)
                {
                    this.Controls.Remove(currentControl);
                    currentControl.Dispose();
                    currentControl = null;
                }
            }
            else
            {
                this.panelSurveysContainer.Controls.Clear();
                this.loadSurveys();
            }
        }

        private void CurrentPhaseChanged(object o, PropertyChangedEventArgs e)
        {
            if (o != null)
            {
                currentControl = (StatisticsControl)o;
                this.Controls.Add(currentControl);
                currentControl.BringToFront();
                currentControl.Show();
            }
        }

    }
}
