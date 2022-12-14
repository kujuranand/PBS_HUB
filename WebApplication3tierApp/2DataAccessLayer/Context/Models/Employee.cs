using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Employee 
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)

        public string Email { get; set; }

        public long Phone { get; set; }

        public string Department { get; set; } 
    }
}
