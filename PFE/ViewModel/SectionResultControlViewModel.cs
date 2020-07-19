using PFE.model;
using PFE.Model;
using PFE.UserContol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class SectionResultControlViewModel
    {
        public Factor factor { get; set; }

        public SectionResultControlViewModel(Factor factor)
        {
            this.factor = factor;
        }
    }
}
