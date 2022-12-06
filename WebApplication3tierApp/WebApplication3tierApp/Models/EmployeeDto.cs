using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)

        public string Email { get; set; }

        public long Phone { get; set; }

        public string Department { get; set; } 
    }

    public static class EmployeeDtoMapExtensions
    {
        public static EmployeeDto ToEmployeeDto(this EmployeeModel src)
        {
            var dst = new EmployeeDto();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Department = src.Department;
            return dst;
        }

        public static EmployeeModel ToEmployeeModel(this EmployeeDto src)
        {
            var dst = new EmployeeModel();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Department = src.Department;
            return dst;
        }
    }
}
