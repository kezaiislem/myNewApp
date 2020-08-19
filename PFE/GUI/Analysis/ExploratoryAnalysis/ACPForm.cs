using MetroFramework;
using PFE.Constants;
using PFE.CustomObjects;
using PFE.model;
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
    public partial class ACPForm : Form
    {

        public ACPFormViewModel viewModel { get; set; }

        public ACPForm(int factorCount)
        {
            InitializeComponent();
            InitializeView(factorCount);
        }

        private void InitializeView(int factorCount)
        {
            viewModel = new ACPFormViewModel(factorCount);
            textboxNumberOfFactors.DataBindings.Add("Text", viewModel, "factorNumber", true, DataSourceUpdateMode.OnPropertyChanged); 
        }

        private void textboxNumberOfFactors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOnPropertyChanged(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                tmp(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void buttonParallelAnalysis_Click(object sender, EventArgs e)
        {
            NotifyOnPropertyChanged("runParallel");
        }

        private void checkBoxCustomFactor_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                textboxNumberOfFactors.Enabled = true;
            }
            else
            {
                textboxNumberOfFactors.Enabled = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkBoxCustomFactor.Checked)
            {
                if (viewModel.factorNumber <= 0)
                {
                    MessageBox.Show("Error", "Number of factors must be higher than 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (viewModel.factorNumber > viewModel.factorCount)
                {
                    MessageBox.Show("Error", "Number of factors must be lower or equal the number of questions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                this.viewModel.factorNumber = 0;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
