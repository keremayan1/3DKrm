

using AutoMapper;
using KRM3D.Services.Course.Entities.Concrete.Dto;

namespace KRM3D.Services.Course.DataAccess.Mapping
{
    public class CourseMapping:Profile
    {
        public CourseMapping()
        {
            CreateMap<Entities.Concrete.Course, CourseDto>().ReverseMap();
            CreateMap<Entities.Concrete.Feature, FeatureDto>().ReverseMap();
            CreateMap<Entities.Concrete.Course, CourseAddDto>().ReverseMap();
        }
    }
}
