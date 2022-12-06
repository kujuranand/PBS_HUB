using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface ILecturerDal
    {
        // Getters
        LecturerModel? GetById(int LecturerId);
        List<LecturerModel> GetAll();

        // Actions
        int CreateLecturer(LecturerModel Lecturer);
        void UpdateLecturer(LecturerModel Lecturer);
        void DeleteLecturer(int LecturerId);
    }
}
