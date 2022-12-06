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
    public static class LecturerMapExtensions
    {
        public static LecturerModel ToLecturerModel(this Lecturer src)
        {
            var dst = new LecturerModel();

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;

            return dst;
        }

        public static Lecturer ToLecturer(this LecturerModel src, Lecturer dst = null)
        {
            if (dst == null)
            {
                dst = new Lecturer();
            }

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;

            return dst;
        }
    }
}
