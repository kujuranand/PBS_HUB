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
    public class StudentDal : IStudentDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public StudentDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<StudentModel> GetAll()
        {
            var result = _db.Students.ToList();

            var returnObject = new List<StudentModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToStudentModel());
            }

            return returnObject;
        }

        public StudentModel? GetById(int Id)
        {
            var result = _db.Students.SingleOrDefault(x => x.Id == Id);
            return result?.ToStudentModel();
        }


        public int CreateStudent(StudentModel Student)
        {
            var newStudent = Student.ToStudent();
            _db.Students.Add(newStudent);
            _db.SaveChanges();
            return newStudent.Id;
        }


        public void UpdateStudent(StudentModel Student)
        {
            var existingStudent = _db.Students
                .SingleOrDefault(x => x.Id == Student.Id);

            if (existingStudent == null)
            {
                throw new ApplicationException($"Student {Student.Id} does not exist.");
            }
            Student.ToStudent(existingStudent);

            _db.Update(existingStudent);
            _db.SaveChanges();
        }

        public void DeleteStudent(int Id)
        {
            var efModel = _db.Students.Find(Id);
            _db.Students.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
