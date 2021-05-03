using AutoMapper;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.StudentClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Profiles
{
    public class StudentClassProfile : Profile
    {
        public StudentClassProfile()
        {
            CreateMap<StudentClass, StudentClassModel>().ReverseMap();
            CreateMap<StudentClassCreateModel, StudentClass>()
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.Class, opt => opt.Ignore())
                .ForMember(dest => dest.Grade, opt => opt.Ignore());
            CreateMap<StudentClassUpdateModel, StudentClass>()
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.Class, opt => opt.Ignore())
                .ForMember(dest => dest.Grade, opt => opt.Ignore());

        }
    }
}
