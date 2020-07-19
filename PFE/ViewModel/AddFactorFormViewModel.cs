﻿using Newtonsoft.Json;
using PFE.model;
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
    public class AddFactorFormViewModel
    {
        public List<Factor> factors { get; set; }
        public Factor selectedItem { get; set; }
        public String Title { get; set; }
        public Factor Factor { get; set; }
        public String Description { get; set; }
        public List<Question> selectedQuestions { get; set; }

        public AddFactorFormViewModel()
        {
            InitializeFactors();
        }

        private void InitializeFactors()
        {
            try
            {
                if (factors == null)
                    factors = new List<Factor>();
                else
                    factors.Clear();

                factors.Add(new Factor { title = "None"});
                factors.Add(new Factor { title = "Ease of use", description = "Ease of use description" });
                factors.Add(new Factor { title = "Communication", description = "Communication description" });
                factors.Add(new Factor { title = "Adaptabillity", description = "Adaptabillity description" });
                factors.Add(new Factor { title = "Usefullness", description = "Usefullness description" });

            }
            catch (Exception ex)
            {
                factors = new List<Factor>();
            }
        }
    }
}