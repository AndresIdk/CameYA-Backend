using CameYA.Core.Entities;

namespace CameYA.Core.Interfaces.IServices
{
    public interface IWorkerService
    {
        Task<List<Worker>> GetAll();
        Task<Worker> GetByDni(int dni);
        Task<Worker> Insert(Worker entity);
        Task Update(int dni, Worker entity);
        Task Delete(int dni);
    }
}
