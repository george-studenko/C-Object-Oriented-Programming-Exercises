using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483.ClassesAndObjects
{
    class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Seniority { get; set; }        

        public string Promote()
        {
            return "Employee has been promoted!...";
        }

        public string AnnualReview()
        {
            return "Annual review completed...";
        }


    }
}
