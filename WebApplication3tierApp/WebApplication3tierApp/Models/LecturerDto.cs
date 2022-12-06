using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class LecturerDto
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)

        public string Email { get; set; }

        public long Phone { get; set; }
    }

    public static class LecturerDtoMapExtensions
    {
        public static LecturerDto ToLecturerDto(this LecturerModel src)
        {
            var dst = new LecturerDto();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            return dst;
        }

        public static LecturerModel ToLecturerModel(this LecturerDto src)
        {
            var dst = new LecturerModel();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            return dst;
        }
    }
}
