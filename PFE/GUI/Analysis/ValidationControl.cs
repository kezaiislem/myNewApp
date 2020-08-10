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
