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
        public SphericityTestResults sphericityTestResults { get; set; }
        public SphericityTestResults newSphericityTestResults { get; set; }
        public int numberOfFactors { get; set; }
        public DataTable chronbachTable { get; set; }

        public FirstCollectControlViewModel(Survey survey)
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

        private SphericityTestResults calculateSpherity()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/spherity-test.csv", ";", dt);
            return RCalculator.SphericityTest(Path.GetTempPath() + "/spherity-test.csv");
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
            if (personalAnswers.Count <= this.getNumberOfQuestions())
            {
                return "The number of answers must be higher than the number of questions.";
            }
            return null;
        }

        public string fiabilityTest()
        {
            string validate = validateFiabilityTest();
            if (validate != null)
            {
                return validate;
            }
            this.chronbachTable = calculateCronbachTable();
            this.sphericityTestResults = calculateSpherity();
            return null;
        }

        private DataTable calculateCronbachTable()
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

        public PCAResults ACP(int customFactorsCount)
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/pca-tmp.csv", ";", dt);
            PCAResults results;
            results = RCalculator.PCA(Path.GetTempPath() + "/pca-tmp.csv", customFactorsCount);
            return results;
        }

        public void Parallel(object o, PropertyChangedEventArgs e)
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/parallel-tmp.csv", ";", dt);
            RCalculator.Parallel(Path.GetTempPath() + "/parallel-tmp.csv");
        }

        public int getNumberOfQuestions()
        {
            int i = 0;
            foreach (Factor f in selectedFactors)
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

        /*public void prepareACPData()
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
        }*/

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

        /*public string calculateNewStats()
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
        }*/

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
