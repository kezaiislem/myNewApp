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
    public partial class FirstCollectControl : UserControl
    {

        FirstCollectControlViewModel viewModel;

        public FirstCollectControl(Survey survey)
        {
            InitializeComponent();
            Init(survey);
        }

        private void Init(Survey survey)
        {
            viewModel = new FirstCollectControlViewModel(survey);
            listOriginalFactors.DataSource = this.viewModel.originalFactors;
            listStatsFactors.DataSource = this.viewModel.selectedFactors;
            listBoxRmvFactors.DataSource = this.viewModel.rmvFactors;
            listBoxQuestions.DataSource = this.viewModel.questions;
            listBoxToRmvQuestions.DataSource = this.viewModel.rmvQuestions;
            listBoxRmvFactors.DataBindings.Add("SelectedValue", this.viewModel, "selectedRmvFactor", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            foreach (Factor factor in listOriginalFactors.SelectedItems)
            {
                if (!this.viewModel.selectedFactors.Contains(listOriginalFactors.SelectedItem))
                {
                    this.viewModel.selectedFactors.Add(factor);
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (listStatsFactors.SelectedItem != null)
            {
                this.viewModel.selectedFactors.Remove((Factor)listStatsFactors.SelectedItem);
            }
        }

        private void buttonRunACP_Click(object sender, EventArgs e)
        {
            if (validateFactorisation())
            {
                this.panelCronbach.Visible = false;
                if (this.viewModel.sphericityTestChecked)
                {
                    viewModel.calculateFirstResults();
                    fillValues();
                }
                PCAResults results = this.viewModel.ACP();
                if (results != null)
                {
                    dataGridPrincipalComponents.DataSource = DataTableManager.PCATableToDataTable(results.pcaTable);
                    dataGridPCALoadings.DataSource = DataTableManager.PCALoadingstoDataTable(results.loadings);
                }
                else
                {
                    MessageBox.Show("An error has been occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                factorisationResults.Visible = true;
            }
        }

        public Boolean validateFactorisation()
        {
            if (this.viewModel.selectedFactors.Count < 2)
            {
                MessageBox.Show("You must select at least two factors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viewModel.personalAnswers == null)
            {
                MessageBox.Show("An error has been occured please check your connection and restart again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.viewModel.reloadAnswers();
                return false;
            }
            int questionsCount = 0;
            foreach (Factor factor in this.viewModel.selectedFactors)
            {
                questionsCount += factor.questions.Count;
            }
            if (questionsCount > this.viewModel.personalAnswers.Count)
            {
                MessageBox.Show("Number of answers must be higher than number of questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void fillValues()
        {
            if (checkBoxSphericity.Checked)
            {
                textBoxBartlett.Text = this.viewModel.sphericityTestResults.bartlett.ToString();
                textBoxKMOIndex.Text = this.viewModel.sphericityTestResults.kmo.ToString();
            }
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

        private void buttonReduceAlpha_Click(object sender, EventArgs e)
        {
            this.panelCronbach.Visible = false;
        }

        private void buttonCor_Click(object sender, EventArgs e)
        {
            var msg = this.viewModel.validateCorelationMatrix();
            if (msg == null)
            {
                viewModel.calculateCorelationMatrix();
            }
            else
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRmvQuestion_Click(object sender, EventArgs e)
        {
            foreach (Question question in listBoxQuestions.SelectedItems)
            {
                if (!this.viewModel.rmvQuestions.Contains(listBoxQuestions.SelectedItem))
                {
                    this.viewModel.rmvQuestions.Add(question);
                }
            }
        }

        private void removeRmvQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxToRmvQuestions.SelectedItem != null)
            {
                this.viewModel.rmvQuestions.Remove((Question)listBoxToRmvQuestions.SelectedItem);
            }
        }

        private void checkBoxSphericity_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            this.viewModel.sphericityTestChecked = e.Checked;
        }

        private void buttonPlotPCA_Click(object sender, EventArgs e)
        {
            this.viewModel.PlotComponenets();
        }

        private void buttonPlotLoadings_Click(object sender, EventArgs e)
        {
            this.viewModel.PlotPCA();
        }

        private void buttonNewStats_Click(object sender, EventArgs e)
        {
            this.viewModel.calculateNewStats();
            if(this.viewModel.newSphericityTestResults != null)
            {
                this.textBoxNewKMO.Text = this.viewModel.newSphericityTestResults.kmo.ToString();
                this.textBoxNewBartlett.Text = this.viewModel.newSphericityTestResults.bartlett.ToString();
                panelNewStats.Show();
            }
        }

        private void buttonHideNewStats_Click(object sender, EventArgs e)
        {
            this.panelNewStats.Hide();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "Sheet";
                saveFileDialog.Filter = "Exel File|*.xlsx|CSV File|*.csv";
                saveFileDialog.Title = "Export";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    viewModel.saveExel(saveFileDialog.FileName);
                }
            }
        }
    }
}
