using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XJob.Models
{
	public class Company
	{
		public int Id { get; set; }
		[Display(Name = "Company name")]
		public string Name { get; set; }
	}
}