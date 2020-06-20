using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Shared
{
    public static class Data
    {
        public static string sessionId { get; set; }
        public static User actifUser { get; set; }
        public static Project currentProject { get; set; }
        public static string directory { get; set; }
        public static List<Field> fields { get; set; } = new List<Field>();
    }
}
