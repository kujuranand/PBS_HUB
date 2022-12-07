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
    public class PractitionerController : ControllerBase   
    {

        private readonly IPractitionerService _PractitionerService;
        private readonly ILogger<PractitionerController> _logger;

        public PractitionerController(IPractitionerService PractitionerService, ILogger<PractitionerController> logger)
        {
            _PractitionerService = PractitionerService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllPractitioners")]
        public async Task<List<PractitionerDto>> GetAll()
        {
            var result = await _PractitionerService.GetAll();
            return result.Select(x => x.ToPractitionerDto()).ToList();
        }

        [HttpGet("{Id}", Name = "GetPractitioner")]
        public async Task<PractitionerDto?> Get(int Id)
        {
            var result = await _PractitionerService.GetById(Id);
            return result?.ToPractitionerDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] PractitionerDto requestDto)
        {
            var PractitionerModel = requestDto.ToPractitionerModel();
            return await _PractitionerService.CreatePractitioner(PractitionerModel);
        }

        [HttpPut, Route("{Id}")]
        public async Task<IActionResult> Update([FromBody] PractitionerDto requestDto)
        {
            await _PractitionerService.UpdatePractitioner(requestDto.ToPractitionerModel());
            return Ok();
        }

        [HttpDelete, Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _PractitionerService.DeletePractitioner(Id);
            return Ok();
        }
    }
}
