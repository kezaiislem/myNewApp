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
using LiveCharts;
using LiveCharts.Wpf;
using PFE.model;

namespace PFE.UserContol
{
    public partial class SectionResultControl : UserControl
    {

        public SectionResultControlViewModel viewModel { get; set; }

        public SectionResultControl(Factor factor)
        {
            InitializeComponent();
            Init(factor);
        }

        private void Init(Factor factor)
        {
            viewModel = new SectionResultControlViewModel(factor);
            labelTitle.DataBindings.Add("Text", viewModel.factor, "title", true, DataSourceUpdateMode.OnPropertyChanged);
            foreach (Question question in factor.questions)
            {
                addQuestion(question);
            }
        }

        private void addQuestion(Question question)
        {
            QuestionResultControl questionResultControl = new QuestionResultControl(question);
            questionResultControl.Dock = DockStyle.Top;
            questionResultControl.AutoScaleMode = AutoScaleMode.None;
            panelQuestionContainer.Controls.Add(questionResultControl);
            panelQuestionContainer.Controls.SetChildIndex(questionResultControl, 0);
            questionResultControl.Show();
        }

    }
}
