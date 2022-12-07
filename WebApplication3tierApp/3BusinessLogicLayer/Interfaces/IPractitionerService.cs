using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IPractitionerService
    {
        Task<PractitionerModel?> GetById(int Id);
        Task<List<PractitionerModel>> GetAll();

        Task<int> CreatePractitioner(PractitionerModel Practitioner);
        Task UpdatePractitioner(PractitionerModel Practitioner);
        Task DeletePractitioner(int Id);
    }
}
