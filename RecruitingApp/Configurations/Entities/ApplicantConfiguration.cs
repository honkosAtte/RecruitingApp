using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitingApp.Data;

namespace RecruitingApp.Configurations.Entities
{
    public class ApplicantConfiguration : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {
            builder.HasData(
                new Applicant
                {
                    Id = 1,
                    FirstName = "Atte",
                    LastName = "Henkonen",
                    Email = "atte.henkonen@outlook.com",
                    Application = "Haen tähän paikkaan, koska haen tähän paikkaan",
                    JobId = 1,
                    Job = null
                },
                new Applicant
                {
                    Id = 2,
                    FirstName = "Markku",
                    LastName = "Miettinen",
                    Email = "markku.miettinen@outlook.com",
                    Application = "Haen tähän paikkaan, koska tarvitsen rahaa",
                    JobId = 2,
                    Job = null
                },
                new Applicant
                {
                    Id = 3,
                    FirstName = "Kalle",
                    LastName = "Kukkonen",
                    Email = "kalle.kullonen@gmail.com",
                    Application = "Haen tähän paikkaan, koska haluan rapata",
                    JobId = 3,
                    Job = null
                });
        }
    }
}
