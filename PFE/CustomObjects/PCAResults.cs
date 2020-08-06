using RDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.CustomObjects
{
    public class PCAResults
    {
        public DataFrame pcaTable { get; set; }
        public DataFrame loadings { get; set; }
    }
}
