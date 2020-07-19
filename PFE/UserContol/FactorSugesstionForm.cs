using PFE.Constants;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using PFE.ViewModel;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE.UserContol
{
    public partial class FactorSugesstionForm : Form
    {

        public FactorSugesstionViewModel viewModel { get; set; }

        private const int PAGE_SIZE_WITH_QUESTIONS = 500;
        private const int PAGE_SIZE_WITHOUT_QUESTIONS = 360;

        public FactorSugesstionForm()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            this.Height = PAGE_SIZE_WITHOUT_QUESTIONS;
            viewModel = new FactorSugesstionViewModel();
            this.comboBoxQuestionTypes.ValueType = typeof(string);
            this.comboBoxQuestionTypes.DataSource = QuestionTypes.evaluationTypesStrings();

            textBoxTechnologyName.DataBindings.Add("Text", viewModel.requestObject, "technologyName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxTechnologyField.DataBindings.Add("Text", viewModel.requestObject, "technologyField", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxEvaluationContext.DataBindings.Add("Text", viewModel.requestObject, "evalutionContext", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxFacor.DataBindings.Add("Text", viewModel.requestObject, "factor", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private async void metroButtonSearch_Click(object sender, EventArgs e)
        {
            List<Factor> factors = await viewModel.loadSuggestions();
            gridResult.DataSource = factors;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void metroButtonImport_Click(object sender, EventArgs e)
        {
            if (gridResult.SelectedRows.Count > 0)
            {
                this.viewModel.selectedItem = (Factor)gridResult.SelectedRows[0].DataBoundItem;
                this.viewModel.selectedItem.questions = null;
                if (checkBoxImportQuestions.Checked)
                {
                    this.viewModel.selectedItem.questions = new List<Question>();
                    foreach (DataGridViewRow row in gridResultQuestions.SelectedRows)
                    {
                        var gridQuestion = (CustomGridQuestion) row.DataBoundItem;
                        Console.WriteLine(gridQuestion.type);
                        this.viewModel.selectedItem.questions.Add(new Question { text = gridQuestion.text, type = QuestionTypes.getIntValue(gridQuestion.type) });
                        Console.WriteLine(this.viewModel.selectedItem.questions.ElementAt(0).type);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }



        private void checkBoxImportQuestions_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkBoxImportQuestions.Checked)
            {
                this.Height = PAGE_SIZE_WITH_QUESTIONS;
                labelQuestions.Visible = true;
                gridResultQuestions.SuspendLayout();
                gridResultQuestions.Visible = true;
                gridResultQuestions.ResumeLayout(false);

            }
            else
            {
                this.Height = PAGE_SIZE_WITHOUT_QUESTIONS;
                labelQuestions.Visible = false;
                gridResultQuestions.SuspendLayout();
                gridResultQuestions.Visible = false;
                gridResultQuestions.ResumeLayout(false);
            }
        }

        private void gridResult_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridResult.SelectedRows.Count > 0)
                {
                    viewModel.selectedItem = (Factor)gridResult.SelectedRows[0].DataBoundItem;
                    if (viewModel.selectedItem != null)
                    {
                        List<CustomGridQuestion> customGridQuestions = new List<CustomGridQuestion>();
                        foreach (Question q in viewModel.selectedItem.questions)
                        {
                            customGridQuestions.Add(new CustomGridQuestion { text = q.text.ToString(), type = QuestionTypes.getStringValue(q.type) });
                        }
                        gridResultQuestions.DataSource = customGridQuestions;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        private void gridResultQuestions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
            if(e.Exception.Message == "La valeur DataGridViewComboBoxCell n'est pas valide.")
            {
                object value = gridResultQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)(gridResult.Columns[e.ColumnIndex])).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)(gridResult.Columns[e.ColumnIndex])).Items.Add(value);
                }
                e.ThrowException = false;
            }
        }
    }
}
