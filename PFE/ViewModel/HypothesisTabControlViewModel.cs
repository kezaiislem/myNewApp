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
    public class HypothesisTabControlViewModel
    {
        public Hypothesis hypothesis { get; set; }

        public HypothesisTabControlViewModel(Hypothesis hypothesis)
        {
            this.hypothesis = hypothesis;
        }

    }
}
