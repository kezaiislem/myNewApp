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

namespace PFE.UserContol
{
    public partial class SectionResultControl : UserControl
    {

        public SectionResultControlViewModel viewModel { get; set; }

        public SectionResultControl(Section section)
        {
            InitializeComponent();
            Init(section);
        }

        private void Init(Section section)
        {
            viewModel = new SectionResultControlViewModel(section);
            labelTitle.DataBindings.Add("Text", viewModel.section, "title", true, DataSourceUpdateMode.OnPropertyChanged);
            foreach (Question question in section.questions)
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
