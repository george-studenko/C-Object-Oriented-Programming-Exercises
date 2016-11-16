using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483.Delegates
{
    // create a delegate outside the class
    // delegate int del(int a, int b);
    // Inside the class create an instance of the delegate and assign the delegated method    
    // del d = de.addNumbers;
    // to keep adding adding (concatenating methods do it with an += )
    // d += de.substractNumbers;
    class DelegateExample
    {
        public int addNumbers(int a, int b)
        {
            Debug.WriteLine("ADD");
            return a + b;
        }

        public int substractNumbers(int a, int b)
        {
            Debug.WriteLine("SUBSTRACT");
            return a - b;
        }

        public int mutliplyNumbers (int a, int b)
        {
            Debug.WriteLine("MULTIPLY");
            return a * b;
        }
    }
}
