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
    public partial class ResultsControl : UserControl
    {

        public ResultControlViewModel viewModel;

        public ResultsControl(int surveyId)
        {
            InitializeComponent();
            Init(surveyId);
        }

        private void Init(int surveyId)
        {
            viewModel = new ResultControlViewModel(surveyId);
            while(viewModel.sections == null) { }
        }
    }
}
