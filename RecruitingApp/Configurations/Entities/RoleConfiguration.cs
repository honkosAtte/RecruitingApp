using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecruitingApp.Configurations.Entities
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {

                    Name = "Applicant",
                    NormalizedName = "APPLICANT"
                },
                new IdentityRole
                {

                    Name = "Recruiter",
                    NormalizedName = "RECRUITER"
                });
        }
    }
}
