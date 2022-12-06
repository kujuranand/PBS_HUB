using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface ISubjectService
    {
        Task<SubjectModel?> GetById(int Id);
        Task<List<SubjectModel>> GetAll();

        Task<int> CreateSubject(SubjectModel Subject);
        Task UpdateSubject(SubjectModel Subject);
        Task DeleteSubject(int Id);
    }
}
