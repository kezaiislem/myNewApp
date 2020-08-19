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
            listBoxFactors.DataSource = viewModel.factors;
            listBoxQuestions.DataSource = viewModel.questions;
            listBoxToRmvQuestions.DataSource = viewModel.rmvQuestions;
            listBoxFactors.DataBindings.Add("SelectedValue", this.viewModel, "selectedFactor", true, DataSourceUpdateMode.OnPropertyChanged);
            listBoxQuestions.DataBindings.Add("SelectedValue", this.viewModel, "selectedQuestion", true, DataSourceUpdateMode.OnPropertyChanged);
            listBoxToRmvQuestions.DataBindings.Add("SelectedValue", this.viewModel, "selectedRmvQuestion", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonRunCFA_Click(object sender, EventArgs e)
        {

        }

        private void addRmvQuestion_Click(object sender, EventArgs e)
        {
            this.viewModel.addRmvQuestion();
        }

        private void removeRmvQuestion_Click(object sender, EventArgs e)
        {
            this.viewModel.removeRmvQuestion();
        }

        private void buttonChronbach_Click(object sender, EventArgs e)
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
