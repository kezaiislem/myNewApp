﻿using Newtonsoft.Json;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    class MainFormViewModel
    {
        public List<Field> fields { get; set; }
        public ComboboxItem selectedItem { get; set; }
        public List<ComboboxItem> combos { get; set; }

        public MainFormViewModel()
        {
            Task.Run(async () => await InitializeFields());
            combos = new List<ComboboxItem>();
        }

        private async Task InitializeFields()
        {
            try
            {
                String data = await RestHelper.getDomains();
                if (data != "")
                {
                    fields = JsonConvert.DeserializeObject<List<Field>>(data);
                }
            } catch (Exception ex)
            {
                fields = new List<Field>();
            }
            
        }

        public void initCombos()
        {
            while (fields == null) { }

            foreach (Field field in fields)
            {
                combos.Add(new ComboboxItem { Text = field.name, Value = field });
                if (Data.currentProject.technologyNature != null)
                {
                    if (field.id == Data.currentProject.technologyNature.id)
                    {
                        selectedItem = combos.Last<ComboboxItem>();
                    }
                }
                
            }
        }
    }
}
