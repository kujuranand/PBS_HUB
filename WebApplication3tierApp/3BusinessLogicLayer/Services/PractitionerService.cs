
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
    public class PractitionerService :  BaseService, IPractitionerService
    {
        private readonly IPractitionerDal _PractitionerDal;
        //private readonly IPractitionerBalService _PractitionerBalService;
        public PractitionerService(IPractitionerDal PractitionerDal
        //ILoggingService loggingService,
        //IPractitionerDal PractitionerDal,
        //IAuditDal auditDal
       // IPractitionerBalanceService balsvc
        ) 
        {
            _PractitionerDal = PractitionerDal;
            // _PractitionerBalService = balsvc;
        }

        public async Task<PractitionerModel?> GetById(int Id)
        {           
            return _PractitionerDal.GetById(Id);
        }

        public async Task<List<PractitionerModel>> GetAll()
        {
            await ValidateAccess(SystemActions.PractitionerView);
            //write log to journal if required -- add to the base class if repeated calls
            return _PractitionerDal.GetAll();
        }

        public async Task<int> CreatePractitioner(PractitionerModel Practitioner)
        {
            //write validations here
            //1 check security
            await ValidateAccess(SystemActions.PractitionerCreate);


            //2 [if required] write log to journal if required -- add to the base class if repeated calls

            //3 do validations here @either fluent or by manual if/else + service calls
            CheckFluentValidation(await new PractitionerValidator().ValidateAsync(Practitioner));

            //4 do any business logic
            var newPractitionerId = _PractitionerDal.CreatePractitioner(Practitioner);

            return newPractitionerId;
        }

        public async Task UpdatePractitioner(PractitionerModel Practitioner)
        {
            //write validations here 
            _PractitionerDal.UpdatePractitioner(Practitioner);
        }

        public async Task DeletePractitioner(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _PractitionerDal.DeletePractitioner(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Practitioner Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
