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
    public class ACPFormViewModel
    {
        public int factorCount { get; set; }
        public int factorNumber { get; set; }
        
        public string factorNumberText;
        public string FactorNumberText { 
            get => factorNumberText;
            set
            {
                factorNumber = Int16.Parse(value);
                factorNumberText = value;
            }
        }

        public ACPFormViewModel(int factorCount)
        {
            this.factorCount = factorCount;
        }
    }
}
