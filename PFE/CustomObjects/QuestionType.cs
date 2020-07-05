using PFE.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.CustomObjects
{
    public class QuestionType
    {
        public int value { get; set; }

        public QuestionType(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return QuestionTypes.getStringValue(value);
        }
    }
}
