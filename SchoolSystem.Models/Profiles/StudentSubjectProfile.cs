﻿using AutoMapper;
using SchoolSystem.Data.Entities;
using SchoolSystem.Models.Models.StudentClass;
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
            CreateMap<StudentSubjectCreateModel, StudentSubject>()
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.Class, opt => opt.Ignore())
                .ForMember(dest => dest.Grade, opt => opt.Ignore());
            CreateMap<StudentSubjectUpdateModel, StudentSubject>()
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.Class, opt => opt.Ignore())
                .ForMember(dest => dest.Grade, opt => opt.Ignore());

        }
    }
}