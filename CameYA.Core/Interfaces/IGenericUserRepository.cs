using CameYA.Core.Entities;

namespace CameYA.Core.Interfaces
{
    public interface IGenericUserRepository<T> where T : UserEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByDni(int dni);
        Task Insert(int dni);
        Task Update(int dni);
        Task Delete(int dni); 
    }
}
