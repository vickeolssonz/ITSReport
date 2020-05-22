using System;
using System.Collections.Generic;
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

		// GET: Users
		public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Create( Report report)
		{
			_context.Reports.Add(report);	
			_context.SaveChanges();
			return RedirectToAction("index", "Users");
		}
	
	}
}
