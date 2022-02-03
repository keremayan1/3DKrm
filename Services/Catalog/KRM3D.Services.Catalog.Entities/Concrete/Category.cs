using KRM3D.Core.Entities.MongoDb.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Catalog.Entities.Concrete
{
    public class Category:MongoDbEntity
    {
        
        public string Name { get; set; }
    }
}
