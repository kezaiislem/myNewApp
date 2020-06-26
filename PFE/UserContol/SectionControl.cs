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
            LoadQuestions();
            labelTitle.Text = this.viewModel.section.title;
            labelDescription.Text = this.viewModel.section.description;
        }

        private void LoadQuestions()
        {
            foreach (Question question in viewModel.section.questions)
            {
                QuestionControl questionControl = new QuestionControl(question);
                questionControl.Dock = DockStyle.Top;
                questionControl.AutoScaleMode = AutoScaleMode.None;
                mainPanel.Controls.Add(questionControl);
                mainPanel.Controls.SetChildIndex(questionControl, 0);
                this.viewModel.QuestionControls.Add(questionControl);
            }
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            using (var form = new AddQuestionForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    addQuestion(form.text, 0);
                }
            }
            
        }

        public void addQuestion(String text, int type)
        {
            Question question = new Question { text = text };
            QuestionControl questionControl = new QuestionControl(question);
            questionControl.Dock = DockStyle.Top;
            questionControl.AutoScaleMode = AutoScaleMode.None;
            mainPanel.Controls.Add(questionControl);
            mainPanel.Controls.SetChildIndex(questionControl, 0);
            if (this.viewModel.section.questions == null)
            {
                this.viewModel.section.questions = new List<Question>();
            }
            this.viewModel.section.questions.Add(question);
        }
    }
}
