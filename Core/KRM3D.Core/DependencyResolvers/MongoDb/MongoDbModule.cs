using KRM3D.Core.Entities.MongoDb;
using KRM3D.Core.Entities.MongoDb.Concrete;
using KRM3D.Core.Utilities.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.DependencyResolvers.MongoDb
{
    public class MongoDbModule : ICoreModule
    {
        public void Load(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IMongoDbConnectionSettings>(sp =>
            sp.GetRequiredService<IOptions<MongoDbConnectionSettings>>().Value);

        }
    }
}
