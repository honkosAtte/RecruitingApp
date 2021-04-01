using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RecruitingApp.Data;
using RecruitingApp.IRepository;

namespace RecruitingApp.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Job> _jobs;
        private IGenericRepository<Applicant> _applicants;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Job> Jobs => _jobs ??= new GenericRepository<Job>(_context);

        public IGenericRepository<Applicant> Applicants => _applicants ??= new GenericRepository<Applicant>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }


        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
