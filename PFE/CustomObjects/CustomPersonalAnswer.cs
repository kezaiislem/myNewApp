using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.CustomObjects
{
    class CustomPersonalAnswer
    {
        public List<Answer> answers { get; set; }
        public List<Question> questions { get; set; }
    }
}
