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
        public Section section { get; set; }

        public SectionResultControlViewModel(Section section)
        {
            this.section = section;
        }
    }
}
