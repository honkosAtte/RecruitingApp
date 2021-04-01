using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace RecruitingApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Job>().HasData(
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

            builder.Entity<Applicant>().HasData(
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
                    FirstName = "Atte",
                    LastName = "Henkonen",
                    Email = "atte.henkonen@outlook.com",
                    Application = "Haen tähän paikkaan, koska haluan rapata",
                    JobId = 3,
                    Job = null
                });

        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
    }
}
