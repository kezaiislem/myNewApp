using Newtonsoft.Json;
using PFE.Constants;
using PFE.CustomObjects;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class AddQuestionFormViewModel
    {
        public List<QuestionType> questionCombos { get; set; }
        public Boolean hasFactor { get; set; }

        public QuestionType selectedItem;
        public QuestionType SelectedItem
        {
            get { return selectedItem; }
            set {
                question.type = value.value;
                selectedItem = value; 
            }
        }

        public Question question;

        public AddQuestionFormViewModel(Boolean hasFactor)
        {
            this.hasFactor = hasFactor;
            this.initCombos();
            this.question = new Question();
        }

        private void initCombos()
        {
            if (this.hasFactor)
            {
                this.questionCombos = QuestionTypes.evaluationTypes();
            }
            else
            {
                this.questionCombos = QuestionTypes.questionTypes();
            }
        }
    }
}
