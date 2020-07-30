using Newtonsoft.Json;
using PFE.CustomObjects;
using PFE.Model;
using PFE.Shared;
using PFE.UserContol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class ValidationControlViewModel
    {
        public Model.Model model { get; set; }

        public ValidationControlViewModel(Model.Model model)
        {
            this.model = model;
        }
    }
}
