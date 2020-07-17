using PFE.CustomObjects;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Constants
{
    public static class QuestionTypes
    {
        public const int LIKERT_3 = 0;
        public const int LIKERT_5 = 1;
        public const int LIKERT_7 = 2;
        public const int RADIO = 3;
        public const int CHECK_BOX = 4;

        public static List<QuestionType> questionTypes()
        {
            List<QuestionType> questionTypes = new List<QuestionType>();
            questionTypes.Add(new QuestionType(QuestionTypes.LIKERT_3));
            questionTypes.Add(new QuestionType(QuestionTypes.LIKERT_5));
            questionTypes.Add(new QuestionType(QuestionTypes.LIKERT_7));
            questionTypes.Add(new QuestionType(QuestionTypes.RADIO));
            questionTypes.Add(new QuestionType(QuestionTypes.CHECK_BOX));
            return questionTypes;
        }

        public static List<String> likertStrings_5()
        {
            return new List<String> { "Strongly disagree", "Disagree", "Neutral", "Agree", "Strongly Agree" };
        }

        public static List<String> likertStrings_3()
        {
            return new List<String> { "Disagree", "Neutral", "Agree" };
        }

        public static List<String> likertStrings_7()
        {
            return new List<String> { "Strongly Sisagree", "Disagree", "More or less Disagree", "Neutral", "More or less Agree", "Agree", "Strongly Agree" };
        }

        public static List<QuestionType> evaluationTypes()
        {
            List<QuestionType> questionTypes = new List<QuestionType>();
            questionTypes.Add(new QuestionType(QuestionTypes.LIKERT_3));
            questionTypes.Add(new QuestionType(QuestionTypes.LIKERT_5));
            questionTypes.Add(new QuestionType(QuestionTypes.LIKERT_7));
            return questionTypes;
        }

        public static String getStringValue(int TYPE)
        {
            switch (TYPE)
            {
                case LIKERT_3:
                    return "Likert 3";
                case LIKERT_5:
                    return "Likert 5";
                case LIKERT_7:
                    return "Likert 7";
                case RADIO:
                    return "Radio";
                case CHECK_BOX:
                    return "Chackbox";
                default:
                    return "Not Supported";
            }
        }
    }
}
