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

        public Field selectedItem;
        public Field SelectedItem
        {
            get { return selectedItem; }
            set
            {
                this.project.model.technology.technologyField = value;
                selectedItem = value;
            }
        }
        public Project project { get; set; }

        public ProjectContextViewModel()
        {
            this.project = Data.currentProject;
            if (project.model.technology == null)
            {
                project.model.technology = new Technology();
            }
            this.fields = InitializeFields();
            InitSelectedItem();
        }

        private List<Field> InitializeFields()
        {
            return new List<Field> { new Field { id = 0, name = "Operational Application" }, 
                                     new Field { id = 1, name = "Strategic Application" }, 
                                     new Field { id = 2, name = "Infrastructure Application" },
                                     new Field { id = 3, name = "Global IS" },
                                     new Field { id = 4, name = "Other" }};
        }

        public void InitSelectedItem()
        {
            foreach (Field field in fields)
            {
                if (Data.currentProject.model.technology.technologyField != null)
                {
                    if (field.id == Data.currentProject.model.technology.technologyField.id)
                    {
                        selectedItem = field;
                    }
                }
            }
        }
    }
}
