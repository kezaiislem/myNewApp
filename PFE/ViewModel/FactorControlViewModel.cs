using PFE.model;
using PFE.Model;
using PFE.UserContol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class FactorControlViewModel
    {
        public Factor factor { get; set; }
        public List<LikertQuestionControl> QuestionControls { get; set; }

        public FactorControlViewModel(Factor factor)
        {
            if (factor.questions == null)
            {
                factor.questions = new List<Question>();
            }
            this.QuestionControls = new List<LikertQuestionControl>();
            this.factor = factor;
        }
    }
}
