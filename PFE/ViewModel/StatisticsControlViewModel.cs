using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.model;
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
    public class StatisticsControlViewModel
    {
        public Survey survey { get; set; }

        public StatisticsControlViewModel(String id)
        {
            Task.Run(async () => await loadSurvey(id));
        }

        public async Task loadSurvey(string id)
        {
            try
            {
                String data = await RestHelper.getSurvey(id);
                if (data != "")
                {
                    Survey survey = JsonConvert.DeserializeObject<Survey>(data);
                    this.survey = survey;
                }
            }
            catch (Exception ex)
            {
                this.survey = null;
            }
        }
    }
}
