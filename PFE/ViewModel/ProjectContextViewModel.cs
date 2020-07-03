using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ProjectContextViewModel
    {
        public List<Field> fields { get; set; }

        public ComboboxItem selectedItem;
        public ComboboxItem SelectedItem
        {
            get { return selectedItem; } 
            set {
                this.project.model.technology.technologyField = (Field)value.Value;
                selectedItem = value; 
            }
        }
        public List<ComboboxItem> combos { get; set; }
        public Project project { get; set; }

        public ProjectContextViewModel()
        {
            this.project = Data.currentProject;
            if(project.model.technology == null)
            {
                project.model.technology = new Technology();
            }
            Task.Run(async () => await InitializeFields());
            combos = new List<ComboboxItem>();
        }

        private async Task InitializeFields()
        {
            try
            {
                String data = await RestHelper.getDomains();
                if (data != "")
                {
                    fields = JsonConvert.DeserializeObject<List<Field>>(data);
                }
            }
            catch (Exception ex)
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
                if (Data.currentProject.model.technology.technologyField != null)
                {
                    if (field.id == Data.currentProject.model.technology.technologyField.id)
                    {
                        selectedItem = combos.Last<ComboboxItem>();
                    }
                }
            }
        }
    }
}
