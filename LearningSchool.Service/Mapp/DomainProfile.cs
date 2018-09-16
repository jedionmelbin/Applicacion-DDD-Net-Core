using AutoMapper;
using LearningSchool.Domain;
using LearningSchool.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSchool.Service.Mapp
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Student, StudentDTO>();

            CreateMap<Enrollment, EnrollmentDTO>()
                .ForMember(x => x.listCourse, opt => opt.Ignore())
                .ForMember(x => x.listStudent, opt => opt.Ignore());
        }
    }
}
