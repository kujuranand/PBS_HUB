
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
    public class ClientService :  BaseService, IClientService
    {
        private readonly IClientDal _ClientDal;
        //private readonly IClientBalService _ClientBalService;
        public ClientService(IClientDal ClientDal
        //ILoggingService loggingService,
        //IClientDal ClientDal,
        //IAuditDal auditDal
       // IClientBalanceService balsvc
        ) 
        {
            _ClientDal = ClientDal;
            // _ClientBalService = balsvc;
        }

        public async Task<ClientModel?> GetById(int Id)
        {           
            return _ClientDal.GetById(Id);
        }

        public async Task<List<ClientModel>> GetAll()
        {
            await ValidateAccess(SystemActions.ClientView);
            //write log to journal if required -- add to the base class if repeated calls
            return _ClientDal.GetAll();
        }

        public async Task<int> CreateClient(ClientModel Client)
        {
            //write validations here
            //1 check security
            await ValidateAccess(SystemActions.ClientCreate);


            //2 [if required] write log to journal if required -- add to the base class if repeated calls

            //3 do validations here @either fluent or by manual if/else + service calls
            CheckFluentValidation(await new ClientValidator().ValidateAsync(Client));

            //4 do any business logic
            var newClientId = _ClientDal.CreateClient(Client);

            return newClientId;
        }

        public async Task UpdateClient(ClientModel Client)
        {
            //write validations here 
            _ClientDal.UpdateClient(Client);
        }

        public async Task DeleteClient(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _ClientDal.DeleteClient(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Client Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
