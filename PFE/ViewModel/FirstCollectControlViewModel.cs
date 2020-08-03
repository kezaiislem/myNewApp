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
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class FirstCollectControlViewModel
    {
        public Survey survey { get; set; }

        public BindingList<Factor> selectedFactors { get; set; }
        public BindingList<Factor> originalFactors { get; set; }
        public List<CustomPersonalAnswer> personalAnswers { get; set; }
        public BartlettStatsResults bartlettStatsResults { get; set; }
        public bool bartlettChecked { get; set; }
        public bool kmoChecked { get; set; }
        public double KMOIndex { get; set; }

        public FirstCollectControlViewModel(Survey survey)
        {
            this.survey = survey;
            this.originalFactors = new BindingList<Factor>();
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
            Exporter.exportCsv(Path.GetTempPath() + "/testcsv.csv", ";", dt);
            if (bartlettChecked)
            {
                bartlettStatsResults = RCalculator.BartlettStats(Path.GetTempPath() + "/testcsv.csv");
            }
            if (kmoChecked)
            {
                KMOIndex = RCalculator.KMOStats(Path.GetTempPath() + "/testcsv.csv");
            }
        }

        public void calculateCorelationMatrix()
        {
            DataTable dt = DataTableManager.prepareEvalTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv(Path.GetTempPath() + "/testcsv.csv", ";", dt);
            RCalculator.showCorelationTable(Path.GetTempPath() + "/testcsv.csv");
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
                    Exporter.exportCsv("C:/Users/ISLEM/Desktop/FF/" + factor.title + ".csv", ";", temp);
                    dataRow[factor.title] = RCalculator.CalculateAlpha("C:/Users/ISLEM/Desktop/FF/" + factor.title + ".csv").ToString();
                }
                else
                {
                    dataRow[factor.title] = "None";
                }
            }
            result.Rows.Add(dataRow);
            return result;
        }
    }
}
