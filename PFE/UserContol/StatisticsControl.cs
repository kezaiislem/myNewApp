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
using System.Web.UI.Design;
using MetroFramework.Controls;
using PFE.Shared;
using PFE.Model;
using Newtonsoft.Json;
using MetroFramework;
using PFE.Constants;
using PFE.model;
using DocumentFormat.OpenXml.Bibliography;

namespace PFE.UserContol
{
    public partial class StatisticsControl : UserControl
    {

        StatisticsControlViewModel viewModel;

        public StatisticsControl(Survey survey)
        {
            InitializeComponent();
            Init(survey);
        }

        private void Init(Survey survey)
        {
            panelSections.Controls.SetChildIndex(panel2, 0);
            panelSections.Controls.SetChildIndex(buttonFirstCollect, 0);
            panelSections.Controls.SetChildIndex(buttonSeconCollect, 0);
            panelSections.Controls.SetChildIndex(buttonConfirmatory, 0);
            this.viewModel = new StatisticsControlViewModel(survey);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonFirstCollect_Click(object sender, EventArgs e)
        {
            FirstCollectControl firstCollectConrol = new FirstCollectControl(this.viewModel.survey);
            firstCollectConrol.Dock = DockStyle.Fill;
            firstCollectConrol.AutoScaleMode = AutoScaleMode.None;
            firstCollectConrol.Show();
            this.panelStepContent.Controls.Add(firstCollectConrol);
        }

        private void buttonSeconCollect_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirmatory_Click(object sender, EventArgs e)
        {

        }

        /*private void swichSection(FactorControl section)
        {
            if (activeSection != null)
            {
                this.activeSection.Dispose();
            }
            this.activeSection = section;
            this.panelSectionContent.Controls.Add(section);
        }

        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            using (var form = new AddFactorForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Factor factor = new Factor { title = form.viewModel.Title, description = form.viewModel.Description, questions = form.viewModel.selectedQuestions };
                    this.viewModel.survey.factors.Add(factor);
                    addFactor(factor);
                }
            }
        }

        private void loadSections()
        {
            foreach (Factor factor in viewModel.survey.factors)
            {
                addFactor(factor);
            }
        }

        public void factorClick(Factor factor)
        {
            FactorControl sectionControl = new FactorControl(factor);
            sectionControl.Visible = true;
            sectionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            sectionControl.AutoScaleMode = AutoScaleMode.None;
            this.swichSection(sectionControl);
        }

        public static void removeFactor()
        {

        }

        private async void buttonHost_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                using (var form = new HostForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        String res = await RestHelper.hostSurvey(this.viewModel.survey);
                        Survey survey = JsonConvert.DeserializeObject<Survey>(res);
                        if (survey != null)
                        {
                            this.viewModel.survey.host = survey.host;
                            this.viewModel.survey.model.id = survey.model.id;
                            ProjectHandler.saveProject();
                            using (var formS = new HostSuccessForm(survey.host.id))
                            {
                                formS.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This survey is already hosted. You need to delete the host from MySurveys tab in order to host it again.");
                        }
                    }
                }
            }
        }

        private Boolean checkFields()
        {
            if (string.IsNullOrWhiteSpace(this.viewModel.survey.model.technology.technologyName) || this.viewModel.survey.model.technology.technologyField == null)
            {
                MetroMessageBox.Show(this, "\nYou need to fill technology informations first before passing to this step. To do that Go to project context tab", "Error", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.viewModel.survey.model.evaluationContext))
            {
                MetroMessageBox.Show(this, "\nYou need to fill evaluation first before passing to this step. To do that Go to model info tab", "Error", MessageBoxButtons.OK);
                return false;
            }

            foreach (Factor factor in this.viewModel.survey.factors)
            {
                foreach (Question q in factor.questions)
                {
                    if (q.type == QuestionTypes.CHECK_BOX || q.type == QuestionTypes.RADIO)
                    {
                        if (q.choices.Count() < 2)
                        {
                            MetroMessageBox.Show(this, "\nCheckbox and radio questions must have two choices or more", "Error", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            if (this.viewModel.survey.host != null)
            {
                using (var formS = new HostSuccessForm(this.viewModel.survey.host.id))
                {
                    formS.ShowDialog();
                }
            }
        }

        private void PhaseControl_VisibleChanged(object sender, EventArgs e)
        {
           
        }*/
    }
}
