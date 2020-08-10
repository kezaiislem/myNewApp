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
    public partial class AddFactorForm : Form
    {
        public AddFactorFormViewModel viewModel { get; set; } 

        public AddFactorForm()
        {
            InitializeComponent();
            this.viewModel = new AddFactorFormViewModel();
            InitializeView();
        }

        private void InitializeView()
        {
            textBoxTitle.DataBindings.Add("Text", viewModel, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxDescription.DataBindings.Add("Text", viewModel, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxFactor.DataSource = viewModel.factors;
            comboBoxFactor.DataBindings.Add("SelectedItem", viewModel, "selectedItem", true, DataSourceUpdateMode.OnPropertyChanged);
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
                MessageBox.Show("Title and description cant be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean checkFields()
        {
            if (this.viewModel.mtaDefault)
                return true;
            if (string.IsNullOrWhiteSpace(viewModel.Description) || string.IsNullOrWhiteSpace(viewModel.Title))
                return false;
            return true;
        }

        private void metroButtonImport_Click(object sender, EventArgs e)
        {
            using (var form = new FactorSugesstionForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxTitle.Text = form.viewModel.selectedItem.title;
                    textBoxDescription.Text = form.viewModel.selectedItem.description;
                    this.viewModel.selectedQuestions = form.viewModel.selectedItem.questions;
                    if (checkBoxDefaultMta.Checked == true)
                        checkBoxDefaultMta.Checked = false;
                }
            }
        }

        private void checkBoxDefaultMta_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            this.viewModel.mtaDefault = e.Checked;
            if (e.Checked)
            {
                comboBoxFactor.Enabled = true;
                textBoxTitle.Enabled = false;
                textBoxDescription.Enabled = false;
                checkBoxEvaluationFactor.Enabled = false;
            }
            else
            {
                comboBoxFactor.Enabled = false;
                textBoxTitle.Enabled = true;
                textBoxDescription.Enabled = true;
                checkBoxEvaluationFactor.Enabled = true;
            }
        }

        private void checkBoxEvaluationFactor_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            this.viewModel.evaluationFactor = e.Checked;
        }
    }
}
