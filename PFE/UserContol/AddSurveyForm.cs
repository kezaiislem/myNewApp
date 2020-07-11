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
    public partial class AddSurveyForm : Form
    {

        public AddSurveyFormViewModel viewModel { get; set; }
        
        public AddSurveyForm(List<int> phases)
        {
            InitializeComponent();
            Init(phases);
        }

        private void Init(List<int> phases)
        {
            viewModel = new AddSurveyFormViewModel(phases);
            textBoxDescription.DataBindings.Add("Text", viewModel, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxTitle.DataBindings.Add("Text", viewModel, "Title", true, DataSourceUpdateMode.OnPropertyChanged);

            comboBoxPhases.DataSource = viewModel.phases;
            comboBoxPhases.DataBindings.Add("SelectedItem", viewModel, "SelectedPhase", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
