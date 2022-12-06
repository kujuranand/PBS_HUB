using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Course
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)

        public long Duration { get; set; }
    }
}
