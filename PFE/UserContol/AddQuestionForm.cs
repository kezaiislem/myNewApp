using MetroFramework;
using PFE.Model;
using PFE.Shared;
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
    public partial class AddQuestionForm : Form
    {

        public AddQuestionFormViewModel viewModel { get; set; }

        public AddQuestionForm()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            viewModel = new AddQuestionFormViewModel();
            textBoxText.DataBindings.Add("Text", viewModel.question, "text", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxType.DataSource = viewModel.questionCombos;
            comboBoxType.DataBindings.Add("SelectedItem", viewModel, "selectedItem", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Question text field cant be empty", "Error", MessageBoxButtons.OK);
            }
            
        }

        private Boolean checkFields()
        {
            if (string.IsNullOrWhiteSpace(viewModel.question.text))
                return false;
            return true;
        }

        private void metroButtonImport_Click(object sender, EventArgs e)
        {
            using (var form = new QuestionSuggestionForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    /*foreach (ComboboxItem item in viewModel.combos)
                    {
                        if (item.Text == form.viewModel.selectedItem.factor.name)
                        {
                            viewModel.selectedItem = item;
                        }
                    }*/
                    textBoxText.Text = form.viewModel.selectedItem.text;
                }
            }
        }
    }
}
