﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class User
    {
		public long id { get; set;}
		public string firstName { get; set;}
		public string lastName { get; set;}
		public string email { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string adress { get; set; }
		//public List<Project> projects { get; set; }
		public string phoneNumber { get; set; }
		public Role role { get; set; }
	}
}
