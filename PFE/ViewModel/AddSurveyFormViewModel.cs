using Newtonsoft.Json;
using PFE.Constants;
using PFE.CustomObjects;
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
    public class AddSurveyFormViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int SelectedPhase { get; set; }
        public List<int> phases { get; set; }

        public AddSurveyFormViewModel(List<int> phases)
        {
            this.phases = phases;
            this.SelectedPhase = phases.First();
        }
    }
}
