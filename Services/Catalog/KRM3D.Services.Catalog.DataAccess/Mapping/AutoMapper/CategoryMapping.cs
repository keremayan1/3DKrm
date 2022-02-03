using AutoMapper;
using KRM3D.Services.Catalog.Entities.Concrete;
using KRM3D.Services.Catalog.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Catalog.DataAccess.Mapping.AutoMapper
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
