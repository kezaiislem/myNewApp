using ClosedXML.Excel;
using Newtonsoft.Json;
using PFE.Constants;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ResultControlViewModel
    {

        public int surveyId { get; set; }
        public List<Factor> factors { get; set; }

        private List<CustomPersonalAnswer> personalAnswers;

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

        public async Task saveExel(string path)
        {
            try
            {
                String data = await RestHelper.getPersonalAnswers(this.surveyId);
                if (data != "")
                {
                    this.personalAnswers = JsonConvert.DeserializeObject<List<CustomPersonalAnswer>>(data);
                    buildExel(path);
                }
            }
            catch (Exception ex)
            {
                factors = new List<Factor>();
            }
        }

        public void buildExel(string path)
        {
            DataTable dt = new DataTable();
            foreach (Factor f in this.factors)
            {
                foreach (Question q in f.questions)
                {
                    dt.Columns.Add(q.text, typeof(string));
                }
            }
            List<DataRow> dataRows = new List<DataRow>();
            foreach (CustomPersonalAnswer answer in personalAnswers)
            {
                DataRow dataRow = dt.NewRow();
                for (int i = 0; i < answer.answers.Count; i++)
                {
                    switch (answer.questions.ElementAt(i).type)
                    {
                        case QuestionTypes.LIKERT_3:
                            dataRow[answer.questions.ElementAt(i).text] = QuestionTypes.likertStrings_3().ElementAt(answer.answers.ElementAt(i).value - 1);
                            break;
                        case QuestionTypes.LIKERT_5:
                            dataRow[answer.questions.ElementAt(i).text] = QuestionTypes.likertStrings_5().ElementAt(answer.answers.ElementAt(i).value - 1);
                            break;
                        case QuestionTypes.LIKERT_7:
                            dataRow[answer.questions.ElementAt(i).text] = QuestionTypes.likertStrings_7().ElementAt(answer.answers.ElementAt(i).value - 1);
                            break;
                        case QuestionTypes.RADIO:
                            dataRow[answer.questions.ElementAt(i).text] = answer.questions.ElementAt(i).choices[answer.answers.ElementAt(i).value - 1];
                            break;
                        case QuestionTypes.CHECK_BOX:
                            string value = "";
                            foreach (int index in answer.answers.ElementAt(i).chValues)
                            {
                                value += answer.questions.ElementAt(i).choices[index] + ",";
                            }
                            value = value.Remove(value.Length - 1);
                            dataRow[answer.questions.ElementAt(i).text] = value;
                            break;
                    }
                }
                dt.Rows.Add(dataRow);
            }

            if (path.EndsWith(".xlsx"))
            {
                Exporter.exportExel(path, dt);
            }
            else if (path.EndsWith(".csv"))
            {
                Exporter.exportCsv(path, ";", dt);
            }

        }

        public void buildEvaluationExel(string path)
        {
            DataTable dt = new DataTable();
            foreach (Factor f in this.factors)
            {
                foreach (Question q in f.questions)
                {
                    dt.Columns.Add(q.text, typeof(string));
                }
            }
            List<DataRow> dataRows = new List<DataRow>();
            foreach (CustomPersonalAnswer answer in personalAnswers)
            {
                DataRow dataRow = dt.NewRow();
                for (int i = 0; i < answer.answers.Count; i++)
                {
                    if (answer.questions.ElementAt(i).type <= QuestionTypes.LIKERT_7)
                        dataRow[answer.questions.ElementAt(i).text] = answer.answers.ElementAt(i).value;
                }
                dt.Rows.Add(dataRow);
            }

            if (path.EndsWith(".xlsx"))
            {
                Exporter.exportExel(path, dt);
            }
            else if (path.EndsWith(".csv"))
            {
                Exporter.exportCsv(path, ";", dt);
            }

        }

    }
}
