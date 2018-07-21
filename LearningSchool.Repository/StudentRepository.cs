using LearningSchool.Domain;
using LearningSchool.Infrastructure;
using LearningSchool.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSchool.Repository
{
    public class StudentRepository:GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext applicationContext)
             : base(applicationContext)
        {
        }
    }
}
