using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
        public string technologyName { get; set; }
        public string organization { get; set; }
        public Domain domain { get; set; }
        public User user { get; set; }
    }
}