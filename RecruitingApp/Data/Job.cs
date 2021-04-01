using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingApp.Data
{
    public class Job
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

         
        public virtual IList<Applicant> Applicants { get; set; }
    }
}
