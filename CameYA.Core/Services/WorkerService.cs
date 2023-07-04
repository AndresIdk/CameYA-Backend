using CameYA.Core.Entities;
using CameYA.Core.Interfaces;
using CameYA.Core.Interfaces.IServices;

namespace CameYA.Core.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<List<Worker>> GetAll()
        {
            var workers = _unitOfWork.WorkerRepository.GetAll();
            return workers;
        }

        public Task<Worker> GetByDni(int dni)
        {
            throw new NotImplementedException();
        }

        public async Task<Worker> Insert(Worker worker)
        {
            var response = await _unitOfWork.WorkerRepository.Insert(worker);
            return response;
        }

        public Task Update(int dni, Worker entity)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int dni)
        {
            throw new NotImplementedException();
        }
    }
}
