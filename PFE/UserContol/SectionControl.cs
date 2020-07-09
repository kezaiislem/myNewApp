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
                if (question.type == QuestionTypes.LIKERT_3 || question.type == QuestionTypes.LIKERT_5 || question.type == QuestionTypes.LIKERT_7)
                {
                    LikertQuestionControl questionControl = new LikertQuestionControl(question, this.viewModel.section.questions);
                    questionControl.Dock = DockStyle.Top;
                    questionControl.AutoScaleMode = AutoScaleMode.None;
                    mainPanel.Controls.Add(questionControl);
                    mainPanel.Controls.SetChildIndex(questionControl, 0);
                }
                else if (question.type == QuestionTypes.RADIO)
                {
                    RadioQuestionContol questionControl = new RadioQuestionContol(question, this.viewModel.section.questions);
                    questionControl.Dock = DockStyle.Top;
                    questionControl.AutoScaleMode = AutoScaleMode.None;
                    mainPanel.Controls.Add(questionControl);
                    mainPanel.Controls.SetChildIndex(questionControl, 0);
                }
                else if (question.type == QuestionTypes.CHECK_BOX)
                {
                    CheckBoxQuestionContol questionControl = new CheckBoxQuestionContol(question, this.viewModel.section.questions);
                    questionControl.Dock = DockStyle.Top;
                    questionControl.AutoScaleMode = AutoScaleMode.None;
                    mainPanel.Controls.Add(questionControl);
                    mainPanel.Controls.SetChildIndex(questionControl, 0);
                }
            }
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            using (var form = new AddQuestionForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    addQuestion(form.viewModel.question);
                }
            }
            
        }

        public void addQuestion(Question question)
        {
            if (question.type == QuestionTypes.LIKERT_3 || question.type == QuestionTypes.LIKERT_5 || question.type == QuestionTypes.LIKERT_7)
            {
                LikertQuestionControl questionControl = new LikertQuestionControl(question, this.viewModel.section.questions);
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
            else if (question.type == QuestionTypes.RADIO)
            {
                RadioQuestionContol questionControl = new RadioQuestionContol(question, this.viewModel.section.questions);
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
            else if (question.type == QuestionTypes.CHECK_BOX)
            {
                CheckBoxQuestionContol questionControl = new CheckBoxQuestionContol(question, this.viewModel.section.questions);
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
}
