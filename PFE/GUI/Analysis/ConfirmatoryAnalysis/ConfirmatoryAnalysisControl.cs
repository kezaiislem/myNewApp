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
using PFE.Constants;
using PFE.model;
using PFE.Shared;
using System.IO;
using PFE.CustomObjects;

namespace PFE.UserContol
{
    public partial class ConfirmatoryAnalysisControl : UserControl
    {

        ConfirmatoryAnalysisControlViewModel viewModel;

        public ConfirmatoryAnalysisControl(Survey survey)
        {
            InitializeComponent();
            Init(survey);
        }

        private void Init(Survey survey)
        {
            this.viewModel = new ConfirmatoryAnalysisControlViewModel(survey);
            listBoxOriginalFactors.DataSource = viewModel.originalFactors;
            listBoxOriginalQuestions.DataSource = viewModel.originalQuestions;
            listBoxExcludedQuestions.DataSource = viewModel.excludedQuestions;
            listBoxOriginalFactors.DataBindings.Add("SelectedValue", this.viewModel, "selectedFactor", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonRunCFA_Click(object sender, EventArgs e)
        {

        }

        private void addRmvQuestion_Click(object sender, EventArgs e)
        {
            foreach (Question question in listBoxOriginalQuestions.SelectedItems)
            {
                if (!this.viewModel.excludedQuestions.Contains(listBoxOriginalQuestions.SelectedItem))
                {
                    this.viewModel.excludedQuestions.Add(question);
                }
            }
        }

        private void removeRmvQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxExcludedQuestions.SelectedItem != null)
            {
                this.viewModel.excludedQuestions.Remove((Question)listBoxExcludedQuestions.SelectedItem);
            }
        }

        private void buttonFiabilityTest_Click(object sender, EventArgs e)
        {
            var msg = this.viewModel.validateChrobach();
            if (msg == null)
            {
                DataTable dt = this.viewModel.calculateChrobachTable();
                dataGridAlpha.DataSource = dt;
                panelCronbach.Visible = true;
            }
            else
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
