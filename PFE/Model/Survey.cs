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
        public int phase { get; set; }
        public Model model { get; set; }
        public List<Question> questions  { get; set; }
        public List<Answer> answers { get; set; }
    }
}
