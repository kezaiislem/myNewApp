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
    public class SurveysControlViewModel
    {
        public int modelId { get; set; }
        public List<Survey> surveys { get; set; }

        public SurveysControlViewModel(int modelId)
        {
            this.modelId = modelId;
            Task.Run(async () => await getSurveys());
        }

        public void refresh()
        {
            surveys = null;
            Task.Run(async () => await getSurveys());
        }

        private async Task getSurveys()
        {
            try
            {
                String data = await RestHelper.getModelSurveys(this.modelId);
                if (data != "")
                {
                    this.surveys = JsonConvert.DeserializeObject<List<Survey>>(data);
                }
            }
            catch (Exception ex)
            {
                this.surveys = new List<Survey>();
            }
        }
    }
}
