using Newtonsoft.Json;
using PFE.CustomObjects;
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

        public StatisticsControlViewModel(Survey survey )
        {
            this.survey = survey;
            //Task.Run(async () => await getSurveys());
        }

        /*private async Task getSurveys()
        {
            try
            {
                String data = await RestHelper.getModelSurveys(this.modelId);
                if (data != "")
                {
                    this.surveys = JsonConvert.DeserializeObject<List<CustomSurveysObject>>(data);
                }
            }
            catch (Exception ex)
            {
                this.surveys = new List<CustomSurveysObject>();
            }
        }*/
    }
}
