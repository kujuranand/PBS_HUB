using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class SubjectDto
    {
        public int Id { get; set; } // int
        public string Code { get; set; }

        public string Name { get; set; }

        public long Semester { get; set; }
    }

    public static class SubjectDtoMapExtensions
    {
        public static SubjectDto ToSubjectDto(this SubjectModel src)
        {
            var dst = new SubjectDto();
            dst.Id = src.Id;
            dst.Code = src.Code;
            dst.Name = src.Name;
            dst.Semester = src.Semester;
            return dst;
        }

        public static SubjectModel ToSubjectModel(this SubjectDto src)
        {
            var dst = new SubjectModel();
            dst.Id = src.Id;
            dst.Code = src.Code;
            dst.Name = src.Name;
            dst.Semester = src.Semester;
            return dst;
        }
    }
}
