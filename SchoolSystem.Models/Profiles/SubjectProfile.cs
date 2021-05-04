using AutoMapper;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Subject, SubjectModelBase>().ReverseMap();
            CreateMap<Subject, SubjectModelExtended>();
            CreateMap<SubjectCreateModel, Subject>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.StudentSubjects, opt => opt.Ignore());

            CreateMap<SubjectUpdateModel, Subject>()
                .ForMember(dest => dest.StudentSubjects, opt => opt.Ignore());

        }
    }
}
