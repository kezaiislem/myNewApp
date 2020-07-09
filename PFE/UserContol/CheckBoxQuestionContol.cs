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
using MetroFramework.Controls;
using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using Bunifu.Core.forms.licensing;

namespace PFE.UserContol
{
    public partial class CheckBoxQuestionContol : UserControl
    {

        Question question;

        List<Question> questions;

        private int checkBox_default_x = 30;
        private int checkBox_default_y = 15;
        private int distance = 25;
        private int choices_count = 0;

        public CheckBoxQuestionContol(Question question, List<Question> questions)
        {
            InitializeComponent();
            this.question = question;
            this.questions = questions;
            this.labelQuestion.Text = question.text;
            textBoxEditQuestion.Text = question.text;
            if (this.question.choices == null)
            {
                this.question.choices = new List<String>();
            }
            InitializeChoices();
        }

        private void InitializeChoices()
        {
            foreach (string choice in this.question.choices.ToList())
            {
                this.addChoice(choice);
            }
        }

        public void addChoice(string choice)
        {
            MetroCheckBox checkBox = new MetroCheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = new System.Drawing.Point(checkBox_default_x, checkBox_default_y + choices_count * distance);
            checkBox.Name = "metroRadioButton3";
            checkBox.Size = new System.Drawing.Size(69, 15);
            checkBox.TabIndex = 8;
            checkBox.Text = choice;
            checkBox.UseSelectable = true;
            choices_count++;

            if (choices_count > 1)
            {
                this.Height = this.Height + distance;
            }
            this.panel3.Controls.Add(checkBox);
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

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            string choice = Interaction.InputBox("Entrer le choix", "Ajouter un choix", "Choice");
            if (!string.IsNullOrWhiteSpace(choice))
            {
                addChoice(choice);
                question.choices.Add(choice);
            }
        }
    }
}
