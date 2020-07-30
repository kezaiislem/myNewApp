using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ResultSurveyControlViewModel
    {
        public Survey survey { get; set; }

        public ResultSurveyControlViewModel(Survey survey)
        {
            this.survey = survey;
        }
    }
}
