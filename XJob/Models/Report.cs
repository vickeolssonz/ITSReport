﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XJob.Models
{
	public class Report
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		[StringLength(255)]
		[Display(Name = "Your Emailadress")]
		public string Username { get; set; }

		[Required]
		[Display(Name ="Your Phonenumber")]
		public int PhoneNumber { get; set; }

		// public User User { get; set; }

		public bool IsDone { get; set; }

		public bool OnGoing { get; set; }
	}
}