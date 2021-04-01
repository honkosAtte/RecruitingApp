using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RecruitingApp.Data;
using RecruitingApp.Models;

namespace RecruitingApp.Configurations
{
    public class AutoMapperInitializer: Profile
    {
        public AutoMapperInitializer()
        {
            CreateMap<Applicant, ApplicantDTO>().ReverseMap();
            CreateMap<Applicant, CreateApplicantDTO>().ReverseMap();
            CreateMap<Job, JobDTO>().ReverseMap();
            CreateMap<Job, CreateJobDTO>().ReverseMap();

        }
    }
}
