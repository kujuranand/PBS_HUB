using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class SubjectDal : ISubjectDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public SubjectDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<SubjectModel> GetAll()
        {
            var result = _db.Subjects.ToList();

            var returnObject = new List<SubjectModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToSubjectModel());
            }

            return returnObject;
        }

        public SubjectModel? GetById(int Id)
        {
            var result = _db.Subjects.SingleOrDefault(x => x.Id == Id);
            return result?.ToSubjectModel();
        }


        public int CreateSubject(SubjectModel Subject)
        {
            var newSubject = Subject.ToSubject();
            _db.Subjects.Add(newSubject);
            _db.SaveChanges();
            return newSubject.Id;
        }


        public void UpdateSubject(SubjectModel Subject)
        {
            var existingSubject = _db.Subjects
                .SingleOrDefault(x => x.Id == Subject.Id);

            if (existingSubject == null)
            {
                throw new ApplicationException($"Subject {Subject.Id} does not exist.");
            }
            Subject.ToSubject(existingSubject);

            _db.Update(existingSubject);
            _db.SaveChanges();
        }

        public void DeleteSubject(int Id)
        {
            var efModel = _db.Subjects.Find(Id);
            _db.Subjects.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
