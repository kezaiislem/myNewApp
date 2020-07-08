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
            while(viewModel.surveys == null)
            {

            }
            foreach (Survey s in viewModel.surveys)
            {
                SurveyTabControl surveyTab = new SurveyTabControl(s);
                this.panelSurveyTable.SuspendLayout();
                surveyTab.Dock = DockStyle.Top;
                surveyTab.Height = 55;
                surveyTab.Visible = true;
                this.panelSurveyTable.Controls.Add(surveyTab);
                this.panelSurveyTable.Controls.SetChildIndex(surveyTab, 0);
                this.panelSurveyTable.ResumeLayout(false);
            }
        }
    }
}
