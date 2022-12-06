using _1CommonInfrastructure.Enums;
using _1CommonInfrastructure.Validations;
using System.Data;

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class LecturerService : BaseService, ILecturerService
    {
        private readonly ILecturerDal _LecturerDal;
        //private readonly ILecturerBalService _LecturerBalService;
        public LecturerService(ILecturerDal LecturerDal
        //ILoggingService loggingService,
        //ILecturerDal LecturerDal,
        //IAuditDal auditDal
       // ILecturerBalanceService balsvc
        ) 
        {
            _LecturerDal = LecturerDal;
            // _LecturerBalService = balsvc;
        }

        public async Task<LecturerModel?> GetById(int Id)
        {           
            return _LecturerDal.GetById(Id);
        }

        public async Task<List<LecturerModel>> GetAll()
        {
            await ValidateAccess(SystemActions.LecturerView);
            return _LecturerDal.GetAll();
        }

        public async Task<int> CreateLecturer(LecturerModel Lecturer)
        {
            await ValidateAccess(SystemActions.LecturerView);

            CheckFluentValidation(await new LecturerValidator ().ValidateAsync (Lecturer));

            var newLecturerId = _LecturerDal.CreateLecturer(Lecturer);
            return newLecturerId;
        }

        public async Task UpdateLecturer(LecturerModel Lecturer)
        {
            //write validations here 
            _LecturerDal.UpdateLecturer(Lecturer);
        }

        public async Task DeleteLecturer(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _LecturerDal.DeleteLecturer(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Lecturer Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
