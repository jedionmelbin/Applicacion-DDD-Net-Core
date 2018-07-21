using AutoMapper;
using LearningSchool.Infrastructure;
using LearningSchool.Repository;
using LearningSchool.Transport;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningSchool.Service
{
    public class StudentService : IServiceBase<StudentDTO>, IStudentService
    {
        private IStudentRepository studentRepository;
        private IMapper mapper;
        public StudentService(IStudentRepository studentRepository,
            IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        public IEnumerable<StudentDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(StudentDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(StudentDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
