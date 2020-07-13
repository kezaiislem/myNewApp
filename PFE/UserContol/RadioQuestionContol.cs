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
    public partial class RadioQuestionContol : UserControl
    {

        Question question;

        List<Question> questions;

        private int radio_default_x = 30;
        private int radio_default_y = 5;
        private int distance = 25;
        private int choices_count = 0;

        public RadioQuestionContol(Question question, List<Question> questions)
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
            foreach (String choice in this.question.choices.ToList())
            {
                this.addChoice(choice);
            }
        }

        public void addChoice(string choice)
        {
            MetroRadioButton radioButton = new MetroRadioButton();
            radioButton.AutoSize = true;
            radioButton.Location = new System.Drawing.Point(radio_default_x, radio_default_y + choices_count * distance);
            radioButton.Name = "metroRadioButton3";
            radioButton.Size = new System.Drawing.Size(69, 15);
            radioButton.TabIndex = 8;
            radioButton.Text = choice;
            radioButton.UseSelectable = true;
            choices_count++;

            if (choices_count > 1)
            {
                this.Height = this.Height + distance;
            }
            this.panel3.Controls.Add(radioButton);
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
