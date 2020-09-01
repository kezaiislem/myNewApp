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
        public PhaseControl currentControl;

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
            this.labelDescription.Text = "You can evaluate your technology according to 3 different levels.\n" +
                " - Level (Phase) 1 : Technology addoption or first use.\n" +
                " - Level (Phase) 2 : Medium-Term use.\n" +
                " - Level (Phase) 3 : Long-Term use.\n" +
                "First you need to spesify the context of the evaluation (ex : Educational use).\n" +
                "Then you can add surveys (Only one is allowed for each level) by clicking on the button ( + ).";
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
            modelSurveyControl.PropertyChanged += CurrentPhaseChanged;
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

        private void CurrentPhaseChanged(object o, PropertyChangedEventArgs e)
        {
            if (o != null)
            {
                currentControl = (PhaseControl)o;
                this.Controls.Add(currentControl);
                currentControl.BringToFront();
                currentControl.Show();
            }
        }

        private void ModelInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                if(this.currentControl != null)
                {
                    this.Controls.Remove(currentControl);
                    currentControl.Dispose();
                    currentControl = null;
                }
            }
        }
    }
}
