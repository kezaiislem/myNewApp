using System;


namespace PFE.Model
{
    public class Session
    {
		public string id { get; set; }
		public DateTime expDate { get; set; }
		public User user { get; set; }
    }
}
