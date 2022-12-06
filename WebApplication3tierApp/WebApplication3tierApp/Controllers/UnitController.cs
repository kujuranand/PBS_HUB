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
    public class UnitController : ControllerBase   
    {

        private readonly IUnitService _UnitService;
        private readonly ILogger<UnitController> _logger;

        public UnitController(IUnitService UnitService, ILogger<UnitController> logger)
        {
            _UnitService = UnitService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllUnits")]
        public async Task<List<UnitDto>> GetAll()
        {
            var result = await _UnitService.GetAll();
            return result.Select(x => x.ToUnitDto()).ToList();
        }

        [HttpGet("{Id}", Name = "GetUnit")]
        public async Task<UnitDto?> Get(int Id)
        {
            var result = await _UnitService.GetById(Id);
            return result?.ToUnitDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] UnitDto requestDto)
        {
            var UnitModel = requestDto.ToUnitModel();
            return await _UnitService.CreateUnit(UnitModel);
        }

        [HttpPut, Route("{Id}")]
        public async Task<IActionResult> Update([FromBody] UnitDto requestDto)
        {
            await _UnitService.UpdateUnit(requestDto.ToUnitModel());
            return Ok();
        }

        [HttpDelete, Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _UnitService.DeleteUnit(Id);
            return Ok();
        }
    }
}
