using Newtonsoft.Json;
using PFE.CustomObjects;
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
    public class FactorSugesstionViewModel
    {
        public SectionSuggestionsRequestObject requestObject { get; set; }
        public Factor selectedItem { get; set; }

        public FactorSugesstionViewModel()
        {
            requestObject = new SectionSuggestionsRequestObject();
        }

        public async Task<List<Factor>> loadSuggestions()
        {
            String data = await RestHelper.loadSectionSuggestion(requestObject);
            Console.WriteLine(data);
            List<Factor> result = JsonConvert.DeserializeObject<List<Factor>>(data);
            foreach(Factor factor in result)
            {
                factor.questions = new List<Question>();
                factor.questions.Add(new Question { text = "Q1", type = 2 });
                factor.questions.Add(new Question { text = "Q2", type = 1 });
                factor.questions.Add(new Question { text = "Q3", type = 1 });
                if(factor.title == "Adaptability")
                {
                    factor.questions.Add(new Question { text = "Q4", type = 1 });
                }
            }
            return result;
        }
    }
}
