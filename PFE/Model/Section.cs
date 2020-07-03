using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Section
    {
        public int ?id { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public List<Question> questions { get; set; }
        public Factor factor { get; set; }
    }
}
