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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class FirstCollectControlViewModel
    {
        public Survey survey { get; set; }

        public BindingList<Factor> selectedFactors { get; set; }
        private List<CustomPersonalAnswer> personalAnswers { get; set; }

        public FirstCollectControlViewModel(Survey survey)
        {
            this.survey = survey;
            selectedFactors = new BindingList<Factor>();
            //Task.Run(async () => await getSurveys());
        }

        private async Task getAnswers()
        {
            try
            {
                String data = await RestHelper.getPersonalAnswers(this.survey.id);
                if (data != "")
                {
                    this.personalAnswers = JsonConvert.DeserializeObject<List<CustomPersonalAnswer>>(data);
                    buildExel();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void buildExel()
        {
            DataTable dt = DataTableManager.prepareExportTable(this.selectedFactors.ToList<Factor>(), this.personalAnswers);
            Exporter.exportCsv("%TEMP%/tempfile.csv", ";", dt);
        }
    }
}
