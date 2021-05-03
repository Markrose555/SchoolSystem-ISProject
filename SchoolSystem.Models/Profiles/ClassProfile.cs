using AutoMapper;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Profiles
{
    public class ClassProfile : Profile
    {
        public ClassProfile()
        {
            CreateMap<Class, ClassModelBase>().ReverseMap();
            CreateMap<Class, ClassModelExtended>();
            CreateMap<ClassCreateModel, Class>();
            CreateMap<ClassUpdateModel, Class>();
        }
    }
}
