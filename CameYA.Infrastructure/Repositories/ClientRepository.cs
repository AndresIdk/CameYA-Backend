using CameYA.Core.Entities;
using CameYA.Core.Interfaces.IRespositories;

namespace CameYA.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task Delete(int dni)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetByDni(int dni)
        {
            throw new NotImplementedException();
        }

        public Task Insert(int dni, Client entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(int dni, Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
