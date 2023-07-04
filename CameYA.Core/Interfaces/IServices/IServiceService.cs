using CameYA.Core.Entities;

namespace CameYA.Core.Interfaces.IServices
{
    public interface IServiceService
    {
        Task<IEnumerable<Service>> GetAll();
        Task<Service> GetById(int id);
        Task Insert(int id, Service entity);
        Task Update(int id, Service entity);
        Task Delete(int id);
    }
}
