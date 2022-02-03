using KRM3D.Core.DataAccess.MongoDb.Concrete;
using KRM3D.Core.DataAccess.MongoDb.Context;
using KRM3D.Core.Entities.MongoDb;
using KRM3D.Services.Catalog.DataAccess.Abstract;
using KRM3D.Services.Catalog.DataAccess.Concrete.MongoDb.Context;
using KRM3D.Services.Catalog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Catalog.DataAccess.Concrete.MongoDb
{
    public class MongoDbCategoryDal : MongoDbRepository<Category>,ICategoryDal
    {
        public MongoDbCategoryDal(MongoDbContextBase mongoDbConnectionSettings) : base(mongoDbConnectionSettings.connectionSettings)
        {
        }
    }
}
