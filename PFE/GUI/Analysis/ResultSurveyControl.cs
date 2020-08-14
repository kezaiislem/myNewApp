using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.Model;
using PFE.ViewModel;
using PFE.Shared;

namespace PFE.UserContol
{
    public partial class ResultSurveyControl : UserControl, INotifyPropertyChanged
    {

        ResultSurveyControlViewModel viewModel;

        public ResultSurveyControl(Survey survey)
        {
            InitializeComponent();
            Init(survey);
        }

        private void Init(Survey survey)
        {
            viewModel = new ResultSurveyControlViewModel(survey);
            labelTitle.DataBindings.Add("Text", viewModel.survey, "title", true, DataSourceUpdateMode.OnPropertyChanged);
            labelDescription.DataBindings.Add("Text", viewModel.survey, "description", true, DataSourceUpdateMode.OnPropertyChanged);
            labelPhase.Text = "Phase " + survey.phaseNumber;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            NotifyOnPropertyChanged("");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOnPropertyChanged(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                StatisticsControl statisticsControl = new StatisticsControl(this.viewModel.survey.host.id);
                statisticsControl.Dock = DockStyle.Fill;
                statisticsControl.AutoScaleMode = AutoScaleMode.None;
                tmp(statisticsControl, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
