using CameYA.Core.Entities;
using CameYA.Core.Interfaces.IRespositories;
using CameYA.Infrastructure.Data.Configurations;

namespace CameYA.Infrastructure.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly DatabaseSettings db = new();
        public Task<IEnumerable<Service>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Service> GetById(int dni)
        {
            throw new NotImplementedException();
        }

        public Task Insert(int dni, Service service)
        {
            throw new NotImplementedException();
        }

        public Task Update(int dni, Service service)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int dni)
        {
            throw new NotImplementedException();
        }
    }
}
