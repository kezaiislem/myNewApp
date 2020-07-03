using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Model
    {
        public int id { get; set; }
        public String evaluationContext { get; set; }
        public Technology technology { get; set; }
        [JsonIgnore]
        public List<Survey> surveys { get; set; }
    }
}
