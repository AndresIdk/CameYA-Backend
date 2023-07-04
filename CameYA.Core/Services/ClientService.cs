using CameYA.Core.Entities;
using CameYA.Core.Interfaces;
using CameYA.Core.Interfaces.IServices;

namespace CameYA.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Client>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetByDni(int dni)
        {
            throw new NotImplementedException();
        }

        public Task Insert(int dni, Client entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(int dni, Client entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int dni)
        {
            throw new NotImplementedException();
        }
    }
}
