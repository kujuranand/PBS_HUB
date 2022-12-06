

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class UnitService :  IUnitService
    {
        private readonly IUnitDal _UnitDal;
        //private readonly IUnitBalService _UnitBalService;
        public UnitService(IUnitDal UnitDal
        //ILoggingService loggingService,
        //IUnitDal UnitDal,
        //IAuditDal auditDal
       // IUnitBalanceService balsvc
        ) 
        {
            _UnitDal = UnitDal;
            // _UnitBalService = balsvc;
        }

        public async Task<UnitModel?> GetById(int Id)
        {           
            return _UnitDal.GetById(Id);
        }

        public async Task<List<UnitModel>> GetAll()
        {            
            return _UnitDal.GetAll();
        }

        public async Task<int> CreateUnit(UnitModel Unit)
        {
            //write validations here
            var newId = _UnitDal.CreateUnit(Unit);
            return newId;
        }

        public async Task UpdateUnit(UnitModel Unit)
        {
            //write validations here 
            _UnitDal.UpdateUnit(Unit);
        }

        public async Task DeleteUnit(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _UnitDal.DeleteUnit(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Unit Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
