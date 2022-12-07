using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClientController : ControllerBase   
    {

        private readonly IClientService _ClientService;
        private readonly ILogger<ClientController> _logger;

        public ClientController(IClientService ClientService, ILogger<ClientController> logger)
        {
            _ClientService = ClientService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllClients")]
        public async Task<List<ClientDto>> GetAll()
        {
            var result = await _ClientService.GetAll();
            return result.Select(x => x.ToClientDto()).ToList();
        }

        [HttpGet("{Id}", Name = "GetClient")]
        public async Task<ClientDto?> Get(int Id)
        {
            var result = await _ClientService.GetById(Id);
            return result?.ToClientDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] ClientDto requestDto)
        {
            var ClientModel = requestDto.ToClientModel();
            return await _ClientService.CreateClient(ClientModel);
        }

        [HttpPut, Route("{Id}")]
        public async Task<IActionResult> Update([FromBody] ClientDto requestDto)
        {
            await _ClientService.UpdateClient(requestDto.ToClientModel());
            return Ok();
        }

        [HttpDelete, Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _ClientService.DeleteClient(Id);
            return Ok();
        }
    }
}
