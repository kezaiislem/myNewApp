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
    public partial class SectionControl : UserControl
    {

        public SectionControlViewModel viewModel { get; set; }

        public SectionControl(Section section)
        {
            viewModel = new SectionControlViewModel(section);
            InitializeComponent();
            labelTitle.Text = this.viewModel.section.title;
            labelDescription.Text = this.viewModel.section.description;
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            QuestionControl question = new QuestionControl("Question 1", 0, null);
            question.Dock = DockStyle.Top;
            question.AutoScaleMode = AutoScaleMode.None;
            mainPanel.Controls.Add(question);
            mainPanel.Controls.SetChildIndex(question, 0);
            if (this.viewModel.section.questions == null)
            {
                this.viewModel.section.questions = new List<Question>();
            }
            this.viewModel.section.questions.Add(new Question { text = "Question 1" });
        }
    }
}
