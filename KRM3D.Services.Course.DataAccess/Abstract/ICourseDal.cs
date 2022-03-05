using KRM3D.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRM3D.Services.Course;
namespace KRM3D.Services.Course.DataAccess.Abstract
{
    public interface ICourseDal:IEntityRepository<Entities.Concrete.Course>
    {
    }
}
