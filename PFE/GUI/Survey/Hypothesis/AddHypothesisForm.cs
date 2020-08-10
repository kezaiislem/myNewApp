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
    public partial class AddHypothesisForm : Form
    {
        public AddHypothesisViewModel viewModel { get; set; } 

        public AddHypothesisForm(List<Factor> factors, List<Hypothesis> hypotheses)
        {
            InitializeComponent();
            Init(factors, hypotheses);
        }

        private void Init(List<Factor> factors, List<Hypothesis> hypotheses)
        {
            this.viewModel = new AddHypothesisViewModel(factors, hypotheses);
            comboBoxStart.BindingContext = new BindingContext();
            comboBoxArrival.BindingContext = new BindingContext();
            this.comboBoxStart.DataSource = this.viewModel.start;
            this.comboBoxArrival.DataSource = this.viewModel.arrival;
            this.comboBoxStart.DataBindings.Add("SelectedValue", this.viewModel, "selectedStart", true, DataSourceUpdateMode.OnPropertyChanged); ; 
            this.comboBoxArrival.DataBindings.Add("SelectedValue", this.viewModel, "selectedArrival", true, DataSourceUpdateMode.OnPropertyChanged); 
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
                MessageBox.Show("Hypothesis already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean checkFields()
        {
            foreach (Hypothesis hypothesis in viewModel.hypotheses)
            {
                if(hypothesis.firstFactor == this.viewModel.selectedStart.title && hypothesis.secondFactor == this.viewModel.selectedArrival.title)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
