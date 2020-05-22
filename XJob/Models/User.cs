using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XJob.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Mail { get; set; }
		public string Password { get; set; }
		public int PhoneNumber { get; set; }
	}
}