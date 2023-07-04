using CameYA.Core.Entities;
using CameYA.Core.Interfaces;
using CameYA.Core.Interfaces.IRespositories;
using CameYA.Core.Interfaces.IServices;

namespace CameYA.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IWorkerRepository _workerRepository { get; }
        private IClientRepository _clientRepository { get; }
        private IServiceRepository _serviceRepository { get; }

        public IWorkerRepository WorkerRepository => _workerRepository ?? new WorkerRepository();

        public IClientRepository ClientRepository => _clientRepository ?? new ClientRepository();

        public IServiceRepository ServiceRepository => _serviceRepository ?? new ServiceRepository();

    }
}
