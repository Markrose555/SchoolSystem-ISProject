using AutoMapper;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.StudentSubject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Profiles
{
    public class StudentSubjectProfile : Profile
    {
        public StudentSubjectProfile()
        {
            CreateMap<StudentSubject, StudentSubjectModel>().ReverseMap();
            CreateMap<StudentSubjectCreateModel, StudentSubject>();
            CreateMap<StudentSubjectCreateModel, Student>();
                
            CreateMap<StudentSubjectCreateModel, StudentSubject>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src));

            CreateMap<StudentSubjectUpdateModel, Student>();

            CreateMap<StudentSubjectUpdateModel, StudentSubject>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src));

            /*CreateMap<StudentSubjectCreateModel, StudentSubject>()
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.Subject, opt => opt.Ignore())
                .ForMember(dest => dest.Grade, opt => opt.Ignore());
            CreateMap<StudentSubjectUpdateModel, StudentSubject>()
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.Subject, opt => opt.Ignore())
                .ForMember(dest => dest.Grade, opt => opt.Ignore());*/

        }
    }
}
