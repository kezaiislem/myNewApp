using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Shared
{
    public static class RestHelper
    {

        private static readonly string BaseUrl = "http://localhost:8080/";

        public static async Task<String> getDomains()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "domains"))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<String> getFactors()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "factors"))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<String> authentificate(String username, String password)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "authenticate?user=" + username + "&pass=" + password))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<String> createProject(Project project)
        {
            using (HttpClient client = new HttpClient())
            {
                var myContent = JsonConvert.SerializeObject(project);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                using (HttpResponseMessage resonse = await client.PostAsync(BaseUrl + "newproject?sessionid="+Data.sessionId, byteContent))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<String> hostSurvey(Survey survey)
        {
            using (HttpClient client = new HttpClient())
            {
                var myContent = JsonConvert.SerializeObject(survey);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                using (HttpResponseMessage resonse = await client.PostAsync(BaseUrl + "host", byteContent))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<String> loadSectionSuggestion(SectionSuggestionsRequestObject requestObject)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "sectionsuggestions?technologyname=" + requestObject.technologyName + "&technologyfield=" + requestObject.technologyField + "&evaluationContext=" + requestObject.evalutionContext + "&factorname=" + requestObject.factor))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<String> loadQuestionSuggestion(QuestionSuggestionsRequestObject requestObject)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "questionsuggestions?technologyname=" + requestObject.technologyName + "&technologyfield=" + requestObject.technologyField + "&evaluationContext=" + requestObject.evalutionContext + "&factorname=" + requestObject.factor))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<String> getModelSurveys(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "modelSurveys/"+id))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }
    }
}
