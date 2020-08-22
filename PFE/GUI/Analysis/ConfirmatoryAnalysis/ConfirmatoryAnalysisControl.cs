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
using MetroFramework.Controls;

namespace PFE.UserContol
{
    public partial class ConfirmatoryAnalysisControl : UserControl
    {

        ConfirmatoryAnalysisControlViewModel viewModel;

        TableLayoutPanel convergentValidityTable;

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
            var msg = viewModel.runCFA();
            if (msg == null)
            {
                fillConstructValidity();
                initTable();
                panelConfirmatoryResults.Visible = true;
            }
            else
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillConstructValidity()
        {
            labelRMSEA.Text = viewModel.rmsea;
            labelSRMR.Text = viewModel.srmr;
            labelCFI.Text = viewModel.cfi;
            labelTLI.Text = viewModel.tli;
            labelCHIDL.Text = viewModel.chisqDf;
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
            var msg = this.viewModel.calculateChrobachTable();
            if (msg == null)
            {
                dataGridAlpha.DataSource = viewModel.chrobachTable;
                panelCronbach.Visible = true;
            }
            else
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int rowHeigh = 25;
        private int panelConvergentValidityHeigh = 120;
        private int panelCFAHeigh = 400;

        private void initTable()
        {
            if (convergentValidityTable != null)
            {
                panelConvergentValidity.Controls.Remove(convergentValidityTable);
            }

            convergentValidityTable = new TableLayoutPanel();
            convergentValidityTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            convergentValidityTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            convergentValidityTable.ColumnCount = 3;
            convergentValidityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            convergentValidityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            convergentValidityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            convergentValidityTable.Controls.Add(this.createNewLabel("CR"), 2, 0);
            convergentValidityTable.Controls.Add(this.createNewLabel("AVE"), 1, 0);
            convergentValidityTable.Controls.Add(this.createNewLabel("Factor"), 0, 0);
            convergentValidityTable.Location = new System.Drawing.Point(133, 72);
            convergentValidityTable.Name = "convergentValidityTable";
            fillTable();
            convergentValidityTable.Size = new System.Drawing.Size(500, (viewModel.selectedFactors.Count + 1) * (rowHeigh + 5 / 3));
            panelConvergentValidity.Height = panelConvergentValidityHeigh + viewModel.selectedFactors.Count * rowHeigh;
            panelConfirmatoryResults.Height = panelCFAHeigh + viewModel.selectedFactors.Count * rowHeigh;
            convergentValidityTable.TabIndex = 74;
            panelConvergentValidity.Controls.Add(convergentValidityTable);
        }

        private void fillTable()
        {
            int row = 1;
            foreach (ConvergentValidityTab tab in viewModel.convergentValidityTabs)
            {
                convergentValidityTable.Controls.Add(this.createNewLabel(tab.CR.ToString()), 2, row);
                convergentValidityTable.Controls.Add(this.createNewLabel(tab.AVE.ToString()), 1, row);
                convergentValidityTable.Controls.Add(this.createNewLabel(tab.factor.ToString()), 0, row);
                row++;
            }

            convergentValidityTable.RowCount = viewModel.selectedFactors.Count + 1;
            convergentValidityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            foreach (Factor factor in viewModel.selectedFactors)
            {
                convergentValidityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            }
        }

        private MetroLabel createNewLabel(String text)
        {
            MetroLabel label = new MetroLabel();

            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            label.Location = new Point(62, 4);
            label.Name = "metroLabel4";
            label.Size = new Size(42, 19);
            label.TabIndex = 72;
            label.Text = text;

            return label;
        }

        private void descriminantValidity_Click(object sender, EventArgs e)
        {
            var msg = viewModel.createCorelationsTable();
            if (msg == null)
            {
                var msg2 = viewModel.openDiscriminantValidityTable();
                if (msg2 != null)
                {
                    MessageBox.Show(msg2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "Sheet";
                saveFileDialog.Filter = "Exel File|*.xlsx";
                saveFileDialog.Title = "Export";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        viewModel.exportAllToExel(saveFileDialog.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("File is already opened please close it first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
