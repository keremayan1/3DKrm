using KRM3D.Core.DataAccess.EntityFramework.Concrete;
using KRM3D.Services.Course.DataAccess.Abstract;
using KRM3D.Services.Course.DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Course.DataAccess.Concrete.EntityFramework
{
    public class EfCourseDal : EfEntityRepository<Entities.Concrete.Course, SqlContext>, ICourseDal
    {
        public EfCourseDal(SqlContext context) : base(context)
        {
        }
    }
}
