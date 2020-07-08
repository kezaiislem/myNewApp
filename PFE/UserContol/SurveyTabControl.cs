using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.ViewModel;
using PFE.Model;

namespace PFE
{
    public partial class SurveyTabControl : UserControl
    {

        SurveyTabControlViewModel viewModel;

        public SurveyTabControl(Survey s)
        {
            InitializeComponent();
            viewModel = new SurveyTabControlViewModel(s);
            Init();
        }

        private void Init()
        {
            metroLabelDate.Text = viewModel.strDate;
            metroLabelPhase.Text = viewModel.phaseNumber.ToString();
            metroLabelStatus.Text = viewModel.status;
        }
    }
}
