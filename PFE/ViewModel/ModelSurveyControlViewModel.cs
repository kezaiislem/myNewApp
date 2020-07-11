using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ModelSurveyControlViewModel
    {
        public Survey survey { get; set; }
        public List<Survey> surveys { get; set; }

        public ModelSurveyControlViewModel(Survey survey, List<Survey> surveys)
        {
            this.surveys = surveys;
            this.survey = survey;
        }
    }
}
