using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.Entities.MongoDb.Concrete
{
    public class MongoDbConnectionSettings : IMongoDbConnectionSettings
    {
        private MongoClientSettings _clientSettings { get; set; }

        public MongoDbConnectionSettings(MongoClientSettings clientSettings)
        {
            _clientSettings = clientSettings;
        }

        public MongoDbConnectionSettings()
        {

        }

        public MongoClientSettings GetMongoClientSettings()
        {
            return _clientSettings;
        }
        public virtual string ConnectionStrings { get; set; }

        public string DatabaseName { get; set; }
    }
}
