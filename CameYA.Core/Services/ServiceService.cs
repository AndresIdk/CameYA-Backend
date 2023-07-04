using CameYA.Core.Entities;
using CameYA.Core.Interfaces;
using CameYA.Core.Interfaces.IServices;

namespace CameYA.Core.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        public Task<IEnumerable<Service>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Service> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(int id, Service entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Service entity)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
