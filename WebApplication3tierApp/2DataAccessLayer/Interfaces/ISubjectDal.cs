using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface ISubjectDal
    {
        // Getters
        SubjectModel? GetById(int SubjectId);
        List<SubjectModel> GetAll();

        // Actions
        int CreateSubject(SubjectModel Subject);
        void UpdateSubject(SubjectModel Subject);
        void DeleteSubject(int SubjectId);
    }
}
