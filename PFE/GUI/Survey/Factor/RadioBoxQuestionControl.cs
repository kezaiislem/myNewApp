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
using PFE.Constants;
using Microsoft.VisualBasic;
using Atalasoft.Imaging.Lib;

namespace PFE.UserContol
{
    public partial class RadioBoxQuestionControl : UserControl
    {

        private const int QUESTION_HEIGH = 35;
        private int controls_index = 0;
        private Boolean isRadio = false;

        Question question;
        List<Question> questions;
        List<RadioChoiceControl> radioChoiceControls;
        List<CheckChoiceControl> checkChoiceControls;

        public RadioBoxQuestionControl(Question question, List<Question> questions)
        {
            InitializeComponent();
            this.question = question;
            this.questions = questions;
            this.labelQuestion.Text = question.text;
            textBoxEditQuestion.Text = question.text;
            Init();
        }

        private void Init()
        {
            if (this.question.type == QuestionTypes.RADIO)
            {
                isRadio = true;
            }
            checkChoiceControls = new List<CheckChoiceControl>();
            radioChoiceControls = new List<RadioChoiceControl>();
            foreach (string choice in question.choices)
            {
                if (isRadio)
                    addRadioChoice(choice);
                else
                    addCheckChoice(choice);
            }
        }

        private void ChoiceChanged(object o, PropertyChangedEventArgs e)
        {
            if (o != null)
            {
                if (isRadio)
                {
                    RadioChoiceChanged((RadioChoiceControl)o);
                }
                else
                {
                    CheckChoiceChanged((CheckChoiceControl)o);
                }
            }
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

        private void addRadioChoice(string choice)
        {
            RadioChoiceControl radioChoice = new RadioChoiceControl(choice, controls_index);
            radioChoice.Dock = DockStyle.Top;
            radioChoice.AutoScaleMode = AutoScaleMode.None;
            radioChoice.Height = QUESTION_HEIGH;
            radioChoice.Visible = true;
            radioChoice.PropertyChanged += ChoiceChanged;
            this.panel1.Controls.Add(radioChoice);
            this.panel1.Controls.SetChildIndex(radioChoice, 0);
            this.radioChoiceControls.Add(radioChoice);
            this.Height += QUESTION_HEIGH;
            controls_index++;
        }

        private void addCheckChoice(string choice)
        {
            CheckChoiceControl checkChoice = new CheckChoiceControl(choice, controls_index);
            checkChoice.Dock = DockStyle.Top;
            checkChoice.AutoScaleMode = AutoScaleMode.None;
            checkChoice.Height = QUESTION_HEIGH;
            checkChoice.Visible = true;
            checkChoice.PropertyChanged += ChoiceChanged;
            this.panel1.Controls.Add(checkChoice);
            this.panel1.Controls.SetChildIndex(checkChoice, 0);
            this.checkChoiceControls.Add(checkChoice);
            this.Height += QUESTION_HEIGH;
            controls_index++;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string choice = Interaction.InputBox("Entrer le choix", "Ajouter un choix", "Choice");
            if (!string.IsNullOrWhiteSpace(choice))
            {
                if (isRadio)
                    addRadioChoice(choice);
                else
                    addCheckChoice(choice);
                question.choices.Add(choice);
            }
        }

        private void RadioChoiceChanged(RadioChoiceControl radioChoice)
        {
            if (radioChoice.remove)
            {
                if (question.choices.Count > 2)
                {
                    question.choices.RemoveAt(radioChoice.index);
                    foreach (RadioChoiceControl radioChoiceControl in radioChoiceControls)
                    {
                        if (radioChoice.index < radioChoiceControl.index)
                        {
                            radioChoiceControl.index--;
                        }
                    }
                    this.panel1.Controls.Remove(radioChoice);
                    this.Height -= QUESTION_HEIGH;
                }
                else
                {
                    MessageBox.Show("A question can't have less than two choices", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                question.choices[radioChoice.index] = radioChoice.choice;
            }
        }
        
        private void CheckChoiceChanged(CheckChoiceControl checkChoice)
        {
            if (checkChoice.remove)
            {
                if (question.choices.Count > 2)
                {
                    question.choices.RemoveAt(checkChoice.index);
                    foreach (CheckChoiceControl checkChoiceControl in checkChoiceControls)
                    {
                        if (checkChoice.index < checkChoiceControl.index)
                        {
                            checkChoiceControl.index--;
                        }
                    }
                    this.panel1.Controls.Remove(checkChoice);
                    this.Height -= QUESTION_HEIGH;
                }
                else
                {
                    MessageBox.Show("A question can't have less than two choices", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                question.choices[checkChoice.index] = checkChoice.choice;
            }
        }
    }
}
