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
        public BindingList<Factor> originalFactors { get; set; }
        public BindingList<Question> originalQuestions { get; set; }
        public BindingList<Question> excludedQuestions { get; set; }
        public List<Factor> selectedFactors { get; set; }

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

        public List<CustomPersonalAnswer> personalAnswers { get; set; }

        public ConfirmatoryAnalysisControlViewModel(Survey survey)
        {
            this.survey = survey;
            this.originalFactors = new BindingList<Factor>();
            this.originalQuestions = new BindingList<Question>();
            this.excludedQuestions = new BindingList<Question>();
            this.excludedQuestions.ListChanged += (sender, e) =>
            {
                UpdateSelectedFactors();
            };
            foreach (Factor f in survey.factors)
            {
                if (f.evaluationFactor)
                {
                    this.originalFactors.Add(f);
                }
            }
            UpdateSelectedFactors();
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
            this.originalQuestions.Clear();
            if (selectedFactor != null)
            {
                foreach (Question q in selectedFactor.questions)
                {
                    this.originalQuestions.Add(q);
                }
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
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors, this.personalAnswers);
            DataRow dataRow = result.NewRow();

            foreach (Factor factor in this.selectedFactors)
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

        private void UpdateSelectedFactors()
        {
            selectedFactors = new List<Factor>();
            foreach (Factor factor in originalFactors)
            {
                Factor f = new Factor { id = factor.id, title = factor.title, description = factor.description, evaluationFactor = factor.evaluationFactor, questions = new List<Question>() };
                foreach (Question question in factor.questions)
                {
                    if (!excludedQuestions.Contains(question))
                    {
                        f.questions.Add(question);
                    }
                }
                if (f.questions.Count > 0)
                {
                    selectedFactors.Add(f);
                }
            }
        }
    }
}
