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
using PFE.Shared;
using PFE.UserContol;
using PFE.CustomObjects;
using PFE.model;

namespace PFE
{
    public partial class HypothesisTabControl : UserControl, INotifyPropertyChanged
    {

        public HypothesisTabControlViewModel viewModel { get; set; }

        public HypothesisTabControl(Hypothesis hypothesis)
        {
            InitializeComponent();
            Init(hypothesis);
        }

        private void Init(Hypothesis hypothesis)
        {
            this.viewModel = new HypothesisTabControlViewModel(hypothesis);
            this.metroLabelNumber.Text += viewModel.hypothesis.number.ToString();
            this.metroLabelDescription.Text += "There is a relation between " + viewModel.hypothesis.firstFactor + " and " + viewModel.hypothesis.secondFactor;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNotifyPropertyChanged(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                tmp(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            OnNotifyPropertyChanged("");
        }
    }
}
