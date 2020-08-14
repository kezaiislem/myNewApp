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

                using (HttpResponseMessage resonse = await client.PostAsync(BaseUrl + "newproject?sessionid=" + Data.sessionId, byteContent))
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

        public static async Task<String> loadFactorSuggestion(SectionSuggestionsRequestObject requestObject)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "factorsuggestions?technologyname=" + requestObject.technologyName + "&technologyfield=" + requestObject.technologyField + "&evaluationContext=" + requestObject.evalutionContext + "&factorname=" + requestObject.factor))
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
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "modelSurveys/" + id))
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

        public static async Task<String> deleteSurvey(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.DeleteAsync(BaseUrl + "deleteSurvey/" + id))
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

        public static async Task<String> switchStatus(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.PutAsync(BaseUrl + "switchStatus/" + id, null))
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

        public static async Task<String> shareSurvey(string id, MailingRequest request)
        {
            using (HttpClient client = new HttpClient())
            {
                var myContent = JsonConvert.SerializeObject(request);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                using (HttpResponseMessage resonse = await client.PutAsync(BaseUrl + "share/" + id, byteContent))
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

        public static async Task<String> getAnswers(long id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "answers/" + id))
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

        public static async Task<String> getSurvey(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "survey/" + id))
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

        public static async Task<String> getPersonalAnswers(long id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "personalanswers/" + id))
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
        
        public static async Task<bool> checkUsername(string username)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "chkU/" + username))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return Boolean.Parse(data);
                        }
                    }
                }
            }
            return false;
        }

        public static async Task<bool> checkEmail(string email)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resonse = await client.GetAsync(BaseUrl + "chkE/" + email))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return Boolean.Parse(data);
                        }
                    }
                }
            }
            return false;
        }

        public static async Task<bool> addUser(User user)
        {
            using (HttpClient client = new HttpClient())
            {
                var myContent = JsonConvert.SerializeObject(user);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                using (HttpResponseMessage resonse = await client.PostAsync(BaseUrl + "newUser", byteContent))
                {
                    using (HttpContent content = resonse.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Debug.WriteLine(data);
                            return Boolean.Parse(data);
                        }
                    }
                }
            }
            return false;
        }
    }
}
