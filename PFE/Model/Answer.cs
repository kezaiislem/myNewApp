using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Answer
    {
        public int id { get; set; }
        public int value { get; set; }
        public Survey survey { get; set; }
        public Question question { get; set; }
    }
}
