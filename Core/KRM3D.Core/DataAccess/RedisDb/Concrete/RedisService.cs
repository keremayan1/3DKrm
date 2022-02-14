﻿using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.DataAccess.RedisDb.Concrete
{
    public class RedisService : IRedisService
    {
        private string _host;
        int _port;

        private ConnectionMultiplexer _connectionMultiplexer;
        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }
        int database = 1;
        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");

        public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(database);
        public List<RedisKey> GetKeys() => _connectionMultiplexer.GetServer($"{_host}:{_port}").Keys(database).ToList();

    }
}
