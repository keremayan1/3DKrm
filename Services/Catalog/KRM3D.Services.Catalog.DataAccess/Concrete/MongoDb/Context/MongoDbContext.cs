using KRM3D.Core.DataAccess.MongoDb.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Catalog.DataAccess.Concrete.MongoDb.Context
{
    public class MongoDbContext : MongoDbContextBase
    {
        public MongoDbContext(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
