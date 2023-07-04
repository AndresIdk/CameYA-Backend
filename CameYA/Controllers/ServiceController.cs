using CameYA.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CameYA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _Service;

        public ServiceController(IServiceService service)
        {
            _Service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Service");
        }
    }
}
