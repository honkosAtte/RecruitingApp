using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingApp.Models
{
    public class CreateApplicantDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Name is too long")]
        public string FirstName { get; set; }

        [Required] 
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Application { get; set; }
        
        [Required]
        public int JobId { get; set; }


    }


    public class ApplicantDTO : CreateApplicantDTO
    {
        public int Id { get; set; }
        public JobDTO Job { get; set; }

    }
}
    
