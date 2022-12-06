using _1CommonInfrastructure.Enums;
using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;
using _1CommonInfrastructure.Validations;
using System.Data;

namespace _3BusinessLogicLayer.Services
{
    public class StudentService : BaseService, IStudentService
    {
        private readonly IStudentDal _StudentDal;
        //private readonly IStudentBalService _StudentBalService;
        public StudentService(IStudentDal StudentDal
        //ILoggingService loggingService,
        //IStudentDal StudentDal,
        //IAuditDal auditDal
       // IStudentBalanceService balsvc
        ) 
        {
            _StudentDal = StudentDal;
            // _StudentBalService = balsvc;
        }

        public async Task<StudentModel?> GetById(int Id)
        {           
            return _StudentDal.GetById(Id);
        }

        public async Task<List<StudentModel>> GetAll()
        {
        
                await ValidateAccess(SystemActions.StudentView);
                //write log to journal if required -- add to the base class if repeated calls
                return _StudentDal.GetAll();
        }

        public async Task<int> CreateStudent(StudentModel Student)
        {
                //1 check security
                await ValidateAccess(SystemActions.StudentCreate);


                //2 [if required] write log to journal if required -- add to the base class if repeated calls

                //3 do validations here @either fluent or by manual if/else + service calls
                CheckFluentValidation(await new StudentValidator().ValidateAsync(Student));

                //4 do any business logic
                var newStudentId = _StudentDal.CreateStudent(Student);

                return newStudentId;
        }

        public async Task UpdateStudent(StudentModel Student)
        {
            //write validations here 
            _StudentDal.UpdateStudent(Student);
        }

        public async Task DeleteStudent(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _StudentDal.DeleteStudent(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Student Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
