using Autofac;
using LearningSchool.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSchool.Infrastructure.Ioc
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();
        }
    }
}
