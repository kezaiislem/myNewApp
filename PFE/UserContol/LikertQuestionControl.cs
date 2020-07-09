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

namespace PFE.UserContol
{
    public partial class LikertQuestionControl : UserControl
    {

        Question question;

        List<Question> questions;

        public LikertQuestionControl(Question question, List<Question> questions)
        {
            InitializeComponent();
            this.question = question;
            this.questions = questions;
            this.labelQuestion.Text = question.text;
            textBoxEditQuestion.Text = question.text;
            Console.WriteLine(question.choices);
        }

        private void buttonRemoveQuestion_Click(object sender, EventArgs e)
        {
            questions.Remove(question);
            this.Parent.Controls.Remove(this);
        }

        private void labelQuestion_DoubleClick(object sender, EventArgs e)
        {
            textBoxEditQuestion.Visible = true;
            labelQuestion.Visible = false;
            labelQuestion.SendToBack();
            textBoxEditQuestion.BringToFront();
            buttonRemoveQuestion.Visible = true;
        }

        private void textBoxEditQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                labelQuestion.Text = textBoxEditQuestion.Text;
                this.question.text = textBoxEditQuestion.Text;
                textBoxEditQuestion.Visible = false;
                labelQuestion.Visible = true;
                labelQuestion.BringToFront();
                textBoxEditQuestion.SendToBack();
                buttonRemoveQuestion.Visible = false;
            }
        }
    }
}
