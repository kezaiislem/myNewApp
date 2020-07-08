using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using PFE.UserContol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class SurveyTabControlViewModel
    {
        public int surveyId { get; set; }
        public int phaseNumber { get; set; }
        public string strDate { get; set; }
        public string status { get; set; }

        public SurveyTabControlViewModel(Survey survey)
        {
            this.surveyId = survey.id;
            this.phaseNumber = survey.phaseNumber;
            this.strDate = "12/12/2020";
            if (survey.host.online)
            {
                this.status = "Online";
            }
            else
            {
                this.status = "Offline";
            }
        }
    }
}
