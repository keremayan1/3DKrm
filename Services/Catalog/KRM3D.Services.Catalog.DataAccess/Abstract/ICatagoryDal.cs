using KRM3D.Core.DataAccess.MongoDb;
using KRM3D.Services.Catalog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Catalog.DataAccess.Abstract
{
    public interface ICatagoryDal:IMongoDbRepository<Category>
    {
    }
}
