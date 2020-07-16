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
    public partial class ModelSurveyControl : UserControl
    {

        ModelSurveyControlViewModel viewModel;

        public ModelSurveyControl(Survey survey, List<Survey> surveys)
        {
            InitializeComponent();
            Init(survey, surveys);
        }

        private void Init(Survey survey, List<Survey> surveys)
        {
            viewModel = new ModelSurveyControlViewModel(survey, surveys);
            labelTitle.DataBindings.Add("Text", viewModel.survey, "title", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxTitle.DataBindings.Add("Text", labelTitle, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
            labelDescription.DataBindings.Add("Text", viewModel.survey, "description", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxDescription.DataBindings.Add("Text", labelDescription, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
            labelPhase.Text = "Phase " + survey.phaseNumber;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            panelEdit.Visible = true;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            PhaseControl phaseControl = new PhaseControl(this.viewModel.survey);
            phaseControl.Visible = false;
            phaseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            phaseControl.AutoScaleMode = AutoScaleMode.None;
            phaseControl.Name = "projectContextView";
            this.Parent.Parent.Controls.Add(phaseControl);
            phaseControl.BringToFront();
            phaseControl.Show();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {

            DialogResult msgBox = MessageBox.Show("The survey will be removed completely and the project will be saved automaticly, Do you realy want to remove this survey ?", "Advertissement", MessageBoxButtons.YesNo);
            
            if(msgBox == DialogResult.Yes)
            {
                Task.Run(async () => await RestHelper.deleteSurvey(this.viewModel.survey.id));
                this.viewModel.surveys.Remove(this.viewModel.survey);
                this.Parent.Controls.Remove(this);
                ProjectHandler.saveProject();
            }

        }
    }
}
