using MongoDB.Driver;
using MongoDb_beta_1.IRepository;
using MongoDb_beta_1.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDb_beta_1.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {
        protected readonly MongoContext _context;

        public int Count(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }


    }
}
