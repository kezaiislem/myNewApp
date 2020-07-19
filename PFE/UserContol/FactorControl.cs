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
    public partial class FactorControl : UserControl
    {

        public FactorControlViewModel viewModel { get; set; }

        public FactorControl(Factor factor)
        {
            foreach (Question q in factor.questions)
            {
                Console.WriteLine("Type = " + q.type);
            }
            viewModel = new FactorControlViewModel(factor);
            InitializeComponent();
            LoadQuestions();
            labelTitle.Text = this.viewModel.factor.title;
            labelDescription.Text = this.viewModel.factor.description;
        }

        private void LoadQuestions()
        {
            foreach (Question question in viewModel.factor.questions)
            {
                if (question.type == QuestionTypes.LIKERT_3 || question.type == QuestionTypes.LIKERT_5 || question.type == QuestionTypes.LIKERT_7)
                {
                    LikertQuestionControl questionControl = new LikertQuestionControl(question, this.viewModel.factor.questions);
                    questionControl.Dock = DockStyle.Top;
                    questionControl.AutoScaleMode = AutoScaleMode.None;
                    mainPanel.Controls.Add(questionControl);
                    mainPanel.Controls.SetChildIndex(questionControl, 0);
                }
                else if (question.type == QuestionTypes.RADIO)
                {
                    RadioQuestionContol questionControl = new RadioQuestionContol(question, this.viewModel.factor.questions);
                    questionControl.Dock = DockStyle.Top;
                    questionControl.AutoScaleMode = AutoScaleMode.None;
                    mainPanel.Controls.Add(questionControl);
                    mainPanel.Controls.SetChildIndex(questionControl, 0);
                }
                else if (question.type == QuestionTypes.CHECK_BOX)
                {
                    CheckBoxQuestionContol questionControl = new CheckBoxQuestionContol(question, this.viewModel.factor.questions);
                    questionControl.Dock = DockStyle.Top;
                    questionControl.AutoScaleMode = AutoScaleMode.None;
                    mainPanel.Controls.Add(questionControl);
                    mainPanel.Controls.SetChildIndex(questionControl, 0);
                }
            }
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            using (var form = new AddQuestionForm(this.viewModel.factor.title != "None"))
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
                LikertQuestionControl questionControl = new LikertQuestionControl(question, this.viewModel.factor.questions);
                questionControl.Dock = DockStyle.Top;
                questionControl.AutoScaleMode = AutoScaleMode.None;
                mainPanel.Controls.Add(questionControl);
                mainPanel.Controls.SetChildIndex(questionControl, 0);
                if (this.viewModel.factor.questions == null)
                {
                    this.viewModel.factor.questions = new List<Question>();
                }
                this.viewModel.factor.questions.Add(question);
            }
            else if (question.type == QuestionTypes.RADIO)
            {
                RadioQuestionContol questionControl = new RadioQuestionContol(question, this.viewModel.factor.questions);
                questionControl.Dock = DockStyle.Top;
                questionControl.AutoScaleMode = AutoScaleMode.None;
                mainPanel.Controls.Add(questionControl);
                mainPanel.Controls.SetChildIndex(questionControl, 0);
                if (this.viewModel.factor.questions == null)
                {
                    this.viewModel.factor.questions = new List<Question>();
                }
                this.viewModel.factor.questions.Add(question);
            }
            else if (question.type == QuestionTypes.CHECK_BOX)
            {
                CheckBoxQuestionContol questionControl = new CheckBoxQuestionContol(question, this.viewModel.factor.questions);
                questionControl.Dock = DockStyle.Top;
                questionControl.AutoScaleMode = AutoScaleMode.None;
                mainPanel.Controls.Add(questionControl);
                mainPanel.Controls.SetChildIndex(questionControl, 0);
                if (this.viewModel.factor.questions == null)
                {
                    this.viewModel.factor.questions = new List<Question>();
                }
                this.viewModel.factor.questions.Add(question);
            }
        }
    }
}
