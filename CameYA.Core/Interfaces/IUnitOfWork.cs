using CameYA.Core.Entities;
using CameYA.Core.Interfaces.IRespositories;
using CameYA.Core.Interfaces.IServices;

namespace CameYA.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IWorkerRepository WorkerRepository { get; }
        IClientRepository ClientRepository { get; }
        IServiceRepository ServiceRepository { get; }

        //void SaveChanges();
        //Task SaveChangesAsync();
    }
}
