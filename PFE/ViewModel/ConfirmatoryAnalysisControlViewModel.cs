using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
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
        public CFAResults cFAResults { get; set; }
        public List<ConvergentValidityTab> convergentValidityTabs { get; set; }
        public string cfi { get; set; }
        public string tli { get; set; }
        public string rmsea { get; set; }
        public string srmr { get; set; }
        public string chisqDf { get; set; }
        public DataTable chrobachTable { get; set; }
        public DataTable discriminantValisityTable { get; set; }

        public ConfirmatoryAnalysisControlViewModel(Survey survey)
        {
            this.survey = survey;
            this.originalFactors = new BindingList<Factor>();
            this.originalQuestions = new BindingList<Question>();
            this.excludedQuestions = new BindingList<Question>();
            convergentValidityTabs = new List<ConvergentValidityTab>();
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

        public string runCFA()
        {
            string valid = this.validateCFATest();
            if (valid != null)
            {
                return valid;
            }
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/cfa.csv", ";", dt);
            cFAResults = RCalculator.CFA(Path.GetTempPath() + "/cfa.csv", this.buildModelString());
            constuctValidity();
            convergentValidity();
            return null;
        }

        public void convergentValidity()
        {
            convergentValidityTabs = new List<ConvergentValidityTab>();
            foreach (Factor factor in selectedFactors)
            {
                ConvergentValidityTab convergentValidityTab = new ConvergentValidityTab();
                double lambdaSum = 0;
                double lambda2Sum = 0;
                double one_lambda2Sum = 0;
                for (int i = 0; i < this.getQuestionsCount(); i++)
                {
                    if (cFAResults.loadings["lhs"][i].ToString().Equals(factor.title.Replace(" ", "_")))
                    {
                        double val = Math.Abs(Double.Parse(cFAResults.loadings["std.all"][i].ToString()));
                        lambdaSum += val;
                        lambda2Sum += Math.Pow(val, 2);
                        one_lambda2Sum += 1 - Math.Pow(val, 2);
                    }
                }
                convergentValidityTab.factor = factor.title;
                convergentValidityTab.AVE = Math.Round(lambda2Sum / factor.questions.Count, 3);
                convergentValidityTab.CR = Math.Round(Math.Pow(lambdaSum, 2) / (Math.Pow(lambdaSum, 2) + one_lambda2Sum), 3);
                convergentValidityTabs.Add(convergentValidityTab);
            }
        }

        public void constuctValidity()
        {
            rmsea = "" + Math.Round(Double.Parse(cFAResults.indexes["rmsea"][0].ToString()), 3);
            srmr = "" + Math.Round(Double.Parse(cFAResults.indexes["srmr"][0].ToString()), 3);
            cfi = "" + Math.Round(Double.Parse(cFAResults.indexes["cfi"][0].ToString()), 3);
            tli = "" + Math.Round(Double.Parse(cFAResults.indexes["tli"][0].ToString()), 3);
            double chisq = Double.Parse(cFAResults.indexes["chisq"][0].ToString());
            double df = Double.Parse(cFAResults.indexes["df"][0].ToString());
            chisqDf = "" + Math.Round(chisq / df, 3);
        }

        public String calculateChrobachTable()
        {
            string valid = validateFiabilityTest();
            if (valid != null)
            {
                return valid;
            }
            DataTable temp;
            DataTable result = new DataTable();
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors, this.personalAnswers);
            DataRow dataRow = result.NewRow();

            foreach (Factor factor in this.selectedFactors)
            {
                result.Columns.Add(factor.title.Replace(" ", "_"));
                if (factor.questions.Count > 1)
                {
                    temp = dt.Copy();
                    foreach (DataColumn column in dt.Columns)
                    {
                        if (!column.ColumnName.StartsWith(factor.title.Replace(" ", "_")))
                        {
                            temp.Columns.Remove(column.ColumnName);
                        }
                    }
                    Exporter.exportCsv(Path.GetTempPath() + "/chronbach-tmp.csv", ";", temp);
                    dataRow[factor.title.Replace(" ", "_")] = RCalculator.CalculateAlpha(Path.GetTempPath() + "/chronbach-tmp.csv").ToString();
                }
                else
                {
                    dataRow[factor.title.Replace(" ", "_")] = 1;
                }
            }
            result.Rows.Add(dataRow);
            this.chrobachTable = result;
            return null;
        }

        private string validateFiabilityTest()
        {
            if (personalAnswers == null)
            {
                this.reloadAnswers();
                return "An error has been occured please check your connection and restart again.";
            }
            if (selectedFactors.Count < 1)
            {
                return "Tou must at least select one factor.";
            }
            if (personalAnswers.Count <= this.getQuestionsCount())
            {
                return "The number of answers must be higher than the number of questions.";
            }
            return null;
        }

        private string validateCFATest()
        {
            if (personalAnswers == null)
            {
                this.reloadAnswers();
                return "An error has been occured please check your connection and restart again.";
            }
            if (selectedFactors.Count < 1)
            {
                return "Tou must at least select one factor.";
            }
            if (personalAnswers.Count <= this.getQuestionsCount())
            {
                return "The number of answers must be higher than the number of questions.";
            }
            foreach (Factor f in selectedFactors)
            {
                if (f.questions.Count < 2)
                {
                    return "Each Factor must have at least 2 questions.";
                }
            }
            return null;
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

        private int getQuestionsCount()
        {
            int res = 0;
            foreach (Factor f in selectedFactors)
            {
                res += f.questions.Count;
            }
            return res;
        }

        private string buildModelString()
        {
            String res = "";
            foreach (Factor f in selectedFactors)
            {
                int index = 1;
                res += f.title.Replace(" ", "_") + "=~";
                foreach (Question q in f.questions)
                {
                    if (index == 1)
                    {
                        res += f.title.Replace(" ", "_") + "_" + index;
                    }
                    else
                    {
                        res += "+" + f.title.Replace(" ", "_") + "_" + index;
                    }
                    index++;
                }
                res += "\n";
            }
            return res;
        }

        public string createCorelationsTable()
        {
            try
            {
                int rowsNumber = selectedFactors.Count * (selectedFactors.Count - 1) / 2;
                int rowIndex = cFAResults.loadings.RowCount - rowsNumber;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Factors");
                foreach (Factor f in selectedFactors)
                {
                    dataTable.Columns.Add(f.title.Replace(" ", "_"));
                }

                int n = selectedFactors.Count - 1;

                foreach (Factor f in selectedFactors)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Factors"] = f.title.Replace(" ", "_");

                    foreach (ConvergentValidityTab tab in convergentValidityTabs)
                    {
                        if (f.title.Equals(tab.factor))
                        {
                            dataRow[f.title.Replace(" ", "_")] = Math.Sqrt(tab.AVE);
                            break;
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        dataRow[cFAResults.loadings["rhs"][rowIndex].ToString()] = cFAResults.loadings["std.all"][rowIndex];
                        rowIndex++;
                    }
                    dataTable.Rows.Add(dataRow);
                    n--;
                }
                this.discriminantValisityTable = dataTable;
            } 
            catch (Exception e)
            {
                return "Unexpected Error please try again";
            }
            return null;
        }

        public string openDiscriminantValidityTable()
        {
            try
            {
                Exporter.exportCsv(Path.GetTempPath() + "/cfa.csv", ";", discriminantValisityTable);
                System.Diagnostics.Process.Start(Path.GetTempPath() + "/cfa.csv");
            }
            catch (Exception e)
            {
                return "File is already opened please close it first";
            }
            return null;
        }
    }
}
