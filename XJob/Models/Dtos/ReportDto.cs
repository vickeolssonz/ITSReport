using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XJob.Dtos
{
	public class ReportDto
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		[StringLength(255)]
		public string Username { get; set; }

		[Required]
		public int PhoneNumber { get; set; }

		public bool IsDone { get; set; }

		public bool OnGoing { get; set; }
		public bool UnHandled { get; set; }
	}
}
