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
    public static class PractitionerMapExtensions
    {
        public static PractitionerModel ToPractitionerModel(this Practitioner src)
        {
            var dst = new PractitionerModel();

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Department = src.Department;

            return dst;
        }

        public static Practitioner ToPractitioner(this PractitionerModel src, Practitioner dst = null)
        {
            if (dst == null)
            {
                dst = new Practitioner();
            }

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Department = src.Department;

            return dst;
        }
    }
}
