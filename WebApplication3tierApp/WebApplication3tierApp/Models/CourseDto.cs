using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class CourseDto
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)

        public long Duration { get; set; }
    }

    public static class CourseDtoMapExtensions
    {
        public static CourseDto ToCourseDto(this CourseModel src)
        {
            var dst = new CourseDto();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Duration = src.Duration;
            return dst;
        }

        public static CourseModel ToCourseModel(this CourseDto src)
        {
            var dst = new CourseModel();
            dst.Id = src.Id;
            dst.Name = src.Name;
            dst.Duration = src.Duration;
            return dst;
        }
    }
}
