using Newtonsoft.Json;
using PFE.model;
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
    public class AddFactorFormViewModel
    {
        public List<Factor> factors { get; set; }
        public Factor selectedItem { get; set; }
        public String Title { get; set; }
        public Factor Factor { get; set; }
        public String Description { get; set; }
        public List<Question> selectedQuestions { get; set; }
        public bool mtaDefault { get; set; } = false;
        public bool evaluationFactor { get; set; } = false;

        public AddFactorFormViewModel()
        {
            InitializeFactors();
        }

        private void InitializeFactors()
        {
            try
            {
                if (factors == null)
                    factors = new List<Factor>();
                else
                    factors.Clear();

                factors.Add(new Factor { title = "Ease of use", description = "Ease of use description", evaluationFactor = true });
                factors.Add(new Factor { title = "Cost", description = "Communication description", evaluationFactor = true });
                factors.Add(new Factor { title = "Adaptabillity", description = "Adaptabillity description", evaluationFactor = true });
                factors.Add(new Factor { title = "Usefullness", description = "Usefullness description", evaluationFactor = true });
                factors.Add(new Factor { title = "Ease of use", description = "Ease of use description", evaluationFactor = true });
                factors.Add(new Factor { title = "Convenience", description = "Convenience description", evaluationFactor = true });
                factors.Add(new Factor { title = "Familiarity", description = "Familiarity description", evaluationFactor = true });
                factors.Add(new Factor { title = "Our Stuff", description = "Our Stuff description", evaluationFactor = true });
                factors.Add(new Factor { title = "Compatibility", description = "Compatibility description", evaluationFactor = true });
                factors.Add(new Factor { title = "Contact", description = "Contact description", evaluationFactor = true });
                factors.Add(new Factor { title = "Leisure", description = "Leisure description", evaluationFactor = true });
                factors.Add(new Factor { title = "Expected Usefulness", description = "Expected Usefulness description", evaluationFactor = true });
                factors.Add(new Factor { title = "Ease of Learning", description = "Ease of Learning description", evaluationFactor = true });
                factors.Add(new Factor { title = "Subjective Norm", description = "Subjective Norm description", evaluationFactor = true });
                factors.Add(new Factor { title = "Accessibility", description = "Accessibility description", evaluationFactor = true });
                factors.Add(new Factor { title = "Relative Advantage", description = "Relative Advantage description", evaluationFactor = true });
                factors.Add(new Factor { title = "Integration", description = "Integration description", evaluationFactor = true });
                factors.Add(new Factor { title = "The Ability to Reuse and Share Information", description = "The Ability to Reuse and Share Information description", evaluationFactor = true });
                factors.Add(new Factor { title = "Expected Integration", description = "Expected Integration description", evaluationFactor = true });
                factors.Add(new Factor { title = "Malleable Technologies", description = "Malleable Technologies description", evaluationFactor = true });
                factors.Add(new Factor { title = "Required Conditions", description = "Required Conditions description", evaluationFactor = true });
                factors.Add(new Factor { title = "Technical Involvement", description = "Technical Involvement description", evaluationFactor = true });
                factors.Add(new Factor { title = "Users Participation", description = "Users Participation description", evaluationFactor = true });

                selectedItem = factors.First<Factor>();
            }
            catch (Exception ex)
            {
                factors = new List<Factor>();
            }
        }
    }
}
