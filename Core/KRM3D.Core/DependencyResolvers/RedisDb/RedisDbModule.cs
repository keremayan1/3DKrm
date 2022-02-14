using KRM3D.Core.DataAccess.RedisDb;
using KRM3D.Core.DataAccess.RedisDb.Concrete;
using KRM3D.Core.Entities.RedisDb.Concrete;
using KRM3D.Core.Utilities.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.DependencyResolvers.RedisDb
{
    public class RedisDbModule : ICoreModule
    {
        public void Load(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<RedisSettings>(configuration.GetSection("RedisSettings"));
            services.AddScoped<IRedisService>(sp =>
            {
                var redisSettings = sp.GetRequiredService<IOptions<RedisSettings>>().Value;
                var redis = new RedisService(redisSettings.Host, redisSettings.Port);
                redis.Connect();
                return redis;
            });
        }
    }
}
