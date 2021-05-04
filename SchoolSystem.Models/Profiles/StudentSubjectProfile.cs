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
            CreateMap<StudentSubjectCreateModel, Student>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.StudentSubjects, opt => opt.Ignore())
                .ForMember(dest => dest.StudentName, opt => opt.Ignore())
                .ForMember(dest => dest.StudentSurname, opt => opt.Ignore())
                .ForMember(dest => dest.StudentDoB, opt => opt.Ignore())
                .ForMember(dest => dest.StudentYear, opt => opt.Ignore());

            CreateMap<StudentSubjectCreateModel, StudentSubject>()
                .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.StudentId))
                .ForMember(dest => dest.SubjectId, opt => opt.MapFrom(src => src.SubjectId));



            CreateMap<StudentSubjectUpdateModel, Student>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.StudentSubjects, opt => opt.Ignore())
                .ForMember(dest => dest.StudentName, opt => opt.Ignore())
                .ForMember(dest => dest.StudentSurname, opt => opt.Ignore())
                .ForMember(dest => dest.StudentDoB, opt => opt.Ignore())
                .ForMember(dest => dest.StudentYear, opt => opt.Ignore());

            CreateMap<StudentSubjectUpdateModel, StudentSubject>()
                .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.StudentId))
                .ForMember(dest => dest.SubjectId, opt => opt.MapFrom(src => src.SubjectId));


            /*CreateMap<StudentSubjectCreateModel, StudentSubject>()
                .ConstructUsing(p => p.Student.)*/

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
