using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class AddSectionFormViewModel
    {
        public List<Factor> factors { get; set; }

        public ComboboxItem selectedItem;
        public ComboboxItem SelectedItem
        {
            get { return selectedItem; }
            set {
                Factor = (Factor)value.Value;
                selectedItem = value; 
            }
        }
        public List<ComboboxItem> combos { get; set; }
        public String Title { get; set; }
        public Factor Factor { get; set; }
        public String Description { get; set; }

        public AddSectionFormViewModel()
        {
            Task.Run(async () => await InitializeFactors());
            combos = new List<ComboboxItem>();
            initCombos();
        }

        private async Task InitializeFactors()
        {
            try
            {
                String data = await RestHelper.getFactors();
                if (data != "")
                {
                    factors = JsonConvert.DeserializeObject<List<Factor>>(data);
                }
            }
            catch (Exception ex)
            {
                factors = new List<Factor>();
            }

        }

        public void initCombos()
        {
            while (factors == null) { }

            foreach (Factor factor in factors)
            {
                combos.Add(new ComboboxItem { Text = factor.name, Value = factor });
                /*if (Data.currentProject.technologyNature != null)
                {
                    if (factor.id == Data.currentProject.technologyNature.id)
                    {
                        selectedItem = combos.Last<ComboboxItem>();
                    }
                }*/
            }
        }
    }
}
