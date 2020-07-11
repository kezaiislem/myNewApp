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
        public string hostId { get; set; }
        public int phaseNumber { get; set; }
        public string strDate { get; set; }
        public string status { get; set; }
        public Survey survey { get; set; }

        public SurveyTabControlViewModel(Survey survey)
        {
            this.survey = survey;
            this.surveyId = survey.id;
            this.phaseNumber = survey.phaseNumber;
            this.strDate = "12/12/2020";
            this.hostId = survey.host.id;
            if (survey.host.online)
            {
                this.status = "Online";
            }
            else
            {
                this.status = "Offline";
            }
        }

        public Boolean switchStatus()
        {
            var data = Task.Run(async () => await RestHelper.switchStatus(hostId)).Result;
            while (data == null) { }
            if (string.IsNullOrWhiteSpace(data))
            {
                return false;
            }
            else
            {
                Host s = JsonConvert.DeserializeObject<Host>(data);
                if (s.online)
                {
                    this.status = "Online";
                }
                else
                {
                    this.status = "Offline";
                }
            }
            return true;
        }
    }
}
