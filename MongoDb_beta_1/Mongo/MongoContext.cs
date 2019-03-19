using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDb_beta_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDb_beta_1.Mongo
{
    public class MongoContext
    {
        public IConfigurationRoot Configuration { get; }
        private IMongoDatabase _database = null;

        public MongoContext(IOptions<Settings> settings)
        {
            Configuration = settings.Value.iConfigurationRoot;
            settings.Value.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
            settings.Value.Database = Configuration.GetSection("MongoConnection:Database").Value;

            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }

        public IMongoCollection<master_keyword> master_keyword
        {
            get
            {
                return _database.GetCollection<master_keyword>("master_keyword");
            }
        }

        public IMongoCollection<master_receiver> master_receiver
        {
            get
            {
                return _database.GetCollection<master_receiver>("master_receiver");
            }
        }
    }
}
