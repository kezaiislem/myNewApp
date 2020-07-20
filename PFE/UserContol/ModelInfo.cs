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
using PFE.model;

namespace PFE.UserContol
{
    public partial class ModelInfo : UserControl
    {

        public ModelInfoViewModel viewModel;

        public ModelInfo(PFE.Model.Model model, MainForm main)
        {
            InitializeComponent();
            Init(model, main);
        }

        public void Init(PFE.Model.Model model, MainForm main)
        {
            viewModel = new ModelInfoViewModel(model, main);
            loadExistingSurveys();
            textBoxEvaluationContext.DataBindings.Add("Text", viewModel.model, "evaluationContext", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void loadExistingSurveys()
        {
            this.viewModel.model.surveys = viewModel.model.surveys.OrderByDescending(q => q.phaseNumber).ToList<Survey>();
            foreach (Survey survey in this.viewModel.model.surveys)
            {
                survey.model = this.viewModel.model;
                this.addSurvey(survey);
            }
        }

        private void buttonAddPhase_Click(object sender, EventArgs e)
        {
            if(this.viewModel.aviabePhases.Count() > 0)
            {
                using (var form = new AddSurveyForm(this.viewModel.aviabePhases))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Survey survey = new Survey
                        {
                            phaseNumber = form.viewModel.SelectedPhase,
                            title = form.viewModel.Title,
                            description = form.viewModel.Description,
                            model = this.viewModel.model,
                            factors = new List<Factor>()
                        };
                        this.addSurvey(survey);
                        this.viewModel.model.surveys.Add(survey);
                    }
                }
            }
        }

        private void addSurvey(Survey survey)
        {
            ModelSurveyControl modelSurveyControl = new ModelSurveyControl(survey, this.viewModel.model.surveys);
            modelSurveyControl.AutoScaleMode = AutoScaleMode.None;
            modelSurveyControl.Dock = DockStyle.Left;
            panelPhasesContainer.Controls.Add(modelSurveyControl);
            switch (survey.phaseNumber)
            {
                case 1:
                    panelPhasesContainer.Controls.SetChildIndex(modelSurveyControl, 2);
                    break;
                case 2:
                    panelPhasesContainer.Controls.SetChildIndex(modelSurveyControl, 1);
                    break;
                case 3:
                    panelPhasesContainer.Controls.SetChildIndex(modelSurveyControl, 0);
                    break;
            }
        }
    }
}
