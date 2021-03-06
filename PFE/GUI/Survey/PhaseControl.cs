﻿using System;
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

        FactorControl activeFactor;

        HypothesisControl hypothesisControl;

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
            if(hypothesisControl != null)
            {
                this.hypothesisControl.Dispose();
                this.hypothesisControl = null;
            }
            if (activeFactor != null)
            {
                this.activeFactor.Dispose();
            }
            this.activeFactor = section;
            this.panelSectionContent.Controls.Add(section);
        }

        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            using (var form = new AddFactorForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.viewModel.mtaDefault)
                    {
                        this.viewModel.survey.factors.Add(form.viewModel.selectedItem);
                        addFactor(form.viewModel.selectedItem);
                    }
                    else
                    {
                        Factor factor = new Factor { title = form.viewModel.Title, description = form.viewModel.Description, questions = form.viewModel.selectedQuestions, evaluationFactor = form.viewModel.evaluationFactor };
                        this.viewModel.survey.factors.Add(factor);
                        addFactor(factor);
                    }
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
            Button buttonFactor = new Button();
            buttonFactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            buttonFactor.Dock = System.Windows.Forms.DockStyle.Top;
            buttonFactor.FlatAppearance.BorderSize = 0;
            buttonFactor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            buttonFactor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            buttonFactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonFactor.ForeColor = System.Drawing.Color.White;
            buttonFactor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonFactor.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonFactor.Height = 40;
            buttonFactor.Text = factor.title;
            buttonFactor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonFactor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonFactor.UseVisualStyleBackColor = false;
            buttonFactor.Click += (s, ev) => factorClick(factor, buttonFactor);
            panelSections.Controls.Add(buttonFactor);
            panelSections.Controls.SetChildIndex(buttonFactor, 0);
        }

        public void factorClick(Factor factor, Button factorButton)
        {
            FactorControl factorControl = new FactorControl(factor, factorButton);
            factorControl.PropertyChanged += FactorRemoved;
            factorControl.Visible = true;
            factorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            factorControl.AutoScaleMode = AutoScaleMode.None;
            this.swichSection(factorControl);
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
                        Survey survey = await viewModel.hostSurvey();
                        if(survey == null)
                        {
                            MessageBox.Show("Cant reach server, please check your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (survey.host != null)
                        {
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

        private void buttonHypothesis_Click(object sender, EventArgs e)
        {
            if(activeFactor != null)
            {
                activeFactor.Dispose();
                activeFactor = null;
            }
            if(hypothesisControl == null)
            {
                if (this.viewModel.survey.hypotheses == null)
                {
                    this.viewModel.survey.hypotheses = new List<Hypothesis>();
                }
                this.hypothesisControl = new HypothesisControl(this.viewModel.survey.hypotheses, this.viewModel.survey.factors);
                this.hypothesisControl.Dock = DockStyle.Fill;
                this.hypothesisControl.AutoScaleMode = AutoScaleMode.None;
                this.hypothesisControl.Show();
                this.panelSectionContent.Controls.Add(hypothesisControl);
            }
        }

        private void FactorRemoved(object o, PropertyChangedEventArgs e)
        {
            if (o != null)
            {
                FactorControl control = (FactorControl)o;
                this.panelSections.Controls.Remove(control.factorButton);
                this.viewModel.survey.factors.Remove(control.viewModel.factor);
                this.panelSectionContent.Controls.Remove(control);
                this.activeFactor = null;
            }
        }
    }
}
