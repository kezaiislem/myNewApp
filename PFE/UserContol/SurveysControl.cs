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
using PFE.Model;

namespace PFE.UserContol
{
    public partial class SurveysControl : UserControl
    {

        SurveysControlViewModel viewModel;

        public SurveysControl(int modelId)
        {
            InitializeComponent();
            viewModel = new SurveysControlViewModel(modelId);
            loadSurveys();
        }

        private void loadSurveys()
        {
            while(viewModel.surveys == null) { }

            foreach (Survey s in viewModel.surveys)
            {
                SurveyTabControl surveyTab = new SurveyTabControl(s);
                this.panelSurveyTableContent.SuspendLayout();
                surveyTab.Dock = DockStyle.Top;
                surveyTab.Height = 55;
                surveyTab.Visible = true;
                this.panelSurveyTableContent.Controls.Add(surveyTab);
                this.panelSurveyTableContent.Controls.SetChildIndex(surveyTab, 0);
                this.panelSurveyTableContent.ResumeLayout(false);
            }
        }

        private void SurveysControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.panelSurveyTableContent.Controls.Clear();
                this.viewModel.refresh();
                while (viewModel.surveys == null) { }
                this.loadSurveys();
            }
        }
    }
}
