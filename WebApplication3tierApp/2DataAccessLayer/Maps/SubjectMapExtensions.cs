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
    public static class SubjectMapExtensions
    {
        public static SubjectModel ToSubjectModel(this Subject src)
        {
            var dst = new SubjectModel();

            dst.Id = src.Id;
            dst.Code = src.Code;
            dst.Name = src.Name;
            dst.Semester = src.Semester;

            return dst;
        }

        public static Subject ToSubject(this SubjectModel src, Subject dst = null)
        {
            if (dst == null)
            {
                dst = new Subject();
            }

            dst.Id = src.Id;
            dst.Code = src.Code;
            dst.Name = src.Name;
            dst.Semester = src.Semester;

            return dst;
        }
    }
}
