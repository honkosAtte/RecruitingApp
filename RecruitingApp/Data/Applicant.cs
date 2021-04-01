using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingApp.Data
{
    public class Applicant
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Application { get; set; }
        
        [ForeignKey(nameof(Job))]
        public int JobId { get; set; }
        public Job Job { get; set; }




    }
}
