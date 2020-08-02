using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using PFE.UserContol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class HypothesisControlViewModel
    {
        public List<Hypothesis> hypotheses { get; set; }
        public List<Factor> factors { get; set; }

        public HypothesisControlViewModel(List<Hypothesis> hypotheses, List<Factor> factors)
        {
            this.hypotheses = hypotheses;
            this.factors = factors;
        }

    }
}
