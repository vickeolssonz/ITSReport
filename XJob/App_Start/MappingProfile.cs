using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XJob.Dtos;
using XJob.Models;

namespace XJob.App_Start
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			Mapper.CreateMap<Report, ReportDto>();
			Mapper.CreateMap<ReportDto, Report >();
		}
	}
}