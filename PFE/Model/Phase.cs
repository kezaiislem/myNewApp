using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Phase
    {
        public int id { get; set; }
        public int phaseNumber { get; set; }
        public Survey survey { get; set; }
    }
}
