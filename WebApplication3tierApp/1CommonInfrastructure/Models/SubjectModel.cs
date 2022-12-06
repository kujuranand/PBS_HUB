using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class SubjectModel
    {
        public int Id { get; set; } // int
        public string Code { get; set; }

        public string Name { get; set; }

        public long Semester { get; set; }

    }

}
