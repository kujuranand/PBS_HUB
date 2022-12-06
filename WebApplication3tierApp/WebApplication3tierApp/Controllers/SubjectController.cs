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
    public class SubjectController : ControllerBase   
    {

        private readonly ISubjectService _SubjectService;
        private readonly ILogger<SubjectController> _logger;

        public SubjectController(ISubjectService SubjectService, ILogger<SubjectController> logger)
        {
            _SubjectService = SubjectService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllSubjects")]
        public async Task<List<SubjectDto>> GetAll()
        {
            var result = await _SubjectService.GetAll();
            return result.Select(x => x.ToSubjectDto()).ToList();
        }

        [HttpGet("{Id}", Name = "GetSubject")]
        public async Task<SubjectDto?> Get(int Id)
        {
            var result = await _SubjectService.GetById(Id);
            return result?.ToSubjectDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] SubjectDto requestDto)
        {
            var SubjectModel = requestDto.ToSubjectModel();
            return await _SubjectService.CreateSubject(SubjectModel);
        }

        [HttpPut, Route("{Id}")]
        public async Task<IActionResult> Update([FromBody] SubjectDto requestDto)
        {
            await _SubjectService.UpdateSubject(requestDto.ToSubjectModel());
            return Ok();
        }

        [HttpDelete, Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _SubjectService.DeleteSubject(Id);
            return Ok();
        }
    }
}
