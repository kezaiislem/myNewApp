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
    public partial class SurveyTabControl : UserControl, INotifyPropertyChanged
    {

        SurveyTabControlViewModel viewModel;

        public SurveyTabControl(CustomSurveysObject s)
        {
            InitializeComponent();
            viewModel = new SurveyTabControlViewModel(s);
            Init();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNotifyPropertyChanged(ResultsControl resultsControl, string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                tmp(resultsControl, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Init()
        {
            metroLabelDate.Text = viewModel.strDate;
            metroLabelPhase.Text = viewModel.phaseNumber.ToString();
            metroLabelStatus.Text = viewModel.status;
            labelNumberOfAnswers.Text = viewModel.answersCount.ToString();
            if (viewModel.status == "Offline")
            {
                this.buttonStatus.Image = global::TechEval.Properties.Resources.wifi;
            }
        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult msgBox = MessageBox.Show("The survey will be removed completely and the project will be saved automaticly, Do you realy want to remove this survey ?", "Advertissement", MessageBoxButtons.YesNo);

            if (msgBox == DialogResult.Yes)
            {
                String result = await RestHelper.deleteSurvey(this.viewModel.surveyId);
                if (string.IsNullOrWhiteSpace(result))
                {
                    Console.WriteLine(this.viewModel.survey.host.id);
                    OnNotifyPropertyChanged(null, this.viewModel.survey.host.id);
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
                    this.buttonStatus.Image = global::TechEval.Properties.Resources.no_wifi;
                }
                else
                {
                    this.buttonStatus.Image = global::TechEval.Properties.Resources.wifi;
                }
                metroLabelStatus.Text = viewModel.status;
            }
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            ResultsControl resultsControl = new ResultsControl(this.viewModel.surveyId);
            resultsControl.Dock = DockStyle.Fill;
            resultsControl.AutoScaleMode = AutoScaleMode.None;
            OnNotifyPropertyChanged(resultsControl, "");
        }
    }
}
