using AutoMapper;
using CameYA.Core.DTOs;
using CameYA.Core.Entities;

namespace CameYA.Infrastructure.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            // Registro del mapeo de Clientes
            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();

            // Registro del mapeo de Trabajadores
            CreateMap<Worker, WorkerDTO>();
            CreateMap<WorkerDTO, Worker>();

            // Registro del mapeo de Servicios
            CreateMap<Service, ServiceDTO>();
            CreateMap<ServiceDTO, Service>();
        }
    }
}
