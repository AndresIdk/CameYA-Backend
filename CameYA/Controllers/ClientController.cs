using CameYA.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CameYA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
           return Ok("Client");
        }
    }
}
