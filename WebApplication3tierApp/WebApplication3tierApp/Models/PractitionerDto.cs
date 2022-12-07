using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class PractitionerDto
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)

        public string Email { get; set; }

        public long Phone { get; set; }

        public string Department { get; set; } 
    }

    public static class PractitionerDtoMapExtensions
    {
        public static PractitionerDto ToPractitionerDto(this PractitionerModel src)
        {
            var dst = new PractitionerDto();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Department = src.Department;
            return dst;
        }

        public static PractitionerModel ToPractitionerModel(this PractitionerDto src)
        {
            var dst = new PractitionerModel();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Department = src.Department;
            return dst;
        }
    }
}
