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

namespace PFE.UserContol
{
    public partial class ModelInfo : UserControl
    {

        public ModelInfoViewModel viewModel;

        public ModelInfo(PFE.Model.Model model, MainForm main)
        {
            InitializeComponent();
            viewModel = new ModelInfoViewModel(model, main);
            InializeView();
        }

        public void InializeView()
        {
            metroCheckBoxPhase1.DataBindings.Add("Checked", viewModel, "hasPhase1", true, DataSourceUpdateMode.OnPropertyChanged);
            metroCheckBoxPhase2.DataBindings.Add("Checked", viewModel, "hasPhase2", true, DataSourceUpdateMode.OnPropertyChanged);
            metroCheckBoxPhase3.DataBindings.Add("Checked", viewModel, "hasPhase3", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void metroButtonSaveModel_Click(object sender, EventArgs e)
        {
            viewModel.updatePhases();
        }
    }
}
