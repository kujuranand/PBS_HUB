using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class StudentDto
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)

        public string Email { get; set; }

        public long Phone { get; set; }

        public string Course { get; set; }
    }

    public static class StudentDtoMapExtensions
    {
        public static StudentDto ToStudentDto(this StudentModel src)
        {
            var dst = new StudentDto();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Course = src.Course;
            return dst;
        }

        public static StudentModel ToStudentModel(this StudentDto src)
        {
            var dst = new StudentModel();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Email = src.Email;
            dst.Phone = src.Phone;
            dst.Course = src.Course;
            return dst;
        }
    }
}
