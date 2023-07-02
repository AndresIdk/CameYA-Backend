using CameYA.Core.Entities;

namespace CameYA.Core.Interfaces
{
    public interface IServiceRepository
    {
        Task<IEnumerable<Service>> GetAll();
        Task<Service> GetByDni(int dni);
        Task Insert(int dni);
        Task Update(int dni);
        Task Delete(int dni);
    }
}
