﻿using KRM3D.Core.Utilities.Results;
using KRM3D.Services.Course.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Course.Business.Abstract
{
    public interface ICourseService
    {
        public Task<IDataResult<List<Entities.Concrete.Course>>> GetAllAsync();
        public Task<IDataResult<List<CourseDto>>> GetAllAsync2();
        public Task<IResult> AddAsync(Entities.Concrete.Course course);
        public Task<IResult> UpdateAsync(Entities.Concrete.Course course);
    }
}
