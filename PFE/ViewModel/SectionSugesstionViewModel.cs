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
    public class SectionSugesstionViewModel
    {
        public SectionSuggestionsRequestObject requestObject { get; set; }
        public Factor selectedItem { get; set; }

        public SectionSugesstionViewModel()
        {
            requestObject = new SectionSuggestionsRequestObject();
        }

        public async Task<List<Factor>> loadSuggestions()
        {
            String data = await RestHelper.loadSectionSuggestion(requestObject);
            Console.WriteLine(data);
            List<Factor> result = JsonConvert.DeserializeObject<List<Factor>>(data);
            return result;
        }
    }
}
