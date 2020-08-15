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
    public class QuestionSuggestionViewModel
    {
        public QuestionSuggestionsRequestObject requestObject { get; set; }
        public Question selectedItem { get; set; }

        public QuestionSuggestionViewModel()
        {
            requestObject = new QuestionSuggestionsRequestObject();
        }

        public async Task<List<Question>> loadSuggestions()
        {
            try
            {
                String data = await RestHelper.loadQuestionSuggestion(requestObject);
                List<Question> result = JsonConvert.DeserializeObject<List<Question>>(data);
                return result;
            }
            catch(Exception e)
            {
                return new List<Question>();
            }
        }
    }
}
