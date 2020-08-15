using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ConfirmatoryAnalysisControlViewModel
    {

        public Survey survey { get; set; }
        public BindingList<Factor> factors { get; set; }
        public BindingList<Question> questions { get; set; }
        public BindingList<Question> rmvQuestions { get; set; }

        public Factor selectedFactor;
        public Factor SelectedFactor
        {
            get => selectedFactor;
            set
            {
                selectedFactor = value;
                UpdateQuestions();
            }
        }
        public Question selectedQuestion { get; set; }
        public Question selectedRmvQuestion { get; set; }
        public List<CustomPersonalAnswer> personalAnswers { get; set; }

        public ConfirmatoryAnalysisControlViewModel(Survey survey)
        {
            this.survey = survey;
            this.factors = new BindingList<Factor>();
            this.questions = new BindingList<Question>();
            this.rmvQuestions = new BindingList<Question>();
            foreach (Factor f in survey.factors)
            {
                if (f.evaluationFactor)
                {
                    factors.Add(f);
                }
            }
            SelectedFactor = this.factors.First<Factor>();
            Task.Run(async () => await getAnswers());
        }

        public void reloadAnswers()
        {
            Task.Run(async () => await getAnswers());
        }

        private async Task getAnswers()
        {
            try
            {
                String data = await RestHelper.getPersonalAnswers(this.survey.id);
                if (data != "")
                {
                    this.personalAnswers = JsonConvert.DeserializeObject<List<CustomPersonalAnswer>>(data);
                }
            }
            catch (Exception ex)
            {
                this.personalAnswers = null;
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdateQuestions()
        {
            if (selectedFactor != null)
            {
                questions.Clear();
                foreach (Question question in selectedFactor.questions)
                {
                    questions.Add(question);
                }
            }
        }

        public void addRmvQuestion()
        {
            if (selectedQuestion != null)
            {
                bool exists = false;
                foreach (Question q in rmvQuestions)
                {
                    if (q.text == selectedQuestion.text)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    this.rmvQuestions.Add(selectedQuestion);
                }
            }
        }

        public void removeRmvQuestion()
        {
            if (selectedRmvQuestion != null)
            {
                this.rmvQuestions.Remove(selectedRmvQuestion);
            }
        }

        public string validateChrobach()
        {
            if (personalAnswers == null)
            {
                this.reloadAnswers();
                return "An error has been occured please check your connection and restart again";
            }
            if (personalAnswers.Count == 0)
            {
                return "There are no answers";
            }
            return null;
        }

        public DataTable calculateChrobachTable()
        {
            DataTable temp;
            DataTable result = new DataTable();
            DataTable dt = DataTableManager.prepareConfirmatoryEvalTable(this.factors.ToList<Factor>(), this.personalAnswers, rmvQuestions.ToList<Question>());
            DataRow dataRow = result.NewRow();

            foreach (Factor factor in this.factors)
            {
                result.Columns.Add(factor.title);
                if (factor.questions.Count > 1)
                {
                    temp = dt.Copy();
                    foreach (DataColumn column in dt.Columns)
                    {
                        if (!column.ColumnName.StartsWith(factor.title))
                        {
                            temp.Columns.Remove(column.ColumnName);
                        }
                    }
                    Exporter.exportCsv(Path.GetTempPath() + "/chronbach-tmp.csv", ";", temp);
                    dataRow[factor.title] = RCalculator.CalculateAlpha(Path.GetTempPath() + "/chronbach-tmp.csv").ToString();
                }
                else
                {
                    dataRow[factor.title] = 1;
                }
            }
            result.Rows.Add(dataRow);
            return result;
        }
    }
}
