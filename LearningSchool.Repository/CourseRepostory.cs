using LearningSchool.Domain;
using LearningSchool.Infrastructure;
using LearningSchool.Infrastructure.Data;
using System;

namespace LearningSchool.Repository
{
    public class CourseRepostory:GenericRepository<Course>,ICourseRepostory
    {
        public CourseRepostory(ApplicationDbContext applicationContext)
              : base(applicationContext)
        {
        }

    }
}
