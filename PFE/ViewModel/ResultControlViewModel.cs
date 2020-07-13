using Newtonsoft.Json;
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
        public List<Section> sections { get; set; }

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
                    sections = JsonConvert.DeserializeObject<List<Section>>(data);
                }
            }
            catch (Exception ex)
            {
                sections = new List<Section>();
            }
        }

    }
}
