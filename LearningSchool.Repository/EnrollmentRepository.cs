using LearningSchool.Domain;
using LearningSchool.Infrastructure;
using LearningSchool.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSchool.Repository
{
    public class EnrollmentRepository : GenericRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(ApplicationDbContext applicationContext)
              : base(applicationContext)
        {
        }


    }
}
