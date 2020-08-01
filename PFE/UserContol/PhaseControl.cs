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

namespace PFE.UserContol
{
    public partial class PhaseControl : UserControl
    {

        PhaseControlViewModel viewModel;

        FactorControl activeSection;

        public PhaseControl(Survey survey)
        {
            InitializeComponent();
            Init(survey);
        }

        private void Init(Survey survey)
        {
            panelSections.Controls.SetChildIndex(panel2, 0);
            viewModel = new PhaseControlViewModel(survey);
            if (this.viewModel.survey.host == null)
            {
                buttonShare.Enabled = false;
            }
            if (viewModel.survey == null)
            {
                viewModel.survey = new Survey { factors = new List<Factor>() };
            }
            else
            {
                loadSections();
            }
        }

        private void swichSection(FactorControl section)
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

        private void addFactor(Factor factor)
        {
            Button panelSection = new Button();
            panelSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            panelSection.Dock = System.Windows.Forms.DockStyle.Top;
            panelSection.FlatAppearance.BorderSize = 0;
            panelSection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            panelSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            panelSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            panelSection.ForeColor = System.Drawing.Color.White;
            panelSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            panelSection.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            panelSection.Height = 40;
            panelSection.Text = factor.title;
            panelSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            panelSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            panelSection.UseVisualStyleBackColor = false;
            panelSection.Click += (s, ev) => factorClick(factor);
            panelSections.Controls.Add(panelSection);
            panelSections.Controls.SetChildIndex(panelSection, 0);
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
                            this.viewModel.survey.id = survey.id;
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
           
        }
    }
}
