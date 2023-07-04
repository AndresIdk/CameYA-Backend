using CameYA.Core.Entities;

namespace CameYA.Core.Interfaces.IRespositories
{
    public interface IServiceRepository
    {
        Task<IEnumerable<Service>> GetAll();
        Task<Service> GetById(int dni);
        Task Insert(int id, Service service);
        Task Update(int id, Service service);
        Task Delete(int id);
    }
}
