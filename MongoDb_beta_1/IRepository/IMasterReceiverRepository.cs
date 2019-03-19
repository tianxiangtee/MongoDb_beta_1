using MongoDb_beta_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDb_beta_1.IRepository
{
    public interface IMasterReceiverRepository : IRepository<master_receiver>
    {
        Task<IEnumerable<master_receiver>> Get();
        Task<master_receiver> GetById(string id);
    }
}
