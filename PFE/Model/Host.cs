using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Host
    {
		public String id { get; set;}
		public DateTime? expDate { get; set;}
		public Survey survey { get; set;}
	}
}
