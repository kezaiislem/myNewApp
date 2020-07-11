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
                            hasPhase1 = true;
                            aviabePhases.Remove(1);
                            break;
                        case 2:
                            hasPhase2 = true;
                            aviabePhases.Remove(2);
                            break;
                        case 3:
                            hasPhase3 = true;
                            aviabePhases.Remove(3);
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

                foreach (Survey survey in this.model.surveys)
                {
                    if (survey.phaseNumber == 1)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    this.model.surveys.Add(new Survey { phaseNumber = 1, model = this.model, sections = new List<Section>() });
                }
                add = true;
            } 
            else
            {
                foreach (Survey survey in this.model.surveys)
                {
                    if (survey.phaseNumber == 1)
                    {
                        this.model.surveys.Remove(survey);
                        break;
                    }
                }
            }

            if (this.hasPhase2)
            {
                foreach (Survey survey in this.model.surveys)
                {
                    if (survey.phaseNumber == 2)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    this.model.surveys.Add(new Survey { phaseNumber = 2, model = this.model, sections = new List<Section>() });
                }
                add = true;
            }
            else
            {
                foreach (Survey survey in this.model.surveys)
                {
                    if (survey.phaseNumber == 2)
                    {
                        this.model.surveys.Remove(survey);
                        break;
                    }
                }
            }

            if (this.hasPhase3)
            {
                foreach (Survey survey in this.model.surveys)
                {
                    if (survey.phaseNumber == 3)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    this.model.surveys.Add(new Survey { phaseNumber = 3, model = this.model, sections = new List<Section>() });
                }
                add = true;
            }
            else
            {
                foreach (Survey survey in this.model.surveys)
                {
                    if (survey.phaseNumber == 3)
                    {
                        this.model.surveys.Remove(survey);
                        break;
                    }
                }
            }
            mainForm.UpdatePhaseButtons();
        }
    }
}
