using CameYA.Core.Entities;
using CameYA.Core.Interfaces;

namespace CameYA.Infrastructure.Repositories
{
    public class UserRepository<T> : IGenericUserRepository<T> where T : UserEntity
    {
        public Task Delete(int dni)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByDni(int dni)
        {
            throw new NotImplementedException();
        }

        public Task Insert(int dni)
        {
            throw new NotImplementedException();
        }

        public Task Update(int dni)
        {
            throw new NotImplementedException();
        }
    }
}
