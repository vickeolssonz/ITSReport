using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XJob.Models;

namespace XJob.ViewModel
{
	public class ReportsFormViewModel
	{
		public Report Report { get; set; }
		public Company Company{ get; set; }
		public IEnumerable<Company>  Companies { get; set; }


	}
}