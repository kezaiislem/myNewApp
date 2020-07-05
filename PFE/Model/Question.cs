using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Question
    {
        public int ?id { get; set; }
        public string text { get; set; }
        public int type { get; set; }
        public List<String> choices { get; set; }

    }
}
