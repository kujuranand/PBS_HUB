
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
    public class EmployeeService :  BaseService, IEmployeeService
    {
        private readonly IEmployeeDal _EmployeeDal;
        //private readonly IEmployeeBalService _EmployeeBalService;
        public EmployeeService(IEmployeeDal EmployeeDal
        //ILoggingService loggingService,
        //IEmployeeDal EmployeeDal,
        //IAuditDal auditDal
       // IEmployeeBalanceService balsvc
        ) 
        {
            _EmployeeDal = EmployeeDal;
            // _EmployeeBalService = balsvc;
        }

        public async Task<EmployeeModel?> GetById(int Id)
        {           
            return _EmployeeDal.GetById(Id);
        }

        public async Task<List<EmployeeModel>> GetAll()
        {
            await ValidateAccess(SystemActions.EmployeeView);
            //write log to journal if required -- add to the base class if repeated calls
            return _EmployeeDal.GetAll();
        }

        public async Task<int> CreateEmployee(EmployeeModel Employee)
        {
            //write validations here
            //1 check security
            await ValidateAccess(SystemActions.EmployeeCreate);


            //2 [if required] write log to journal if required -- add to the base class if repeated calls

            //3 do validations here @either fluent or by manual if/else + service calls
            CheckFluentValidation(await new EmployeeValidator().ValidateAsync(Employee));

            //4 do any business logic
            var newEmployeeId = _EmployeeDal.CreateEmployee(Employee);

            return newEmployeeId;
        }

        public async Task UpdateEmployee(EmployeeModel Employee)
        {
            //write validations here 
            _EmployeeDal.UpdateEmployee(Employee);
        }

        public async Task DeleteEmployee(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _EmployeeDal.DeleteEmployee(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Employee Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
