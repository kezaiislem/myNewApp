using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class SectionControlViewModel
    {
        public Section section { get; set; }

        public SectionControlViewModel(Section section)
        {
            this.section = section;
        }
    }
}
