using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Survey
    {
        public int id { get; set; }
        public Phase phase { get; set; }
        public List<Section> sections  { get; set; }
        public List<Answer> answers { get; set; }
    }
}
