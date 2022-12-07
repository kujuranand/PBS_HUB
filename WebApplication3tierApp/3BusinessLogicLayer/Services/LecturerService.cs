

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class LecturerService :  ILecturerService
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
            return _LecturerDal.GetAll();
        }

        public async Task<int> CreateLecturer(LecturerModel Lecturer)
        {
            //write validations here
            var newId = _LecturerDal.CreateLecturer(Lecturer);
            return newId;
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
