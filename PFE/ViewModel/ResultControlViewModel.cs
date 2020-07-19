using Newtonsoft.Json;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ResultControlViewModel{

        public int surveyId { get; set; }
        public List<Factor> factors { get; set; }

        public ResultControlViewModel(int surveyId)
        {
            this.surveyId = surveyId;
            Task.Run(async () => await loadResults());
        }

        public async Task loadResults()
        {
            try
            {
                String data = await RestHelper.getAnswers(this.surveyId);
                if (data != "")
                {
                    factors = JsonConvert.DeserializeObject<List<Factor>>(data);
                }
            }
            catch (Exception ex)
            {
                factors = new List<Factor>();
            }
        }

    }
}
