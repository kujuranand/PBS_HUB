using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class StudentMapExtensions
    {
        public static StudentModel ToStudentModel(this Student src)
        {
            var dst = new StudentModel();

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Course = src.Course;

            return dst;
        }

        public static Student ToStudent(this StudentModel src, Student dst = null)
        {
            if (dst == null)
            {
                dst = new Student();
            }

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Course = src.Course;

            return dst;
        }
    }
}
