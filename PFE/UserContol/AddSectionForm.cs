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
            if (checkFields())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Title and description cant be empty", "Error", MessageBoxButtons.OK);
            }
            
        }

        private Boolean checkFields()
        {
            if (string.IsNullOrWhiteSpace(viewModel.Description) || string.IsNullOrWhiteSpace(viewModel.Title))
                return false;
            return true;
        }

        private void metroButtonImport_Click(object sender, EventArgs e)
        {
            using (var form = new SectionSugesstionForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach ( ComboboxItem item in viewModel.combos)
                    {
                        if (item.Text == form.viewModel.selectedItem.factor.name)
                        {
                            viewModel.selectedItem = item;
                        }
                    }
                    textBoxTitle.Text = form.viewModel.selectedItem.title;
                    textBoxDescription.Text = form.viewModel.selectedItem.description;
                }
            }
        }
    }
}
