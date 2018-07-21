using Autofac;
using LearningSchool.Service;
using System;
using System.Reflection;

namespace LearningSchool.Infrastructure.Ioc
{
    public class ServiceModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentService>().As<IStudentService>();
            builder.RegisterType<CourseService>().As<ICourseService>();
        }
    }
}
