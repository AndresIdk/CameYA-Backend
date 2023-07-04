using CameYA.Core.Entities;

namespace CameYA.Core.Interfaces.IRespositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();
        Task<UserEntity> GetByDni(int dni);
        Task Insert(int dni, Client entity);
        Task Update(int dni, Client entity);
        Task Delete(int dni);
    }
}
