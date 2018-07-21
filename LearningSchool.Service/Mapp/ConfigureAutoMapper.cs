using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSchool.Service.Mapp
{
    public class ConfigureAutoMapper
    {
        public void Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new DomainProfile());
                cfg.AddProfile(new ViewModelProfile());
            });

            AutoMapper.Mapper.AssertConfigurationIsValid();
        }
    }
}
