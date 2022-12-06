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
    public static class CourseMapExtensions
    {
        public static CourseModel ToCourseModel(this Course src)
        {
            var dst = new CourseModel();

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Duration = src.Duration;

            return dst;
        }

        public static Course ToCourse(this CourseModel src, Course dst = null)
        {
            if (dst == null)
            {
                dst = new Course();
            }

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Duration = src.Duration;

            return dst;
        }
    }
}
