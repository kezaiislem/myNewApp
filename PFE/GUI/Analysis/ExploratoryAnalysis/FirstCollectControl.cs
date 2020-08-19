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
            listBoxOriginalFactors.DataSource = this.viewModel.originalFactors;
            listBoxOriginalQuestions.DataSource = this.viewModel.originalQuestions;
            listBoxExcludedQuestions.DataSource = this.viewModel.excludedQuestions;
            listBoxOriginalFactors.DataBindings.Add("SelectedValue", this.viewModel, "selectedFactor", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonRunACP_Click(object sender, EventArgs e)
        {
            using (var form = new ACPForm(viewModel.getNumberOfQuestions()))
            {
                form.PropertyChanged += this.viewModel.Parallel;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PCAResults results = this.viewModel.ACP(form.viewModel.factorNumber);
                    if (results != null)
                    {
                        dataGridPrincipalComponents.DataSource = DataTableManager.PCATableToDataTable(results.pcaTable);
                        dataGridPCALoadings.DataSource = DataTableManager.PCALoadingstoDataTable(results.loadings);
                    }
                    else
                    {
                        MessageBox.Show("An error has been occured or number of chosen factors is more than the number of questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    factorisationResults.Visible = true;
                }
            }
        }

        private void fillValues()
        {
            textBoxBartlett.Text = this.viewModel.sphericityTestResults.bartlett.ToString();
            textBoxKMOIndex.Text = this.viewModel.sphericityTestResults.kmo.ToString();
        }

        private void buttonFiabilityTest_Click(object sender, EventArgs e)
        {
            var msg = this.viewModel.fiabilityTest();
            if (msg == null)
            {
                dataGridAlpha.DataSource = this.viewModel.chronbachTable;
                fillValues();
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

        private void buttonPlotPCA_Click(object sender, EventArgs e)
        {
            this.viewModel.PlotComponenets();
        }

        private void buttonPlotLoadings_Click(object sender, EventArgs e)
        {
            this.viewModel.PlotPCA();
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
                    //viewModel.saveExel(saveFileDialog.FileName);
                }
            }
        }
    }
}
