using _1CommonInfrastructure.Enums;
using _1CommonInfrastructure.Validations;
using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;
using System.Data;

namespace _3BusinessLogicLayer.Services
{
    public class CourseService : BaseService, ICourseService
    {
        private readonly ICourseDal _CourseDal;
        //private readonly ICourseBalService _CourseBalService;
        public CourseService(ICourseDal CourseDal
        //ILoggingService loggingService,
        //ICourseDal CourseDal,
        //IAuditDal auditDal
       // ICourseBalanceService balsvc
        ) 
        {
            _CourseDal = CourseDal;
            // _CourseBalService = balsvc;
        }

        public async Task<CourseModel?> GetById(int Id)
        {           
            return _CourseDal.GetById(Id);
        }

        public async Task<List<CourseModel>> GetAll()
        {
            
                await ValidateAccess(SystemActions.CourseView);
                //write log to journal if required -- add to the base class if repeated calls
                return _CourseDal.GetAll();

        }

        public async Task<int> CreateCourse(CourseModel Course)
        {
            //1 check security
            await ValidateAccess(SystemActions.CourseCreate);


            //2 [if required] write log to journal if required -- add to the base class if repeated calls

            //3 do validations here @either fluent or by manual if/else + service calls
            CheckFluentValidation(await new CourseValidator().ValidateAsync(Course));

            //4 do any business logic
            var newCourseId = _CourseDal.CreateCourse(Course);
            return newCourseId;
        }

        public async Task UpdateCourse(CourseModel Course)
        {
            //write validations here 
            _CourseDal.UpdateCourse(Course);
        }

        public async Task DeleteCourse(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _CourseDal.DeleteCourse(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Course Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
