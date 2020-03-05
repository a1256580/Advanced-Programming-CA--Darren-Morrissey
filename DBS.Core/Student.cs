using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.Core
{
    public class Student
    {
        public string LoginID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public string City { get; set; }
        public string County { get; set; }

        public bool Level { get; set; }
        public string Course { get; set; }
        public int StudentNumber { get; set; }
    }
}
