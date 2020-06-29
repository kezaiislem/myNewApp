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
    public partial class AddSectionForm : Form
    {
        public AddSectionFormViewModel viewModel { get; set; } 

        public AddSectionForm()
        {
            InitializeComponent();
            this.viewModel = new AddSectionFormViewModel();
            InitializeView();
        }

        private void InitializeView()
        {
            textBoxTitle.DataBindings.Add("Text", viewModel, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxDescription.DataBindings.Add("Text", viewModel, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxFactor.DataSource = viewModel.combos;
            comboBoxFactor.DataBindings.Add("SelectedItem", viewModel, "selectedItem", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
