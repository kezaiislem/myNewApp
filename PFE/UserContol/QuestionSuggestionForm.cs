using PFE.Model;
using PFE.ViewModel;
using System;
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
    public partial class QuestionSuggestionForm : Form
    {
        public QuestionSuggestionViewModel viewModel { get; set; }

        public QuestionSuggestionForm()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            viewModel = new QuestionSuggestionViewModel();
            textBoxTechnologyName.DataBindings.Add("Text", viewModel.requestObject, "technologyName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxTechnologyField.DataBindings.Add("Text", viewModel.requestObject, "technologyField", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxEvaluationContext.DataBindings.Add("Text", viewModel.requestObject, "evalutionContext", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxFacor.DataBindings.Add("Text", viewModel.requestObject, "factor", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private async void metroButtonSearch_Click(object sender, EventArgs e)
        {
            List<Question> sections = await viewModel.loadSuggestions();
            gridResult.DataSource = sections;
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
                this.viewModel.selectedItem = (Question)gridResult.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
