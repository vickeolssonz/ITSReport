using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XJob.Models;
using XJob.ViewModel;

namespace XJob.Controllers
{
	public class UsersController : Controller
	{

		private ApplicationDbContext _context;

		public UsersController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		public ActionResult New()
		{
			var companies = _context.Company.ToList();

			var viewModel = new ReportsFormViewModel()
			{
				Companies = companies
			};
		
			return View(viewModel);
		}

		[AllowAnonymous]
		public ActionResult ShowUsers()
		{
			var user = User.Identity.Name;
			return View((object)user);
		}

		[AllowAnonymous]
		public ActionResult Index()
		{
			var users = _context.Users.ToList();
			return View(users);
		}

		[HttpPost]
		public ActionResult Create( Report report)
		{
			_context.Reports.Add(report);	
			_context.SaveChanges();
			return RedirectToAction("index", "Users");
		}

		public ActionResult Registrated()
		{
			var ListOfReports =_context.Reports.ToList();

			return View(ListOfReports);
		}

		public ActionResult Delete(Report report)
		{
			foreach (var rep in _context.Reports)
			{
				if(report.Id == rep.Id)
				{
					_context.Reports.Remove(rep);
				}
			}
			_context.SaveChanges();
			return RedirectToAction("Registrated","Users");
		} 
	
	}
}
