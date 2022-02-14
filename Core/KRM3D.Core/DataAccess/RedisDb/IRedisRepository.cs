using KRM3D.Core.Entities.RedisDb;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.DataAccess.RedisDb
{
    public interface IRedisRepository<T> where T : IRedisEntity
    {
        Task<bool> SaveOrUpdate(string id, T entity);
        Task<bool> Delete(string id);
        Task<T> Get(string id);
        List<RedisKey> GetKeys();
    }
}
