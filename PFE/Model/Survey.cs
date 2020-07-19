using PFE.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PFE.Model
{
    public class Survey
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int phaseNumber { get; set; }
        public List<Factor> factors  { get; set; }
        public List<Answer> answers { get; set; }
        public Host host { get; set; }
        [XmlIgnore]
        public Model model { get; set; }
    }
}
