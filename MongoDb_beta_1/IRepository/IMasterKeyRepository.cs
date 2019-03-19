using MongoDb_beta_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDb_beta_1.IRepository
{
    public interface IMasterKeyRepository : IRepository<master_keyword>
    {
        Task<IEnumerable<master_keyword>> Get();
        Task<master_keyword> GetById(string id);
        
    }
}
