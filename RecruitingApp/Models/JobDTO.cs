using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingApp.Models
{
    public class CreateJobDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

    }

    public class JobDTO : CreateJobDTO
    {
        public int Id { get; set; }

        public IList<ApplicantDTO> Applicants { get; set; }


    }
}
