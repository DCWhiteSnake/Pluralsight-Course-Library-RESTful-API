﻿using AutoMapper;

namespace CourseLibraryApi.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, Models.CourseDto>();

            CreateMap<Models.CourseForCreationDto, Entities.Course>();
        }
    }
}