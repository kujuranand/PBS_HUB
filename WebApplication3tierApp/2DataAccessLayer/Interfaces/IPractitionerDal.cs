using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IPractitionerDal
    {
        // Getters
        PractitionerModel? GetById(int PractitionerId);
        List<PractitionerModel> GetAll();

        // Actions
        int CreatePractitioner(PractitionerModel Practitioner);
        void UpdatePractitioner(PractitionerModel Practitioner);
        void DeletePractitioner(int PractitionerId);
    }
}
