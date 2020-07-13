using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.CustomObjects
{
    public class MailingRequest
    {
        public String subject { get; set; }
        public String text { get; set; }
        public List<String> destinations { get; set; }
    }
}
