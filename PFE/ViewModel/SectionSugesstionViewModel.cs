using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    class SectionSugesstionViewModel
    {
        public SectionSuggestionsRequestObject requestObject { get; set; }
        public Section selectedItem { get; set; }

        public SectionSugesstionViewModel()
        {
            requestObject = new SectionSuggestionsRequestObject();
        }

        public async Task<List<Section>> loadSuggestions()
        {
            String data = await RestHelper.loadSectionSuggestion(requestObject);
            Console.WriteLine(data);
            List<Section> result = JsonConvert.DeserializeObject<List<Section>>(data);
            return result;
        }
    }
}
