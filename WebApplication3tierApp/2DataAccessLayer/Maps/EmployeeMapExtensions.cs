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
    public static class EmployeeMapExtensions
    {
        public static EmployeeModel ToEmployeeModel(this Employee src)
        {
            var dst = new EmployeeModel();

            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Department = src.Department;

            return dst;
        }

        public static Employee ToEmployee(this EmployeeModel src, Employee dst = null)
        {
            if (dst == null)
            {
                dst = new Employee();
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
