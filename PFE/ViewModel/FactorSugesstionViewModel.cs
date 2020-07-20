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
            try
            {
                String data = await RestHelper.loadFactorSuggestion(requestObject);
                List<Factor> result = JsonConvert.DeserializeObject<List<Factor>>(data);
                return result;
            }
            catch(Exception e)
            {
                return new List<Factor>();
            }
        }
    }
}
