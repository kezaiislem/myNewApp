using Atalasoft.Imaging.ImageProcessing.Filters;
using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using PFE.UserContol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class FirstCollectControlViewModel
    {
        public Survey survey { get; set; }
        public BindingList<Factor> selectedFactors { get; set; }
        public BindingList<Factor> originalFactors { get; set; }
        public BindingList<Factor> rmvFactors { get; set; }
        public BindingList<Question> questions { get; set; }
        public BindingList<Question> rmvQuestions { get; set; }

        public Factor selectedRmvFactor;

        public Factor SelectedRmvFactor
        {
            get => selectedRmvFactor;
            set
            {
                selectedRmvFactor = value;
                UpdateQuestions();
            }
        }
        public List<CustomPersonalAnswer> personalAnswers { get; set; }
        public SphericityTestResults sphericityTestResults { get; set; }
        public SphericityTestResults newSphericityTestResults { get; set; }
        public bool sphericityTestChecked { get; set; }
        public bool cutomFactorsChecked { get; set; }
        public int numberOfFactors { get; set; }

        public string factorsText;
        public string FactorsText
        {
            get => factorsText;
            set
            {
                numberOfFactors = Int16.Parse(value);
                factorsText = value;
            }
        }

        public FirstCollectControlViewModel(Survey survey)
        {
            this.survey = survey;
            this.originalFactors = new BindingList<Factor>();
            this.rmvFactors = new BindingList<Factor>();
            this.questions = new BindingList<Question>();
            this.rmvQuestions = new BindingList<Question>();
            foreach (Factor f in survey.factors)
            {
                if (f.evaluationFactor)
                {
                    this.originalFactors.Add(f);
                }
            }
            selectedFactors = new BindingList<Factor>();
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

        public void calculateFirstResults()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/factorisation-test.csv", ";", dt);
            if (sphericityTestChecked)
            {
                this.sphericityTestResults = RCalculator.SphericityTest(Path.GetTempPath() + "/factorisation-test.csv");
            }
        }

        public string validateCorelationMatrix()
        {
            if (selectedFactors.Count < 2)
            {
                return "You must select at least two factors";
            }
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

        public void calculateCorelationMatrix()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/corelation-tmp.csv", ";", dt);
            RCalculator.showCorelationTable(Path.GetTempPath() + "/corelation-tmp.csv");
        }

        public string validateChrobach()
        {
            if (selectedFactors.Count < 1)
            {
                return "Tou must at least select one factor";
            }
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
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
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

        public PCAResults ACP()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/pca-tmp.csv", ";", dt);
            PCAResults results;
            if (cutomFactorsChecked)
            {
                if (numberOfFactors <= getNumberOfQuestions())
                {
                    results = RCalculator.PCA(Path.GetTempPath() + "/pca-tmp.csv", numberOfFactors);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                results = RCalculator.PCA(Path.GetTempPath() + "/pca-tmp.csv", selectedFactors.Count);
            }
            prepareACPData();
            return results;
        }

        public void Parallel()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/parallel-tmp.csv", ";", dt);
            RCalculator.Parallel(Path.GetTempPath() + "/parallel-tmp.csv");
        }

        private int getNumberOfQuestions()
        {
            int i = 0;
            foreach(Factor f in selectedFactors)
            {
                i += f.questions.Count;
            }
            return i;
        }

        public void PlotPCA()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/pca-plot-tmp.csv", ";", dt);
            RCalculator.plotPCALoadings(Path.GetTempPath() + "/pca-plot-tmp.csv");
        }
        
        public void PlotComponenets()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/componenet-plot-tmp.csv", ";", dt);
            RCalculator.plotPrincipalCompnnents(Path.GetTempPath() + "/componenet-plot-tmp.csv");
        }

        public void prepareACPData()
        {
            this.rmvFactors.Clear();
            this.rmvQuestions.Clear();
            this.questions.Clear();
            foreach (Factor factor in this.selectedFactors)
            {
                Factor f = new Factor { id = factor.id, title = factor.title, questions = new List<Question>() };
                int i = 1;
                foreach (Question question in factor.questions)
                {
                    Question q = new Question { text = f.title + "_" + i };
                    f.questions.Add(q);
                    i++;
                }
                rmvFactors.Add(f);
            }
            this.selectedRmvFactor = rmvFactors.First<Factor>();
            UpdateQuestions();
        }

        private void UpdateQuestions()
        {
            this.questions.Clear();
            if (selectedRmvFactor != null)
            {
                foreach (Question q in selectedRmvFactor.questions)
                {
                    this.questions.Add(q);
                }
            }
        }

        public string calculateNewStats()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            foreach(Question q in this.rmvQuestions)
            {
                dt.Columns.Remove(q.text);
            }
            if (dt.Columns.Count < 2)
            {
                return "Number of questions must be 2 or higher";
            }
            else
            {
                Exporter.exportCsv(Path.GetTempPath() + "/new-results-tmp.csv", ";", dt);
                this.newSphericityTestResults = RCalculator.SphericityTest(Path.GetTempPath() + "/new-results-tmp.csv");
                return null;
            }
        }

        public void saveExel(string path)
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            foreach (Question q in this.rmvQuestions)
            {
                dt.Columns.Remove(q.text);
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
