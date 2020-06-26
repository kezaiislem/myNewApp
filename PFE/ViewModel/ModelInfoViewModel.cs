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
        public MainForm mainForm { get; set; }
        public Boolean hasPhase1 { get; set; } = false;
        public Boolean hasPhase2 { get; set; } = false;
        public Boolean hasPhase3 { get; set; } = false;

        public ModelInfoViewModel(PFE.Model.Model model, MainForm mainForm)
        {
            this.model = model;
            if(this.model.phases == null)
            {
                this.model.phases = new List<Phase>();
            }
            else
            {
                foreach (Phase phase in this.model.phases)
                {
                    switch (phase.phaseNumber)
                    {
                        case 1 :
                            hasPhase1 = true;
                            break;
                        case 2:
                            hasPhase2 = true;
                            break;
                        case 3:
                            hasPhase3 = true;
                            break;
                    }
                }
            }
            this.mainForm = mainForm;
        }

        public void updatePhases()
        {
            Boolean add = true; ;
            if (this.hasPhase1)
            {

                foreach (Phase phase in this.model.phases)
                {
                    if (phase.phaseNumber == 1)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    this.model.phases.Add(new Phase { phaseNumber = 1 });
                }
                add = true;
            } 
            else
            {
                foreach (Phase phase in this.model.phases)
                {
                    if (phase.phaseNumber == 1)
                    {
                        this.model.phases.Remove(phase);
                        break;
                    }
                }
            }

            if (this.hasPhase2)
            {
                foreach (Phase phase in this.model.phases)
                {
                    if (phase.phaseNumber == 2)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    this.model.phases.Add(new Phase { phaseNumber = 2 });
                }
                add = true;
            }
            else
            {
                foreach (Phase phase in this.model.phases)
                {
                    if (phase.phaseNumber == 2)
                    {
                        this.model.phases.Remove(phase);
                        break;
                    }
                }
            }

            if (this.hasPhase3)
            {
                foreach (Phase phase in this.model.phases)
                {
                    if (phase.phaseNumber == 3)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    this.model.phases.Add(new Phase { phaseNumber = 3 });
                }
                add = true;
            }
            else
            {
                foreach (Phase phase in this.model.phases)
                {
                    if (phase.phaseNumber == 3)
                    {
                        this.model.phases.Remove(phase);
                        break;
                    }
                }
            }
            mainForm.UpdatePhaseButtons();
        }
    }
}
