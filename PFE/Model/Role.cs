using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
    public class Role
    {
		public long id { get; set;}
		public string roleName { get; set;}

		public override string ToString()
		{
			return roleName;
		}

		public static List<Role> getRoles()
		{
			return new List<Role> { new Role { id = 2, roleName = "Evaluator" }, new Role { id = 3, roleName = "Decision maker" } };
		}
	}
}
