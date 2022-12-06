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
    public class LecturerController : ControllerBase   
    {

        private readonly ILecturerService _LecturerService;
        private readonly ILogger<LecturerController> _logger;

        public LecturerController(ILecturerService LecturerService, ILogger<LecturerController> logger)
        {
            _LecturerService = LecturerService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllLecturers")]
        public async Task<List<LecturerDto>> GetAll()
        {
            var result = await _LecturerService.GetAll();
            return result.Select(x => x.ToLecturerDto()).ToList();
        }

        [HttpGet("{Id}", Name = "GetLecturer")]
        public async Task<LecturerDto?> Get(int Id)
        {
            var result = await _LecturerService.GetById(Id);
            return result?.ToLecturerDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] LecturerDto requestDto)
        {
            var LecturerModel = requestDto.ToLecturerModel();
            return await _LecturerService.CreateLecturer(LecturerModel);
        }

        [HttpPut, Route("{Id}")]
        public async Task<IActionResult> Update([FromBody] LecturerDto requestDto)
        {
            await _LecturerService.UpdateLecturer(requestDto.ToLecturerModel());
            return Ok();
        }

        [HttpDelete, Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _LecturerService.DeleteLecturer(Id);
            return Ok();
        }
    }
}
