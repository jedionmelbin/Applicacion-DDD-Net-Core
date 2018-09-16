using AutoMapper;
using LearningSchool.Domain;
using LearningSchool.Infrastructure;
using LearningSchool.Repository;
using LearningSchool.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSchool.Service
{
    public class EnrollmentService : IServiceBase<EnrollmentDTO>, IEnrollmentService
    {
        private IEnrollmentRepository enrollmentRepository;
        private IMapper mapper;
        public EnrollmentService(IEnrollmentRepository enrollmentRepository,
            IMapper mapper)
        {
            this.enrollmentRepository = enrollmentRepository;
            this.mapper = mapper;
        }

        public IEnumerable<EnrollmentDTO> GetAll()
        {
            try
            {
                IEnumerable<Enrollment> enrollment = enrollmentRepository.GetAll();
                IEnumerable<EnrollmentDTO> enrollmentDTOs = mapper.Map<IEnumerable<Enrollment>, IEnumerable<EnrollmentDTO>>(enrollment);

                return enrollmentDTOs.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EnrollmentDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(EnrollmentDTO entity)
        {
            try
            {
                Enrollment enrollment = mapper.Map<Enrollment>(entity);
                await enrollmentRepository.Insert(enrollment);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<EnrollmentDTO> ListEnrollment()
        {
            try
            {
                IEnumerable<Enrollment> enrollment = enrollmentRepository.ListEnrollment();
                IEnumerable<EnrollmentDTO> enrollmentDTOs = mapper.Map<IEnumerable<Enrollment>, IEnumerable<EnrollmentDTO>>(enrollment);

                return enrollmentDTOs.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(EnrollmentDTO entity)
        {
            try
            {
                Enrollment enrollment = mapper.Map<Enrollment>(entity);
                await enrollmentRepository.Update(enrollment);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
