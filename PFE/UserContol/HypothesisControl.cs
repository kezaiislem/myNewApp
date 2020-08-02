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
    public partial class HypothesisControl : UserControl
    {
        HypothesisControlViewModel viewModel;

        public HypothesisControl(List<Hypothesis> hypotheses, List<Factor> factors)
        {
            InitializeComponent();
            Init(hypotheses, factors);
        }

        private void Init(List<Hypothesis> hypotheses, List<Factor> factors)
        {
            this.viewModel = new HypothesisControlViewModel(hypotheses, factors);
            loadHypotheses();
        }

        private void buttonAddHypothesis_Click(object sender, EventArgs e)
        {
            using (var form = new AddHypothesisForm( this.viewModel.factors, this.viewModel.hypotheses))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Hypothesis hypothesis = new Hypothesis { number = this.viewModel.hypotheses.Count, secondFactor = form.viewModel.selectedArrival.title, firstFactor = form.viewModel.selectedStart.title };
                    this.viewModel.hypotheses.Add(hypothesis);
                    this.addHypothesis(hypothesis);
                }
            }
        }

        private void addHypothesis(Hypothesis hypothesis)
        {
            HypothesisTabControl Hypothesis = new HypothesisTabControl(hypothesis);
            Hypothesis.Dock = DockStyle.Top;
            Hypothesis.Height = 55;
            Hypothesis.Visible = true;
            Hypothesis.PropertyChanged += PropretyChanged;
            this.panelSurveyTableContent.Controls.Add(Hypothesis);
            this.panelSurveyTableContent.Controls.SetChildIndex(Hypothesis, 0);
        }

        private void loadHypotheses()
        {
            foreach (Hypothesis hypothesis in this.viewModel.hypotheses)
            {
                addHypothesis(hypothesis);
            }
        }

        private void PropretyChanged(object o, PropertyChangedEventArgs e)
        {
            if (o != null)
            {
                HypothesisTabControl hypothesisTabControl = (HypothesisTabControl)o;
                this.viewModel.hypotheses.Remove(hypothesisTabControl.viewModel.hypothesis);
                this.panelSurveyTableContent.Controls.Clear();
                int i = 0;
                foreach(Hypothesis hypothesis in viewModel.hypotheses)
                {
                    hypothesis.number = i;
                    i++;
                }
                loadHypotheses();
            }
        }
    }
}
