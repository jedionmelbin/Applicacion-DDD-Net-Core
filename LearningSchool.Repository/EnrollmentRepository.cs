using LearningSchool.Domain;
using LearningSchool.Infrastructure;
using LearningSchool.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSchool.Repository
{
    public class EnrollmentRepository : GenericRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(ApplicationDbContext applicationContext)
              : base(applicationContext)
        {
        }

        public IEnumerable<Enrollment> ListEnrollment()
        {
            var query = _applicationDbContext.Enrollment
                .Include(a => a.Course)
                .Include(x => x.Student)
                .ToList();

            return query;
        }
    }
}
