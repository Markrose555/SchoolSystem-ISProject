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
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.StudentSubjects, opt => opt.Ignore())
                .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.StudentName))
                .ForMember(dest => dest.StudentSurname, opt => opt.MapFrom(src => src.StudentSurname))
                .ForMember(dest => dest.StudentDoB, opt => opt.MapFrom(src => src.StudentDoB))
                .ForMember(dest => dest.StudentYear, opt => opt.MapFrom(src => src.StudentYear));
        }
    }
}
