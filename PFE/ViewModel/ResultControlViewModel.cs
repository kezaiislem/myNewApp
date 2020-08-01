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
            DataTable dt = DataTableManager.prepareExportTable(this.factors, this.personalAnswers);

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
            DataTable dt = DataTableManager.prepareEvalTable(this.factors, this.personalAnswers);

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
