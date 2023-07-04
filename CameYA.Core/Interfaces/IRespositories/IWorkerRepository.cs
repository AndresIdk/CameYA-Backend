using CameYA.Core.Entities;

namespace CameYA.Core.Interfaces.IRespositories
{
    public interface IWorkerRepository
    {
        Task<List<Worker>> GetAll();
        Task<Worker> GetByDni(int dni);
        Task<Worker> Insert(Worker worker);
        Task Update(int dni, Worker worker);
        Task Delete(int dni);
    }
}
