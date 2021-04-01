using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitingApp.Data;

namespace RecruitingApp.Configurations.Entities
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(
                new Job
                {
                    Id = 1,
                    Name = "Ohjelmistosuunnittelija",
                    Description = ".Net, SQL, Entity Framework"
                },
                new Job
                {
                    Id = 2,
                    Name = "Taitelija",
                    Description = "Pensselit, ja vesivärit"
                },
                new Job
                {
                    Id = 3,
                    Name = "Rappari",
                    Description = "Haetaan rakennusalan ammattilaista"
                });
        }
    }
}
