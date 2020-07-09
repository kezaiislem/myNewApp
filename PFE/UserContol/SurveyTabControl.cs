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

namespace PFE
{
    public partial class SurveyTabControl : UserControl
    {

        SurveyTabControlViewModel viewModel;

        public SurveyTabControl(Survey s)
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
            if(viewModel.status == "Offline")
            {
                this.buttonStatus.Image = global::PFE.Properties.Resources.wifi;
            }
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {

        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            String result = await RestHelper.deleteSurvey(this.viewModel.surveyId);
            if(string.IsNullOrWhiteSpace(result))
            {
                MessageBox.Show("Survey Removed Successfuly", "Success");
            } 
            else
            {
                MessageBox.Show("Oops an error has been occured", "Error");
            }
            this.Parent.Controls.Remove(this);
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
    }
}
