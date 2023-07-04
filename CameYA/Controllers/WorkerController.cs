using AutoMapper;
using CameYA.Api.Responses;
using CameYA.Core.DTOs;
using CameYA.Core.Entities;
using CameYA.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CameYA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _workerService;
        private readonly IMapper _mapper;

        public WorkerController(IWorkerService workerService, IMapper mapper)
        {
            _workerService = workerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Worker>>> GetAll() 
        {
            var workers = await _workerService.GetAll();
            var workersDTO = _mapper.Map<IEnumerable<WorkerDTO>>(workers);
            var response = new GenericResponse<IEnumerable<WorkerDTO>>(workersDTO);
            return Ok(response); 
        }

        [HttpPost]
        public async Task<ActionResult<WorkerDTO>> Insert([FromBody] WorkerDTO workerDTO)
        {
            var worker = _mapper.Map<Worker>(workerDTO);
            var response = await _workerService.Insert(worker);
            var workerDTOMap = _mapper.Map<WorkerDTO>(response);
            var res = new GenericResponse<WorkerDTO>(workerDTOMap);
            return Ok(res);
        }
    }
}
