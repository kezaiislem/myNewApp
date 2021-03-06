﻿using PFE.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public string companyName { get; set; }
        public string companyField { get; set; }
        public string companyAdress { get; set; }
        public string phoneNumber { get; set; }
        public List<String> objectives { get; set; }
        public List<ProjectEvent> events { get; set; }
        public Model model { get; set; }
        public User user { get; set; }
    }
}