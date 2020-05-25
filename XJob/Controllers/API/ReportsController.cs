using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XJob.Dtos;
using XJob.Models;

namespace XJob.Controllers.API
{
    public class ReportsController : ApiController
    {
		private ApplicationDbContext _context;

		public ReportsController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}


		[HttpGet]
		public IEnumerable<ReportDto> GetReports()
		{
			return _context.Reports.ToList().Select(Mapper.Map<Report,ReportDto>);
		}

		[HttpGet]
		public IHttpActionResult GetReport(int id)
		{
			var report = _context.Reports.SingleOrDefault(r => r.Id == id);

			if (report == null)
				return NotFound();

			return Ok(Mapper.Map<Report, ReportDto> (report));
		}

		[HttpPost]
		public IHttpActionResult CreateReport(ReportDto reportDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var report = Mapper.Map<ReportDto, Report>(reportDto);
			_context.Reports.Add(report);
			_context.SaveChanges();

			reportDto.Id = report.Id;

			return Created(new Uri(Request.RequestUri + "/" + report.Id), reportDto);
		}

		[HttpPut]
       public void UpdateReport(int id, ReportDto reportDto)
		{
			if (!ModelState.IsValid)
			{
				throw new HttpResponseException(HttpStatusCode.BadRequest);
			}

			var reportInDb = _context.Reports.SingleOrDefault(r => r.Id == id);

			if(reportInDb == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}

			Mapper.Map(reportDto,reportInDb);
		
			_context.SaveChanges();
		}

		[HttpDelete]
		public void DeleteReport(int id)
		{
			var reportInDb = _context.Reports.SingleOrDefault(r => r.Id == id);

			if (reportInDb == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}

			_context.Reports.Remove(reportInDb);
			_context.SaveChanges();
		}
    }
}
