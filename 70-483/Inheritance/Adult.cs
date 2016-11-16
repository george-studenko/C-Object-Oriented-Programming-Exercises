using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483.Inheritance
{
    class Adult : Patient
    {
        public string Bill(long ssn) { return "Billed to " + ssn; }
    }
}
