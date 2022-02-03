using KRM3D.Core.Entities.MongoDb.Concrete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.DataAccess.MongoDb.Context
{
    public abstract class MongoDbContextBase
    {
        public readonly IConfiguration configuration; 
        public readonly MongoDbConnectionSettings connectionSettings;

        public MongoDbContextBase(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionSettings = configuration.GetSection("MongoDbConnectionSettings").Get<MongoDbConnectionSettings>();

        }
    }
}
