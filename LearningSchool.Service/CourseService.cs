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
    public class CourseService : IServiceBase<CourseDTO>, ICourseService
    {
        private ICourseRepostory courseRepostory;
        private IMapper mapper;
        public CourseService(ICourseRepostory courseRepostory,
            IMapper mapper)
        {
            this.courseRepostory = courseRepostory;
            this.mapper = mapper;
        }
        public IEnumerable<CourseDTO> GetAll()
        {
            try
            {
                IEnumerable<Course> student = courseRepostory.GetAll();
                IEnumerable<CourseDTO> studentDTO = mapper.Map<IEnumerable<Course>, IEnumerable<CourseDTO>>(student);

                return studentDTO.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public CourseDTO GetById(int id)
        {
            Course course = courseRepostory.GetById(id);
            CourseDTO courseDTO = mapper.Map<CourseDTO>(course);
            return courseDTO;
        }

        public async Task Insert(CourseDTO entity)
        {
            try
            {
                Course course = mapper.Map<Course>(entity);
                await courseRepostory.Insert(course);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Update(CourseDTO entity)
        {
            try
            {
                Course course = mapper.Map<Course>(entity);
                await courseRepostory.Update(course);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
