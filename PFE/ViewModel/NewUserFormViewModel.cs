using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using Newtonsoft.Json;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class NewUserFormViewModel
    {
        public Role selectedItem { get; set; }
        public Role SelectedItem {
            get => selectedItem;
            set
            {
                user.role = value;
                selectedItem = value;
            }
        }
        public List<Role> roles { get; set; }

        public User user { get; set; }

        public NewUserFormViewModel()
        {
            roles = Role.getRoles();
            user = new User();
        }
    }
}
