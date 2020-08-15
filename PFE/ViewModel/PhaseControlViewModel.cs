using Bunifu.Json;
using PFE.Model;
using PFE.Shared;
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

        public PhaseControlViewModel(Survey survey)
        {
            this.survey = survey;
        }

        public async Task<Survey> hostSurvey()
        {
            try
            {
                String res = await RestHelper.hostSurvey(this.survey);
                Survey survey = JsonConvert.DeserializeObject<Survey>(res);
                if (survey != null)
                {
                    this.survey.host = survey.host;
                    this.survey.id = survey.id;
                    this.survey.model.id = survey.model.id;
                    ProjectHandler.saveProject();
                    return survey;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
            return new Survey();
        }
    }
}
