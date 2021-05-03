using AutoMapper;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentModelBase>().ReverseMap();
            CreateMap<Student, StudentModelExtended>();
            CreateMap<StudentCreateModel, Student>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.DoB, opt => opt.MapFrom(src => src.DoB))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year));
        }
    }
}
