using ClosedXML.Excel;
using Newtonsoft.Json;
using PFE.Constants;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
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

        public async Task saveExel()
        {
            try
            {
                String data = await RestHelper.getPersonalAnswers(this.surveyId);
                if (data != "")
                {
                    this.personalAnswers = JsonConvert.DeserializeObject<List<CustomPersonalAnswer>>(data);
                    buildExel();
                }
            }
            catch (Exception ex)
            {
                factors = new List<Factor>();
            }
        }

        public void buildExel()
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
                    {
                        dataRow[answer.questions.ElementAt(i).text] = answer.answers.ElementAt(i).value.ToString();
                    }
                    else if (answer.questions.ElementAt(i).type == QuestionTypes.RADIO)
                    {
                        dataRow[answer.questions.ElementAt(i).text] = answer.questions.ElementAt(i).choices[answer.answers.ElementAt(i).value - 1];
                    }
                    /*else if (answer.questions.ElementAt(i).type == QuestionTypes.CHECK_BOX)
                    {
                        string value = "";
                        foreach(int index in answer.answers.ElementAt(i).chValues)
                        {
                            value += answer.questions.ElementAt(i).choices[answer.answers.ElementAt(i).chValues[index]] + ",";
                        }
                        dataRow[answer.questions.ElementAt(i).text] = value;
                    }*/
                }
                dt.Rows.Add(dataRow);
            }
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, "WorksheetName");
            wb.SaveAs("C:/Users/ISLEM/Desktop/ExelTst/csharp-Excel.xlsx");
        }

    }
}
