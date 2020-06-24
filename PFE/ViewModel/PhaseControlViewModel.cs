using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class PhaseControlViewModel
    {
        public int phaseNumber { get; set; }

        public PhaseControlViewModel(int phaseNumber)
        {
            this.phaseNumber = phaseNumber;
        }
    }
}
