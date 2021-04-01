using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecruitingApp.Data;

namespace RecruitingApp.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Job> Jobs { get; }
        IGenericRepository<Applicant> Applicants { get; }

        Task Save();
    }
}
