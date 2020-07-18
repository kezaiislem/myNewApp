using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class MainFormViewModel
    {
        public Boolean hasModel { get; set; }
        public String Title { get; set; }
        public Project projet { get; set; }

        public MainFormViewModel()
        {
            this.projet = Data.currentProject;
            if (this.projet.model == null)
                hasModel = false;
            else
                hasModel = true;

            if (this.projet.events == null)
            {
                this.projet.events = new List<model.ProjectEvent>();
            }

            Title = "Dashboard";
        }

        /*private async Task InitializeFields()
        {
            try
            {
                String data = await RestHelper.getDomains();
                if (data != "")
                {
                    fields = JsonConvert.DeserializeObject<List<Field>>(data);
                }
            } catch (Exception ex)
            {
                fields = new List<Field>();
            }
            
        }

        public void initCombos()
        {
            while (fields == null) { }

            foreach (Field field in fields)
            {
                combos.Add(new ComboboxItem { Text = field.name, Value = field });
                if (Data.currentProject.technologyNature != null)
                {
                    if (field.id == Data.currentProject.technologyNature.id)
                    {
                        selectedItem = combos.Last<ComboboxItem>();
                    }
                }
                
            }
        }*/
    }
}
