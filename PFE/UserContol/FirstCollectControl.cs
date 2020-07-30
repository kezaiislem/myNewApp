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

namespace PFE.UserContol
{
    public partial class FirstCollectControl : UserControl
    {

        FirstCollectControlViewModel viewModel;

        public FirstCollectControl(Survey survey)
        {
            InitializeComponent();
            Init(survey);
        }

        private void Init(Survey survey)
        {
            viewModel = new FirstCollectControlViewModel(survey);
            listOriginalFactors.DataSource = this.viewModel.survey.factors;
            listStatsFactors.DataSource = this.viewModel.selectedFactors;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach(Factor factor in listOriginalFactors.SelectedItems)
            {
                if (!this.viewModel.selectedFactors.Contains(listOriginalFactors.SelectedItem))
                {
                    this.viewModel.selectedFactors.Add(factor);
                }
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (listStatsFactors.SelectedItem != null)
            {
                this.viewModel.selectedFactors.Remove((Factor)listStatsFactors.SelectedItem);
            }
        }

        private void buttonFactorisationTest_Click(object sender, EventArgs e)
        {

        }

        public Boolean validateFactorisation()
        {
            if (this.viewModel.selectedFactors.Count < 2)
            {
                // You must select at least two factors
                return false;
            }
            else if (!checkBoxBartlett.Checked && !checkBoxKMO.Checked)
            {
                // You must select at least at least KMO or Bartlett
                return false;
            }

            return true;
        }
    }
}
