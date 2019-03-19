using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDb_beta_1.IRepository
{
    public interface IRepository<T> where T : class
    {
        
        IEnumerable<T> Find(Func<T, bool> predicate);        
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Count(Func<T, bool> predicate);
    }
}
