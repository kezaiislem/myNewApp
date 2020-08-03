using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.model
{
    public class Factor
    {
        public int? id { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public List<Question> questions { get; set; }
        public bool evaluationFactor { get; set; }

        public override string ToString()
        {
            return title;
        }
    }
}
