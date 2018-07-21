using AutoMapper;
using LearningSchool.Domain;
using LearningSchool.Infrastructure;
using LearningSchool.Repository;
using LearningSchool.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                IEnumerable<Student> student = studentRepository.GetAll();
                IEnumerable<StudentDTO> studentDTO = mapper.Map<IEnumerable<Student>, IEnumerable<StudentDTO>>(student);

                return studentDTO.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public StudentDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(StudentDTO entity)
        {
            try
            {
                Student student = mapper.Map<Student>(entity);
                await studentRepository.Insert(student);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task Update(StudentDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
