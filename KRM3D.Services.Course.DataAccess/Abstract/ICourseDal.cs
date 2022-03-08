using KRM3D.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRM3D.Services.Course;
using KRM3D.Services.Course.Entities.Concrete.Dto;
using System.Linq.Expressions;

namespace KRM3D.Services.Course.DataAccess.Abstract
{
    public interface ICourseDal:IEntityRepository<Entities.Concrete.Course>
    {
        Task<List<CourseDto>> GetAllCourse(Expression<Func<CourseDto, bool>> filter = null);
    }
}
