using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class PhaseControlViewModel
    {
        public Survey survey { get; set; }

        public PhaseControlViewModel(Survey survey, Model.Model model)
        {
            this.survey = survey;
            this.survey.model = model;
        }
    }
}
