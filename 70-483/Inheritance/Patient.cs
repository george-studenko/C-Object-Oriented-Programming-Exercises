using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483.Inheritance
{
    class Patient
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public string Examine(string pname)
        {
            return "Patient " +pname + " has been examined...";

        }

        
    }
}
