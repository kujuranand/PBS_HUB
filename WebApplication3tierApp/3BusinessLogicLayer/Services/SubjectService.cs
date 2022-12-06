
using _1CommonInfrastructure.Enums;
using _1CommonInfrastructure.Validations;
using System.Data;
using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Services;

namespace _3BusinessLogicLayer.Services
{
    public class SubjectService :  BaseService, ISubjectService
    {
        private readonly ISubjectDal _SubjectDal;
        //private readonly ISubjectBalService _SubjectBalService;
        public SubjectService(ISubjectDal SubjectDal
        //ILoggingService loggingService,
        //ISubjectDal SubjectDal,
        //IAuditDal auditDal
       // ISubjectBalanceService balsvc
        ) 
        {
            _SubjectDal = SubjectDal;
            // _SubjectBalService = balsvc;
        }

        public async Task<SubjectModel?> GetById(int Id)
        {           
            return _SubjectDal.GetById(Id);
        }

        public async Task<List<SubjectModel>> GetAll()
        {
            await ValidateAccess(SystemActions.SubjectView);
            //write log to journal if required -- add to the base class if repeated calls
            return _SubjectDal.GetAll();
        }

        public async Task<int> CreateSubject(SubjectModel Subject)
        {
            //write validations here
            //1 check security
            await ValidateAccess(SystemActions.SubjectCreate);


            //2 [if required] write log to journal if required -- add to the base class if repeated calls

            //3 do validations here @either fluent or by manual if/else + service calls
            CheckFluentValidation(await new SubjectValidator().ValidateAsync(Subject));

            //4 do any business logic
            var newSubjectId = _SubjectDal.CreateSubject(Subject);
            return newSubjectId;
        }

        public async Task UpdateSubject(SubjectModel Subject)
        {
            //write validations here 
            _SubjectDal.UpdateSubject(Subject);
        }

        public async Task DeleteSubject(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _SubjectDal.DeleteSubject(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Subject Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
