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
using PFE.Model;
using PFE.Shared;
using PFE.UserContol;
using PFE.CustomObjects;

namespace PFE
{
    public partial class SurveyTabControl : UserControl
    {

        SurveyTabControlViewModel viewModel;

        public SurveyTabControl (CustomSurveysObject s)
        {
            InitializeComponent();
            viewModel = new SurveyTabControlViewModel(s);
            Init();
        }

        private void Init()
        {
            metroLabelDate.Text = viewModel.strDate;
            metroLabelPhase.Text = viewModel.phaseNumber.ToString();
            metroLabelStatus.Text = viewModel.status;
            labelNumberOfAnswers.Text = viewModel.answersCount.ToString();
            if (viewModel.status == "Offline")
            {
                this.buttonStatus.Image = global::PFE.Properties.Resources.wifi;
            }
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {

        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult msgBox = MessageBox.Show("The survey will be removed completely and the project will be saved automaticly, Do you realy want to remove this survey ?", "Advertissement", MessageBoxButtons.YesNo);

            if (msgBox == DialogResult.Yes)
            {
                String result = await RestHelper.deleteSurvey(this.viewModel.surveyId);
                if (string.IsNullOrWhiteSpace(result))
                {
                    this.viewModel.survey.host = null;
                    MessageBox.Show("Survey Removed Successfuly", "Success");
                }
                else
                {
                    MessageBox.Show("Oops an error has been occured", "Error");
                }
                this.Parent.Controls.Remove(this);
            }
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            if (viewModel.switchStatus())
            {
                if (this.viewModel.status == "Online")
                {
                    this.buttonStatus.Image = global::PFE.Properties.Resources.no_wifi;
                }
                else
                {
                    this.buttonStatus.Image = global::PFE.Properties.Resources.wifi;
                }
                metroLabelStatus.Text = viewModel.status;
            }
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            ResultsControl resultsControl = new ResultsControl(this.viewModel.surveyId);
            resultsControl.Dock = DockStyle.Fill;
            resultsControl.AutoScaleMode = AutoScaleMode.None;
            this.Parent.Parent.Parent.Parent.Controls.Add(resultsControl);
            resultsControl.Show();
            resultsControl.BringToFront();
        }
    }
}
