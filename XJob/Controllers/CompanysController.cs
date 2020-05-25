using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XJob.Models;
using System.Data.Entity;
using Newtonsoft.Json;

namespace XJob.Controllers
{
	public class CompanysController : Controller
	{

		private ApplicationDbContext _context;

		public CompanysController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// GET: Companys
		public ActionResult Index()
		{
			var reports = _context.Reports.ToList();
			return View(reports);
		}

	   [AllowAnonymous]
		public ActionResult HomePage()
		{
			return View();
		}

		public ActionResult Details(int id)
		{
			var report = _context.Reports.SingleOrDefault(r => r.Id == id);

			return View(report);
		}

		public ActionResult Analyze()
		{
	
			return View();
		}

		[Route("Companys/Analyze/BarDiagram")]
		public ActionResult BarDiagram()
		{

			return View();
		}

		// Checkbox 
		[HttpPost] 
		public ActionResult reportAnalyz(Report report)
		{		  
			var dbReport = _context.Reports.Where(r => r.Id == report.Id).FirstOrDefault();

			dbReport.IsDone = report.IsDone;
			dbReport.OnGoing = report.OnGoing;
			
			_context.SaveChanges();

			return RedirectToAction("Index", "Companys");
		}

		public ActionResult GetData()
		{
			var data = _context.Reports.Count(); // Alla ärenden 
			var isDone = _context.Reports.Where(r => r.IsDone == true).Count(); //Uppklarade ärenden
			 var onGoing = _context.Reports.Where(r => r.OnGoing == true).Count(); //Pågående ärenden

			Ratio obj = new Ratio();
			obj.RepData = data;
			obj.IsDone = isDone;
			obj.OnGoing = onGoing;
			return Json(obj, JsonRequestBehavior.AllowGet);
		}

		public class Ratio
		{
			public int RepData { get; set; }
			public int IsDone { get; set; }
			public int OnGoing { get; set; }
		}



	}
}