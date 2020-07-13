using PFE.Model;
using PFE.UserContol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ModelInfoViewModel
    {
        public PFE.Model.Model model { get; set; }
        public List<int> aviabePhases { get; set; } = new List<int> { 1, 2, 3 };

        public ModelInfoViewModel(PFE.Model.Model model, MainForm mainForm)
        {

            this.model = model;
            if(this.model.surveys == null)
            {
                this.model.surveys = new List<Survey>();
            }
            else
            {
                foreach (Survey survey in this.model.surveys)
                {
                    switch (survey.phaseNumber)
                    {
                        case 1 :
                            aviabePhases.Remove(1);
                            break;
                        case 2:
                            aviabePhases.Remove(2);
                            break;
                        case 3:
                            aviabePhases.Remove(3);
                            break;
                    }
                }
            }
        }
    }
}
