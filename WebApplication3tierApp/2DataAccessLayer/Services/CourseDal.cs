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
    public class CourseDal : ICourseDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public CourseDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<CourseModel> GetAll()
        {
            var result = _db.Courses.ToList();

            var returnObject = new List<CourseModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToCourseModel());
            }

            return returnObject;
        }

        public CourseModel? GetById(int Id)
        {
            var result = _db.Courses.SingleOrDefault(x => x.Id == Id);
            return result?.ToCourseModel();
        }


        public int CreateCourse(CourseModel Course)
        {
            var newCourse = Course.ToCourse();
            _db.Courses.Add(newCourse);
            _db.SaveChanges();
            return newCourse.Id;
        }


        public void UpdateCourse(CourseModel Course)
        {
            var existingCourse = _db.Courses
                .SingleOrDefault(x => x.Id == Course.Id);

            if (existingCourse == null)
            {
                throw new ApplicationException($"Course {Course.Id} does not exist.");
            }
            Course.ToCourse(existingCourse);

            _db.Update(existingCourse);
            _db.SaveChanges();
        }

        public void DeleteCourse(int Id)
        {
            var efModel = _db.Courses.Find(Id);
            _db.Courses.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
