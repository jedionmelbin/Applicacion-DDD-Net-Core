using AutoMapper;
using LearningSchool.Domain;
using LearningSchool.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSchool.Service.Mapp
{
    class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<StudentDTO, Student>();

            CreateMap<CourseDTO, Course>();

            CreateMap<EnrollmentDTO, Enrollment>();
        }

    }
}
